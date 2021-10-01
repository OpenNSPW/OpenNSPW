// Code from: https://github.com/OpenRA/OpenRA/blob/6810469634d43a7a3e8ab2664942e162c3f4436a/OpenRA.Game/Actor.cs

#region Copyright & License Information
/*
 * Copyright 2007-2021 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

using System.Collections.ObjectModel;
using OpenNspw.Components;

namespace OpenNspw
{
	internal sealed class ConditionManager
	{
		private sealed class ConditionState
		{
			public List<VariableObserverNotifier> Notifiers { get; } = new();
			public HashSet<ConditionToken> Tokens { get; } = new();
		}

		private readonly Dictionary<string, ConditionState> _conditionStates = new();
		private readonly Dictionary<ConditionToken, string> _conditionTokens = new();
		private ConditionToken _nextConditionToken = new(1);
		private readonly Dictionary<string, int> _conditionCache = new();
		private readonly IReadOnlyDictionary<string, int> _readOnlyConditionCache;

		private bool _created;

		public ConditionManager()
		{
			_readOnlyConditionCache = new ReadOnlyDictionary<string, int>(_conditionCache);
		}

		public void Initialize(Unit self)
		{
			_created = true;

			var allObserverNotifiers = new HashSet<VariableObserverNotifier>();
			foreach (var provider in self.Components.OfType<IObservesVariables>())
			{
				foreach (var variableUser in provider.GetVariableObservers())
				{
					allObserverNotifiers.Add(variableUser.Notifier);
					foreach (var variable in variableUser.Variables)
					{
						var conditionState = _conditionStates.GetOrAdd(variable);
						conditionState.Notifiers.Add(variableUser.Notifier);

						_conditionCache[variable] = conditionState.Tokens.Count;
					}
				}
			}

			foreach (var notify in allObserverNotifiers)
				notify(self, _readOnlyConditionCache);
		}

		private void UpdateConditionState(Unit self, string condition, ConditionToken token, bool isRevoke)
		{
			var conditionState = _conditionStates.GetOrAdd(condition);

			if (isRevoke)
				conditionState.Tokens.Remove(token);
			else
				conditionState.Tokens.Add(token);

			_conditionCache[condition] = conditionState.Tokens.Count;

			if (_created)
			{
				foreach (var notify in conditionState.Notifiers)
					notify(self, _readOnlyConditionCache);
			}
		}

		public ConditionToken GrantCondition(Unit self, string? condition)
		{
			if (string.IsNullOrEmpty(condition))
				return ConditionToken.Invalid;

			var token = _nextConditionToken++;
			_conditionTokens.Add(token, condition);
			UpdateConditionState(self, condition, token, isRevoke: false);
			return token;
		}

		public ConditionToken RevokeCondition(Unit self, ConditionToken token)
		{
			if (!_conditionTokens.TryGetValue(token, out var condition))
				throw new InvalidOperationException($"Attempting to revoke condition with invalid token {token} for {this}.");

			_conditionTokens.Remove(token);
			UpdateConditionState(self, condition, token, isRevoke: true);
			return ConditionToken.Invalid;
		}

		public bool HasToken(ConditionToken token) => _conditionTokens.ContainsKey(token);
	}
}

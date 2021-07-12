// Code from: https://github.com/OpenRA/OpenRA/blob/6810469634d43a7a3e8ab2664942e162c3f4436a/OpenRA.Mods.Common/Traits/Conditions/PausableConditionalTrait.cs

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

using System.Collections.Generic;

namespace OpenNspw.Components
{
	internal abstract record PausableConditionalComponentOptions : ConditionalComponentOptions
	{
		public BooleanExpression? PauseOnCondition { get; init; }
		public bool PausedByDefault { get; init; }

		public abstract override PausableConditionalComponent CreateComponent(Unit self);
	}

	internal abstract record PausableConditionalComponentOptions<TComponent> : PausableConditionalComponentOptions
		where TComponent : PausableConditionalComponent
	{
		public abstract override TComponent CreateComponent(Unit self);
	}

	internal abstract class PausableConditionalComponent : ConditionalComponent<PausableConditionalComponentOptions>
	{
		public bool IsPaused { get; private set; }

		protected PausableConditionalComponent(Unit self, PausableConditionalComponentOptions options) : base(self, options)
		{
			IsPaused = options.PausedByDefault;
		}

		protected override void OnCreated(Unit self)
		{
			base.OnCreated(self);

			if (Options.PauseOnCondition is null)
				OnResumed(self);
		}

		protected virtual void OnResumed(Unit self) { }
		protected virtual void OnPaused(Unit self) { }

		private void PauseConditionsChanged(Unit self, IReadOnlyDictionary<string, int> conditions)
		{
			if (Options.PauseOnCondition is null)
				return;

			var wasPaused = IsPaused;
			IsPaused = Options.PauseOnCondition.Evaluate(conditions);

			if (IsPaused != wasPaused)
			{
				if (wasPaused)
					OnResumed(self);
				else
					OnPaused(self);
			}
		}

		public override IEnumerable<VariableObserver> GetVariableObservers()
		{
			foreach (var observer in base.GetVariableObservers())
				yield return observer;

			if (Options.PauseOnCondition is not null)
				yield return new VariableObserver(PauseConditionsChanged, Options.PauseOnCondition.Variables);
		}
	}

	internal abstract class PausableConditionalComponent<TOptions> : PausableConditionalComponent
		where TOptions : PausableConditionalComponentOptions
	{
		public new TOptions Options { get; }

		protected PausableConditionalComponent(Unit self, TOptions options) : base(self, options)
		{
			Options = options;
		}
	}
}

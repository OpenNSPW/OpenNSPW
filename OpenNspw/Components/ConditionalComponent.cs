// Code from: https://github.com/OpenRA/OpenRA/blob/6810469634d43a7a3e8ab2664942e162c3f4436a/OpenRA.Mods.Common/Traits/Conditions/ConditionalTrait.cs

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

namespace OpenNspw.Components
{
	internal abstract record ConditionalComponentOptions : IComponentOptions<ConditionalComponent>
	{
		public BooleanExpression? RequiresCondition { get; init; }

		public abstract ConditionalComponent CreateComponent(Unit self);
	}

	internal abstract record ConditionalComponentOptions<TComponent> : ConditionalComponentOptions
		where TComponent : ConditionalComponent
	{
		public abstract override TComponent CreateComponent(Unit self);
	}

	internal abstract class ConditionalComponent : IComponent<ConditionalComponentOptions>, IObservesVariables, ICreatedEventListener
	{
		public Unit Self { get; }
		public ConditionalComponentOptions Options { get; }
		public bool IsDisabled { get; private set; }

		protected ConditionalComponent(Unit self, ConditionalComponentOptions options)
		{
			Self = self;
			Options = options;

			IsDisabled = options.RequiresCondition is not null;
		}

		private void RequiredConditionsChanged(Unit self, IReadOnlyDictionary<string, int> conditions)
		{
			if (Options.RequiresCondition is null)
				return;

			var wasDisabled = IsDisabled;
			IsDisabled = !Options.RequiresCondition.Evaluate(conditions);

			if (IsDisabled != wasDisabled)
			{
				if (wasDisabled)
					OnEnabled(self);
				else
					OnDisabled(self);
			}
		}

		public virtual IEnumerable<VariableObserver> GetVariableObservers()
		{
			if (Options.RequiresCondition is not null)
				yield return new VariableObserver(RequiredConditionsChanged, Options.RequiresCondition.Variables);
		}

		protected virtual void OnEnabled(Unit self) { }
		protected virtual void OnDisabled(Unit self) { }

		protected virtual void OnCreated(Unit self)
		{
			if (Options.RequiresCondition is null)
				OnEnabled(self);
		}

		void ICreatedEventListener.OnCreated(Unit self) => OnCreated(self);
	}

	internal abstract class ConditionalComponent<TOptions> : ConditionalComponent
		where TOptions : ConditionalComponentOptions
	{
		public new TOptions Options { get; }

		protected ConditionalComponent(Unit self, TOptions options) : base(self, options)
		{
			Options = options;
		}
	}
}

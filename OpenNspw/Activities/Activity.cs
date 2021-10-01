// Code from: https://github.com/OpenRA/OpenRA/blob/6810469634d43a7a3e8ab2664942e162c3f4436a/OpenRA.Game/Activities/Activity.cs

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

namespace OpenNspw.Activities
{
	internal enum ActivityState
	{
		Queued,
		Active,
		Canceling,
		Done,
	}

	internal abstract class Activity
	{
		public ActivityState State { get; private set; }

		public static Activity? Run(Unit self, Activity? activity)
		{
			if (activity is null)
				return null;

			while (activity is not null)
			{
				var previousActivity = activity;
				activity = activity.Update(self);

				if (activity == previousActivity)
					break;
			}

			return activity;
		}

		public static Activity? SkipDoneActivities(Activity? first)
		{
			while (first?.State == ActivityState.Done)
				first = first._nextActivity;

			return first;
		}

		private Activity? _childActivity;
		public Activity? ChildActivity
		{
			get => SkipDoneActivities(_childActivity);
			private set => _childActivity = value;
		}

		private Activity? _nextActivity;
		public Activity? NextActivity
		{
			get => SkipDoneActivities(_nextActivity);
			private set => _nextActivity = value;
		}

		public bool ChildHasPriority { get; protected init; } = true;

		public bool IsCanceling => State == ActivityState.Canceling;

		protected virtual bool UpdateCore(Unit self) => true;

		protected bool UpdateChild(Unit self)
		{
			ChildActivity = Run(self, ChildActivity);
			return ChildActivity is null;
		}

		protected virtual void OnFirstRun(Unit self) { }

		protected virtual void OnLastRun(Unit self) { }

		private bool _finishing;
		private bool _firstRunCompleted;
		private bool _lastRun;

		public Activity? Update(Unit self)
		{
			if (State == ActivityState.Done)
				throw new InvalidOperationException();

			if (State == ActivityState.Queued)
			{
				OnFirstRun(self);
				_firstRunCompleted = true;
				State = ActivityState.Active;
			}

			if (!_firstRunCompleted)
				throw new InvalidOperationException();

			if (ChildHasPriority)
			{
				_lastRun = UpdateChild(self) && (_finishing || UpdateCore(self));
				_finishing |= _lastRun;
			}
			else
				_lastRun = UpdateCore(self);

			var childActivity = ChildActivity;
			if (childActivity is not null && childActivity.State == ActivityState.Queued)
			{
				if (ChildHasPriority)
					_lastRun = UpdateChild(self) && _finishing;
				else
					UpdateChild(self);
			}

			if (_lastRun)
			{
				State = ActivityState.Done;
				OnLastRun(self);
				return NextActivity;
			}

			return this;
		}

		public virtual void Cancel(Unit self, bool keepQueue = false)
		{
			if (!keepQueue)
				NextActivity = null;

			ChildActivity?.Cancel(self);

			State = State == ActivityState.Queued ? ActivityState.Done : ActivityState.Canceling;
		}

		public void Queue(Activity? activity)
		{
			var nextActivity = this;
			while (nextActivity._nextActivity is not null)
				nextActivity = nextActivity._nextActivity;
			nextActivity._nextActivity = activity;
		}

		public void QueueChild(Activity activity)
		{
			if (_childActivity is not null)
				_childActivity.Queue(activity);
			else
				_childActivity = activity;
		}
	}
}

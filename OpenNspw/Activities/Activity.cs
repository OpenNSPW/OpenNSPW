namespace OpenNspw.Activities
{
	internal abstract class Activity
	{
		public Activity? NextActivity { get; set; }

		protected virtual void OnFirstUpdate(Unit self) { }

		protected abstract Activity? UpdateCore(Unit self);

		private bool _firstUpdate = true;

		public Activity? Update(Unit self)
		{
			if (_firstUpdate)
			{
				_firstUpdate = false;
				OnFirstUpdate(self);
			}

			return UpdateCore(self);
		}
	}
}

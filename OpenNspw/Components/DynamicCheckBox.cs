using System;
using Aigamo.Saruhashi;

namespace OpenNspw.Components
{
	internal sealed class DynamicCheckBox : CheckBox
	{
		public new Func<bool> IsVisible
		{
			get => base.IsVisible;
			set => base.IsVisible = value;
		}

		public new Func<bool> IsChecked
		{
			get => base.IsChecked;
			set => base.IsChecked = value;
		}
	}
}

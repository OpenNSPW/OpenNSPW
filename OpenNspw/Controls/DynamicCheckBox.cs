using Aigamo.Saruhashi;

namespace OpenNspw.Controls
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

		public new Func<bool> IsEnabled
		{
			get => base.IsEnabled;
			set => base.IsEnabled = value;
		}
	}
}

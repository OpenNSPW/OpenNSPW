using System;
using Aigamo.Saruhashi;

namespace OpenNspw.Controls
{
	internal sealed class DynamicLabel : Label
	{
		public Func<string>? GetText { get; set; }

		public override string Text
		{
			get => GetText?.Invoke() ?? base.Text;
			set => base.Text = value;
		}
	}
}

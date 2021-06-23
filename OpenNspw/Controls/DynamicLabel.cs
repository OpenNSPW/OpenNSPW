using System;
using Aigamo.Saruhashi;

namespace OpenNspw.Controls
{
	internal sealed class DynamicLabel : Label
	{
		public new Func<string> GetText
		{
			get => base.GetText;
			set => base.GetText = value;
		}
	}
}

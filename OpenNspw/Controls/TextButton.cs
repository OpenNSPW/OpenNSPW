using Aigamo.Saruhashi;
using DColor = System.Drawing.Color;

namespace OpenNspw.Controls
{
	internal sealed class TextButton : ButtonBase
	{
		public TextButton()
		{
			SetStyle(ControlStyles.StandardClick, false);

			BackColor = DColor.Transparent;
		}

		private ITextRenderer? _textRenderer;

		public ITextRenderer TextRenderer
		{
			get => _textRenderer ??= new TextRenderer();
			set => _textRenderer = value;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			if (Font is not null)
				Size = e.Graphics.MeasureString(Text, Font).ToSize();

			TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor, TextFormatFlags.VerticalCenter);
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (Capture && WindowManager.WindowFromPoint(PointToScreen(e.Location)) == this)
				{
					OnClick(EventArgs.Empty);
					OnMouseClick(new MouseEventArgs(e.Button, e.Clicks, PointToClient(e.Location), e.Delta));
				}
			}

			base.OnMouseUp(e);
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);

			ForeColor = DColor.Red;
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);

			ForeColor = DColor.White;
		}
	}
}

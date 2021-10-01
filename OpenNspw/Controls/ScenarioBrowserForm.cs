using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using MonoGame.Extended.Sprites;
using DPoint = System.Drawing.Point;

namespace OpenNspw.Controls;

internal sealed class ScenarioBrowserForm : Form
{
	private readonly IAssetManager _assets;

	private readonly TextButton[] _scenarioButtons;
	private readonly TextButton _previousButton;
	private readonly TextButton _nextButton;

	public IReadOnlyList<(string Title, Type ScenarioType)> Scenarios { get; }

	private const int PageSize = 10;

	private readonly int _pages;

	public EventHandler? PageChanged;
	private void OnPageChanged(EventArgs e) => PageChanged?.Invoke(this, e);

	private int _page = 1;
	public int Page
	{
		get => _page;
		private set
		{
			var newValue = Math.Clamp(value, 1, _pages);
			if (_page != newValue)
			{
				_page = newValue;
				OnPageChanged(EventArgs.Empty);
			}
		}
	}

	public Type? SelectedScenario { get; private set; }

	public ScenarioBrowserForm(IAssetManager assets, Sound sound, IEnumerable<(string Title, Type ScenarioType)> scenarios)
	{
		_assets = assets;

		Size = new(1024, 768);

		Scenarios = scenarios.ToList();

		_pages = (int)Math.Ceiling((decimal)Scenarios.Count / PageSize);

		_scenarioButtons = new TextButton[Scenarios.Count];
		for (var i = 0; i < _scenarioButtons.Length; i++)
		{
			var scenario = Scenarios[i];
			_scenarioButtons[i] = new TextButton
			{
				Location = new(120, 150 + i % PageSize * 25),
				Text = scenario.Title,
			};
			_scenarioButtons[i].MouseEnter += (sender, e) => SelectedScenario = scenario.ScenarioType;
			_scenarioButtons[i].MouseDown += (sender, e) =>
			{
				if (e.Button == MouseButtons.Left)
					sound.Play("SoundEffects/btn_4");
			};
			_scenarioButtons[i].Click += (sender, e) =>
			{
				sound.Play("SoundEffects/combat_start");

				Close();
			};
			_scenarioButtons[i].Visible = false;
			Controls.Add(_scenarioButtons[i]);
		}

		_previousButton = new TextButton
		{
			Location = new(250, 110),
			Text = "<- Previous",
		};
		_previousButton.MouseDown += (sender, e) =>
		{
			sound.Play("SoundEffects/btn_4");
		};
		_previousButton.Click += (sender, e) => Page--;
		Controls.Add(_previousButton);

		_nextButton = new TextButton
		{
			Location = new(330, 110),
			Text = "Next ->",
		};
		_nextButton.MouseDown += (sender, e) =>
		{
			sound.Play("SoundEffects/btn_4");
		};
		_nextButton.Click += (sender, e) => Page++;
		Controls.Add(_nextButton);

		PageChanged += (sender, e) =>
		{
			foreach (var button in _scenarioButtons)
				button.Visible = false;

			var start = (_page - 1) * PageSize;
			foreach (var button in _scenarioButtons.Skip(start).Take(PageSize))
				button.Visible = true;
		};
		OnPageChanged(EventArgs.Empty);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);

		var month = DateTime.Today.Month;
		e.Graphics.DrawImage(MonoGameImage.Create(new Sprite(_assets.Textures[$"Textures/background_{(month - 1) % 4}"])), new DPoint(1024 / 2, 768 / 2));
	}
}

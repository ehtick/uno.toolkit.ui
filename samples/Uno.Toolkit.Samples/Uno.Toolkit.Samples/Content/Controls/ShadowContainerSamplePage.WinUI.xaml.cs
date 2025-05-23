using Shadow = Uno.Toolkit.UI.Shadow;

namespace Uno.Toolkit.Samples.Content.Controls
{
	[SamplePage(SampleCategory.Controls, nameof(ShadowContainer), Description = "Add many colored shadows to your controls.")]
	public sealed partial class ShadowContainerSamplePage : Page
	{
		private ShadowCollection _shadows;

		public ShadowContainerSamplePage()
		{
			this.InitializeComponent();

			this.Loaded += (s, e) =>
			{
				if (SamplePageLayout.GetSampleChild<ShadowContainer>(Design.Agnostic, "ShadowContainer") is { } shadowContainer)
				{
					_shadows = shadowContainer.Shadows;

					var shadowsItemsControl = SamplePageLayout.GetSampleChild<ItemsRepeater>(Design.Agnostic, "ShadowsItemsControl");
					shadowsItemsControl.ItemsSource = _shadows;
				}
			};
		}

		private void AddShadow(object sender, RoutedEventArgs e)
		{
			var defaultShadow = (Shadow)Resources["DefaultShadow"];

			_shadows.Add(defaultShadow.Clone());
		}

		private void RemoveShadow(object sender, RoutedEventArgs e)
		{
			if (_shadows.Count == 0)
			{
				return;
			}

			_shadows.RemoveAt(_shadows.Count - 1);
		}
	}
}


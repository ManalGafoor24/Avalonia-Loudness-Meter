using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace ogh_mockup
{
	public class LabelSetControl : TemplatedControl
	{
		// @Input for LargeText
		public static readonly StyledProperty<string> LargeTextProperty = AvaloniaProperty.Register<LabelSetControl, string>(
			name:"LargeText", "LARGE TEXT");

		public string LargeText
		{
			get => GetValue(LargeTextProperty);
			set => SetValue(LargeTextProperty, value);
		}

		// @Input for SmallText
        public static readonly StyledProperty<string> SmallTextProperty = AvaloniaProperty.Register<LabelSetControl, string>(
            name: "SmallText", "small text"); // name is the property accessible in xaml, the second 'value' is the default value

        public string SmallText
        {
            get => GetValue(SmallTextProperty);
            set => SetValue(SmallTextProperty, value);
        }
    }
}

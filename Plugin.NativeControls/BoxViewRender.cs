using Xamarin.Forms;

namespace Plugin.NativeControls
{
    public class BoxViewRender : BoxView
    {
        public static readonly BindableProperty ElevationProperty =
            BindableProperty.Create("Elevation", typeof(double), typeof(BoxViewRender), (double)0);
        /// <summary>
        /// Only Android API 21+
        /// </summary>
        public double Elevation
        {
            get { return (double)GetValue(ElevationProperty); }
            set { SetValue(ElevationProperty, value); }
        }
    }
}

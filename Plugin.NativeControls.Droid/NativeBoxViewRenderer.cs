using Android.OS;
using Plugin.NativeControls;
using Plugin.NativeControls.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BoxViewRender), typeof(NativeBoxViewRenderer))]
namespace Plugin.NativeControls.Droid
{
    class NativeBoxViewRenderer : BoxRenderer
    {
        protected BoxViewRender View { get; private set; }
        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null) return;

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                View = (BoxViewRender)this.Element;

                this.Elevation = (float)View.Elevation;
            }

        }
    }
}
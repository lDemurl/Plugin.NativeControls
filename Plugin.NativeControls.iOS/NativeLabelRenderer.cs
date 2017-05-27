using Foundation;
using Plugin.NativeControls;
using Plugin.NativeControls.iOS;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LabelRender), typeof(NativeLabelRenderer))]
namespace Plugin.NativeControls.iOS
{
    class NativeLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            var view = (LabelRender)Element;
            if (view != null)
                UpdateView(view, Control);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            var view = (LabelRender)Element;

            UpdateView(view, Control);

        }

        private static void UpdateView(LabelRender view, UILabel control)
        {

            if (control.Text != null)
            {

                var attrString = new NSMutableAttributedString(control.Text);

                switch (view.TexType)
                {
                    case TextType.Underline:
                        attrString.AddAttribute(UIStringAttributeKey.UnderlineStyle,
                                            NSNumber.FromInt32((int)NSUnderlineStyle.Single),
                                            new NSRange(0, attrString.Length));
                        break;

                    case TextType.StrikeThru:
                        attrString.AddAttribute(UIStringAttributeKey.StrikethroughStyle,
                                            NSNumber.FromInt32((int)NSUnderlineStyle.Single),
                                            new NSRange(0, attrString.Length));
                        break;
                }

                control.AttributedText = attrString;
            }
        }
    }
}

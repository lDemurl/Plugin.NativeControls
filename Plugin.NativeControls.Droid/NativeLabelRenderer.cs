using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Plugin.NativeControls.Droid;
using Plugin.NativeControls;
using Android.Graphics;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(LabelRender), typeof(NativeLabelRenderer))]
namespace Plugin.NativeControls.Droid
{
    class NativeLabelRenderer : LabelRenderer
    {
        protected LabelRender LabelRender { get; private set; }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                LabelRender = (LabelRender)this.Element;
            }

            SetPaintFlags(LabelRender);

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {

                this.Control.LetterSpacing = (float)(LabelRender.LetterSpacing / 10);

                this.UpdateLayout();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            var view = (LabelRender)Element;

            if ((e.PropertyName == LabelRender.TextTypeProperty.PropertyName))
                SetPaintFlags(view);

        }

        void SetPaintFlags(LabelRender control)
        {
            switch (control.TexType)
            {

                case TextType.Underline:
                    Control.PaintFlags = PaintFlags.UnderlineText;
                    break;
                case TextType.StrikeThru:
                    Control.PaintFlags = PaintFlags.StrikeThruText;
                    break;
                default:
                    Control.PaintFlags = PaintFlags.LinearText;
                    break;
            }
        }
    }
}
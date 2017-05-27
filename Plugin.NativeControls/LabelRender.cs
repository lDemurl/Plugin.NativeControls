using Xamarin.Forms;

namespace Plugin.NativeControls
{
    public enum TextType
    {
        Normal,
        Underline,
        StrikeThru
    }

    public class LabelRender : Label
    {

        public static readonly BindableProperty TextTypeProperty = 
            BindableProperty.Create("TexType", typeof(TextType), typeof(LabelRender), TextType.Normal);

        public static readonly BindableProperty LetterSpacingProperty =
            BindableProperty.Create("LetterSpacing", typeof(double), typeof(LabelRender), (double) 0);
        /// <summary>
        /// dev
        /// </summary>
        public TextType TexType
        {
            get { return (TextType)GetValue(TextTypeProperty); }
            set { SetValue(TextTypeProperty, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public double LetterSpacing
        {
            get { return (double)GetValue(LetterSpacingProperty); }
            set { SetValue(LetterSpacingProperty, value); }
        }

    }
}

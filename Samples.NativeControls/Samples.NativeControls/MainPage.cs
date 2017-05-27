using Plugin.NativeControls;
using Xamarin.Forms;

namespace Samples.NativeControls
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var dev = new LabelRender()
            {
                TexType = TextType.StrikeThru,
                Text = "dev"
            };

            Content = new StackLayout
            {
                Children = {
                    dev
                }
            };
        }
    }
}
using Sharpnado.Tabs;
using Xamarin.Forms;

namespace AugustUIChallenge.Views
{
    public partial class HomeView : ContentView, IAnimatableReveal
    {
        public HomeView()
        {
            InitializeComponent();
        }

        public bool Animate { get; set; }
    }
}
using Sharpnado.Tabs;
using Xamarin.Forms;

namespace AugustUIChallenge.Views
{
    public partial class UserProfileView : ContentView, IAnimatableReveal
    {
        public UserProfileView()
        {
            InitializeComponent();
        }

        public bool Animate { get; set; }
    }
}
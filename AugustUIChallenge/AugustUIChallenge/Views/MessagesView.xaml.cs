using Sharpnado.Tabs;
using Xamarin.Forms;

namespace AugustUIChallenge.Views
{
    public partial class MessagesView : ContentView, IAnimatableReveal
    {
        public MessagesView()
        {
            InitializeComponent();
        }

        public bool Animate { get; set; }
    }
}
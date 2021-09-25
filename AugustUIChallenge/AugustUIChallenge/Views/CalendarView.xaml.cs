using Sharpnado.Tabs;
using Xamarin.Forms;

namespace AugustUIChallenge.Views
{
    public partial class CalendarView : ContentView, IAnimatableReveal
    {
        public CalendarView()
        {
            InitializeComponent();
        }

        public bool Animate { get; set; }
    }
}
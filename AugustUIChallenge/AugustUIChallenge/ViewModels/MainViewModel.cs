using System.Threading.Tasks;

namespace AugustUIChallenge.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Fields

        private int _selectedViewModelIndex;

        #endregion Fields

        #region Properties

        public int SelectedViewModelIndex
        {
            get => _selectedViewModelIndex;
            set
            {
                _selectedViewModelIndex = value;
                OnPropertyChanged();
            }
        }
        
        public HomeViewModel Home { get; private set; }
        public CalendarViewModel Calendar { get; private set; }
        public MessagesViewModel Messages { get; private set; }
        public UserProfileViewModel UserProfile { get; private set; }
        

        #endregion Properties

        #region Public Methods

        public override Task Initialize()
        {
            Home = new HomeViewModel();
            Calendar = new CalendarViewModel();
            Messages = new MessagesViewModel();
            UserProfile = new UserProfileViewModel();

            Home.Initialize();
            Calendar.Initialize();
            Messages.Initialize();
            UserProfile.Initialize();
            
            return Task.CompletedTask;
        }

        #endregion Public Methods
    }
}
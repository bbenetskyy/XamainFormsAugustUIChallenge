using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AugustUIChallenge.Annotations;

namespace AugustUIChallenge.ViewModels
{
    public class BaseViewModel: INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        #endregion INotifyPropertyChanged Implementation

        #region Public Methods

        public virtual Task Initialize() => Task.CompletedTask;

        #endregion Public Methods
    }
}
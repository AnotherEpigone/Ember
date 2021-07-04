using Plugin.LocalNotification;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ember.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            ToastCommand = new Command(async () => await NotifyAsync());
        }

        public ICommand ToastCommand { get; }

        private async Task NotifyAsync()
        {
            var notification = new NotificationRequest()
            {
                BadgeNumber = 1,
                Description = "Ember days are coming up!",
                Title = "Ember reminder",
                ReturningData = string.Empty,
                NotificationId = 123,
            };

            await NotificationCenter.Current.Show(notification);
        }
    }
}
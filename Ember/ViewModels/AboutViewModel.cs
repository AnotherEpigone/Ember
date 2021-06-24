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
            await Task.CompletedTask;
        }
    }
}
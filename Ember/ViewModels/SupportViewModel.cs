using Ember.Views;
using Xamarin.Forms;

namespace Ember.ViewModels
{
    public class SupportViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public SupportViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}

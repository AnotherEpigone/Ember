using Ember.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Ember.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
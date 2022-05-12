using ResumeApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ResumeApp.Views
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
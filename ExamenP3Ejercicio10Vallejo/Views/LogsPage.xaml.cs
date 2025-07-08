using ExamenP3Ejercicio10Vallejo.Data;
using Microsoft.Extensions.Logging;
namespace ExamenP3Ejercicio10Vallejo.Views
{
    public partial class LogsPage : ContentPage
    {
        public LogsPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            LogLabel.Text = await LogHelper.LeerLogs();
        }
    }
}
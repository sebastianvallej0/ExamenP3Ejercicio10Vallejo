using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using ExamenP3Ejercicio10Vallejo.Models;
using ExamenP3Ejercicio10Vallejo.Data;

namespace ExamenP3Ejercicio10Vallejo.ViewModels
{
    public class SuscripcionViewModels : INotifyPropertyChanged
    {
        public ObservableCollection<Suscripcion> Suscripciones { get; set; } = new();
        public ICommand GuardarCommand { get;  }

        private AppDatabase db;
        public Suscripcion NuevaSuscripcion { get; set; } = new ();
        public SuscripcionViewModels()
        {
            db = ExamenP3Ejercicio10Vallejo.App.Database;
            GuardarCommand= new Command(async () => await GuardarSuscripcion());
            CargarSuscripciones();
        }
        private async Task GuardarSuscripcion()
        {
            if ((int)NuevaSuscripcion.CostoMensual % 2 == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "El costo mensual debe ser impar.", "OK");
                return;
            }

            await db.InsertSuscripcionAsync(NuevaSuscripcion);
            await LogHelper.Agregarlog(NuevaSuscripcion.Servicio);
            Suscripciones.Add(NuevaSuscripcion);
            NuevaSuscripcion = new Suscripcion();
            OnPropertyChanged(nameof(NuevaSuscripcion));
        }

        private async void CargarSuscripciones()
        {
            var lista = await db.GetSuscripcionesAsync();
            Suscripciones.Clear();
            foreach (var s in lista)
            Suscripciones.Add(s);

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) =>
        
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        
        }

    }
    
    


using System.IO;
using ExamenP3Ejercicio10Vallejo.Data;
namespace ExamenP3Ejercicio10Vallejo
{
    public partial class App : Application
    {
        public static AppDatabase Database;
        public App()
        {
            InitializeComponent();
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Suscripciones_Ejercicio10Vallejo.db3");
            Database = new AppDatabase(dbPath);
            MainPage = new AppShell();
        }
    }
}
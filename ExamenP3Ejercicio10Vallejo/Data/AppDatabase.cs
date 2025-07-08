using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenP3Ejercicio10Vallejo.Models;
using SQLite;   

namespace ExamenP3Ejercicio10Vallejo.Data
{
    public class AppDatabase
    {
        private readonly SQLiteAsyncConnection _database;
        public AppDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Suscripcion>().Wait();
        }


        public Task<int> InsertSuscripcionAsync(Suscripcion suscripcion)
        {
            return _database.InsertAsync(suscripcion);
        }

        public Task<List<Suscripcion>> GetSuscripcionesAsync()
        {
            return _database.Table<Suscripcion>().ToListAsync();
        }
    }

}

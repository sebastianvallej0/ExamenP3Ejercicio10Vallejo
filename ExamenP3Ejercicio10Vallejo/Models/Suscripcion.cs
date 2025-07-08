using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace ExamenP3Ejercicio10Vallejo.Models
{
    public class Suscripcion
    {

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string Servicio { get; set; }
        public string CorreoAsociado { get; set; }
        public Decimal CostoMensual { get; set; }
        public bool RenovacionAutomatica { get; set; }
    }
}


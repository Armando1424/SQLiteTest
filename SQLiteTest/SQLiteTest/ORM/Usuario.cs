using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteTest.ORM
{
    public class Usuario
    {
        [PrimaryKey,AutoIncrement]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

    }
}

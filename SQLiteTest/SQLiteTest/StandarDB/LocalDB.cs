
using DevAzt.FormsX.Storage.SQLite.LiteConnection;
using SQLiteTest.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAzt.FormsX.Storage.SQLite.StandarDB
{
    public class LocalDB : DataBase
    {
        public Table<Usuario> Usuario { get; set; }
        public Table<CV> CV { get; set; }

        public LocalDB(string databasePath, bool storeDateTimeAsTicks = true) : base(databasePath, storeDateTimeAsTicks)
        {
            Usuario = DBSet<Usuario>();
            CV = DBSet<CV>();
        }

        public static LocalDB Instace
        {
            get
            {
                var service = Xamarin.Forms.DependencyService.Get<IDataBase>();
                if (service != null)
                {
                    return service.GetDataBase();
                }
                throw new Exception("No es posible obtener el servicio");
            }
        }
    }
}

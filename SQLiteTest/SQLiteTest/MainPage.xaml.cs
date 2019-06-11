using DevAzt.FormsX.Storage.SQLite.LiteConnection;
using DevAzt.FormsX.Storage.SQLite.StandarDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteTest
{
	public partial class MainPage : ContentPage
	{
        public static LocalDB DB { get; private set; }

        public MainPage()
		{
			InitializeComponent();
            Keys.DataBaseName = "Prueba.db3";
            DB = LocalDB.Instace;

            Users.ItemsSource = DB.Usuario.ToList();
        }

        private void btnAgregar_Clicked(object sender, EventArgs e)
        {
            DB.Usuario.Add(new ORM.Usuario
            {
                Edad = Convert.ToInt32(txtAge.Text),
                Nombre = txtName.Text
            });
            DB.SaveChanges();
            txtAge.Text = string.Empty;
            txtName.Text = string.Empty;
            Users.ItemsSource = DB.Usuario.ToList();
        }

        private void btnBorrar_Clicked(object sender, EventArgs e)
        {
            DB.Delete<ORM.Usuario>(Convert.ToInt32(txtId.Text));
            Users.ItemsSource = DB.Usuario.ToList();
        }
    }
}

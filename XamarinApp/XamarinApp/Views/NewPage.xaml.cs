using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Models;

namespace XamarinApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewPage : ContentPage
	{
		public NewPage ()
		{
			InitializeComponent ();
		}

        private void SaveToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Title = titleEntry.Text
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseConnection))
            {
                conn.CreateTable<Post>();
                int rows = conn.Insert(post);

                if (rows > 0)
                    DisplayAlert("Success", "Title successfully added", "Ok");
                else
                    DisplayAlert("Failure", "Unable to add Title", "Ok"); 
            }
        }
    }
}
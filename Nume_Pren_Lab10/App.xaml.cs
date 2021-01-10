using System;
using System.IO;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using Nume_Pren_Lab10.Data;

namespace Nume_Pren_Lab10
{
    public partial class App : Application
    {
        static ShoppingListDatabase database;

        public static ShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                    ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "ShoppingList.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}





//using System;
//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

//namespace Nume_Pren_Lab10
//{
//    public partial class App : Application
//    {
//        public App()
//        {
//            InitializeComponent();

//            MainPage = new MainPage();
//        }

//  am adaugat ce e mai jos

//        protected override void OnStart()
//        {
//        }

//        protected override void OnSleep()
//        {
//        }

//        protected override void OnResume()
//        {
//        }
//    }
//}

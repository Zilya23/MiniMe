using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace MiniMe
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "taskForMiniMe.db";
        public static TaskRepository database;
        public static MyLvlRepoitory myLvl;
        public static LvlRepository lvlRepository;
        public static TaskRepository Database
        {
            get
            {
                if(database == null)
                {
                    database = new TaskRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }

        public static LvlRepository lvlRepoitory
        {
            get
            {
                if(lvlRepository == null)
                {
                    lvlRepository = new LvlRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return lvlRepository;
            }
        }

        public static LvlRepository repository
        {
            get
            {
                if (lvlRepository == null)
                {
                    lvlRepository = new LvlRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return lvlRepository;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListPage());
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

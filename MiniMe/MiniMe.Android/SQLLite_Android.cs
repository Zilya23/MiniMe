using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MiniMe.Droid;
using Xamarin.Forms;

//[assembly: Dependency(typeof(SQLLite_Android))]
namespace MiniMe.Droid
{
    public class SQLLite_Android : ISQLite
    {
        public SQLLite_Android() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return path;
        }
    }
}
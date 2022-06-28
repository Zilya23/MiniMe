using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MiniMe
{
    public class MyLvlRepoitory
    {
        SQLiteConnection database;

        public MyLvlRepoitory(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<lvl>();
        }
        public MyLvl GetLvl(int id)
        {
            return database.Get<MyLvl>(id);
        }
        public int SaveItem(MyLvl item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}

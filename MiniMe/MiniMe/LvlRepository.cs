using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MiniMe
{
    public class LvlRepository
    {
        SQLiteConnection database;

        public LvlRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<lvl>();
        }
        public IEnumerable<lvl> GetItems()
        {
            return database.Table<lvl>().ToList();
        }

        public lvl GetLvl(int id)
        {
            return database.Get<lvl>(id);
        }
    }
}

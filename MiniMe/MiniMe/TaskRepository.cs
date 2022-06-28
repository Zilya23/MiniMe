using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MiniMe
{
    public class TaskRepository
    {
        SQLiteConnection database;
        public TaskRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<TaskForMiniMe>();
        }
        public IEnumerable<TaskForMiniMe> GetItems()
        {
            return database.Table<TaskForMiniMe>().ToList();
        }

        public TaskForMiniMe GetTask(int id)
        {
            return database.Get<TaskForMiniMe>(id);
        }

        public int DeleteItem(int id)
        {
            return database.Delete<TaskForMiniMe>(id);
        }

        public int SaveItem(TaskForMiniMe item)
        {
            if(item.Id != 0)
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

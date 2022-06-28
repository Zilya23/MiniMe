using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MiniMe
{
    [Table ("TaskForMiniMe")]
    public class TaskForMiniMe
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int XPoint { get; set; }
    }
}

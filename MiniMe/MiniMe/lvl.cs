using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MiniMe
{
    [Table ("Lvl")]
    public class lvl
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public int Number { get; set; }
        public int start_lvl { get; set; }
        public int end_lvl { get; set; }
    }
}

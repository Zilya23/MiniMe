using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MiniMe
{
    [Table ("MyLvl")]
    public class MyLvl
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public int XPcount { get; set; }
    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteTest.ORM
{
    public class CV
    {
        [PrimaryKey,AutoIncrement]
        public int IdCV { get; set; }
    }
}

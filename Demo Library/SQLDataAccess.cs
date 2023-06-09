﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SQLDataAccess : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output=base.LoadConnectionString(name);
            output += "from SQL";
            return output;
        }

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading SQL Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving Data to SQL");
        }

    }
}

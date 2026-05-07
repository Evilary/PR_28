using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_Чернышков.Classes.Database
{
    public class Config
    {
        public static readonly string connection = "server=127.0.0.1;" +
            "uid=root;" +
            "pwd=;" +
            "database = TaskManager;";

        public static readonly MySqlServerVersion version = new MySqlServerVersion(new Version(8, 0, 11));

    }
}

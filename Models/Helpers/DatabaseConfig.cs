using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AEB_demo.Models.Helpers
{
    public class DatabaseConfig
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}
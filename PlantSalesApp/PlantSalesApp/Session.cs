using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSalesApp
{
    internal static class Session
    {
        public static int UserId { get; set; }
        public static bool IsAdmin { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace VideoGamesStore.Classes
{
    internal class Helper
    {
        public static Database.PlayerokEntities3 DB = new Database.PlayerokEntities3();
        public static Database.User user { get; set; }
    }
}

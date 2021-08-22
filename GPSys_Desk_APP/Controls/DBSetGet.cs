using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSys_Desk_APP.Controls
{
    public class DBSetGet
    {
        public long? ID { set; get; }
        public string ServerName { set; get; }
        public string DBName { set; get; }
        public string DBUser { set; get; }
        public string DBPassword { set; get; }
    }
}

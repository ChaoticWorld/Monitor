using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDB
{

    public class clientModel
    {
        public string ver { get; set; }
        public string serverIPAddr { get; set; }
        public string serverPort { get; set; }
        public string clientid { get; set; }
        public DateTime installDate { get; set; }
    }

    public class clientFunctions
    {
        public int fid { get; set; }
        public string functionName { get; set; }
        public int enable { get; set; }
        public DateTime lastUpdateDate { get; set; }
    }
    public class functionModel
    {
        public string key { get; set; }
        public string value { get; set; }
        public int index { get; set; }
        public int fid { get; set; }
        public int keyid { get; set; }
        public DateTime lastUpdateDate { get; set; }
        /// <summary>
        /// 唯一值，组成：clientid-ver-serverIP-fid-keyid
        /// </summary>
        public string keysn         { get; set; }
    }
}

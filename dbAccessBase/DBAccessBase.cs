using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using FluentData;

namespace DBAccessBase
{
    public abstract class DBAccessBase
    {
        public string connStr { get; private set; }
        public static int Records = -1;
        public static string MasterKey = string.Empty;

        protected string TableName { get; set; }
        protected string _sqlBase = string.Empty;
        protected string BaseQuery { get { return _sqlBase; } }
        protected void setBaseQuery(string _base)
        { _sqlBase = _base; }
        protected StringBuilder wStr;
        protected IDbContext Context;
        public DBAccessBase(string _conn)
        { connStr = _conn; }
        ~DBAccessBase()
        {
            connStr = null;
            Context = null;
        }
    }
    public class ServiceDBAccess : DBAccessBase
    {
        public ServiceDBAccess(string _svcConn) : base(_svcConn)
        { }
    }
}

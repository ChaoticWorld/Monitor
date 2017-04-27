using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAccessBase;
using CommunityParams;
using FluentData;

namespace ClientDB
{
    public class clientConfigurationDBA : IDBHelper.IdbCRUD<clientModel>
    {
        IDbContext Context;
        public clientConfigurationDBA(IDbContext _context)
        { Context = _context; }
        public long Create(clientModel t)
        {
            throw new NotImplementedException();
        }

        public int Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<clientModel> selects(clientModel t)
        {
            throw new NotImplementedException();
        }

        public clientModel Single(string key)
        {
            throw new NotImplementedException();
        }

        public clientModel Single(long id)
        {
            throw new NotImplementedException();
        }

        public int Update(clientModel t)
        {
            throw new NotImplementedException();
        }
    }
    public class clientFunctionsDBA : IDBHelper.IdbCRUD<clientFunctions>
    {
        public long Create(clientFunctions t)
        {
            throw new NotImplementedException();
        }

        public int Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<clientFunctions> selects(clientFunctions t)
        {
            throw new NotImplementedException();
        }

        public clientFunctions Single(string key)
        {
            throw new NotImplementedException();
        }

        public clientFunctions Single(long id)
        {
            throw new NotImplementedException();
        }

        public int Update(clientFunctions t)
        {
            throw new NotImplementedException();
        }
    }
    public class functionModelDBA : IDBHelper.IdbCRUD<functionModel>
    {
        public long Create(functionModel t)
        {
            throw new NotImplementedException();
        }

        public int Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<functionModel> selects(functionModel t)
        {
            throw new NotImplementedException();
        }

        public functionModel Single(string key)
        {
            throw new NotImplementedException();
        }

        public functionModel Single(long id)
        {
            throw new NotImplementedException();
        }

        public int Update(functionModel t)
        {
            throw new NotImplementedException();
        }
    }

    public class ClientDBAccess : DBAccessBase.DBAccessBase
    {
        public clientModel clientConfiguration { get { return getClientConfigModel(); } }

        private clientModel getClientConfigModel()
        {
            throw new NotImplementedException();
        }

        //private static SQLiteConnection conn;
        public ClientDBAccess(string _cliConn) : base(_cliConn)
        {
            Context = new DbContext().ConnectionString(base.connStr, new SqliteProvider());
            initClientBaseTable();
        }

        public bool isExistTable(string tableName)
        {
            bool r = false;
            string cmd = "select [name] from sqlite_master where [type]='table' and [name]='" + tableName + "'";
            string tn = Context.Sql(cmd).QuerySingle<string>();
            r = !string.IsNullOrEmpty(tn);
            return r;
        }
        /// <summary>
        /// 初始化数据表
        /// </summary>
        public void initClientBaseTable()
        {
            string cmd = string.Empty;
            
            if (!isExistTable("clientConfiguration"))
            /*
        public string ver { get; set; }
        public string serverIPAddr { get; set; }
        public string serverPort { get; set; }
        public string clientid { get; set; }
        public DateTime installDate { get; set; }*/
            { cmd = "CREATE TABLE clientConfiguration(ver TEXT,serverIPAddr TEXT,serverPort  TEXT,clientid  TEXT,installDate Datetime)";
                Context.Sql(cmd).Execute(); }

            if (!isExistTable("clientFunctions"))
            {
                /*        public int fid { get; set; }
        public string functionName { get; set; }
        public bool enable { get; set; }
        public DateTime lastUpdateDate { get; set; }*/
                cmd = "CREATE TABLE clientFunctions(fid INTEGER,enable INTEGER,functionName  TEXT,lastUpdateDate Datetime)";
                Context.Sql(cmd).Execute();
            }

            if (!isExistTable("functionConfiguration"))
            {
            /*
        public string key { get; set; }
        public string value { get; set; }
        public int index { get; set; }
        public int fid { get; set; }
        public int keyid { get; set; }
        public DateTime lastUpdateDate { get; set; }
        public string keysn         { get; set; }*/
                cmd = "CREATE TABLE functionConfiguration(keyid INTEGER,key  TEXT,value  TEXT,index INTEGER,fid INTEGER,keysn  TEXT,lastUpdateDate Datetime)";
                Context.Sql(cmd).Execute();
            }

        }        
    }
}

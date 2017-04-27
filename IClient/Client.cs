using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFunction;

namespace Client
{
    public partial class Client
    {
        ClientDB.ClientDBAccess cliDbAccess;
        public string clientID { get; set; }
        IEnumerable<int> FuncIDs { get { return getServiceFuncIDs(); } }
        List<IFunction.IFunction> Functions;
        
        public IEnumerable<int> getServiceFuncIDs()
        {
            IEnumerable<int> r  = null;
            //获得服务器功能数据列表
            string[] strids = clicommun.request(null).Split(',');
            List<int> ids = new List<int>();
            foreach (string id in strids)
            {; }
            return r;
        }

        public Client()
        {
            Init();
        }

        private void InitLocalDB()
        {
            string localDBPath = "Data Source =" + Environment.CurrentDirectory + "/Data/localConfig.db";
            cliDbAccess = new ClientDB.ClientDBAccess(localDBPath);
        }
        private void Init()
        {
            InitLocalDB();
            InitFunctions();
        }
        private void InitFunctions()
        {
            Functions = new List<IFunction.IFunction>();
            IFunction.IFunction func;
            //初始代功能列表并启动
            foreach (int funcID in FuncIDs)
            {
                //DLL注入
                func = registerDLL(funcID);
                Functions.Add(func);
            }
        }
        IFunction.IFunction registerDLL(int id)
        {
            IFunction.IFunction func = null;
            return func;
        }
    }
}

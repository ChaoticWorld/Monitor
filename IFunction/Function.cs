using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFunction
{
    public abstract class FunctionBase<T> : IFunction
    {
        public string state { get; set; }
        public int id { get; set; }
        public void End()
        {
            throw new NotImplementedException();
        }

        public void Initializer()
        {
            throw new NotImplementedException();
        }

        public T receiveConfigration()
        {
            throw new NotImplementedException();
        }

        public void requestConfigration()
        {
            throw new NotImplementedException();
        }

        public void reStart()
        {
            End();
            Initializer();
            Start();
        }

        public void Start()
        {
            // 开始功能
            // 载入本地配置值
            // loadLocalConfigration();
            // 定时监视或植入勾子，开始功能
            throw new NotImplementedException();
        }
        public T loadLocalConfigration()
        {
            throw new NotImplementedException();
        }
    }
}

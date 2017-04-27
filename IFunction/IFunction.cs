using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFunction
{
    public interface IFunction
    {
        /// <summary>
        /// 初始化功能
        /// 获得本地配置版本和服务器配置版本进行比较。
        /// 如果相同，执行开始功能；
        /// 如果不同，请求服务器配置值更新本地配置值后，执行开始功能；
        /// </summary>
        void Initializer();
        /// <summary>
        /// 开始功能
        /// 载入本地配置值
        /// 定时监视或植入勾子，
        /// 开始功能
        /// </summary>
        void Start();
        /// <summary>
        /// 结束功能
        /// </summary>
        void End();
        /// <summary>
        /// 重启功能
        /// </summary>
        void reStart();
        string state { get; set; }
        int id { get; set; }

    }

}

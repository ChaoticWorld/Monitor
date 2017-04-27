using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HookLibrary;

namespace IOHookLib
{
    public class IOHook:IDisposable,IHook
    {
        public IOHook() {
            callback = ioMessage;
        }

        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)。
                }

                // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
                // TODO: 将大型字段设置为 null。

                disposedValue = true;
            }
        }

        // TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
        ~IOHook()
        {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(false);
        }

        // 添加此代码以正确实现可处置模式。
        void IDisposable.Dispose()
        {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
            // GC.SuppressFinalize(this);
        }

        #endregion


        private IntPtr hookId;
        private readonly LowLevelProc callback ;
        private bool hooked;
        
        private IntPtr ioMessage(int nCode, IntPtr wParam, IntPtr lParam) {
            if (nCode >= 0) {

            }

            return Win32.CallNextHookEx(hookId, nCode, wParam, lParam);
        }
        public void Hook()
        {
            hookId = Win32.SetWindowsHook(Win32.Hooks.WH_GETMESSAGE, callback);
            hooked = true;
        }

        public void Unhook()
        {
            if (!hooked) return;
            Win32.UnhookWindowsHookEx(hookId);
            hooked = false;
        }

    }
    public class IOMessageStruct
    {

    }
}

using System;
using System.Diagnostics;

namespace CSharpJs.WinForm
{
    public class SimpleInvoke<T> where T : System.Windows.Forms.Control
    {
        public static void Invoke(T _this, Action func)
        {
            try
            {
                if (!_this.IsHandleCreated)
                    return;

                _this.Invoke(func);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }

        }

        public static void BeginInvoke(T _this, Action func)
        {
            try
            {
                if (!_this.IsHandleCreated)
                    return;

                _this.BeginInvoke(func);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }

        }
    }
}

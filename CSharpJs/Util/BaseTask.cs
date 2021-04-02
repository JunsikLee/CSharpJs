using System.Threading;
using System.Threading.Tasks;

namespace CSharpJs.Util
{
    public class BaseTask
    {
        protected CancellationTokenSource runToken = new CancellationTokenSource();

        public virtual bool Start()
        {
            Task.Factory.StartNew(() => Run(runToken.Token), runToken.Token);
            return true;
        }

        public virtual bool End()
        {
            runToken.Cancel();
            return true;
        }

        protected virtual bool Run(CancellationToken cancellationToken)
        {
            Thread.Sleep(10);
            return !runToken.IsCancellationRequested;
        }
    }
}

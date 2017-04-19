using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.WindowsAzure.Storage;

namespace CountdownRole
{
    public class WorkerRole : RoleEntryPoint
    {
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private readonly ManualResetEvent _runCompleteEvent = new ManualResetEvent(false);
        private LockboxEntities _dataContext { get; set; }


        public override void Run()
        {
            Trace.TraceInformation("CountdownRole is running");

            try
            {
                this.RunAsync(this._cancellationTokenSource.Token).Wait();
            }
            finally
            {
                this._runCompleteEvent.Set();
            }
        }

        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections
            ServicePointManager.DefaultConnectionLimit = 12;

            _dataContext = new LockboxEntities();

            // For information on handling configuration changes
            // see the MSDN topic at https://go.microsoft.com/fwlink/?LinkId=166357.

            bool result = base.OnStart();

            Trace.TraceInformation("CountdownRole has been started");

            return result;
        }


        public override void OnStop()
        {
            Trace.TraceInformation("CountdownRole is stopping");

            this._cancellationTokenSource.Cancel();
            this._runCompleteEvent.WaitOne();

            base.OnStop();

            Trace.TraceInformation("CountdownRole has stopped");
        }

        private async Task RunAsync(CancellationToken cancellationToken)
        {
            while (cancellationToken.IsCancellationRequested)
            {
                
            }
        }
    }
}

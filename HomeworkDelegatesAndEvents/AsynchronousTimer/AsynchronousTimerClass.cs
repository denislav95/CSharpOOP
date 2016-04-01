using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousTimer
{
    internal class AsynchronousTimerClass
    {
        private int ticks;
        private int t;

        public AsynchronousTimerClass(Action<int> method, int ticks, int t)
        {
            this.MethodToExecute = method;
            this.Ticks = ticks;
            this.T = t;
        }

        public Action<int> MethodToExecute { get; private set; }

        public int Ticks { get; set; }

        public int T { get; set; }

        public void ExecuteAction()
        {
            Thread thread = new Thread(this.Run);
            thread.Start();
        }

        private void Run()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                Thread.Sleep(this.T);
                Random random = new Random();

                if (this.MethodToExecute != null)
                {
                    this.MethodToExecute(random.Next(66, 133));
                }
            }
        }
    }
}

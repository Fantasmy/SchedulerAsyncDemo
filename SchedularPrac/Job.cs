using Quartz;
using System;
using System.Threading.Tasks;

namespace SchedularPrac
{
    public class Job : IJob  // implementa Ijob
    {
        public Task Execute(IJobExecutionContext context)  // método Execute
        {
            Task task = new Task(new Action(MyFuncAsync));
            task.Start();
            return task;
        }

        public void MyFuncAsync() { 
            Form2 fm = new Form2();
                fm.ShowDialog();
        }
    }
}

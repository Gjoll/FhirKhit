using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FhirKhit.Tools
{
    public static class TaskExtensions
    {
        public static T WaitResult<T>(this Task<T> task)
        {
            task.Wait();
            return task.Result;
        }
    }
}

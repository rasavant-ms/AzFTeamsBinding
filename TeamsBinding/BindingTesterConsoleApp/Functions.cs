using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebJobs.TeamsBinding;

namespace BindingTesterConsoleApp
{
    public static class Functions
    {
        public static void SampleTrigger([SampleTrigger(@"sample\path")] SampleTriggerValue value)
        {
            Console.WriteLine("Sample trigger job called!");
        }
    }
}

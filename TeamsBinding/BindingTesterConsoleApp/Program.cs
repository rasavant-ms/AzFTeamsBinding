using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingTesterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            JobHostConfiguration config = new JobHostConfiguration();

            config.UseSample();

            JobHost host = new JobHost(config);

            // Add or remove types from this list to choose which functions will 
            // be indexed by the JobHost.
            // To run some of the other samples included, add their types to this list
            //config.TypeLocator = new SamplesTypeLocator(
            //    typeof(SampleSamples));

            //// Some direct invocations to demonstrate various binding scenarios
            //host.Call(typeof(SampleSamples).GetMethod("Sample_BindToStream"));
            //host.Call(typeof(SampleSamples).GetMethod("Sample_BindToString"));

            host.RunAndBlock();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Orleans;
using GrainInterfaces;

namespace GrainCollection
{
    public class Grain1 : Orleans.Grain, IGrain1
    {
        public Task<string> GetMachineName()
        {
            return Task.FromResult(Environment.MachineName);
        }
    }
}

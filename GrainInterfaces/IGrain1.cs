using Orleans;
using System.Threading.Tasks;

namespace GrainInterfaces
{
    public interface IGrain1 : IGrain
    {
        Task<string> GetMachineName();
    }
}

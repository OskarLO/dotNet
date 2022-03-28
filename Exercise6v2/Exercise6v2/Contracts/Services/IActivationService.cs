using System.Threading.Tasks;

namespace Exercise6v2.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}

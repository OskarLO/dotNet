using System.Threading.Tasks;

namespace Exercise6v2.Activation
{
    public interface IActivationHandler
    {
        bool CanHandle(object args);

        Task HandleAsync(object args);
    }
}

using System.Threading;
using System.Threading.Tasks;

namespace CqrsDotnet
{
  public interface ICommandDispatcher
  {
    Task<TCommandResult> Dispatch<TCommand, TCommandResult>(TCommand command, CancellationToken cancellation);
  }
}
using System.Threading;
using System.Threading.Tasks;

namespace CqrsDotnet
{
  public interface ICommandHandler<in TCommand, TCommandResult>
  {
    Task<TCommandResult> Handle(TCommand query, CancellationToken cancellation);
  }
}
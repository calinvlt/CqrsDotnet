using System.Threading;
using System.Threading.Tasks;

namespace CqrsDotnet
{
  public interface IQueryDispatcher
  {
    Task<TQueryResult> Dispatch<TQuery, TQueryResult>(TQuery query, CancellationToken cancellation);
  }
}

using System.Threading;
using System.Threading.Tasks;

namespace CqrsDotnet
{
  public interface IQueryHandler<in TQuery, TQueryResult>
  {
    Task<TQueryResult> Handle(TQuery query, CancellationToken cancellation);
  }
}
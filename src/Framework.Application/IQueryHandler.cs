

namespace Framework.Application
{
    public interface IQueryHandler< TQuery, TQueryResult>  where TQuery : IQuery
    {
        Task<TQueryResult> Handle(TQuery query);
    }
}

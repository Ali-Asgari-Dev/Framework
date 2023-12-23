namespace Framework.Application;

public class PagingQueryResult<T> : IQueryResult where T : class
{
    public T Items { get; set; }
    public int PageSize { get; set; }
    public long Count { get; set; }

    public PagingQueryResult(T items, int pageSize, long count)
    {
        Items = items;
        PageSize = pageSize;
        Count = CalculateCountOfPage(count,pageSize);
    }

    private long CalculateCountOfPage(double count,int size)=>(long)Math.Ceiling(count / size);

}
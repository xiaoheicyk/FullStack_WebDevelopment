using System.Collections;

namespace Infrastructure.Models;

public class PaginatedList<T> : IEnumerable<T>
{
    private readonly List<T> _items;
    
    public int TotalCount { get; private set; }
    public int PageIndex{ get; private set; }
    public int PageSize { get; private set; }
    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    
    public bool HasPreviousPage => PageIndex > 1;
    public bool HasNextPage => PageIndex < TotalPages;
    
    public IEnumerator<T> GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _items.GetEnumerator();
    }
    
    public PaginatedList(IEnumerable<T> items, int count, int pageIndex, int pageSize)
    {
        TotalCount = count;
        PageIndex = pageIndex;
        PageSize = pageSize;
        _items = new List<T>(items); 
    }
    
    
}
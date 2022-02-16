namespace Vimasistem.QueryFilter.Interfaces
{
    public interface IPagination
    {
        public string GetQuery(int? pageNumber, int? pageSize);
    }
}
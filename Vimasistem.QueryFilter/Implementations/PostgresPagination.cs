using Vimasistem.QueryFilter.Interfaces;

namespace Vimasistem.QueryFilter.Implementations
{
    public class PostgresPagination : IPagination
    {
        public string GetQuery(int? pageNumber, int? pageSize)
        {
            string query = "";

            if (pageSize != null) query = query + " " + $"LIMIT {pageSize}";
            
            if (pageNumber != null)
            {
                pageNumber = (pageNumber - 1) * (pageSize ?? 1);
                query =  query + " " + $"OFFSET {pageNumber} ROWS";
            }

            return query;
        }
    }
}
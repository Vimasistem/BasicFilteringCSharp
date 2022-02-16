using Vimasistem.QueryFilter.Interfaces;

namespace Vimasistem.QueryFilter.Implementations
{
    public class OraclePagination : IPagination
    {
        public string GetQuery(int? pageNumber, int? pageSize)
        {
            string query = "";

            if (pageNumber != null)
            {
                pageNumber = (pageNumber - 1) * (pageSize ?? 1);
                query =  query + " " + $"OFFSET {pageNumber} ROWS";
            }
            
            if (pageSize != null) query = query + " " + $"FETCH NEXT {pageSize} ROWS ONLY";

            return query;
        }
    }
}
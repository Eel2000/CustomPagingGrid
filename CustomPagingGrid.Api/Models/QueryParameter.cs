namespace CustomPagingGrid.Api.Models
{
    public class QueryParameter
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public string OrderBy { get; set; }

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPagingGrid.Shared
{
    public class ODataEnvelop
    {
        [JsonProperty("@odata.context")]
        public string? OdataContext { get; set; }

        [JsonProperty("@odata.count")]
        public int OdataCount { get; set; }

        [JsonProperty("value")]
        public List<Value>? Value { get; set; }
    }

    public class Value
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public bool? Discontinued { get; set; }
        public List<OrderDetails>? Order_Details { get; set; }
    }

    public class OrderDetails
    {
        public int OrderID { get; set; }
        public int? ProductID { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public decimal? Discount { get; set; }
    }
}

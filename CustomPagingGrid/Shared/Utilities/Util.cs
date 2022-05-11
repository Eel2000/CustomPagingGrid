using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPagingGrid.Shared.Utilities
{
    public static class Util
    {
        /// <summary>
        /// Formatt the given string filter from telerik grid
        /// </summary>
        /// <param name="filterString"></param>
        /// <param name="page"></param>
        /// <returns>Well formatted querystring to be used for api calls</returns>
        public static string FormatQueryString(string filterString, int page)
        {
            var desc = filterString.Replace("$", string.Empty); ;
            var d = desc.Split("&");
            var t = d[d.Length - 2] = $"skip={page}";
            var cleaned = string.Join("&", d);
            return cleaned;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Ubiety.Dns.Core.Records.NotUsed;

namespace BlazingPizza.Server.Helpers
{
    public  static class HttpContextExtensions
    {
        public static async Task InsertPaginationParameterInResponse<T>(this HttpContext httpcontext,
            IQueryable<T> queryable, int recordsPerPage)
        {
            double count = await queryable.CountAsync();
            double pagesQuantity = Math.Ceiling(count / recordsPerPage);
            httpcontext.Response.Headers.Add("pagesQuantity", pagesQuantity.ToString());
        }
    }
}

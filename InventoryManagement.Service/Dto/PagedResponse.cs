using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto
{
    public class ServiceResponse
    {
        public ServiceResponse()
        {
            Errors = new List<string>();
        }
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }
        public object Data { get; set; }

  
    }

    public class PagedResponse : ServiceResponse
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }  
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public string Search { get; set; }

        public PagedResponse(object data, int pageNumber, int totalRecords, int pageSize=10, string search="")
        {
            Success = true;
            Data = data;
            TotalRecords = totalRecords;
            PageNumber = pageNumber;
            PageSize = pageSize;
            Search = search;
            TotalPages = TotalRecords / pageSize ;
        }
    }


    public class GetAllRequest<Entity, FilterDto>
    {
        [JsonIgnore]
        public Expression<Func<Entity, bool>> predicate;
        [JsonIgnore]
        public string includeProperties;
        [JsonIgnore]
        public bool tracked  = false;
        public int PageNumber { get; set; }
        public int PageSize { get; set; } = 5;
        public string Search { get; set; }
        public FilterDto Filter  { get; set; }

    }
}

using Microsoft.AspNetCore.Mvc;
using static Micro.Web.Utility.StaticDetails;

namespace Micro.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }

    }
}

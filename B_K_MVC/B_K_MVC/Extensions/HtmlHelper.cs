using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace B_K_MVC.Extensions
{
    public  static class HtmlHelperExtensions
    {
        public static HtmlString HtmlConvertToJson(this HtmlHelper htmlHelper, object model)
        {
            var setting = new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented
            };
            return new HtmlString(JsonConvert.SerializeObject(model,setting));
        }
    }
}
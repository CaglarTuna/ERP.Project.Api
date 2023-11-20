using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public static class ListExtensions
    {
        public static List<SelectListItem> ToSelectList<T>(this List<T> list,string id,string name)
            where T :class,new()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            list.ForEach(x =>
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = x.GetType().GetProperty(name).GetValue(x).ToString(),
                    Value = x.GetType().GetProperty(id).GetValue(x).ToString()
                });
            });
            return selectListItems;
        }
    }
}

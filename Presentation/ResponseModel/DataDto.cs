using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.ResponseModel
{
    public class DataDto<T>
    {
        public T data { get; set; }
        public string message { get; set; }
        public bool statu { get; set; }
        public List<T> dataList { get; set; }
    }
}

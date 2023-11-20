using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ResultDTO<T>
    {
        public T Data { get; set; }
        public List<T> DataList { get; set; }
        public string Message { get; set; }
        public bool Statu { get; set; }
    }
}

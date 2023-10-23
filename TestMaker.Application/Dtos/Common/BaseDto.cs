using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaker.Application.Dtos.Common
{
    public class BaseDto<T>
    {
        public T Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string RegisteringUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string EditingUser { get; set; }
        public bool IsDelete { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaker.Domain.Models.list
{
    public class BaseDomainEntity<T>
    {
        public T Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string RegisteringUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string EditingUser { get; set; }
        public bool IsDelete { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Domain.Models.list;

namespace TestMaker.Domain.Models
{
    public class Tag : BaseDomainEntity<int>
    {
        public string Title { get; set; }
        public string EnTitle { get; set; }
        public string Class { get; set; }
        public string Icon { get; set; }
        
    }
}

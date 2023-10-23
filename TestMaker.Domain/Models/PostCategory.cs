using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Domain.Models.list;

namespace TestMaker.Domain.Models
{
    public class PostCategory : BaseDomainEntity<int>
    {
        public string Title { get; set; }
        public string EnTitle { get; set; }
        public string Icon { get; set; }
        public int Type { get; set; }
        //relations

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaker.Domain.Models.list
{
    public class SimpleEntity<T>
    {
        [Key]
        public T Id { get; set; }
    }
}

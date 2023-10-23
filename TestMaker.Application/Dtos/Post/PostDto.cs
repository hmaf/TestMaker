using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.Common;

namespace TestMaker.Application.Dtos.Post
{
    public class PostDto : BaseDto<int>
    {
        [MaxLength(250)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string SubTitle { get; set; }
        [MaxLength(250)]
        public string TopTitle { get; set; }
        [MaxLength(250)]
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [MaxLength(250)]
        public string Text { get; set; }
        [MaxLength(50)]
        public string FromHourToHour { get; set; }
        [MaxLength(50)]
        public string FromDayToDay { get; set; }
        public string Factors { get; set; }
        public string Interested { get; set; }
        public string Tags { get; set; }
        public string BasicPostCategory { get; set; }
        public string SubPostCategory { get; set; }
        public string Cover { get; set; }
        public string AttacheFile { get; set; }
        public string Image { get; set; }
        public string OwnerId { get; set; }
    }
}

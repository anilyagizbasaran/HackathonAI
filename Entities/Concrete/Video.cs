using Entities.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Video:IEntity
    {
        public int VideoId { get; set; }
        public string VideoTitle { get; set; }
        public string VideoContent { get; set; }
        public string VideoPath { get; set; }
        public DateTime VideoUploadedAt { get; set; }
        public int CategoryLessonId { get; set; }
    }
}

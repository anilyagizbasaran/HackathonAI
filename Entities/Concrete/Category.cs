using Entities.Abstact;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category: IEntity
    {
        [Key]
        public int CategoryLessonId { get; set; }
        public string CategoryLessonName { get; set; }
    }
}

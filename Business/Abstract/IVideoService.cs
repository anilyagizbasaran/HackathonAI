using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVideoService
    {
        List<Video> GetAll();
        void Add(Video video);
        void Update(Video video);
        void Delete(Video video);
        List<Video> GetVideoByCategory(int categoryLessonId);
        
    }
}

using Business.Abstract;
using Business.ValidationRules;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VideoManager : IVideoService
    {
        private IVideoDal _videoDal;
        public VideoManager(IVideoDal videoDal)
        {
            _videoDal = videoDal;
        }
        public void Add(Video video)
        {
            _videoDal.Add(video);
        }

        public void Delete(Video video)
        {
            try
            {
                _videoDal.Delete(video);
            }
            catch
            {

                throw new Exception("Silme gerçekleşemedi");

            }
        }

        public List<Video> GetAll()
        {
            return _videoDal.GetAll();
        }

        public List<Video> GetVideoByCategory(int categoryLessonId)
        {
            return _videoDal.GetAll(p => p.CategoryLessonId == categoryLessonId);
        }
        
        public void Update(Video video)
        {
            _videoDal.Update(video);
        }
    }
}

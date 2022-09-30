using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageManager : IImageService
    {
       private readonly IImageDal _imageDal;

        public ImageManager(IImageDal ımageDal)
        {
            _imageDal = ımageDal;
        }

        public void Delete(Image t)
        {
            throw new NotImplementedException();
        }

        public Image GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Image> GetListAll()
        {
            return _imageDal.GetListAll();
        }

        public void Insert(Image t)
        {
            throw new NotImplementedException();
        }

        public void Update(Image t)
        {
            throw new NotImplementedException();
        }
    }
}

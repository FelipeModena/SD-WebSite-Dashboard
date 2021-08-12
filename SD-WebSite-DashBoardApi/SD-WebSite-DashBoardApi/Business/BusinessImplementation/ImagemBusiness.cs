using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Repositorio.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Business.BusinessImplementation
{
    public class ImagemBusiness : IImagemBusiness
    {

        private readonly IGenericRepository<Imagem> _genericRepository;

        public ImagemBusiness(IGenericRepository<Imagem> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public void DeleteImagens(List<int> imagensId)
        {
            foreach (var imgId in imagensId)
            {
                _genericRepository.Delete(imgId);
            }
        }
    }
}

using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MovieManager : IMovieService
    {
        public List<Movie> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Movie t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Movie t)
        {
            throw new NotImplementedException();
        }

        public Movie TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Movie t)
        {
            throw new NotImplementedException();
        }
    }
}

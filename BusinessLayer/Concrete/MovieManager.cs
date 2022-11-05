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
    public class MovieManager : IMovieService
    {
        IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public List<Movie> GetMovieListWithCategory()
        {
            return _movieDal.GetListWithCategory();
        }

        public List<Movie> GetMovieListWithMovieExtra()
        {
            return _movieDal.GetListWithMovieExtra();
        }

        public List<Movie> GetList()
        {
            return _movieDal.GetListAll();
        }

        public void TAdd(Movie t)
        {
            _movieDal.Insert(t);
        }

        public void TDelete(Movie t)
        {
            _movieDal.Delete(t);
        }

        public Movie TGetByID(int id)
        {
            return _movieDal.GetByID(id);
        }

        public void TUpdate(Movie t)
        {
            _movieDal.Update(t);
        }
    }
}

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
    public class MovieExtraManager : IMovieExtraService
    {
        IMovieExtraDal _movieExtraDal;

        public MovieExtraManager(IMovieExtraDal movieExtraDal)
        {
            _movieExtraDal = movieExtraDal;
        }

        public List<MovieExtra> GetList()
        {
            return _movieExtraDal.GetListAll();
        }

        public void TAdd(MovieExtra t)
        {
            _movieExtraDal.Insert(t);
        }

        public void TDelete(MovieExtra t)
        {
            _movieExtraDal.Delete(t);
        }

        public MovieExtra TGetByID(int id)
        {
            return _movieExtraDal.GetByID(id);
        }

        public void TUpdate(MovieExtra t)
        {
            _movieExtraDal.Update(t);
        }
    }
}

using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMovieRepository:IGenericRepository<Movie>,IMovieDal
    {
        public List<Movie> GetListWithCategory()
        {
            using (var context = new Context())
            {
                return context.Movies.Include(x => x.Category).ToList();
            }

        }

        public List<Movie> GetListWithMovieExtra()
        {
            using (var context = new Context())
            {
                return context.Movies.Include(x => x.MovieExtra).ToList();
            }
        }
    }
}

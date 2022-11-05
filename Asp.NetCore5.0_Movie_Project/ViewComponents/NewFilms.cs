using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Movie_Project.ViewComponents
{
    public class NewFilms:ViewComponent
    {
        MovieManager movieManager = new MovieManager(new EfMovieRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = movieManager.GetMovieListWithCategory();
            id = movieManager.GetMovieListWithMovieExtra().Select(x=>x.MovieExtra.MovieAge).FirstOrDefault();
            var values2 = movieManager.GetMovieListWithMovieExtra().Where(x=>x.MovieExtra.MovieAge==id).Select(y=>y.MovieExtra.MovieAge).FirstOrDefault();
            var values3 = movieManager.GetMovieListWithMovieExtra().Select(y => y.MovieExtra.MovieQuality).FirstOrDefault();
            ViewBag.v1 = values2;
            ViewBag.v2 = values3;

            return View(values);
        }
    }
}

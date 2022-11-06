
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Movie_Project.ViewComponents
{
    
    public class RecommendFilms:ViewComponent
    {
        MovieManager movieManager = new MovieManager(new EfMovieRepository());

        public IViewComponentResult Invoke()
        {
            var values = movieManager.GetMovieListWithCategory();
            return View(values);
        }

    }
}

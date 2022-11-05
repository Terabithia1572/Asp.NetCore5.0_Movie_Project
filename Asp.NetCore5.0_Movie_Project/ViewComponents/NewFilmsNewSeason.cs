using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Movie_Project.ViewComponents
{
    MovieManager movieManager = new MovieManager(new EfMovieRepository());

    public class NewFilmsNewSeason
    {
    }
}

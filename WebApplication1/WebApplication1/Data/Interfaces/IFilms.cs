using System.Collections;
using System.Collections.Generic;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Interfaces
{
    public interface IFilms
    {
        IEnumerable<Film> AllFilms { get; }
    }
}

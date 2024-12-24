using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Domain;

namespace BookStore.Repository.Abstract
{
    public interface IGenreService
    {
        bool Add(Genre model);
        bool Update(Genre model);

        bool Delete(int id);
        Genre FindbyId(int id);
        IEnumerable<Genre> GetAll();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Domain;

namespace BookStore.Repository.Abstract
{
    public interface IAuthorService
    {
        bool Add(Author model);
        bool Update(Author model);

        bool Delete(int id);
        Author FindbyId(int id);
        IEnumerable<Author> GetAll();
    }
}

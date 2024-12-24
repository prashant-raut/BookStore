using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Domain;

namespace BookStore.Repository.Abstract
{
    public interface IPublisherService
    {
        bool Add(Publisher model);
        bool Update(Publisher model);

        bool Delete(int id);
        Publisher FindbyId(int id);
        IEnumerable<Publisher> GetAll();
    }
}

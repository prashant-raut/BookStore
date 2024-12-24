﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Domain;

namespace BookStore.Repository.Abstract
{
    public interface IBookService
    {
        bool Add(Book model);
        bool Update(Book model);

        bool Delete(int id);
        Book FindbyId(int id);
        IEnumerable<Book> GetAll();
    }
}

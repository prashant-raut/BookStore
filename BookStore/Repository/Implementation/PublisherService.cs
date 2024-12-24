using BookStore.Models.Domain;
using BookStore.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository.Implementation
{
    public class PublisherService : IPublisherService
    {
        private readonly DatabaseContext context;
        public PublisherService(DatabaseContext context)
        {
            this.context = context;
        }
        public bool Add(Publisher model)
        {
            try
            {
                context.Publishers.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.FindbyId(id);
                if (data == null)
                    return false;
                context.Publishers.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        
        public Publisher FindbyId(int id)
        {
            return context.Publishers.Find(id);
        }

        public IEnumerable<Publisher> GetAll()
        {
            return context.Publishers.ToList();
        }

        public bool Update(Publisher model)
        {
            try
            {
                context.Publishers.Update(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
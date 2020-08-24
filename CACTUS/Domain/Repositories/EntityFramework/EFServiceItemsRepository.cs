using CACTUS.Domain.Entities;
using CACTUS.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsRepository : IServiceItemsRepository
    {
        private readonly AppDbContext context;

        public EFServiceItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteServiceItem(Guid Id)
        {
            this.context.ServiceItems.Remove(new ServiceItem() { Id = Id });
            this.context.SaveChanges();
        }

        public ServiceItem GetServiceItem(Guid Id)
        {
            return this.context.ServiceItems.FirstOrDefault(x => x.Id == Id);
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return this.context.ServiceItems;
        }

        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }

            context.SaveChanges();
        }
    }
}

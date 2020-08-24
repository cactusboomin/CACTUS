using CACTUS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItem(Guid Id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid Id);
    }
}

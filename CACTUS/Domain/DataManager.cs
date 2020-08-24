using CACTUS.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFields, IServiceItemsRepository serviceItems)
        {
            this.TextFields = textFields;
            this.ServiceItems = serviceItems;
        }
    }
}

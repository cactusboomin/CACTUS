using CACTUS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextField(Guid Id);
        TextField GetTextField(string codeword);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid Id);
    }
}

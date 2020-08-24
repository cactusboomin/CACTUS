using CACTUS.Domain.Entities;
using CACTUS.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        private readonly AppDbContext context;

        public EFTextFieldsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteTextField(Guid Id)
        {
            this.context.TextFields.Remove(new TextField() { Id = Id });
            this.context.SaveChanges();
        }

        public TextField GetTextField(Guid Id)
        {
            return this.context.TextFields.FirstOrDefault(x => x.Id == Id);
        }

        public TextField GetTextField(string codeword)
        {
            return this.context.TextFields.FirstOrDefault(x =>
                    x.CodeWord.Equals(codeword, StringComparison.InvariantCultureIgnoreCase));
        }

        public IQueryable<TextField> GetTextFields()
        {
            return this.context.TextFields;
        }

        public void SaveTextField(TextField entity)
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

using PocArquitecture.Persistance.Entities;
using System;

namespace PocArquitecture.Persistance.Repositories
{
    public interface IEmailConfirmationRepository : IGenericRepository<EmailConfirmation>
    {
        void AddEmailConfirmation(string Email, int RoleId, Guid guidGenerated, TimeSpan timeToAddToExpire);

        Guid GetValidCode(string Email);

        void ConsumeEmail(EmailConfirmation emailobtained);
    }
}

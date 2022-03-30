using HomeworkFour.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFour.Business.Abstracts
{
    public interface ICompanyService
    {
        List<Company> GetAllCompany();
        void AddCompany(Company company);
        void UpdateCompany(Company company);
        void DeleteCompany(Company company);
    }
}

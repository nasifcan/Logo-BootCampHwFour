﻿using HomeworkFour.Business.Abstracts;
using HomeworkFour.DataAccess.EntityFramework.Repository.Abstracts;
using HomeworkFour.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkFour.Business.Concretes
{
    public class CompanyService : ICompanyService
    {
        private readonly IRepository<Company> repository;
        private readonly IUnitOfWork unitOfWork;
        public CompanyService(IRepository<Company> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public void AddCompany(Company company)
        {
            repository.Add(company);
            unitOfWork.Commit();
        }

        public void DeleteCompany(Company company)
        {
            repository.Delete(company);
            unitOfWork.Commit();
        }

        public List<Company> GetAllCompany()
        {
            return repository.Get().ToList();
        }

        public void UpdateCompany(Company company)
        {
            repository.Update(company);
            unitOfWork.Commit();
        }
    }
}

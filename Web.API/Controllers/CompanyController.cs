using HomeworkFour.API.Models;
using HomeworkFour.Business.Abstracts;
using HomeworkFour.Business.DTOs;
using HomeworkFour.Domain.Entitites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkFour.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService companyService;

        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
        [Route("Compaines")]
        [HttpGet]
        public IActionResult Get()
        {
            var companies = companyService.GetAllCompany().Select(x => new CompanyDto
            {
                Name = x.Name,
                Address = x.Address,
                City = x.City,
                Country = x.Country,
                Description = x.Description,
                Location = x.Location,
                Phone = x.Phone
            });
            return Ok(new CompanyResponse { Data = companies, Success = true });
        }

        /// <summary>
        /// Şirket ekleme işlemi yapar
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("AddCompany")]
        [HttpPost]
        public IActionResult Post([FromBody] CompanyDto model)
        {
            companyService.AddCompany(new Company
            {
                Address = model.Address,
                City = model.City,
                Description = model.Description,
                CreatedBy = "SAMET",
                CreatedAt = System.DateTime.Now,
                IsDeleted = false,
                Name = model.Name.ToUpper(),
                Country = model.Country,
                Phone = model.Phone,
                Location = model.Location,
            });
            return Ok(
                new CompanyResponse
                {
                    Data = "İşleminiz Başarıyla Tamamlandı",
                    Success = true
                });
        }

        [Route("UpdateCompany")]
        [HttpPut]
        public IActionResult Update([FromBody] Company company)
        {
            companyService.UpdateCompany(company);
            return Ok(
                new CompanyResponse
                {
                    Data = "Güncelleme işlemi başarıyla gerçekleştirildi.",
                    Success = true
                });
        }

        [Route("Delete")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var company = companyService.GetAllCompany().Find(c => c.Id == id);

            companyService.DeleteCompany(company);
            return Ok(new CompanyResponse
            {
                Data = "Silme işlemi yapıldı.",
                Success = true
            });
        }
    }
}

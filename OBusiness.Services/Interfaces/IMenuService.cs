using OBusiness.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OBusiness.Services.Interfaces
{
    public interface IMenuService
    {
        Task<List<Menu>> GetAll();
        Task<Menu> GetByID(string id);
        Task Add(Menu entity);
        Task AddMany(List<Menu> entities);
        Task Update(Menu entity);
        Task Remove(Menu entity);
        Task Remove(string id);
    }
}

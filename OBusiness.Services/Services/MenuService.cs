using MongoDB.Driver;
using OBusiness.Core.Data;
using OBusiness.Core.Domain.Models;
using OBusiness.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OBusiness.Services.Services
{

    public class MenuService : IMenuService
    {
        IGenericRepostory<Menu> MenuRepository;
        public MenuService(IGenericRepostory<Menu> MenuRepository)
        {
            this.MenuRepository = MenuRepository;
        }
        public async Task Add(Menu entity)
        {
            await MenuRepository.Add(entity);
        }

        public async Task AddMany(List<Menu> entities)
        {
            await MenuRepository.AddMany(entities);
        }

        public async Task<List<Menu>> GetAll()
        {
            var Menus = await MenuRepository.GetAll();
            return Menus.ToList();
        }

        public async Task<Menu> GetByID(string id)
        {
            var Menu = await MenuRepository.GetByID(id);
            return Menu.FirstOrDefault();
        }

        public async Task Remove(Menu entity)
        {
            await MenuRepository.Remove(entity);
        }

        public async Task Remove(string id)
        {
            await MenuRepository.Remove(id);
        }

        public async Task Update(Menu entity)
        {
            await MenuRepository.Update(entity);
        }
    }
}

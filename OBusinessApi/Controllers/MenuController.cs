using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBusiness.Core.Domain.Models;
using OBusiness.Services.Interfaces;

namespace OBusinessApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        IMenuService MenuService;
        public MenuController(IMenuService MenuService)
        {
            this.MenuService = MenuService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Menu>>> Get([FromRoute]string id)
        {
            var find = await MenuService.GetStoreMenus(id);
            if (find.Count == 0)
            {
                return NotFound();
            }
            return find;
        }


    }
}

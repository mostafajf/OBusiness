using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBusiness.Core.Domain.Models;
using OBusiness.Core.Dto.Input;
using OBusiness.Services.Interfaces;

namespace OBusinessApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        IStoreService StoreService;
        public StoreController(IStoreService StoreService)
        {
            this.StoreService = StoreService;
        }
        // GET: api/Store
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Store>>> Get()
        {
            return await StoreService.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Store>> Get([FromRoute]string id)
        {
            var find = await StoreService.GetByStoreID(id);
            if (find == null)
            {
                return NotFound();
            }
            return find;
        }
        [HttpGet("nearby")]
        public async Task<ActionResult<IEnumerable<Store>>> GetNearBy([FromBody]GeoPoint location)
        {
            return await StoreService.GetNearby(location);
        }
    }
}

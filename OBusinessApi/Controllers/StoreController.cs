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
    public class StoreController : ControllerBase
    {
        IStoreService StoreService;
        public StoreController(IStoreService StoreService)
        {
            this.StoreService = StoreService;
        }
        // GET: api/Store
        [HttpGet]
        public async Task<IEnumerable<Store>> Get()
        {
            return await StoreService.GetAll();
        }

    }
}

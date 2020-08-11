using MappingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MappingData.Controllers
{
    [ApiController]
    [Route("api/mat6")]
    public class MatWarehouseController : ControllerBase
    {
        private MappingContext context;
        public MatWarehouseController(MappingContext context) : base()
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<TaMatWarehouse> getMatWarehouse(int id)
        {
            return context.MatWarehouse.First(mat => mat.Id == id);
        }

    }
}

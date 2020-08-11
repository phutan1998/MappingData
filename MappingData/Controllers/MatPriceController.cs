using Microsoft.AspNetCore.Mvc;
using MappingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MappingData.Controllers
{
    [ApiController]
    [Route("api/mat2")]
    public class MatPriceController : ControllerBase
    {
        private MappingContext context;
        public MatPriceController(MappingContext context) : base()
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<TaMatPrice> getMatPrice(int id)
        {
            return context.MatPricing.First(mat => mat.Id == id);
        }

    }
}
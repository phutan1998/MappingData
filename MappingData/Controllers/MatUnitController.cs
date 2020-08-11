using MappingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MappingData.Controllers
{
    [ApiController]
    [Route("api/mat5")]
    public class MatUnitController : ControllerBase
    {
        private MappingContext context;
        public MatUnitController(MappingContext context) : base()
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<TaMatUnit> getMatUnit(int id)
        {
            return context.MatUnit.First(mat => mat.Id == id);
        }

    }
}

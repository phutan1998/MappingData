using Microsoft.AspNetCore.Mvc;
using MappingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MappingData.Controllers
{
    [ApiController]
    [Route("api/mat")]
    public class MatController : ControllerBase
    {
        private MappingContext context;
        public MatController(MappingContext context) : base()
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<TaMatMaterial> getMaterial(int id)
        {
            return context.MatMaterial.First(mat => mat.Id == id);
        }
        
    }    
}

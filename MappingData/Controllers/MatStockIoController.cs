using MappingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MappingData.Controllers
{
    [ApiController]
    [Route("api/mat4")]
    public class MatStrockIoController : ControllerBase
    {
        private MappingContext context;
        public MatStrockIoController(MappingContext context) : base()
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<TaMatStockIo> getMatStockIo(int id)
        {
            return context.MatStockIo.First(mat => mat.Id == id);
        }

    }
}
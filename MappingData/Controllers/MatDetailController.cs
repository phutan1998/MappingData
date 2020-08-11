using Microsoft.AspNetCore.Mvc;
using MappingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MappingData.Controllers
{
    [ApiController]
    [Route("api/mat1")]
    public class MatDetailController : ControllerBase
    {
        private MappingContext context;
        public MatDetailController(MappingContext context) : base()
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<TaMatMaterialDetail> getMaterialDetail(int id)
        {
            return context.MatMaterialDetail.First(mat => mat.Id == id);
        }

    }
}

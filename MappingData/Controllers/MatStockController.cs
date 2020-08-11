using Microsoft.AspNetCore.Mvc;
using MappingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MappingData.Controllers
{ 
[ApiController]
[Route("api/mat3")]
public class MatStrockController : ControllerBase
{
    private MappingContext context;
    public MatStrockController(MappingContext context) : base()
    {
        this.context = context;
    }

    [HttpGet("{id}")]
    public ActionResult<TaMatStock> getMatStock(int id)
    {
        return context.MatStock.First(mat => mat.Id == id);
    }

}
}
using MaVilla_API.Datos;
using MaVilla_API.Modelos.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MaVilla_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDto> GetVillas()
        {
            return VillaStore.villaList;
        }

        [HttpGet("id:int")]
        public VillaDto GetVilla(int id)
        {
            return VillaStore.villaList.FirstOrDefault(v => v.Id == id);
        }

    }
}

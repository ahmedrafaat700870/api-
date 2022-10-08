using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoriesPatternWithUnitOfWork.EF.Models;
using RepositoriesPatternWithUnitOfWork.EF.Repositories;

namespace TourApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocatoinController : ControllerBase
    {
        private readonly IRepositories<TbLocation> repositories;

        public LocatoinController(IRepositories<TbLocation> repositories)
        {
            this.repositories = repositories;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var data = repositories.GetAll();
            if (data is null)
                return NotFound();
            return Ok(data);
        }
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            if (id == 0)
                return BadRequest();
            var data = repositories.GetById(id);
            if (data is null)
                return NotFound($"no locations included by this id : {id}");
            return Ok(data);
        }
        [HttpGet("GetByName")]
        public IActionResult GetByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return BadRequest();
            var data = repositories.GetByName(x =>x.LocationName == name);
            if (data is null)
                return BadRequest();

            return Ok(data);
        }
        [HttpGet("CheckByName")]
        public IActionResult CheckByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return BadRequest();
            var data = repositories.GetByName(x => x.LocationName == name);
            if (data is null)
                return Ok(true); // mean form coming is valid
            return Ok(false); // mean this data is exists in data base
        }
        [HttpPost]
        public IActionResult Edit(TbLocation oTbLocation)
        {
            if (!ModelState.IsValid)
                return BadRequest(oTbLocation);
            var valid = repositories.GetById(oTbLocation.LocationId);
            if (valid is not null)
                return BadRequest("this id included");
            var data = repositories.Edit(oTbLocation);
            if (data is null)
                return BadRequest("Can not save this data");
            return Ok(data);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, TbLocation oTbLocation)
        {

            if (!ModelState.IsValid)
                return BadRequest();
            if (id != oTbLocation.LocationId)
                return BadRequest();
            var dataExsits = repositories.GetById(id);
            if (dataExsits is null)
                return BadRequest();
            dataExsits.LocationName = oTbLocation.LocationName;
            var Save = repositories.Update(dataExsits);
            if (Save is null)
                return BadRequest();
            return Ok(Save);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            if (id == 0)
                return BadRequest();
            var Data= repositories.GetById(id);
            if (Data is null)
                return BadRequest();
            var DeletedData = repositories.Delete(Data);
            if (DeletedData is null)
                return BadRequest();
            return Ok(Data);
         }
    }
}

using basic_element_database.Elements;
using basic_element_database.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace basic_element_structure_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementDatabaseController : ControllerBase
    {
        private readonly IRepositoryBase<Element> _elementRepo;
        public ElementDatabaseController(IRepositoryBase<Element> repo)
        {
            _elementRepo = repo;
        }
        [HttpGet("getallelement")]
        public async Task<IEnumerable<Element>> getallElement() 
        {
            return new List<Element>
            {
                new Element {Name = "Carbon",MaxNumberOfBound = 4, Charge = Charge.Zero},
                new Element{Name = "Oxygen",MaxNumberOfBound =2, Charge = Charge.Negative },
                new Element{Name = "Nitrogen",MaxNumberOfBound =2, Charge = Charge.Negative }
            };
            //return await _elementRepo.FindAll();
        }
        [HttpPost("CreateElement")]
        public async Task<bool> CreateElement([FromBody] Element element) 
        {
            try 
            {
                await _elementRepo.Create(element);
                return true;
            }
            catch(Exception ex) 
            {
                return false;
            }
        }
    }
}
using basic_element_database.Elements;
using basic_element_database.Repository.Interfaces;
using basic_element_database_firebase.DataAdapter;
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
        private readonly ElementsDataAdapter _firebaseElement = new ElementsDataAdapter(); 
        public ElementDatabaseController(IRepositoryBase<Element> repo)
        {
            _elementRepo = repo;
        }
        [HttpGet("getallelement")]
        public async Task<IEnumerable<Element>> getallElement() 
        {
            var result = _firebaseElement.GetAllElements();
            return await _elementRepo.FindAll();
        }
        [HttpPost("addelement")]
        public async Task<bool> CreateElement([FromBody] elementRequestModel element) 
        {
            try 
            {
                var newElement = new Element
                {
                    Name = element.Name,
                    MaxNumberOfBond = element.MaxNumberOfBonds,
                    Charge = (Charge)Int32.Parse(element.Charge)
                };
                await _elementRepo.Create(newElement);
                await _elementRepo.Save();
                return true;
            }
            catch(Exception ex) 
            {
                return false;
            }
        }
    }
}
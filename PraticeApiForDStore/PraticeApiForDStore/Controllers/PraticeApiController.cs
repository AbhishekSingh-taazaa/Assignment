using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PraticeApiForDStore.Entities;
using PraticeApiForDStore.Models;
using PraticeApiForDStore.OperationDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PraticeApiController : ControllerBase
    {

        private readonly AssignmentQueries assignmentQueries;
        private readonly IMapper _mapper;

       public PraticeApiController(AssignmentQueries queries, IMapper mapper)
        {
            assignmentQueries = queries;
            _mapper = mapper;
        }

        [HttpGet("Ak")]
        public object Get() {

            return new Inventory { 
                Product_Code = "PIZZA", Brand_Name="Dominos", Product_Quantity=100, InStock= true };
        
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public List<Staff> GetallStaff(int id) {

            return null;
        }

        [HttpGet("Staff/{id}")]

        public IActionResult getStaffById(int id, bool includeRolex = false) {

            try
            {
                var staff = assignmentQueries.GetStaffById(id, includeRolex);

                StaffModel model = _mapper.Map<StaffModel>(staff);

                return Ok(model);
            }
            catch (Exception) {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

    }
}

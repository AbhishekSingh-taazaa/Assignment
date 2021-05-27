using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
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
    public class StaffController : ControllerBase
    {

        private readonly AssignmentQueries assignmentQueries;
        private readonly IMapper _mapper;
        private readonly LinkGenerator  _linkGenerator;
        public StaffController(AssignmentQueries queries, IMapper mapper, LinkGenerator linkGenerator)
        {
            assignmentQueries = queries;
            _mapper = mapper;
            _linkGenerator = linkGenerator;
        }

        [HttpGet("staff-members/{id}")]

        public IActionResult getStaffById(int id, bool includeRole = false)
        {

            try
            {
                var staff = assignmentQueries.GetStaffById(id, includeRole);

                StaffModel model = _mapper.Map<StaffModel>(staff);

                return Ok(model);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpGet("staff-members")]
        public IActionResult getStaffMembers(bool includeRole = false) {


            try {

                var result = assignmentQueries.GetAllStaff(includeRole);
                List<StaffModel> model = _mapper.Map<List<StaffModel>>(result);

                return this.StatusCode(StatusCodes.Status200OK, model);
            } catch (Exception) {


                return this.StatusCode(StatusCodes.Status500InternalServerError, "Sever not responding");
            }
        }


        [HttpPost("staff-members")]
        public IActionResult Post(StaffModel staffModel) {
            try {
                var staff = _mapper.Map<Staff>(staffModel);
                //  var location = _linkGenerator.GetPathByAction("staff-members/{id}", "Staff", new { id = staff.Staff_Id });

                //if (string.IsNullOrWhiteSpace(location)) {

                //    return BadRequest("Could not show current staff");
                //}
              
                assignmentQueries.Add(staff);
                if (assignmentQueries.saveChangestoDatabase())
                {
                    return Ok(staffModel);
                   //return Created($"/api/Staff/staff-members/{staff.Staff_Id}", _mapper.Map<StaffModel>(staff));

                }
                else {

                    return BadRequest("Data Can not be added");
                }

               
            } catch (Exception) {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Sever not responding");
            };
        
        }

        [HttpPut("staff-members/{id}")]
        public IActionResult Put(int id, StaffModel staffModel, bool includeRole = false) {
            try {
                Staff oldStaff = assignmentQueries.GetStaffById(id, includeRole);

                if (oldStaff == null) return NotFound($"Id Not Found {id}");

                _mapper.Map(staffModel, oldStaff);

                if (assignmentQueries.saveChangestoDatabase())
                {
                    return  Ok(_mapper.Map<StaffModel>(oldStaff));
                }
                else {
                    return BadRequest("Not Updated");
                }
                
        } catch (Exception) {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Sever not responding");
    };

}

    }
}

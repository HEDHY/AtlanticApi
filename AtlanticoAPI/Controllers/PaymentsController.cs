using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlanticoAPI.Controllers
{
    public class PaymentsController : ApiController
    {
        [HttpPost("GetAllCourses")]
        public async Task<ActionResult<ResultMessage<IEnumerable<CourseViewModel>>>> GetAllCourses()
        {
            return await Mediator.Send(new GetAllCoursesQuery());
        }
    }
}

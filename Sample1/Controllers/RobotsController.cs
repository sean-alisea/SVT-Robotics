using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Sample1.Models.Input;
using Sample1.Models.Output;
using Sample1.Repository;

namespace Sample1.Controllers
{
    [ApiController]
    [Route("api/robots")]
    public class RobotsController : ControllerBase
    {
        private readonly ILogger<RobotsController> _logger;
        private readonly IRobotRepository _repository;

        public RobotsController(ILogger<RobotsController> logger, IRobotRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpPost]
        public async Task<ActionResult> Closest(PalletTransportRequest l)
        {             
            try
            {
                Robot path = await this._repository.CalculatePath(l);

                return CreatedAtAction("Closest", path);
            }
            catch (Exception e)
            {
                this._logger.LogError(e.Message);

                return StatusCode((int)HttpStatusCode.InternalServerError, "Error on POST.");
            }
        }
    }
}

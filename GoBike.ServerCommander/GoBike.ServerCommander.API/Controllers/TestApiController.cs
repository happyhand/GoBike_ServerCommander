using GoBike.ServerCommander.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace GoBike.ServerCommander.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {
        /// <summary>
        /// serverService
        /// </summary>
        private readonly IServerService serverService;

        /// <summary>
        /// logger
        /// </summary>
        private readonly ILogger<TestApiController> logger;

        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="logger">logger</param>
        /// <param name="serverService">serverService</param>
        public TestApiController(ILogger<TestApiController> logger, IServerService serverService)
        {
            this.logger = logger;
            this.serverService = serverService;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpPost]
        public async Task<IActionResult> Get()
        {
            try
            {
                //// TODO Call Service

                //// TODO Call Service

                return Ok();
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Test Api Error\n{ex}");
                return BadRequest("發生錯誤.");
            }
        }
    }
}
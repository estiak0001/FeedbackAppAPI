using APIES.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserFeedbackController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IUserFeedbackService _userFeedbackService;
        private readonly IMapper _mapper;
        public UserFeedbackController(IWebHostEnvironment hostingEnvironment, IUserFeedbackService userFeedbackService, IMapper mapper)
        {
            _hostingEnvironment = hostingEnvironment;
            _userFeedbackService = userFeedbackService ??
                throw new ArgumentNullException(nameof(userFeedbackService));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [AllowAnonymous]
        [HttpGet("ReturnImage/{CriteriaID}")]
        public IActionResult ReturnImage(string CriteriaID)
        {
            var path = Path.Combine(_hostingEnvironment.WebRootPath, "BackgroundImage", $"{CriteriaID}.png");
            var imageFileStream = System.IO.File.OpenRead(path);
            return File(imageFileStream, "image/jpeg");
        }

        [AllowAnonymous]
        [HttpGet("GetCriteriaData/{ModelID}/{EnOrBN}")]
        public IActionResult GetCriteriaData(string ModelID, string EnOrBN)
        {
            var result = _userFeedbackService.GetCriteria(ModelID, EnOrBN);

            return Ok(result);
        }
    }
}

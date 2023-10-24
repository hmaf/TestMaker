using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using TestMaker.Application.Dtos.Tag;
using TestMaker.Application.Interfaces.Common;
using TestMaker.Domain.Models;

namespace TestMaker.Api.Controllers
{
    [Route("api/Tag")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ICombinedService _combinedService;

        public TagController(ICombinedService combinedService)
        {
            _combinedService = combinedService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var data = await _combinedService.TagService.GetAll();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                Expression<Func<Tag, bool>> predicateToGetId = tag => tag.Id == id;
                var result = await _combinedService.TagService.GetById(predicateToGetId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(TagDto model)
        {
            try
            {
                var data = await _combinedService.TagService.Add(model);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

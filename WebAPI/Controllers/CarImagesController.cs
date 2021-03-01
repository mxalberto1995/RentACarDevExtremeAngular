﻿using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs.CarImageDTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm] AddCarImageDto carIamgeDto)
        {
            var result = _carImageService.Add(carIamgeDto);
            if (result.Success)
            {
                return Ok(result.Message);

            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Add(int id)
        {
            var result = _carImageService.Delete(new CarImage { Id = id });
            if (result.Success)
            {
                return Ok(result.Message);

            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Add([FromForm] UpdateCarImageDto carIamge)
        {
            var result = _carImageService.Update(carIamge);
            if (result.Success)
            {
                return Ok(result.Message);

            }
            return BadRequest(result.Message);
        }
    }
}

﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ControllerBase
    {
        #region prueba
        [HttpGet("prueba")]

        public string Get()
        {
            return "Hola mundo";
        }
        #endregion
    }
}

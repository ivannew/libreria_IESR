﻿using libreria_IESR.Data.Models.Services;
using libreria_IESR.Data.Services;
using libreria_IESR.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace libreria_IESR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private AuthorsService _authorsService;

        public AuthorsController(AuthorsService authorsService)
        {
            _authorsService = authorsService;
        }

        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            _authorsService.AddAuthor(author);
            return Ok(); 
        }

        [HttpGet("get-author-with-books-by-id")]
        public IActionResult GetAuthorWithBooks(int id)
        {
            var response = _authorsService.GetAuthorWithBooks(id);
            return Ok(response);
        }


    }
}

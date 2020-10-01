using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MongoDotNet.Api.Models;
using MongoDotNet.Core.Models;
using MongoDotNet.Services;

namespace MongoDotNet.Api.Controllers
{
    [Route("api/[controller]")]
    public class BookController: ControllerBase 
    {
        private readonly BookServices bookServices;
    
        public BookController(BookServices bookServices)
        {
            this.bookServices = bookServices;
        }

        [HttpGet]
        public ActionResult<List<IBook>> GetBooks() => this.bookServices.Read();
        

        [HttpGet("{id}", Name="GetBook")]
        public ActionResult<IBook> GetBook(String id) 
        {
            IBook book = this.bookServices.Read(id);
            return new ActionResult<IBook>(book);
        }
  
        [HttpPost]
        public ActionResult<IBook> AddBook([FromBody] AddBookRequest addBookRequest) 
        {
            IBook createdBook = this.bookServices.Create(addBookRequest);
            return CreatedAtRoute("GetBook", new { id = createdBook.Id.ToString() }, createdBook);
        }

    }
    
}
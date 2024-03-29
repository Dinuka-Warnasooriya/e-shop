﻿using e_shop.Models;
using e_shop.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_shop.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data =  _bookRepository.GetAllBooks();


            return View(data);
        }
        
        public ViewResult GetBook(int id)
        {
            var data = _bookRepository.GetBookById(id);  
            return View(data);
        }

        public string searchBooks(string bookName, string authorName)
        { 
            return $"Book with name = {bookName} & authorName ={authorName }";
        }

    }


}

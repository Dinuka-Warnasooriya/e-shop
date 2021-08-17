﻿using e_shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_shop.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public List<BookModel> GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).ToList();
        }
        public List<BookModel> SearchBook(string title , string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author == authorName).ToList();
        }


        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id=1, Title="MvC" , Author="Dinuka"},
                new BookModel(){ Id=2, Title="Dot Net" , Author="Imasha"},
                new BookModel(){ Id=3, Title="Java" , Author="Sandaru"},
                new BookModel(){ Id=4, Title="C++" , Author="Chalani"},
                new BookModel(){ Id=5, Title="Dart" , Author="Achini"},
            };
        }
    }
}

using CREAR_API.Data.Models;
using CREAR_API.Data.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace CREAR_API.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }

        //metodo para crear autor
        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }

        public AuthorWithBooksVM GetAuthorWithBooks(int authorId)
        {
            var _author = _context.Authors.Where(n => n.Id == authorId).Select(n => new AuthorWithBooksVM()
            {
                FullName = n.FullName,
                BookTitles = n.Book_Authors.Select(n => n.Books.Titulo).ToList()
            }).FirstOrDefault();
            return _author;
        }
            
    }
}

using BookStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Interfaces
{
    interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        IEnumerable<Author> GetAllAuthors();
        IEnumerable<Genre> GetAllGenres();        
        
        Task AddBookAsync(Book book);
        Task AddAuthorAsync(Author author);
        Task AddGenreAsync(Genre genre);
        Task GetBook(int id);
        Task GetAuthor(int id);
        Task GetGenre(int id);

        Task EditBook(Book book);
        Task EditAuthor(Author author);
        Task EditGenre(Genre id);

        Task DeleteBook(int id);
        Task DeleteAuthor(int id);
        Task DeleteGenre(int id);

    }
}

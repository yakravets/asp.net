using BookStore.BLL.Interfaces;
using BookStore.DAL.Entities;
using BookStore.DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Implementation
{
    public class BookStoreService: IBookService
    {
        private readonly IGenericRepository<Book> _bookRepository;
        private readonly IGenericRepository<Author> _authorRepository;
        private readonly IGenericRepository<Genre> _genreRepository;

        public BookStoreService(IGenericRepository<Book> _bookRepository, IGenericRepository<Author> _authorRepository, IGenericRepository<Genre> _genreRepository)
        {
            this._bookRepository = _bookRepository;
            this._authorRepository = _authorRepository;
            this._genreRepository = _genreRepository;
        }

        public Task AddAuthorAsync(Author author)
        {
            return _authorRepository.CreateAsync(author);
        }

        public Task AddBookAsync(Book book)
        {
            return _bookRepository.CreateAsync(book);
        }

        public Task AddGenreAsync(Genre genre)
        {
            return _genreRepository.CreateAsync(genre);
        }

        public Task DeleteAuthor(Author author)
        {
            return _authorRepository.DeleteAsync(author.Id);
        }

        public Task DeleteAuthor(int id)
        {
            return _authorRepository.DeleteAsync(id);
        }

        public Task DeleteBook(int id)
        {
            return _bookRepository.DeleteAsync(id);
        }

        public Task DeleteGenre(int id)
        {
            return _genreRepository.DeleteAsync(id);
        }

        public Task EditAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public Task EditBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Task EditGenre(Genre id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return _authorRepository.GetAll();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetAll();
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            return _genreRepository.GetAll();
        }

        public Task GetAuthor(int id)
        {
            return _authorRepository.GetAsync(id);
        }

        public Task GetBook(int id)
        {
            return _bookRepository.GetAsync(id);
        }

        public Task GetGenre(int id)
        {
            return _genreRepository.GetAsync(id);
        }
    }
}

using BookStore.API.Models;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface IBookRepository
    {
         Task<List<BookModel>> GetAllBooksAsync();
        Task<BookModel> GetBooksByIdAsync(int bookId);

        Task<int> AddBookAsync(BookModel bookModel);
        Task UpdateBookAsync(int bookId, BookModel BookModel);
       // Task UpdateBookPatch(int bookId, JsonPatchDocument bookModel);
        Task UpdateBookPatchAsync(int id, JsonPatchDocument bookModel);
        Task DeleteBookAsync(int bookId);
    }
}

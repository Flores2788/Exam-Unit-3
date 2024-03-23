using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;



public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string ISBN { get; set; }

}



public class bookOperations
{
    private List<Book> books;

    public bookOperations(string filePath)
    {
        var jsonString = File.ReadAllText(filePath);
        books = JsonSerializer.Deserialize<List<Book>>(jsonString);
    }

    public IEnumerable<Book> GetBooksStartingWithThe()
    {
        return books.Where(book => book.Title.StartsWith("The"));
    }

    public IEnumerable<Book> GetBooksByAuthorsWithTInName()
    {
        return books.Where(book => book.Author.Contains("t", StringComparison.OrdinalIgnoreCase));
    }

    public int GetNumberOfBooksWrittenAfter1992()
    {
        return books.Count(book => book.Year > 1992);
    }

    public int GetNumberOfBooksWrittenBefore2004()
    {
        return books.Count(book => book.Year < 2004);
    }

    public IEnumerable<string> GetISBNsByAuthor(string author)
    {
        return books.Where(book => book.Author == author).Select(book => book.ISBN);
    }

    public IEnumerable<Book> ListBooksAlphabetically(bool ascending)
    {
        return ascending ? books.OrderBy(book => book.Title) : books.OrderByDescending(book => book.Title);
    }

    public IEnumerable<Book> ListBooksChronologically(bool ascending)
    {
        return ascending ? books.OrderBy(book => book.Year) : books.OrderByDescending(book => book.Year);
    }

    public ILookup<string, Book> GroupBooksByAuthorLastName()
    {
        return books.ToLookup(book => book.Author.Split().Last());
    }

    public ILookup<string, Book> GroupBooksByAuthorFirstName()
    {
        return books.ToLookup(book => book.Author.Split().First());
    }

    
}

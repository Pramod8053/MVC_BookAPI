using EntityLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;

namespace BookWeb.BookAPIRepo
{
    public class BookAPIRepos : IBookAPIRepo
    {
        HttpClient client;
        string BaseUrl;
        public BookAPIRepos()
        {
            BaseUrl = ConfigurationManager.AppSettings["BookAPI"].ToString();
            client = new HttpClient();
            client.BaseAddress= new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public List<Book> GetBookList()
        {
            try
            {
                List<Book> _lstbook = new List<Book>();
                HttpResponseMessage getBook = client.GetAsync("api/BookAPI/GetBookList").Result;
                if (getBook.IsSuccessStatusCode)
                {
                    _lstbook = getBook.Content.ReadAsAsync<List<Book>>().Result;
                }
                return _lstbook;
            }catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public Book GetByID(int i)
        {
            try
            {
                Book _Book = new Book();
                HttpResponseMessage GetBook = client.PostAsJsonAsync("api/BookAPI/GetByID", i).Result;
                if (GetBook.IsSuccessStatusCode)
                {
                    _Book = GetBook.Content.ReadAsAsync<Book>().Result;
                }
                return _Book;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public int SaveModify(Book _obj)
        {
            try
            {
                int x = 0;
                HttpResponseMessage getRespon = client.PostAsJsonAsync("api/BookAPI/SaveModify", _obj).Result;
                if (getRespon.IsSuccessStatusCode)
                {
                    x = getRespon.Content.ReadAsAsync<int>().Result;
                }
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
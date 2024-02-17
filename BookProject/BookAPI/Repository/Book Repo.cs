using BookAPI.DBContext;
using BookAPI.Models;
using System;
using System.Collections.Generic;
using Dapper;

namespace BookAPI.Repository
{
    public class BookRepo : IBookRepo
    {
        DBConnect _con = new DBConnect();
        public Book GetByID(int i)
        {
            try
            {
                DynamicParameters Para = new DynamicParameters();
                Para.Add("@Action", "a");
                Para.Add("@ID", i);
                var _Book = (Book)_con.Connect().Query<Book>("SP_Book", Para, commandType: System.Data.CommandType.StoredProcedure);
                return _Book;
            }
            catch(Exception ex)
            {
                throw ex;
            }
         
        }

        public List<Book> GetList()
        {
            try
            {
                DynamicParameters Para = new DynamicParameters();
                Para.Add("@Action", "c");
                var _BookList = (List<Book>)_con.Connect().Query<Book>("SP_Book", Para, commandType: System.Data.CommandType.StoredProcedure);
                return _BookList;
            }
            catch(Exception ex)
            {
                throw ex;

            }
           
        }

        public int SaveModify(Book _Obj)
        {
            try
            {
                DynamicParameters Para = new DynamicParameters();
                Para.Add("@Action", "b");
                Para.Add("@BookName", _Obj.Name);
                Para.Add("@Author", _Obj.Author);
                Para.Add("@Price", _Obj.Price);
                var x = _con.Connect().Execute("SP_Book", Para, commandType: System.Data.CommandType.StoredProcedure);
                return x;

            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
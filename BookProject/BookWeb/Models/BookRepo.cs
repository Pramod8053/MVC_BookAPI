using EntityLibrary.DBConext;
using EntityLibrary.Entity;
using System;
using System.Collections.Generic;
using Dapper;

namespace BookWeb.Models
{
    public class BookRepo : IBookRepo
    {
        DBConnect _db = new DBConnect();
        public List<Book> GetList()
        {
            try
            {
            DynamicParameters Para = new DynamicParameters();
            Para.Add("@Action", "c");
            var _BookList = (List<Book>)_db.Connect().Query<Book>("SP_Book", Para, commandType: System.Data.CommandType.StoredProcedure);
            return _BookList;
            }  
            catch(Exception ex)
            {
                throw ex;
            }
       }
    }
}
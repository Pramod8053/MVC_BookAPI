using EntityLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWeb.BookAPIRepo
{
   public interface IBookAPIRepo
    {
        List<Book> GetBookList();
        Book GetByID(int i);
        int SaveModify(Book _obj);
    }
}

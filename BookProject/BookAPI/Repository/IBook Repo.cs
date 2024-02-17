using BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.Repository
{
   public interface IBookRepo
    {
        List<Book> GetList();
        Book GetByID(int i);
        int SaveModify(Book _Obj);
    }
}

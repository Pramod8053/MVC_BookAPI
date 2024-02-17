using EntityLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWeb.Models
{
   public interface IBookRepo
    {
        List<Book> GetList();

    }
}

using LibraryWeb.Contracts.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWeb.Core.Handlers.Queries
{
   public class GetAllBooksQuery : IRequest<IEnumerable<BookDTO>>
    {

    }
    public class GetAllBooksQueryHandler : IRequest<IEnumerable<BookDTO>>
    {

    }
}

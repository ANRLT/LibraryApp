using LibraryWeb.Contracts.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWeb.Core.Handlers.Queries
{
    public class GetBookByIdQuery : IRequest<BookDTO>
    {
        public int BookId { get; }
        public GetBookByIdQuery(int id)
        {
            BookId = id;
        }
    }
    public class GetBookByIdQueryHandler 
    {
     
    }
}

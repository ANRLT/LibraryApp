using LibraryWeb.Contracts.Data.Entities;

namespace LibraryWeb.Contracts.DTO
{
    internal class BookDTO : BaseEntity
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}

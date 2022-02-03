using BookStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.Mapping
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable("Book");

            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(60).IsRequired();
            Property(x => x.ISBN).HasMaxLength(32).IsRequired();
            Property(x => x.ReleasedDate).IsRequired();
        }
    }
}
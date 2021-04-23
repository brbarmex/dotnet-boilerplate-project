using Boilerplate.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Boilerplate.Infraestructure.Mapping
{
    public class CustomerMapConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customer");
            builder.HasKey(x => x.Id).HasName("customer_id");
           // builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.Name).HasColumnName("customer_name");
            builder.Property(x => x.LastName).HasColumnName("customer_lastname");
            builder.Property(x => x.BirthDate).HasColumnName("customer_birthdate");

            builder.OwnsOne(x => x.Email, email => email.Property(s => s.Value).HasColumnName("customer_email"));
            //builder.OwnsOne(x => x.Phone, phone => phone.Property<string>("customer_email"));

            //builder.Property(x => x.Email.Value).HasColumnName("customer_email");
            // builder.Property(x => x.Phone).HasColumnName("customer_phone");
            // builder.Property(x => x.BirthDate).HasColumnName("customer_birthdate");
        }
    }
}
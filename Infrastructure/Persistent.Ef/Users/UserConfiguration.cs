using Domain.UserAgg;
using System.Data.Entity.ModelConfiguration;
using System.Reflection;

namespace Infrastructure.Persistent.Ef.Users
{
    
    internal class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users", "user");
            HasIndex(b => b.PhoneNumber).IsUnique();
            HasIndex(b => b.Email).IsUnique();

            Property(b => b.Email)
                .IsRequired()
            .HasMaxLength(256);

            Property(b => b.PhoneNumber)
                .IsRequired()
                .HasMaxLength(11);

            Property(b => b.Name)
                .IsRequired()

               .HasMaxLength(80);

            Property(b => b.Family)
                .IsRequired()
                .HasMaxLength(80);

            Property(b => b.Password)
                .IsRequired()
                .HasMaxLength(50);


            //OwnsMany(b => b.Tokens, option =>
            //{
            //    option.ToTable("Tokens", "user");
            //    option.HasKey(b => b.Id);

            //    option.Property(b => b.HashJwtToken)
            //        .IsRequired()
            //        .HasMaxLength(250);

            //    option.Property(b => b.HashRefreshToken)
            //        .IsRequired()
            //        .HasMaxLength(250);

            //    option.Property(b => b.Device)
            //        .IsRequired()
            //        .HasMaxLength(100);
            //});


            //OwnsMany(b => b.Addresses, option =>
            //{
            //    option.HasIndex(b => b.UserId);
            //    option.ToTable("Addresses", "user");

            //    option.Property(b => b.Shire)
            //         .IsRequired().HasMaxLength(100);

            //    option.Property(b => b.City)
            //        .IsRequired().HasMaxLength(100);

            //    option.Property(b => b.Name)
            //       .IsRequired().HasMaxLength(50);

            //    option.Property(b => b.Family)
            //        .IsRequired().HasMaxLength(50);



            //    option.Property(b => b.NationalCode)
            //        .IsRequired().HasMaxLength(10);

            //    option.Property(b => b.PostalCode)
            //        .IsRequired().HasMaxLength(20);

            //    option.OwnsOne(c => c.PhoneNumber, config =>
            //    {
            //        config.Property(b => b.Value)
            //            .HasColumnName("PhoneNumber")
            //            .IsRequired().HasMaxLength(11);
            //    });
            //});

            //OwnsMany(b => b.Wallets, option =>
            //{
            //    option.ToTable("Wallets", "user");
            //    option.HasIndex(b => b.UserId);

            //    option.Property(b => b.Description)
            //        .IsRequired(false)
            //        .HasMaxLength(500);
            //});

            //OwnsMany(b => b.Roles, option =>
            //{
            //    option.ToTable("Roles", "user");
            //    option.HasIndex(b => b.UserId);
            //});
        }
    }
}
using eShopSolution.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtension
    {
       public static void Seed (this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "HomeKeyWord", Value = "This is keyword  of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description  of eShopSolution" });

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Enums.Status.Active,
                    
                },
                new Category()
                {
                    Id = 2,
                    IsShowHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Enums.Status.Active,
                    
                });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,                    

                    CategoryId = 1,
                    Name = "Áo nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm thời trang nam",
                    SeoTitle = "Sản phẩm thời trang nam"
                },
                new CategoryTranslation()
                {
                    Id= 2,
                    CategoryId = 1,
                    Name = "Men Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "men-shirt",
                    SeoDescription = "The Shirt products for men",
                    SeoTitle = "The Shirt products for men"
               },
               new CategoryTranslation()
               {
                   Id = 3,
                   CategoryId = 2,
                   Name = "Áo nữ",
                   LanguageId = "vi-VN",
                   SeoAlias = "ao-nu",
                   SeoDescription = "Sản phẩm thời trang nữ",
                   SeoTitle = "Sản phẩm thời trang nữ"
               },
               new CategoryTranslation()
               {
                   Id = 4,
                   CategoryId = 2,
                   Name = "Áo nữ",
                   LanguageId = "vi-VN",
                   SeoAlias = "ao-nu",
                   SeoDescription = "Sản phẩm thời trang nữ",
                   SeoTitle = "Sản phẩm thời trang nữ"
               });
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OrginalPrice = 100000,
                    Price = 20000,
                    Stock = 0,
                    ViewCount = 0,
                  
                    
                });
            modelBuilder.Entity<ProductTranslation>().HasData(
                    new ProductTranslation()
                    {
                        Id =1,
                        ProductId = 1,
                        Name = "Áo sơ mi nam trắng Việt Tiến",
                        LanguageId = "vi-VN",
                        SeoAlias = "ao-so-mi-nam-viet-tien",
                        SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                        SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                        Details = "Áo sơ mi nam trắng Việt Tiến",
                        Description = "Áo sơ mi nam trắng Việt Tiến"
                    },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Viet Tien Men white T-Shirt",
                        LanguageId = "en-US",
                        SeoAlias = "Viet Tien Men white T-Shirt",
                        SeoDescription = "Viet Tien Men white T-Shirt",
                        SeoTitle = "Viet Tien Men white T-Shirt",
                        Details = "Viet Tien Men white T-Shirt",
                        Description = "Viet Tien Men white T-Shirt"
                    }) ;
            modelBuilder.Entity<ProductInCategory>().HasData(
                    new ProductInCategory()
                    {
                        ProductId = 1,
                        CategoryId = 1
                        
                    });
            //any Guid
            var ADMIN_ID = new Guid("AAB36913-DEF1-4C72-93C8-B9995243356F");
            var ROLE_ID = new Guid("BB97D77D-565E-4D10-82F6-3CB15F355002");
            

            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Admin Role"



            });


            

            //tao hash passwod
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456"),
                SecurityStamp = string.Empty,
                FirstName = "Van",
                LastName = "Nguyen",
                Dob = new DateTime(1999, 5, 7)



            }) ;

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {                
                UserId = ADMIN_ID,
                RoleId = ROLE_ID
            });

        }
    }
}

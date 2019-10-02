using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="C#"},
                new Category(){KategoriAdi="Asp.Net MVC"},
                new Category(){KategoriAdi="Asp.Net Core"},
                new Category(){KategoriAdi="Python"},
                new Category(){KategoriAdi="Görüntü İşleme"},
            };
            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();
            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){Baslik="C# Delegates", Aciklama="C# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-20), Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=1},
                new Blog(){Baslik="Asp.Net MVC", Aciklama="Asp.Net MVC Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-50), Anasayfa=true, Onay=true, Icerik="Asp.Net MVC Hakkında Asp.Net MVC Hakkında Asp.Net MVC Hakkında Asp.Net MVC Hakkında", Resim="1.jpg", CategoryId=2},
                new Blog(){Baslik="Asp.Net Core", Aciklama="Asp.Net Core Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-100), Anasayfa=true, Onay=true, Icerik="Asp.Net Core Hakkında Asp.Net Core Hakkında Asp.Net Core Hakkında Asp.Net Core Hakkında", Resim="1.jpg", CategoryId=3},
            };
            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
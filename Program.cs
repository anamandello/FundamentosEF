using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

using var context = new DataContext();
  // context.Users.Add(new User{
  //   Bio = "Desenvolvedor",
  //   Email = "Teste.teste.io",
  //   Image = "https://",
  //   Name = "Maria",
  //   PasswordHash = "1234",
  //   Slug = "maria"
  // });

  // context.SaveChanges();
var user = context.Users.FirstOrDefault(x => x.Id == 2);

var post = new Post {
  Author = user,
  Body = "Meu artigo",
  Category = new Category{
    Name = "backend",
    Slug = "backend5"
  },
  CreateDate = DateTime.Now,
  Slug = "meu-artigo",
  Summary = "Neste artigo...",
  Title = "Meu artigo"
};

context.Posts.Add(post);
context.SaveChanges();
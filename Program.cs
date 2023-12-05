
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using var context = new DataContext();
// var user = new User(){
//   Name = "User 1",
//   Slug = "user1",
//   Email = "user1@user1.io",
//   Bio = "dev",
//   Image = "https://",
//   PasswordHash = "HASH123"
// };

// var category = new Category{
//   Name = "Backend",
//   Slug = "backend"
// };

// var post = new Post{
//   Author = user,
//   Category = category,
//   Body = "<p>Hello world</p>",
//   Slug = "desenvolvimento",
//   Summary = "Vamos começar a aprender sobre...",
//   Title = "Backend",
//   CreateDate = DateTime.Now,
//   LastUpdateDate = DateTime.Now
// };

// context.Posts.Add(post);
// context.SaveChanges();

// var posts = context.Posts.AsNoTracking()
//             .Include(x => x.Author) // -- join
//             .Include(x => x.Category)
//             .Where(x => x.AuthorId == 1)
//             .OrderByDescending(x => x.LastUpdateDate)
//             .ToList();

// foreach(var post in posts){
//   Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}");
// }

var post = context
          .Posts
          .Include(x => x.Author)
          .Include(x => x.Category)
          .OrderBy(x => x.LastUpdateDate)
          .FirstOrDefault();

post.Author.Name = "Teste";
context.Posts.Update(post);
context.SaveChanges();
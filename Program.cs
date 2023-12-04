
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using (var context = new DataContext()){
  // var tag = new Tag { Name="ASP.NET", Slug="aspnet"};
  // context.Tags.Add(tag);
  // context.SaveChanges();

  // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
  // tag.Name = ".NET";
  // tag.Slug = "dotnet";

  // context.Update(tag);
  // context.SaveChanges();

  // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);
  // context.Remove(tag);
  // context.SaveChanges();

  //  var tags = context.Tags.AsNoTracking().ToList();
  //  foreach(var tag in tags){
  //    Console.WriteLine(tag.Name);
  //  }

   var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 51);
   Console.WriteLine(tag?.Name);
};


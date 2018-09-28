using System;
using System.Collections.Generic;

namespace Blog
{
  public class Program
  {
    static void Main(string[] args)
    {
      // Blog
      var blog = new Blog();
      blog.Name = "My new blog";

      // BlogPost
      var blogPost = new BlogPost();
      blogPost.Title = "my first blogpost";
      blogPost.Categories = new List<Category>();
      blogPost.Comments = new List<Comment>();
      blog.BlogPosts = new List<BlogPost>();
      blog.BlogPosts.Add(blogPost);

      blogPost.Blog = blog;

      // Author
      var author = new Author();
      author.Name = "Matthias Daelemans";
      author.BlogPosts = new List<BlogPost>();
      author.BlogPosts.Add( blogPost );

      blogPost.Author = author;

      // Category
      var category = new Category();
      category.Title = "Development";
      category.BlogPosts = new List<BlogPost>();
      category.BlogPosts.Add( blogPost );

      blogPost.Categories.Add( category );

      // Comment
      var comment = new Comment();
      comment.Body = "This is my comment.";
      comment.BlogPost = blogPost;

      blogPost.Comments.Add( comment );

      Console.WriteLine($"Naam van mijn blog: {blogPost.Blog.Name}");
      Console.WriteLine($"Naam van mijn blogpost: {blogPost.Title}");
      Console.WriteLine($"Auteur van mijn blogpost: {blogPost.Author.Name}");
      Console.WriteLine($"Categorie van mijn blogpost: {blogPost.Categories[0].Title}");
      Console.WriteLine($"Comment op mijn blogpost: {blogPost.Comments[0].Body}");
    }
    /*
      Blog, Blogpost, Author, Category, Comment
      Blog heeft meerdere blogposts, blogpost heeft één blog
      Blogpost heeft één auteur, auteur heeft meerdere blogposts
      Blogpost heeft meerdere categorieën, category heeft meerdere blogposts
      Blogpost heeft meerdere comments, comment heeft één Blogpost 
     */
  }
}

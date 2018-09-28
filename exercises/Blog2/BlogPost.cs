using System.Collections.Generic;

namespace Blog
{
  class BlogPost
  {
    public string Title { get; set; }
    public Blog Blog { get; set; }
    public Author Author { get; set; }
    public List<Category> Categories { get; set; }
    public List<Comment> Comments { get; set; }
  }
}

using System.Collections.Generic;

namespace Blog
{
  class Category
  {
    public string Title { get; set; }
    public List<BlogPost> BlogPosts { get; set; }
  }
}

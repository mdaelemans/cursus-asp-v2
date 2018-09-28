using System.Collections.Generic;

namespace Blog
{
  class Author
  {
    public string Name { get; set; }
    public List<BlogPost> BlogPosts { get; set; }
  }
}

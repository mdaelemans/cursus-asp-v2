namespace Blog
{
  class Comment
  {
    public string Body { get; set; }
    public BlogPost BlogPost { get; set; }
  }
}

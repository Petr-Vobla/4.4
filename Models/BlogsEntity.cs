using System.Collections.Generic;


namespace AvaloniaApplication4.Models;

    public class BlogsEntity
{
    public string Article { get; set; }
    public string Text { get; set; }
    public string ImagePath { get; set; }
    public List<string> Tags { get; set; }
}

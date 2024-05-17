using AvaloniaApplication4.Models;
using System.Collections.Generic;

namespace AvaloniaApplication4.ViewModels;

using System;
using System.Collections.Generic;
using AvaloniaApplication4.Models;



public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        MainMenuEntity = new()
        {
            Home = "Home",
            About = "About",
            MainTopicsList = new List<string> { "Tema 1", "Tema 2", "Tema 3" },
            Profile = "RSS"
        };


        BlogsEntities = new List<BlogsEntity>()
        {
            new BlogsEntity()
            {
                Article = "ZAgolovok 1",
                Text = "TeXt 1",
                ImagePath = "SiliconCroda.jpg",
                Tags = new List<string> {"Tag1.1", "Tag2.1", "Tag3.1"}
            },
            new BlogsEntity()
            {
                Article = "ZAgolovok 2",
                Text = "TeXt 2",
                ImagePath = "SiliconCroda.jpg",
                Tags = new List<string> {"Tag1.2", "Tag2.2", "Tag3.2"}
            },


            new BlogsEntity()
            {
                Article = "ZAgolovok 3",
                Text = "TeXt 3",
                ImagePath = "SiliconCroda.jpg",
                Tags = new List<string> {"Tag1.3 ", "Tag2.3", "Tag3.3"}
            },
        };
        NewsEntities = new List<NewsEntity>()
        {
            new NewsEntity
            {
            Text = "NoVost 1",
            PublishDate = DateTime.Now
            },
            new NewsEntity
            {
            Text = "NoVost 2",
            PublishDate = DateTime.Now
            },
            new NewsEntity
            {
            Text = "NoVost 3",
            PublishDate = DateTime.Now.AddDays(-100)
            }

        };
    }
    public MainEntity MainMenuEntity { get; set; }
    public List<BlogsEntity> BlogsEntities { get; set; }
    public List<NewsEntity> NewsEntities { get; set; }


}
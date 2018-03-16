﻿using System.Collections.Generic;

namespace Forum.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public ICollection<int> ReplyIds { get; set; }

        public Post(int id, string title, string content, int categoryId, int authorId, ICollection<int> replyIds)
        {
            this.Id = id;
            this.Title = title;
            this.Content = content;
            this.CategoryId = categoryId;
            this.AuthorId = authorId;
            this.ReplyIds = replyIds;
        }
    }
}
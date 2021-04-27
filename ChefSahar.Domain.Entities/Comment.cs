using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Domain.Entities
{
    public class Comment : Entity
    {
        public byte RankStar { get; set; }
        public byte RankNumber { get; set; }
        public DateTime InsertDate { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public List<Comment> ChildComments { get; set; }
        public long Comment_ID { get; set; }

    }
}

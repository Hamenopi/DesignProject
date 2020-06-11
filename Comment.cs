using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignProject
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string User { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int PhotoID { get; set; }

    }
}
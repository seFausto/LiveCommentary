using System;

namespace LiveCommentary.Models
{
    [Serializable]
    public class LiveComment
    {
        public string Id { get; set; }

        public string Interval { get; set; }

        public string CreatedDate { get; set; }

        public string MovieId { get; set; }

        public string UserId { get; set; }

        public string Comment { get; set; }
    }
}
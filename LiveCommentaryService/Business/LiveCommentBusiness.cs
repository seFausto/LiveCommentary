using LiveCommentary.Models;
using LiveCommentaryService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommentaryService.Business
{
    public class LiveCommentBusiness
    {
        private LiveCommentService _liveCommentService;

        public LiveCommentBusiness(LiveCommentService liveCommentService)
        {
            _liveCommentService = liveCommentService;
        }

        public LiveCommentBusiness()
        {
            _liveCommentService = new LiveCommentService();
        }


        public Guid NewComment(LiveComment comment = null, string movieName = "", string userName = "")
        {

            var newComment = new LiveComment
            {
                Id = Guid.NewGuid().ToString(),
                UserId = Guid.NewGuid().ToString(),
                MovieId = Guid.NewGuid().ToString(),
                Comment = "this is a test",
                CreatedDate = DateTime.Now.ToString(),
                Interval = new TimeSpan(1, 2, 1).ToString()
            };

            //add comment, returnd new guid
            var result = _liveCommentService.AddComment(newComment);


            return Guid.NewGuid();
        }

        public LiveComment GetComment(Guid guid)
        {
            var result = new LiveComment();

            result = _liveCommentService.GetComment(guid);

            return result;
        }
    }
}

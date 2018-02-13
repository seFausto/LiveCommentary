using LiveCommentaryService.Business;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommentaryService.Modules
{
    public class LiveCommentModule : NancyModule
    {
        public LiveCommentModule()
        {
            Get["/"] = _ => "Hello World!";

            Get["/movie/{name}"] = args => GetComments(args);

            Post["/movie/{movieName}/{userName}"] = args => PostComment(args);
        }

        private dynamic PostComment(dynamic args)
        {
            throw new NotImplementedException();
        }

        private dynamic GetComments(dynamic args)
        {
            var d = new LiveCommentBusiness();

            var result = d.GetComment(Guid.NewGuid());

            return result;

        }
    }
}

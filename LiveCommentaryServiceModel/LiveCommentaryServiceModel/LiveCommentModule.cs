using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveCommentaryServiceModel
{
    public class LiveCommentModule : NancyModule
    {
        public LiveCommentModule()
        {
            Get["/"] = args => "Hello World";
        }
    }
}
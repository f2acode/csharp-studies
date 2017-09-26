using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegate
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message ..." + args.Video.Title);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // - 1 Define a delegate
        // - 2 Define an event based on the delegate
        // - 3 Raise the event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video ...");
            Thread.Sleep(3000);

            OnVideoEncoded();
            Console.ReadKey();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}

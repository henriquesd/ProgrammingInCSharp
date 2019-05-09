using System;
using System.Threading;

namespace Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1 - Define a delegate;
        // 2 - Define an event based on that delegate;
        // 3 - Raise the event;

        // First we defined a delegate;
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); // this line was commented because of the code in line 19;

        // In .NET they have a delegate type which is called EventHandler, and it comes in two forms:
        // EventHandler     // normal form
        // EventHandler<TEventArgs>     // generic form

        public event EventHandler<VideoEventArgs> VideoEncoded; // this is exactly equivalent to line 13; So we don't have
                                                                // to create a delegate explicitly. We can just use the EventHandler<> class;

        // If you wat to publish an event without sending any additional data, instead of using a generic form like the line 19,
        // we could just use the normal form like this:
        //public event EventHandler VideoEncoded;


        // The second step was to create an event based on that delegate;
        // public event VideoEncodedEventHandler VideoEncoded;

        // The third step is reaising the event;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000); // to delay the application for a period of three seconds;

            OnVideoEncoded(video);
        }

        // event publisher methods should be protected, virtual and void; And in terms of naming, they should start
        // with the word On and then the name of the event, which is VideoEncoded;
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}

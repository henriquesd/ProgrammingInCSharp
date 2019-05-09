using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher;
            var mailService = new MailService(); // subscriber;
            var messageService = new MessageService(); // subscriber;

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // note that I'm not making a call to this method here, so
                                                                     // I don't have brackets here. I just use the name of the method
                                                                     // and basically what that means is this a reference or a pointer to that method;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            // the beauty of this approach is when I created a new subscriber which was MessageService, I did not need
            // to change anything in the VideoEncoded;
            // With events you can create a publisher and you can add subscribers without changing the publisher; so the older
            // code doesn't need recompilation and doesn't need to be redeployed; And basically, you can extend the application,
            // add more capabilities by simply creating a new class, like in this case, the MessageService class.
            // Tomorrow we can have a new class cailled PagerService for example, that sends a notification using a pager and nothing else will be affected.

            videoEncoder.Encode(video);

            Console.ReadLine();
        }
    }
}

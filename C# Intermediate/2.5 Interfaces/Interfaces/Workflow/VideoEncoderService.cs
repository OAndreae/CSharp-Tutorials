using System;

namespace Workflow
{
    public class VideoEncoderService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video is ready to be encoded");
        }
    }
}

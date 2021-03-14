using System;

namespace Workflow
{
    public class VideoUploadManager : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploaded video");
        }
    }
}

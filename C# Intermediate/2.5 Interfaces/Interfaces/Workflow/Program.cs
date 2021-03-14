using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow
{

    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new VideoUploadManager());
            workflow.Add(new VideoEncoderService());
            workflow.Add(new EmailNotificationService());
            workflow.Add(new ChangeStatus());

            var engine = new WorkflowEngine();
            engine.Run(workflow);
        }
    }
}

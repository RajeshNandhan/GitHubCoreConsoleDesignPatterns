using System.Collections.Generic;

namespace StructuralPatterns.Composite
{
    internal class ProjectComposite : ITaskActionComponent
    {
        private List<ITaskActionComponent> stories = null;

        private readonly string projectName;

        public ProjectComposite(string name, List<ITaskActionComponent> stories)
        {
            this.projectName = name;
            this.stories = stories;
        }

        public bool GetTaskStatus()
        {
            var status = true;

            foreach (ITaskActionComponent story in stories)
            {
                if (story.GetTaskStatus() == false)
                {
                    status = false;
                    break;
                }
            }

            return status;
        }

        public string GetTaskStatusToString()
        {
            var projectStatus = GetTaskStatus();

            var projectStatusString = projectStatus ? "all task completed" : "in complete tasks";

            var s = $"Project Name = {projectName}, Project Status = {projectStatusString}\n";

            foreach (ITaskActionComponent story in stories)
            {
                s += "\t " + story.GetTaskStatusToString();
            }

            return s;
        }

        public void AddTask(ITaskActionComponent value)
        {
            if (stories == null)
                stories = new List<ITaskActionComponent>();

            stories.Add(value);
        }
    }
}

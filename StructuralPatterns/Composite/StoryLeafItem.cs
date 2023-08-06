namespace StructuralPatterns.Composite
{
    internal class StoryLeafItem : ITaskActionComponent
    {
        public StoryLeafItem(string name, bool status)
        {
            storyName = name;
            storyStatus = status;
        }

        private readonly string storyName;

        private readonly bool storyStatus;

        public bool GetTaskStatus()
        {
            return storyStatus;
        }

        public string GetTaskStatusToString()
        {
            var storyStatusString = storyStatus ? "completed" : "not completed";

            return $"\t Story Name = {storyName}, Story Status = {storyStatusString}\n";
        }

        public void AddTask(ITaskActionComponent value)
        {
            return;
        }
    }
}

using System;
using System.Collections.Generic;

namespace StructuralPatterns.Composite
{
    internal class CompositeClient
    {
        public static void CompositeClientTest()
        {
            StoryLeafItem story1 = new StoryLeafItem("Task 1", true);
            StoryLeafItem story2 = new StoryLeafItem("Task 2", true);
            ProjectComposite module1 = new ProjectComposite("Module 1", new List<ITaskActionComponent>() { story1, story2 });

            StoryLeafItem story3 = new StoryLeafItem("Task 3", true);
            StoryLeafItem story4 = new StoryLeafItem("Task 4", true);
            ProjectComposite module2 = new ProjectComposite("Module 2", new List<ITaskActionComponent>() { story3, story4 });

            ProjectComposite project1 = new ProjectComposite("Project 1", new List<ITaskActionComponent>() { module1, module2 });

            //Console.WriteLine(project1.GetTaskStatusToString());

            StoryLeafItem storyI = new StoryLeafItem("Task I", true);
            StoryLeafItem storyII = new StoryLeafItem("Task II", false);
            ProjectComposite moduleI = new ProjectComposite("Module I", new List<ITaskActionComponent>() { storyI, storyII });

            StoryLeafItem storyIII = new StoryLeafItem("Task III", true);
            StoryLeafItem storyIV = new StoryLeafItem("Task IV", true);
            StoryLeafItem storyV = new StoryLeafItem("Task V", true);

            storyV.AddTask(null);//NO IMPACT CREATED for THE StoryLeafItem

            ProjectComposite moduleII = new ProjectComposite("Module II", new List<ITaskActionComponent>() { storyIII, storyIV });

            ProjectComposite project2 = new ProjectComposite("Project 2", new List<ITaskActionComponent>() { moduleI, moduleII });

            //mutation is eleiminated here as by changing the status of the object
            project2.AddTask(storyV);

            //Console.WriteLine(project2.GetTaskStatusToString());


            ProjectComposite projectComposite = new ProjectComposite("Team", new List<ITaskActionComponent>() { project1, project2 });


            Console.WriteLine(projectComposite.GetTaskStatusToString());
            Console.Read();
        }

        public static void TestMethod()
        {
            CompositeClientTest();
        }
    }
}

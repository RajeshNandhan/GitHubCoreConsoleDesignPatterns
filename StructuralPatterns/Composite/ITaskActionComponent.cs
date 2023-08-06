namespace StructuralPatterns.Composite
{
    /*
     * 
composite means made of parts or object, here traet both single obkect and compiste object(collection) same way
algorithm inorder, preorder, postorder

maintaine statsu for done not done for eaach task
completd module uncompleted module
    */
    internal interface ITaskActionComponent
    {
        bool GetTaskStatus();

        string GetTaskStatusToString();

        //mutation is eleiminated here as by changing the status of the object
        void AddTask(ITaskActionComponent value); 
    }
}

using System;

namespace SimpleDragAndDropWithBlazor.Shared
{
    public class Task
    {
        public int Id { get; set; }
        public TaskStatuses Status { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    public enum TaskStatuses
    {
        Todo,
        Started,
        Completed
    }
}

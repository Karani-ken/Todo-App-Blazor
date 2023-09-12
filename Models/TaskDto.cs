namespace Todo_App_Blazor.Models
{
    public class TaskDto
    {
        public Guid TaskId{ get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

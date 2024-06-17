using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;
public class RequestAddTaskJson {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public DateTime CutOffDay { get; set; }
    public Status Status { get; set; }
}

using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses;
public class ResponseShortVisualizeAllTasksJson {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}

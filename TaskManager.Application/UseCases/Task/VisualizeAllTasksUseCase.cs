using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task;
public class VisualizeAllTasksUseCase {
    public ResponseShortVisualizeAllTasksJson Execute() {
        return new ResponseShortVisualizeAllTasksJson {
            Id = 1,
            Name = "Test"
        };
    }
}

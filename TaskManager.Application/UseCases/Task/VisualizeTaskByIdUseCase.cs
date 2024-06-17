using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task;
public class VisualizeTaskByIdUseCase {
    public ResponseLongVisualizeTaskByIDJson Execute(int id) {
        return new ResponseLongVisualizeTaskByIDJson {
            Id = id,
            Name = "Teste",
            Description = "AAAA",
            Priority = Communication.Enums.Priority.Media,
            CutOffDay = DateTime.Now,
            Status = Communication.Enums.Status.EmAndamento
        };
    }
}

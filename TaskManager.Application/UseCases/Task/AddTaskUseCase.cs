using TaskManager.Communication.Enums;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task;
public class AddTaskUseCase {
    public ResponseAddTaskJson Execute(RequestAddTaskJson request) {
        return new ResponseAddTaskJson {
            Id = 12,
            Name = "Tarefa1",
            Description = "Fazer comida",
            Priority = Priority.Alta,
            CutOffDay = DateTime.Now,
            Status = Status.Aguardando
        };
    }
}

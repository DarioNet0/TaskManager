using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Task;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase {
    [HttpPost]
    [ProducesResponseType(typeof(ResponseAddTaskJson), StatusCodes.Status201Created)]
    public IActionResult AddTask(RequestAddTaskJson request) {
        var UseCase = new AddTaskUseCase();
        var response = UseCase.Execute(request);
        return Created("", response);
    }
    [HttpGet]
    [ProducesResponseType(typeof(ResponseShortVisualizeAllTasksJson), StatusCodes.Status200OK)]
    public IActionResult VizualizeAllTasks() {
        var UseCase = new VisualizeAllTasksUseCase();
        var response = UseCase.Execute();
        return Ok(response);
    }
    [HttpGet]
    [Route("{Id}")]
    [ProducesResponseType(typeof(ResponseLongVisualizeTaskByIDJson), StatusCodes.Status200OK)]
    public IActionResult VizualizeTaskById([FromRoute] int Id) {
        var UseCase = new VisualizeTaskByIdUseCase();
        var response = UseCase.Execute(Id);
        return Ok(response);
    }
    [HttpPut]
    [Route("{Id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult EditTask([FromRoute] int Id, [FromBody] RequestEditTaskJson request) {
        var UseCase = new EditTaskUseCase();
        UseCase.Execute(request);
        return NoContent();
    }
    [HttpDelete]
    [Route("{Id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteTask([FromRoute] int Id) {
        var UseCase = new DeleteTaskUseCase();
        return NoContent();
    }
}

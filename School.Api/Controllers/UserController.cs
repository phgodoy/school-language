using Microsoft.AspNetCore.Mvc;
using School.Api.Models;
using School.Api.Repositories.Interfaces;

[Route("api/users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserModel>>> GetUsers()
    {
        var users = await _userRepository.GetAllUsers();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserModel>> GetUserById(int id)
    {
        var user = await _userRepository.GetUserById(id);
        return Ok(user);
    }

    [HttpPost]
    public async Task<ActionResult<UserModel>> AddUser([FromBody] UserModel user)
    {
        await _userRepository.AddUser(user);
        return CreatedAtAction(nameof(GetUserById), new { id = user.ID }, user);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UserModel>> UpdateUser(int id, [FromBody] UserModel user)
    {
        var User = await _userRepository.UpdateUser(id, user);

        return Ok(User);

    }

    [HttpPut("enableUser/{id}")]
    public async Task<ActionResult<UserModel>> EnableUser(int id)
    {
        var user = await _userRepository.GetUserById(id);

        if (user == null)
        {
            return NotFound();
        }

        await _userRepository.EnableUser(id);
        return Ok(user);
    }
}
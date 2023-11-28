﻿using Microsoft.AspNetCore.Mvc;
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

        if (user == null)
        {
            return NotFound();
        }

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
        if (id != user.ID)
        {
            return BadRequest();
        }

        await _userRepository.UpdateUser(user);
        return Ok(user);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<UserModel>> DeleteUser(int id)
    {
        var user = await _userRepository.GetUserById(id);

        if (user == null)
        {
            return NotFound();
        }

        await _userRepository.DeleteUser(id);
        return Ok(user);
    }
}
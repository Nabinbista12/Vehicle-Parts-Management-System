using backend.Data.Entities;
using backend.Dtos.Request;
using Microsoft.AspNetCore.Identity;

namespace backend.Services.Implementations;

public class AuthService(UserManager<User> userManager)
{
    public async Task<string> RegisterUserAsync(RegisterUserDto registerUserDto)
    {
        User user = new User()
        {
            Name = registerUserDto.Name,
        };
        
        var registerResult = await userManager.CreateAsync(user, registerUserDto.password);
        if (!registerResult.Succeeded)
        {
            return registerResult.ToString();
        }

        return "User Registered Successfully";
    }
    
}
using AuthAPI.DTOs;
using AuthAPI.Entities;
using System.ComponentModel.DataAnnotations;

namespace AuthAPI.Mapper
{
    public static class UserMapper
    {
        public static UserDto Map(this User user)
        {
            return new UserDto
            {
                UserName = user.UserName,
                Email = user.Email,  
                //Password = user.
            };
        }

        public static User Map(this UserDto user)
        {
            return new User
            {
                UserName = user.UserName,
                Email = user.Email,
               // Password = user.Password
            };
        }
    }
}

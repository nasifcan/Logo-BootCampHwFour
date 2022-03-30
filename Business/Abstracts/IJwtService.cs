using HomeworkFour.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFour.Business.Abstracts
{
    public interface IJwtService
    {
        TokenDto Authenticate(UserDto user);
    }
}

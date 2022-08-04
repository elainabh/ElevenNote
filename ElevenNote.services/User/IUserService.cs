using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevenNote.models.User;

namespace ElevenNote.services.User
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(UserRegister model);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevenNote.models.Token;

namespace ElevenNote.services.Token
{
    public interface ITokenService
    {
        Task<TokenResponse> GetTokenAsync(TokenRequest model);
    }
}
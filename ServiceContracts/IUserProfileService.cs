using ServiceContracts.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceContracts
{
    public interface IUserProfileService
    {
        public UserProfileResponse GetUserInformationById(Guid id);
    }
}

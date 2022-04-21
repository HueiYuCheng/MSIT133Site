using MSIT133Site.Models;

namespace MSIT133Site.Service
{
    public interface IMemberService
    {
        string Register(RegisterRequestModel request);
        Members GetMember(int memberId);
    }
}

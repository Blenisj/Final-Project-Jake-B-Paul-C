using Final_Project.Models;

namespace Final_Project.Interfaces
{
    public interface ITM
    {
        int? AddMember(TeamMember tm);
        List<TeamMember> GetAllMembers();
        TeamMember GetMembersById(int num);
        int? RemoveMembersById(int num);
        int? UpdateMembers(TeamMember tm);
    }
}

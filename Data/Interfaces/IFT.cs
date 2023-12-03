using Final_Project.Models;

namespace Final_Project.Interfaces
{
    public interface IFT
    {
        int? AddTeam(FavoriteTeam t);
        List<FavoriteTeam> GetAllTeams();
        FavoriteTeam GetTeamsById(int Id);
        int? RemoveTeamsById(int id);
        int? UpdateTeams(FavoriteTeam t);
    }
}

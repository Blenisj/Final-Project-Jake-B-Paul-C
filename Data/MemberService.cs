using Final_Project.Interfaces;

namespace Final_Project.Data
{
    public class TMService : ITM
    {
        MemberContext ctx;
        public TMService(MemberContext context)
        {
            ctx = context;
        }

        public int? AddMember(TeamMember tm)
        {
            var teammember = this.GetMembersById(tm.Id);
            if (teammember != null)
            {
                return null;
            }
            ctx.TeamMembers.Add(tm);
            return ctx.SaveChanges();
        }

        public List<TeamMember> GetAllMembers()
        {
            return ctx.TeamMembers.ToList();
        }

        public TeamMember GetMembersById(int Id)
        {
            return ctx.TeamMembers.FirstOrDefault(x => x.Id == Id);
        }

        public int? RemoveMembersById(int id)
        {
            var teammember = this.GetMembersById(id);
            if (teammember == null)
            {
                return null;
            }
            ctx.TeamMembers.Remove(teammember);
            return ctx.SaveChanges();
        }

        public int? UpdateMembers(TeamMember tm)
        {
            ctx.TeamMembers.Update(tm);
            return ctx.SaveChanges();
        }
    }

    public class FFService : IFF
    {
        MemberContext ctx;
        public FFService(MemberContext context)
        {
            ctx = context;
        }

        public int? AddFood(FavoriteFood f)
        {
            var favfood = this.GetFoodsById(f.Id);
            if (favfood != null)
            {
                return null;
            }
            ctx.FavoriteFoods.Add(f);
            return ctx.SaveChanges();
        }

        public List<FavoriteFood> GetAllFoods()
        {
            return ctx.FavoriteFoods.ToList();
        }

        public FavoriteFood GetFoodsById(int Id)
        {
            return ctx.FavoriteFoods.FirstOrDefault(x => x.Id == Id);
        }

        public int? RemoveFoodsById(int id)
        {
            var favfood = this.GetFoodsById(id);
            if (favfood == null)
            {
                return null;
            }
            ctx.FavoriteFoods.Remove(favfood);
            return ctx.SaveChanges();
        }

        public int? UpdateFoods(FavoriteFood f)
        {
            ctx.FavoriteFoods.Update(f);
            return ctx.SaveChanges();
        }
    }
    public class HOService : IH
    {
        MemberContext ctx;
        public HOService(MemberContext context)
        {
            ctx = context;
        }

        public int? AddHobby(Hobby h)
        {
            var hobby = this.GetHobbysById(h.Id);
            if (hobby != null)
            {
                return null;
            }
            ctx.Hobbies.Add(h);
            return ctx.SaveChanges();
        }

        public List<Hobby> GetAllHobbys()
        {
            return ctx.Hobbies.ToList();
        }

        public Hobby GetHobbysById(int Id)
        {
            return ctx.Hobbies.FirstOrDefault(x => x.Id == Id);
        }

        public int? RemoveHobbysById(int id)
        {
            var hobby = this.GetHobbysById(id);
            if (hobby == null)
            {
                return null;
            }
            ctx.Hobbies.Remove(hobby);
            return ctx.SaveChanges();
        }

        public int? UpdateHobbys(Hobby h)
        {
            ctx.Hobbies.Update(h);
            return ctx.SaveChanges();
        }
    }
    public class FTService : IFT
    {
        MemberContext ctx;
        public FTService(MemberContext context)
        {
            ctx = context;
        }

        public int? AddTeam(FavoriteTeam t)
        {
            var favteam = this.GetTeamsById(t.Id);
            if (favteam != null)
            {
                return null;
            }
            ctx.FavoriteTeams.Add(t);
            return ctx.SaveChanges();
        }

        public List<FavoriteTeam> GetAllTeams()
        {
            return ctx.FavoriteTeams.ToList();
        }

        public FavoriteTeam GetTeamsById(int Id)
        {
            return ctx.FavoriteTeams.FirstOrDefault(x => x.Id == Id);
        }

        public int? RemoveTeamsById(int id)
        {
            var favteam= this.GetTeamsById(id);
            if (favteam == null)
            {
                return null;
            }
            ctx.FavoriteTeams.Remove(favteam);
            return ctx.SaveChanges();
        }

        public int? UpdateTeams(FavoriteTeam t)
        {
            ctx.FavoriteTeams.Update(t);
            return ctx.SaveChanges();
        }
    }
}

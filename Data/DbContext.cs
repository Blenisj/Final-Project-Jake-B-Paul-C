﻿using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<Hobby> Hobbies { get; set; }

    public DbSet<FavoriteFood> FavoriteFoods { get; set; }
    public DbSet<FavoriteTeam> FavoriteTeams { get; set; }
}
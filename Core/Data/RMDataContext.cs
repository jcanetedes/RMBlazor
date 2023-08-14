using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RMBlazor.Core.Data.Entities;
using System;

namespace RMBlazor.Core.Data;

public class RMDataContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
    public RMDataContext(DbContextOptions<RMDataContext> options) : base(options)
    {
    }

    public DbSet<ApplicationSource> ApplicationSources { get; set; }
    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<CandidateStatus> CandidateStatuses { get; set; }
    public DbSet<Comments> Comments { get; set; }
    public DbSet<Currency> Currencies { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<HireDecision> HireDecisions { get; set;}
    public DbSet<Recruiter> Recruiters { get; set;}
    public DbSet<Vacancy> Vacancies { get; set; }
    public DbSet<VacancyStatus> VacancyStatuses { get; set;}
}

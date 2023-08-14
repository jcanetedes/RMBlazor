using System.ComponentModel.DataAnnotations.Schema;

namespace RMBlazor.Core.Data.Entities;

public class Vacancy : BaseEntity
{
    [ForeignKey("Id")]
    public int DepartmentId { get; set; }
    public string JobTitle { get; set; }
    public DateTime OpeningDate { get; set; }
    [ForeignKey("Id")]
    public int RecruiterId { get; set; }
    [ForeignKey("Id")]
    public int VacanStatusId { get; set; }
    public DateTime NewHireDate { get; set; }
    public decimal HiringCost { get; set; }

    public Recruiter Recruiter { get; set; }
    public VacancyStatus Status { get; set; }
    public Department Department { get; set; }
}

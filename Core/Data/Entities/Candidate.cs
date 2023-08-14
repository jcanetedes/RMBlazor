using System.ComponentModel.DataAnnotations.Schema;

namespace RMBlazor.Core.Data.Entities;

public class Candidate : BaseEntity
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    [ForeignKey("Id")]
    public int VacancyId { get; set; }
    [ForeignKey("Id")]
    public int ApplicationSourceId { get; set; }
    public DateTime ApplicationDate { get; set; }
    [ForeignKey("Id")]
    public int CandidateStatusId { get; set; }
    [ForeignKey("Id")]
    public int HireDecisionId { get; set; }
    public string Comments { get; set; }
    public Vacancy Vacancy { get; set; }
    public ApplicationSource ApplicationSource { get; set;}
    public CandidateStatus CandidateStatus { get; set; }
    public HireDecision HireDecision { get; set; }
}

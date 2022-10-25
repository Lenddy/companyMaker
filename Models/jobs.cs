#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
//your namespace
namespace companyMaker.Models;    //must be the same that is on you program file 
//classname
public class Job
{
//* you need to use
//dotnet ef migrations add FirstMigration
//dotnet ef database update
//* only doit after creating you routes with all the info that you need
//this is the primary key
    [Key]
// always match the name of the class + id
    public int JobId { get; set; }
//change the field as needed
    [Required]
    [Display(Name ="Title")]
    [MinLength(2)]
    public string title { get; set; }

    [Required]
    [Display(Name ="Description")]
    [MinLength(5)]
    public string description{ get; set; }

    [Required]
    [Display(Name ="Payment")]
    [Range(0.00,Double.MaxValue)]
    public double payment {get; set;}

    [Required]
    [Display(Name ="how long")]
    // make a drop down menu
    public string hours {get; set;}

    [Display(Name ="image url")]
    [MinLength(2)]
    public string? image { get; set; }


    [Required]
    [MinLength(1,ErrorMessage = "you must add a country/region name ")]
    [Display(Name ="country/region")]
    public string country {get; set;}
    
    [Required]
    [MinLength(1,ErrorMessage = "you must add a city")]
    [Display(Name ="city")]
    public string city {get; set;}

    [Required]
    [MinLength(1,ErrorMessage = "you must add a company address")]
    [Display(Name ="address")]
    public string address {get; set;}

    [Required]
    [Display(Name ="postal Code")]
    [Range(0,Int32.MaxValue)]
    public int postalCode {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public int UserId {get; set; }
    public User? jobCreator {get; set;}
}




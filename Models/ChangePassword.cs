#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//your namespace
namespace companyMaker.Models;    //must be the same that is on your program file 
//className
[NotMapped]
public class changePassword
{
    [Required,DataType(DataType.Password),Display(Name ="Current Password"),MinLength(8)]
    public string currentPassword { get; set; }

//change the field as needed
    [Required,DataType(DataType.Password),Display(Name ="New Password"),MinLength(8)]

    public string NewPassword { get; set; }

    [Required,DataType(DataType.Password),Display(Name ="Confirm New Password"),Compare("NewPassword",ErrorMessage ="the password does not match"),MinLength(8)]

    public string ConfirmNewPassword {get; set;}
}
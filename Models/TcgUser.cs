using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Lab4.Models{

public class TcgUser : IdentityUser{

    
    //public virtual Card favourite {get;set;}
     public string favourite {get;set;} = "forest";
}

}
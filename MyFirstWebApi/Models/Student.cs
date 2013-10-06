using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebApi.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
  }
}
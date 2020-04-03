using System;

namespace Crud.Models {
  public class Employee {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid Employeetype { get; set; }
    public string Telephone { get; set; }
    public string Address { get; set; }
    public string Employmentdate { get; set; }

  }
}

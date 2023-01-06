using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    // [Range(1, int.MaxValue, ErrorMessage = "There must be a machine to assign to an engineer. Are any machines installed?")]
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "The engineer must have a name!")]
    public string Name { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class EngineerMachine
  {
    public int EngineerMachineId { get; set; }
    // [Range(1, int.MaxValue, ErrorMessage = "There must be a machine to assign to an engineer. Are any machines installed?")]
    public int MachineId { get; set; }
    public Machine Machine { get; set; }
    public int EngineerId { get; set; }
    public Engineer Engineer { get; set; }
  }
}
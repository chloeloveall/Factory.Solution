using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      JoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    [Required]
    [Display(Name="Name")]
    public string MachineName { get; set; }
    [Required]
    [Display(Name="Description")]
    public string MachineDescription { get; set; }
    [Required]
    [Display(Name="Manufacturer")]
    public string MachineManufacturer { get; set; }
    [Display(Name="Purchase Date")]
    public DateTime PurchaseDate { get; set; }
    [Display(Name="Last Repair Date")]
    public DateTime RepairDate { get; set; }
    [Display(Name="Repair Log")]
    public string RepairLog { get; set; }

    public virtual ICollection<EngineerMachine> JoinEntities { get; }
  }
}
using System;
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
    
    [Required(ErrorMessage = "Please enter a machine name")]
    [Display(Name="Machine Name")]
    public string MachineName { get; set; }

    [Required(ErrorMessage = "Please enter a machine description")]
    [Display(Name="Description")]
    public string MachineDescription { get; set; }

    [Required(ErrorMessage = "Please enter the manufacturer")]
    [Display(Name="Manufacturer")]
    public string MachineManufacturer { get; set; }

    [Required(ErrorMessage = "Please select machine status")]
    [Display(Name="Machine Status")]
    public string MachineStatus { get; set; }

    [Display(Name="Installation Date")]
    public DateTime InstallationDate { get; set; }
    
    // the repair sections can either be on a separate view or on the edit page - edit machine/add repair info
    [Display(Name="Last Repair Date")]
    public DateTime RepairDate { get; set; }
    // this will be a dropdown with engineers - should be same engineers that have already been added to the machine - NOT the entire list of engineers  
    [Display(Name="Last Repaired By")]
    public string RepairedBy { get; set; }

    [Display(Name="Repair Log")]
    public string RepairLog { get; set; }

    public virtual ICollection<EngineerMachine> JoinEntities { get; }
  }
}
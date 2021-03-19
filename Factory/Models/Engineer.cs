using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    [Required]
    [Display(Name="Name")]
    public string EngineerName { get; set; }
    [Required]
    [DataType(DataType.PhoneNumber)]
    [Display(Name="Phone")]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
    public string EngineerPhone { get; set; }
    [Required]
    [EmailAddress]
    [Display(Name="Email")]
    public string EngineerEmail { get; set; }
    [Required]
    [Display(Name="Street Address")]
    public string EngineerAddress { get; set; }
    [Required]
    [Display(Name="City")]
    public string EngineerCity { get; set; }
    [Required]
    [Display(Name="State")]
    public EngineerState EngineerState { get; set; }
    [Required]
    [Display(Name="Postal Code")]
    public int EngineerZip { get; set; }
    [Required]
    [Display(Name="Licenses & Certifications")]
    public string EngineerCerts { get; set; }
    [Required]
    [Display(Name="Bio")]
    public string EngineerBio { get; set; }
    [Display(Name="Hire Date")]
    public DateTime HireDate { get; set; }

    public virtual ICollection<EngineerMachine> JoinEntities { get; }
  }

  public enum EngineerState
  {
    AL,
    AK,
    AS,
    AZ,
    AR,
    CA,
    CO,
    CT,
    DE,
    DC,
    FL,
    GA,
    GU,
    HI,
    ID,
    IL,
    IN,
    IA,
    KS,
    KY,
    LA,
    ME,
    MD,
    MA,
    MI,
    MN,
    MS,
    MO,
    MT,
    NE,
    NV,
    NH,
    NJ,
    NM,
    NY,
    NC,
    ND,
    OH,
    OK,
    OR,
    PA,
    PR,
    RI,
    SC,
    SD,
    TN,
    TX,
    UT,
    VT,
    VA,
    VI,
    WA,
    WV,
    WI,
    WY
  }
}
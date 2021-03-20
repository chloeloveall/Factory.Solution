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
    
    [Required(ErrorMessage = "Please enter a name")]
    [Display(Name="Name")]
    public string EngineerName { get; set; }

    [Required(ErrorMessage = "Please enter a phone number")]
    [DataType(DataType.PhoneNumber)]
    [Display(Name="Phone")]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
    public string EngineerPhone { get; set; }

    [Required(ErrorMessage = "Please enter an email")]
    [EmailAddress]
    [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Not a valid email address")]
    [Display(Name="Email")]
    public string EngineerEmail { get; set; }

    [Required(ErrorMessage = "Please enter an address")]
    [Display(Name="Street Address")]
    public string EngineerAddress { get; set; }

    [Required(ErrorMessage = "Please enter a city")]
    [Display(Name="City")]
    public string EngineerCity { get; set; }

    [Required(ErrorMessage = "Please select a state")]
    [Display(Name="State")]
    public EngineerState EngineerState { get; set; }

    [Required(ErrorMessage = "Please enter a postal code")]
    [RegularExpression(@"^(?(^00000(|-0000))|(\d{5}(|-\d{4})))$", ErrorMessage = "Not a valid postal code")]
    [Display(Name="Postal Code")]
    public int EngineerZip { get; set; }

    [Required(ErrorMessage = "Please select a certification level")]
    [Display(Name="Licenses & Certifications")]
    public string EngineerCerts { get; set; }

    [Required(ErrorMessage = "Please enter an engineer bio")]
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
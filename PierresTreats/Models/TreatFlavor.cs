namespace PierresTreats.Models
{
  public class TreatFlavor
  {       
    public int TreatFlavorId { get; set; }
    public int TreatId { get; set; }
    public int FlavorId { get; set; }
    public virtual Treat Treats { get; set; }
    public virtual Flavor Flavors { get; set; }
  }
}
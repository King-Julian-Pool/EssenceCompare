namespace EssenceCompare.Models
{
    public class PrixEssence
    {

        public long Id { get; set; }
        public double PrixValeur { get; set; }
        public string? PrixNom { get; set; }
        public DateTime PrixMaj { get; set; }
        public string? Adresse { get; set; }
        public string? Cp { get; set; }
        public string? Ville { get; set; }
        public string? DepName { get; set; }
        public string? RegName { get; set; }
        public string? ServicesService { get; set; }
        public string? Horaires { get; set; }
        public string? Geom { get; set; }

    }
}

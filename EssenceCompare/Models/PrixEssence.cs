namespace EssenceCompare.Models
{
    public class PrixEssence
    {
        public long id { get; set; }
        public double prix_valeur { get; set; }
        public string? prix_nom { get; set; }
        public DateTime prix_maj { get; set; }
        public string? adresse { get; set; }
        public string? cp { get; set; }
        public string? ville { get; set; }
        public string? dep_name { get; set; }
        public string? reg_name { get; set; }
        public string? services_service { get; set; }
        public string? horaires { get; set; }
        public string[]? geom { get; set; }
        }

    public class Root
    {
        public List<Record>? records { get; set; }
    }

    public class Record
    {
        public PrixEssence? fields { get; set; }
    }

}
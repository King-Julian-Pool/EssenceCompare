using MessagePack.Formatters;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;

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
        public string? geom { get; set; }

        [JsonConstructor]
        public PrixEssence(long id, double prix_valeur, string? prix_nom, DateTime prix_maj, string? adresse, string? cp, string? ville, string? dep_name, string? reg_name, string? services_service, string? horaires, string[]? geom)
        {
            this.id = id;
            this.prix_valeur = prix_valeur;
            this.prix_nom = prix_nom;
            this.prix_maj = prix_maj;
            this.adresse = adresse;
            this.cp = cp;
            this.ville = ville;
            this.dep_name = dep_name;
            this.reg_name = reg_name;
            this.services_service = services_service;
            this.horaires = horaires;

            if (geom != null)
            {
                this.geom = String.Join(",", geom);
            }
        }

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
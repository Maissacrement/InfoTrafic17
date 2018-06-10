using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace InfoTrafic17.Models
{
    public class Alerte
    {
        public string Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public int Niveau { get; set; }
        public DateTime DatePost { get; set; }
        public Color Color { get; set; }

        public Alerte()
        {
            CreateAlerte("Test", "Ceci est un test", 3, new DateTime(2018, 6, 10));
        }

        public Alerte(String titre, String description, Int32 niveau, DateTime date)
        {
            CreateAlerte(titre, description, niveau, date);
        }

        private void CreateAlerte(String titre, String description, Int32 niveau, DateTime date)
        {
            Titre = titre;
            Description = description;
            Niveau = niveau;
            DatePost = date;

            if (niveau == 1)
            {
                Color = Color.LightGray;
            }
            else if (niveau == 2)
            {
                Color = Color.LightBlue;
            }
            else if (niveau == 3)
            {
                Color = Color.Yellow;
            }
            else if (niveau == 4)
            {
                Color = Color.Orange;
            }
            else if (niveau == 5)
            {
                Color = Color.Red;
            }
        }


        public Int32 Heures
        {
            get
            {
                return (DateTime.Now - DatePost).Hours;
            }
        }
    }
}

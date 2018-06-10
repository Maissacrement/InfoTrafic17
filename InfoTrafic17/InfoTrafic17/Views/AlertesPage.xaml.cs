using InfoTrafic17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InfoTrafic17.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlertesPage : ContentPage
	{
		public AlertesPage ()
		{
			InitializeComponent ();

            alertes.ItemTapped += (object sender, ItemTappedEventArgs e) => {
                // don't do anything if we just de-selected the row
                if (e.Item == null) return;
                // do something with e.SelectedItem
                ((ListView)sender).SelectedItem = null;
            };



            alertes.ItemsSource = new List<Alerte>() {
                new Alerte("⚠ 🐶 Chatel - Angoulin" , "Attention chien érrant sur la D925 entre angoulins et chatelaillon", 3, new DateTime(2018,6,10,5,15,00)),
                new Alerte("🚗 💥 Ile de ré" , "Accident sur la départementale entre la flotte et sainte-marie", 2, new DateTime(2018,6,10,8,15,00)),
                new Alerte("🚓 5️0️ Boulevard sautel" , "Police boulevard sautel au niveau du Leclerc", 1, new DateTime(2018,6,10,12,15,00)),
                new Alerte("🔥 🚒 Muron" , "Voiture en feu dans le centre ville de muron, route totalement bloquée ! Pompier sur place", 5, new DateTime(2018,6,10,12,15,00)),
                new Alerte("⚠ 🐶 Chatel - Angoulin" , "Attention chien érrant sur la D925 entre angoulins et chatelaillon", 3, new DateTime(2018,6,10,5,15,00)),
                new Alerte("🚗 💥 Ile de ré" , "Accident sur la départementale entre la flotte et sainte-marie", 4, new DateTime(2018,6,10,8,15,00)),
                new Alerte("🚓 5️0️ Boulevard sautel" , "Police boulevard sautel au niveau du Leclerc", 2, new DateTime(2018,6,10,12,15,00)),
                new Alerte("🔥 🚒 Muron" , "Voiture en feu dans le centre ville de muron, route totalement bloquée ! Pompier sur place", 5, new DateTime(2018,6,10,12,15,00))
            };
        }
	}
}
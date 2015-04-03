using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Pour en savoir plus sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=391641

namespace AppCoupePizza
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Decoupage : Page
    {
        public Decoupage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoqué lorsque cette page est sur le point d'être affichée dans un frame.
        /// </summary>
        /// <param name="e">Données d’événement décrivant la manière dont l’utilisateur a accédé à cette page.
        /// Ce paramètre est généralement utilisé pour configurer la page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: préparer la page pour affichage ici.

            // TODO: si votre application comporte plusieurs pages, assurez-vous que vous
            // gérez le bouton Retour physique en vous inscrivant à l’événement
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed.
            // Si vous utilisez le NavigationHelper fourni par certains modèles,
            // cet événement est géré automatiquement.
        }


        String Forme="Rond";
        int NB_mangeur = 1;

          
    public void Traitement()
        {

        }


    private void BT_Rond(object sender, TappedRoutedEventArgs e)
    {
        Forme = "Rond";

        string path = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
        ImgPizza.Source = new BitmapImage(new Uri(path + "/Assets/" + Forme + "/" + NB_mangeur + ".jpg", UriKind.Relative));
        
    }

    private void BT_Rectangle(object sender, TappedRoutedEventArgs e)
    {
        Forme = "Rectangle";

        string path = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
        ImgPizza.Source = new BitmapImage(new Uri(path + "/Assets/" + Forme + "/" + NB_mangeur + ".jpg", UriKind.Relative));
        
    }

    private void BT_plus(object sender, TappedRoutedEventArgs e)
    {
        if (NB_mangeur<6){
            NB_mangeur = NB_mangeur + 1;
        }

        string path = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
        ImgPizza.Source = new BitmapImage(new Uri(path + "/Assets/" + Forme + "/" + NB_mangeur + ".jpg", UriKind.Relative));
        
    }

    private void BT_moins(object sender, TappedRoutedEventArgs e)
    {
        if (NB_mangeur>1){
             NB_mangeur = NB_mangeur - 1;
        }
        string path = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
        ImgPizza.Source = new BitmapImage(new Uri(path + "/Assets/" + Forme + "/" + NB_mangeur + ".jpg", UriKind.Relative));
                                                                                 // Changer png en jpg pour afficher le projet de base.
    }

  

  

    private void Boutton_Back(object sender, RoutedEventArgs e)
    {
        Frame.Navigate(typeof(Accueil));
    }

  


 
    } 
}

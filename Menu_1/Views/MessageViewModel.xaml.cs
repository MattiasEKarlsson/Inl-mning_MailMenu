using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Menu_1.Views
{
    /// <summary>
    /// Interaction logic for MessageViewModel.xaml
    /// </summary>
    public partial class MessageViewModel : UserControl
    {
        public MessageViewModel()
        {
            InitializeComponent();
        }

        

        private void mess1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txSubject.Text = "Tjenare";
            txName.Text = "Gustaf Vasa";
            body.Text = "Egentligen är det sällan jag dricker. Och röker gör jag inte. Men efter en lyckad läsning kan jag tillåta mig att ta ett par glas tequila med is + en dominikansk cigarr. Tequila med is piggar upp, det är en lätt och uppfriskande dryck. Och dominikanska cigarrer är långt godare än de kubanska … Relax, relax, book’n’grill-chef.";
        }

        private void mess2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txSubject.Text = "Tjna";
            txName.Text = "Mattias";
            body.Text = "Tiotusen pund för en kväll är inte så illa. Mitt gage är redan högre än bokens värde. Det är ett tecken på kvalitet. Och när gaget stiger förstärks också känslan av djup tillfredsställelse. Det är status, book’n’grill - mästarstatus.Kort sagt, jag är nöjd.Både med mitt yrke och med mitt öde. Det har inte alltid varit så lätt.Men ärr är vardag för oss book’n’grill - mästare.";
        }

        private void mess3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txSubject.Text = "Hej";
            txName.Text = "Sven";
            body.Text = "Blossande på min cigarr tar jag fram en packe vackra, halvt genomskinliga engelska sedlar med kungens självbelåtna fysionomi. Jag drar ut en och rullar mig en cigarett. Lägger den i askfatet och tänder på. Det är ett tacksamhetsoffer till den digitala värld som tryggar vårt arbete. Den här ritualen gör jag efter varje lyckad kväll. Dagens papperspengar brinner förskräckligt dåligt, man får försöka tända dem gång på gång …";
        }

        private void mess4_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txSubject.Text = "Tjollahoppsan";
            txName.Text = "Bertil";
            body.Text = "Om man hade fortsatt att trycka och läsa böcker skulle jag i bästa fall stå och steka guldbraxar på en grill i något semesterhotell, i värsta fall skulle jag koka spagetti i min hemstad Budapests syltor. Och grillmästare hade jag aldrig blivit: jag är dålig på att handleda. Men, Elden vare lovad, tryckpressarna står sedan länge och rostar världen över. Gutenbergeran slutade i en totalseger för elektriciteten.";
        }

        private void mess5_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txSubject.Text = "Tjabba!";
            txName.Text = "Kjelle";
            body.Text = "Ända sedan man slutade trycka böcker och gjorde museiföremål av de bästa har book’n’grill existerat. Människorna dras alltid till den förbjudna frukten. Nittio procent av de böcker som man en gång i tiden låtit trycka gick till återanvändning eller slängdes helt enkelt på soptippen för att inte uppta dyrbart utrymme i bostäderna.";
        }

        private void mess6_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txSubject.Text = "Tjenare";
            txName.Text = "Vasa";
            body.Text = "Så var det. Engelsmännen var de första ”framom andra på planeten vår”. De fyra gentlemän som skänkte världen ett nytt mode döptes till ”de nya beatlarna” eftersom tre av dem råkade ha samma förnamn som de i kvartetten från Liverpool – John, George och Paul. Kontrafagottisten hette Gregor. Både de och dagens grillmästare tog den europeiska efterkrigsvärlden med storm. Jojomän.";
        }

        private void mess7_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txSubject.Text = "Tjenare";
            txName.Text = "Gustaf";
            body.Text = "Men redan ett halvt år senare, när stölderna i museer och bibliotek runtom i världen blivit vardagsmat, såg man sig tvungen att beteckna book’n’grill som brott inte bara mot kulturen utan också mot civilisationen i sin helhet. Lagens svärd hängde inte bara över huvudet på kockar, boktjuvar och kunder, det hotade också alla de gäster som ville pröva på lammstek på Don Quijote eller tonfiskbiff på Moby Dick.";
        }

        
    }
}

using System.Windows.Controls;
using System.Windows.Media;

namespace Menu_1.Controls
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }
        public ImageSource ContactImage
        {
            get { return contactImage.Source; }
            set { contactImage.Source = value; }
        }

        public string ContactName
        {
            get { return contactName.Text; }
            set { contactName.Text = value; }
        }

        public string ContactTitle
        {
            get { return contactTitle.Text; }
            set { contactTitle.Text = value; }
        }
    }
}

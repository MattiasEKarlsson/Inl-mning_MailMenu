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

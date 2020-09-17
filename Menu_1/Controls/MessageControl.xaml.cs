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
    /// Interaction logic for MessageControl.xaml
    /// </summary>
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
        }
        public string MessageFrom
        {
            get { return messageFrom.Text; }
            set { messageFrom.Text = value; }

        }
        public string MessageAbout
        {
            get { return messegeAbout.Text; }
            set { messegeAbout.Text = value; }

        }
        public string MessageDate
        {
            get { return messageDate.Text; }
            set { messageDate.Text = value; }

        }
        public string MessageTime
        {
            get { return messageTime.Text; }
            set { messageTime.Text = value; }

        }
    }
}

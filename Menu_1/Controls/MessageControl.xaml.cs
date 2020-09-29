using System.Windows.Controls;

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

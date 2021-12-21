using System;
using System.Windows.Forms;

namespace DiscordRP
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_MouseClick(object sender, MouseEventArgs e)
        {
            wbMedia.Url = new Uri("https://smallquilt.quilt.idv.tw:8923/resource.php");
            wbMedia.Visible = true;
        }
    }
}
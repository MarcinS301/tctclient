using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace tctclient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUPdown_TextChanged(object sender, EventArgs e)
        {

        }

        private void przycisk_polacz_Click(object sender, EventArgs e)
        {
            string host = adres.Text;
            int port = Convert.ToInt32(my_port.Value);
            try
            {
                TcpClient klient = new TcpClient(host, port);
                info_o_polaczeniu.Items.Add("nawiazano pol" + host + "na porcie" + port);
                klient.Close();

            }
            catch (Exception ex)
            {
                info_o_polaczeniu.Items.Add("blad" + "nie udalo sie");
                MessageBox.Show(ex.ToString(), "blad");
            }
            }
    }
}

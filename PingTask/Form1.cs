using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace PingTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnAdd.Click += new EventHandler(btnAdd_Click);
            btnRemove.Click += new EventHandler(btnRemove_Click);
            btnPing.Click += new EventHandler(btnPing_Click);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIpInput.Text))
            {
                lstIps.Items.Add(txtIpInput.Text);
                txtIpInput.Clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstIps.SelectedIndex != -1)
            {
                lstIps.Items.RemoveAt(lstIps.SelectedIndex);
            }
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            if (lstIps.SelectedItem == null)
            {
                MessageBox.Show("Please select an IP address from the list.");
                return;
            }

            string ipAddress = lstIps.SelectedItem.ToString();
            lstResults.Items.Clear();

            try
            {
                Ping pingSender = new Ping();

                for (int i = 0; i < 3; i++)
                {
                    PingReply reply = pingSender.Send(ipAddress, 2000);

                    if (reply != null && reply.Status == IPStatus.Success)
                    {
                        lstResults.Items.Add($"Ping to {ipAddress} successful: {reply.RoundtripTime}ms");
                    }
                    else
                    {
                        lstResults.Items.Add($"Ping to {ipAddress} failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid IP or network error: " + ex.Message);
            }
        }
    }
}
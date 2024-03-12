using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IP_addressInfo
{
	public partial class PingTest : Form
	{
		Ping ping = new Ping();
		PingReply ping_reply = null;
		string ip_address = "";
		public PingTest()
		{
			InitializeComponent();
		}
		async Task SendPackets()
		{			
			ping_reply = await ping.SendPingAsync(ip_address);
		}
		
		private async void b_AddHost_Click(object sender, EventArgs e)
		{
			ListViewItem lvi = null;
			int packets_send = 0;
			int packets_recv = 0;
			int packets_lost = 0;
			int packets_lost_percent = 0;
			string time;
			string host_name = "";
			string[] host_info = null;
			string ip = "";

			if(iac_IP.CheckFillIPAddress())
				ip_address = ip = iac_IP.TextIP;
			else if(tb_URL.Text.Length != 0)
				ip_address = tb_URL.Text;
			else return;

			Task task = SendPackets();
			await Task.WhenAny(task);
			ip_address = ping_reply.Address.ToString();
			packets_send++;
			if (ping_reply.Status == IPStatus.Success)
			{
				time = ping_reply.RoundtripTime > 1000 ? ">1000" : ping_reply.RoundtripTime.ToString();
				packets_recv++;
			}
			else
			{ 
				time = "Request timed out";
				ip_address = ip;
				packets_lost++;
			}
			packets_lost_percent = 100 * (packets_lost) / packets_send;
			if (iac_IP.CheckFillIPAddress() || tb_URL.Text.Length != 0)
			{
				if (tb_URL.Text.Length != 0)
					host_name = tb_URL.Text;
				host_info = new string[] { ip_address, host_name, time, packets_send.ToString(), packets_recv.ToString(), packets_lost.ToString(), packets_lost_percent.ToString() };
				lvi = new ListViewItem(host_info);
				lv_HostList.Items.Add(lvi);
			}
			t_Refresh.Enabled = true;
		}
		async Task RefreshListViev()
		{
			Ping ping = new Ping();
			PingReply ping_reply = null;
			for (int i = 0; i < lv_HostList.Items.Count; i++)
			{ 
				ping_reply = await ping.SendPingAsync(lv_HostList.Items[i].SubItems[0].Text);
				lv_HostList.Items[i].SubItems[3].Text = Convert.ToString(Convert.ToInt32(lv_HostList.Items[i].SubItems[3].Text) + 1);
				if (ping_reply.Status == IPStatus.Success)
				{
					lv_HostList.Items[i].SubItems[2].Text = ping_reply.RoundtripTime > 1000 ? ">1000" : ping_reply.RoundtripTime.ToString();
					lv_HostList.Items[i].SubItems[4].Text = Convert.ToString(Convert.ToInt32(lv_HostList.Items[i].SubItems[4].Text) + 1);
				}
				else
				{ 
					lv_HostList.Items[i].SubItems[2].Text = "Request timed out";
					lv_HostList.Items[i].SubItems[5].Text = Convert.ToString(Convert.ToInt32(lv_HostList.Items[i].SubItems[5].Text) + 1);
				}
				lv_HostList.Items[i].SubItems[6].Text = Convert.ToString(100 * Convert.ToInt32(lv_HostList.Items[i].SubItems[5].Text) / Convert.ToInt32(lv_HostList.Items[i].SubItems[3].Text));
			}
		}
		private async void t_Refresh_Tick(object sender, EventArgs e)
		{			
			Task task = RefreshListViev();
			await Task.WhenAny(task);
		}

		private void PingTest_FormClosed(object sender, FormClosedEventArgs e)
		{
			t_Refresh.Stop();
		}

		private void iac_IP_Enter(object sender, EventArgs e)
		{
			tb_URL.Text = "";
		}

		private void tb_URL_Enter(object sender, EventArgs e)
		{
			iac_IP.TextIP = "...";
		}

		private void b_DeleteHost_Click(object sender, EventArgs e)
		{			
			ListViewItem lvi = lv_HostList.SelectedItems[0];
			lv_HostList.Items.Remove(lvi);
		}
	}
}

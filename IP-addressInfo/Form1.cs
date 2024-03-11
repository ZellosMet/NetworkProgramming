using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_addressInfo
{
	public partial class Form1 : Form
	{
		int[] ip_address = new int[4];
		int[] mask = new int[4];
		int[] invert_mask = new int[4];
		char web_class;
		public Form1()
		{
			InitializeComponent();
		}
		void GetClass()
		{
			if (ip_address[0] >= 1 && ip_address[0] <= 127) this.web_class = 'A';
			if (ip_address[0] >= 128 && ip_address[0] <= 191) this.web_class = 'B';
			if (ip_address[0] >= 192 && ip_address[0] <= 223) this.web_class = 'C';
			if (ip_address[0] >= 224 && ip_address[0] <= 239) this.web_class = 'D';
			if (ip_address[0] >= 240 && ip_address[0] <= 255) this.web_class = 'E';
		}
		int CountBit(string number)
		{
			int count = 0;
			int n = Convert.ToInt32(number);
			while (n > 0)
			{
				if (n % 2 == 1)
					count++;
				n = n >> 1;
			}
			return count;
		}

		private void b_clear_Click(object sender, EventArgs e)
		{
			nud_Prefix.Value = 1;
			iac_IPAddress.TextIP = "...";
			iac_Mask.TextIP = "...";
			nud_Prefix.Value = 1;
			l_Info.Text = "";
		}

		private void b_Result_Click(object sender, EventArgs e)
		{

			if (iac_IPAddress.TextIP.Split('.')[0].Length != 0 && iac_IPAddress.TextIP.Split('.')[1].Length != 0 && iac_IPAddress.TextIP.Split('.')[2].Length != 0 && iac_IPAddress.TextIP.Split('.')[3].Length != 0)
			{
				ip_address[0] = Convert.ToInt32(iac_IPAddress.TextIP.Split('.')[0]);
				ip_address[1] = Convert.ToInt32(iac_IPAddress.TextIP.Split('.')[1]);
				ip_address[2] = Convert.ToInt32(iac_IPAddress.TextIP.Split('.')[2]);
				ip_address[3] = Convert.ToInt32(iac_IPAddress.TextIP.Split('.')[3]);
				GetClass();
				l_Info.Text = $"IP-адрес: {ip_address[0]}.{ip_address[1]}.{ip_address[2]}.{ip_address[3]}\n";
				l_Info.Text += $"Маска сети: {mask[0]}.{mask[1]}.{mask[2]}.{mask[3]}\n";
				l_Info.Text += $"Адресс сети: {ip_address[0] & mask[0]}.{ip_address[1] & mask[1]}.{ip_address[2] & mask[2]}.{ip_address[3] & mask[3]}\n";
				l_Info.Text += (Convert.ToInt32(nud_Prefix.Value)<32)? $"Широковещательный адрес: {ip_address[0] | invert_mask[0]}.{ip_address[1] | invert_mask[1]}.{ip_address[2] | invert_mask[2]}.{ip_address[3] | invert_mask[3]}\n" : "Широковещательный адрес: Не возможно расчитать\n";
				l_Info.Text += (Convert.ToInt32(nud_Prefix.Value)<=30)? $"IP-адрес 1-го узла: {ip_address[0] & mask[0]}.{ip_address[1] & mask[1]}.{ip_address[2] & mask[2]}.{(ip_address[3] & mask[3]) + 1}\n" : "IP-адрес 1-го узла: Не возможно расчитать\n";
				l_Info.Text += (Convert.ToInt32(nud_Prefix.Value) <=30)? $"IP-адрес последнего узла: {ip_address[0] | invert_mask[0]}.{ip_address[1] | invert_mask[1]}.{ip_address[2] | invert_mask[2]}.{(ip_address[3] | invert_mask[3]) - 1}\n" : "IP-адрес последнего узла: Не возможно расчитать\n";
				l_Info.Text += (Convert.ToInt32(nud_Prefix.Value) <=30)? $"Количество узлов в сети: {Math.Pow(2, 32 - Convert.ToInt32(nud_Prefix.Value)) - 2}\n" : "Количество узлов в сети: 0\n";
				l_Info.Text += $"Класс сети: {this.web_class}";
			}
			else l_Info.Text = "Заполнены не все поля!";
		}
		private void iac_IPAddress_IPChanched(object sender, EventArgs e)
		{
			if (iac_Mask.TextIP.Split('.')[0].Length != 0 && iac_Mask.TextIP.Split('.')[1].Length != 0 && iac_Mask.TextIP.Split('.')[2].Length != 0 && iac_Mask.TextIP.Split('.')[3].Length != 0) return;
			if (iac_IPAddress.TextIP.Split('.')[0].Length != 0 && iac_IPAddress.TextIP.Split('.')[1].Length != 0 && iac_IPAddress.TextIP.Split('.')[2].Length != 0 && iac_IPAddress.TextIP.Split('.')[3].Length != 0)
			{
				if (Convert.ToInt32(iac_IPAddress.TextIP.Split('.')[0]) > 0 && Convert.ToInt32(iac_IPAddress.TextIP.Split('.')[0]) <= 127)
				{
					iac_Mask.TextIP = "255.0.0.0";
				}
				if (Convert.ToInt32(iac_IPAddress.TextIP.Split('.')[0]) >= 128 && Convert.ToInt32(iac_IPAddress.TextIP.Split('.')[0]) <= 191)
				{
					iac_Mask.TextIP = "255.255.0.0";
				}
				if (Convert.ToInt32(iac_IPAddress.TextIP.Split('.')[0]) >= 192 && Convert.ToInt32(iac_IPAddress.TextIP.Split('.')[0]) <= 223)
				{
					iac_Mask.TextIP = "255.255.255.0";
				}
			}
		}
		private void nud_Prefix_ValueChanged(object sender, EventArgs e)
		{
			int mi = Convert.ToInt32(nud_Prefix.Value);
			string m = "00000000.00000000.00000000.00000000";
			char[] mc = m.ToCharArray();
			for (int i = 0, j = 0; i < mi; i++, j++)
			{
				if (mc[j] == '.') j++;
				mc[j] = '1';
			}
			string ms = new string(mc);
			char[] imc = mc;
			for (int i = 0; i < m.Length; i++)
			{
				if (imc[i] == '0') imc[i] = '1';
				else if (imc[i] == '.') continue;
				else imc[i] = '0';
			}
			string ims = new string(imc);
			for (int i = 0; i < m.Split('.').Length; i++)
			{
				this.mask[i] = Convert.ToInt32(ms.Split('.')[i], 2);
				this.invert_mask[i] = Convert.ToInt32(ims.Split('.')[i], 2);
			}
			iac_Mask.TextIP = $"{mask[0].ToString()}.{mask[1].ToString()}.{mask[2].ToString()}.{mask[3].ToString()}";
		}

		private void iac_Mask_IPChanched(object sender, EventArgs e)
		{
			//if (iac_Mask.TextIP.Split('.')[0].Length != 0 && iac_Mask.TextIP.Split('.')[1].Length != 0 && iac_Mask.TextIP.Split('.')[2].Length != 0 && iac_Mask.TextIP.Split('.')[3].Length != 0) return;
			nud_Prefix.Value = CountBit(iac_Mask.TextIP.Split('.')[0]) + CountBit(iac_Mask.TextIP.Split('.')[1]) + CountBit(iac_Mask.TextIP.Split('.')[2]) + CountBit(iac_Mask.TextIP.Split('.')[3]);
		}
	}
}

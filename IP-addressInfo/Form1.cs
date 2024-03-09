using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
			//l_Info.Text = "192.168.0.100";
		}
		void GetMask(string mask)
		{
			int mi = Convert.ToInt32(mask);
			string m = "00000000.00000000.00000000.00000000";
			char[] mc = m.ToCharArray();
			for (int i = 0, j = 0; i < mi; i++ , j++)
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
		}
		void GetClass()
		{
			if (ip_address[0] >= 1 && ip_address[1] <= 126 && ip_address[3] >= 0 && ip_address[3] <= 255 ) this.web_class = 'A';
			if (ip_address[0] >= 128 && ip_address[1] <= 191 && ip_address[3] >= 0 && ip_address[3] <= 255 ) this.web_class = 'B';
			if (ip_address[0] >= 192 && ip_address[1] <= 223 && ip_address[3] >= 0 && ip_address[3] <= 255 ) this.web_class = 'C';
			if (ip_address[0] >= 224 && ip_address[1] <= 239 && ip_address[3] >= 0 && ip_address[3] <= 255 ) this.web_class = 'D';
			if (ip_address[0] >= 240 && ip_address[1] <= 255 && ip_address[3] >= 0 && ip_address[3] <= 255 ) this.web_class = 'E';
		}
		private void tb_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)			
				e.Handled = true;			
		}

		private void tb_FirstNum_TextChanged(object sender, EventArgs e)
		{
			if(tb_OneNum.Text.Length == 3)
				tb_TwoNum.Focus();
			if (tb_OneNum.Text == "") return;
			if (Convert.ToInt32(tb_OneNum.Text) > 255) tb_OneNum.Text = "255";
			else if (tb_OneNum.Text.Length == 0) tb_OneNum.Text = "";
		}

		private void tb_TwoNum_TextChanged(object sender, EventArgs e)
		{
			if (tb_TwoNum.Text.Length == 3)
				tb_TreeNum.Focus();
			if (tb_TwoNum.Text == "") return;
			if (Convert.ToInt32(tb_TwoNum.Text) > 255) tb_TwoNum.Text = "255";
			else if (tb_TwoNum.Text.Length == 0) tb_TwoNum.Text = "";
		}

		private void tb_TreeNum_TextChanged(object sender, EventArgs e)
		{
			if (tb_TreeNum.Text.Length == 3)
				tb_FourNum.Focus();
			if (tb_TreeNum.Text == "") return;
			if (Convert.ToInt32(tb_TreeNum.Text) > 255) tb_TreeNum.Text = "255";
			else if (tb_TreeNum.Text.Length == 0) tb_TreeNum.Text = "";
		}

		private void tb_FourNum_TextChanged(object sender, EventArgs e)
		{
			if (tb_FourNum.Text.Length == 3)
				tb_MaskNum.Focus();
			if (tb_FourNum.Text == "") return;
			if (Convert.ToInt32(tb_FourNum.Text) > 255) tb_FourNum.Text = "255";
			else if (tb_FourNum.Text.Length == 0) tb_FourNum.Text = "";
		}
		private void tb_MaskNum_TextChanged(object sender, EventArgs e)
		{
			if (tb_MaskNum.Text.Length == 2)
				b_Result.Focus();
			if (tb_MaskNum.Text == "") return;
			if (Convert.ToInt32(tb_MaskNum.Text) > 32) tb_MaskNum.Text = "32";
			else if (tb_MaskNum.Text.Length == 0) tb_MaskNum.Text = "";
		}

		private void b_clear_Click(object sender, EventArgs e)
		{
			tb_OneNum.Clear();
			tb_TwoNum.Clear();
			tb_TreeNum.Clear();
			tb_FourNum.Clear();
			tb_MaskNum.Clear();
		}

		private void b_Result_Click(object sender, EventArgs e)
		{
			if (tb_OneNum.Text.Length != 0 && tb_TwoNum.Text.Length != 0 && tb_TreeNum.Text.Length != 0 && tb_FourNum.Text.Length != 0 && tb_MaskNum.Text.Length != 0)
			{
				ip_address[0] = Convert.ToInt32(tb_OneNum.Text);
				ip_address[1] = Convert.ToInt32(tb_TwoNum.Text);
				ip_address[2] = Convert.ToInt32(tb_TreeNum.Text);
				ip_address[3] = Convert.ToInt32(tb_FourNum.Text);
				GetMask(tb_MaskNum.Text);
				GetClass();
				l_Info.Text = $"IP-адрес: {ip_address[0]}.{ip_address[1]}.{ip_address[2]}.{ip_address[3]}\n";
				l_Info.Text += $"Маска сети: {mask[0]}.{mask[1]}.{mask[2]}.{mask[3]}\n";
				l_Info.Text += $"Адресс сети: {ip_address[0] & mask[0]}.{ip_address[1] & mask[1]}.{ip_address[2] & mask[2]}.{ip_address[3] & mask[3]}\n";
				l_Info.Text += (Convert.ToInt32(tb_MaskNum.Text)<32)? $"Широковещательный адрес: {ip_address[0] | invert_mask[0]}.{ip_address[1] | invert_mask[1]}.{ip_address[2] | invert_mask[2]}.{ip_address[3] | invert_mask[3]}\n" : "Широковещательный адрес: Не возможно расчитать\n";
				l_Info.Text += (Convert.ToInt32(tb_MaskNum.Text)<=30)? $"IP-адрес 1-го узла: {ip_address[0] & mask[0]}.{ip_address[1] & mask[1]}.{ip_address[2] & mask[2]}.{(ip_address[3] & mask[3]) + 1}\n" : "IP-адрес 1-го узла: Не возможно расчитать\n";
				l_Info.Text += (Convert.ToInt32(tb_MaskNum.Text)<=30)? $"IP-адрес последнего узла: {ip_address[0] | invert_mask[0]}.{ip_address[1] | invert_mask[1]}.{ip_address[2] | invert_mask[2]}.{(ip_address[3] | invert_mask[3]) - 1}\n" : "IP-адрес последнего узла: Не возможно расчитать\n";
				l_Info.Text += (Convert.ToInt32(tb_MaskNum.Text)<=30)? $"Количество узлов в сети: {Math.Pow(2, 32 - Convert.ToInt32(tb_MaskNum.Text)) - 2}\n" : "Количество узлов в сети: 0\n";
				l_Info.Text += $"Класс сети: {this.web_class}";
			}
			else l_Info.Text = "Заполнены не все поля!";
		}
		private void ipAddressControl1_IPChanched(object sender, EventArgs e)
		{
			//l_Info.Text = ipAddressControl1.Text;
		}
	}
}

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
	public delegate void EventHandler(object sender, EventArgs e);
	public partial class IPAddressControl : UserControl
	{
		int first_min = 0;
		int first_max = 255;
		int second_min = 0;
		int second_max = 255;
		int third_min = 0;
		int third_max = 255;
		int fourd_min = 0;
		int fourd_max = 255;

		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Bindable(true)]
		public int FirstMin { get { return first_min; } set { first_min = value; } }
		public int FirstMax { get { return first_max; } set { first_max = value; } }
		public int SecondMin { get { return second_min; } set { second_min = value; } }
		public int SecondMax { get { return second_max; } set { second_max = value; } }
		public int ThirdMin { get { return third_min; } set { third_min = value; } }
		public int ThirdMax { get { return third_max; } set { third_max = value; } }
		public int FourdMin { get { return fourd_min; } set { fourd_min = value; } }
		public int FourdMax { get { return fourd_max; } set { fourd_max = value; } }

		public string TextIP
		{ 
			get 
			{ 
				return $"{FirstByte.Text}.{SecondByte.Text}.{ThirdByte.Text}.{FourthByte.Text}"; 
			}
			set 
			{
				if (value.Split('.').Length == 0) return;
				if (value.Split('.').Length == 1) FirstByte.Text = value.Split('.')[0];
				if (value.Split('.').Length == 2) { FirstByte.Text = value.Split('.')[0]; SecondByte.Text = value.Split('.')[1]; }
				if (value.Split('.').Length == 3) { FirstByte.Text = value.Split('.')[0]; SecondByte.Text = value.Split('.')[1]; ThirdByte.Text = value.Split('.')[2]; }
				if (value.Split('.').Length == 4) { FirstByte.Text = value.Split('.')[0]; SecondByte.Text = value.Split('.')[1]; ThirdByte.Text = value.Split('.')[2]; FourthByte.Text = value.Split('.')[3]; }
				this.Invalidate();
			}			
		}
		[Browsable(true)]
		public event EventHandler IPChanched;
		public event EventHandler IPLeave;
		public event EventHandler IPEnter;

		new protected virtual void TextChanged(EventArgs e)
		{
			EventHandler eh = IPChanched;
			if (eh != null)
				eh(this, e);
		}
		new protected virtual void OnLeave(EventArgs e)
		{
			EventHandler eh = IPLeave;
			if (eh != null)
				eh(this, e);
		}
		new protected virtual void OnEnter(EventArgs e)
		{
			EventHandler eh = IPEnter;
			if (eh != null)
				eh(this, e);
		}
		public IPAddressControl()
		{
			InitializeComponent();
		}
		/////////////////////////// Methods ///////////////////////////////////////////////
		private void tb_KeyPress(object sender, KeyPressEventArgs e) //Проверка на вводимые символы
		{
			if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 11)
				e.Handled = true;
		}
		private void CheckTextBox(TextBox tb, int min, int max) //Проверка на указанный диапозон
		{
			if (tb.Text == "") return;
			if (Convert.ToInt32(tb.Text) > max) tb.Text = max.ToString();
			else if (Convert.ToInt32(tb.Text) < min) tb.Text = min.ToString();
			else if (tb.Text.Length == 0) tb.Text = "";
		}
		private void CheckTextBoxLength(TextBox current_tb, TextBox next_tb) //Проверка на переход
		{
			if (current_tb.Text == "") return;
			if (current_tb.Text.Length == 3 && current_tb.Focused)
				next_tb.Focus();
		}
		void CheckCreateEventIPChanched(object sender)
		{
			if (IPChanched != null)
			{
				EventArgs ef = new EventArgs();
				IPChanched(sender, ef);
			}
		}
		void CheckCreateEventIPLeave(object sender)
		{
			if (IPLeave != null)
			{
				EventArgs ef = new EventArgs();
				IPLeave(sender, ef);
			}
		}
		void CheckCreateEventIPEnter(object sender)
		{
			if (IPEnter != null)
			{
				EventArgs ef = new EventArgs();
				IPEnter(sender, ef);
			}
		}
		public bool CheckFillIPAddress()
		{ 
			if(FirstByte.Text.Length != 0 && SecondByte.Text.Length != 0 && ThirdByte.Text.Length != 0 && FourthByte.Text.Length != 0)
				return true;
			return false;
		}
		/////////////////////////////////////////////////////////////

		/////////////////////////// Events //////////////////////////

		private void FirstByte_TextChanged(object sender, EventArgs e)
		{
			CheckTextBoxLength(FirstByte, SecondByte);
			CheckCreateEventIPChanched(sender);			
		}
		private void SecondByte_TextChanged(object sender, EventArgs e)
		{
			CheckTextBoxLength(SecondByte, ThirdByte);
			CheckCreateEventIPChanched(sender);
		}
		private void ThirdByte_TextChanged(object sender, EventArgs e)
		{
			CheckTextBoxLength(ThirdByte, FourthByte);
			CheckCreateEventIPChanched(sender);
		}
		private void FourthByte_TextChanged(object sender, EventArgs e)
		{
			if (FourthByte.Text == "") return;
			CheckTextBoxLength(FourthByte, FourthByte);
			CheckCreateEventIPChanched(sender);
		}
		private void FirstByte_Leave(object sender, EventArgs e)
		{
			CheckTextBox(FirstByte, first_min, first_max);
		}
		private void SecondByte_Leave(object sender, EventArgs e)
		{
			CheckTextBox(SecondByte, second_min, second_max);
		}
		private void ThirdByte_Leave(object sender, EventArgs e)
		{
			CheckTextBox(ThirdByte, third_min, third_max);
		}
		private void FourthByte_Leave(object sender, EventArgs e)
		{
			CheckTextBox(FourthByte, fourd_min, fourd_max);
		}

		private void IPAddressControl_Leave(object sender, EventArgs e)
		{
			CheckCreateEventIPLeave(sender);
		}

		private void IPAddressControl_Enter(object sender, EventArgs e)
		{
			CheckCreateEventIPEnter(sender);
		}
		///////////////////////////////////////////////////////////////
	}
}

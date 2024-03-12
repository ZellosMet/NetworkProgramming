using System;

namespace IP_addressInfo
{
	partial class IPAddressControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.FirstByte = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SecondByte = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ThirdByte = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.FourthByte = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// FirstByte
			// 
			this.FirstByte.BackColor = System.Drawing.SystemColors.Window;
			this.FirstByte.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.FirstByte.Location = new System.Drawing.Point(0, 2);
			this.FirstByte.MaxLength = 3;
			this.FirstByte.Name = "FirstByte";
			this.FirstByte.Size = new System.Drawing.Size(40, 15);
			this.FirstByte.TabIndex = 0;
			this.FirstByte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.FirstByte.TextChanged += new System.EventHandler(this.FirstByte_TextChanged);
			this.FirstByte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
			this.FirstByte.Leave += new System.EventHandler(this.FirstByte_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(35, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = ".";
			// 
			// SecondByte
			// 
			this.SecondByte.BackColor = System.Drawing.SystemColors.Window;
			this.SecondByte.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SecondByte.Location = new System.Drawing.Point(45, 2);
			this.SecondByte.MaxLength = 3;
			this.SecondByte.Name = "SecondByte";
			this.SecondByte.Size = new System.Drawing.Size(40, 15);
			this.SecondByte.TabIndex = 1;
			this.SecondByte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.SecondByte.TextChanged += new System.EventHandler(this.SecondByte_TextChanged);
			this.SecondByte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
			this.SecondByte.Leave += new System.EventHandler(this.SecondByte_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(80, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = ".";
			// 
			// ThirdByte
			// 
			this.ThirdByte.BackColor = System.Drawing.SystemColors.Window;
			this.ThirdByte.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ThirdByte.Location = new System.Drawing.Point(90, 2);
			this.ThirdByte.MaxLength = 3;
			this.ThirdByte.Name = "ThirdByte";
			this.ThirdByte.Size = new System.Drawing.Size(40, 15);
			this.ThirdByte.TabIndex = 2;
			this.ThirdByte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ThirdByte.TextChanged += new System.EventHandler(this.ThirdByte_TextChanged);
			this.ThirdByte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
			this.ThirdByte.Leave += new System.EventHandler(this.ThirdByte_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(125, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = ".";
			// 
			// FourthByte
			// 
			this.FourthByte.BackColor = System.Drawing.SystemColors.Window;
			this.FourthByte.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.FourthByte.Location = new System.Drawing.Point(135, 2);
			this.FourthByte.MaxLength = 3;
			this.FourthByte.Name = "FourthByte";
			this.FourthByte.Size = new System.Drawing.Size(40, 15);
			this.FourthByte.TabIndex = 3;
			this.FourthByte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.FourthByte.TextChanged += new System.EventHandler(this.FourthByte_TextChanged);
			this.FourthByte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
			this.FourthByte.Leave += new System.EventHandler(this.FourthByte_Leave);
			// 
			// IPAddressControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Controls.Add(this.FourthByte);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ThirdByte);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SecondByte);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FirstByte);
			this.Name = "IPAddressControl";
			this.Size = new System.Drawing.Size(180, 25);
			this.Enter += new System.EventHandler(this.IPAddressControl_Enter);
			this.Leave += new System.EventHandler(this.IPAddressControl_Leave);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox FirstByte;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SecondByte;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ThirdByte;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox FourthByte;
	}
}

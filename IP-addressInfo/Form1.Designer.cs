using System.ComponentModel;

namespace IP_addressInfo
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.l_Info = new System.Windows.Forms.Label();
			this.b_Result = new System.Windows.Forms.Button();
			this.b_clear = new System.Windows.Forms.Button();
			this.nud_Prefix = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.iac_Mask = new IP_addressInfo.IPAddressControl();
			this.iac_IPAddress = new IP_addressInfo.IPAddressControl();
			this.b_IPTest = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nud_Prefix)).BeginInit();
			this.SuspendLayout();
			// 
			// l_Info
			// 
			this.l_Info.AutoSize = true;
			this.l_Info.Location = new System.Drawing.Point(9, 118);
			this.l_Info.Name = "l_Info";
			this.l_Info.Size = new System.Drawing.Size(0, 16);
			this.l_Info.TabIndex = 1;
			// 
			// b_Result
			// 
			this.b_Result.Location = new System.Drawing.Point(291, 58);
			this.b_Result.Name = "b_Result";
			this.b_Result.Size = new System.Drawing.Size(85, 23);
			this.b_Result.TabIndex = 14;
			this.b_Result.Text = "Расчитать";
			this.b_Result.UseVisualStyleBackColor = true;
			this.b_Result.Click += new System.EventHandler(this.b_Result_Click);
			// 
			// b_clear
			// 
			this.b_clear.Location = new System.Drawing.Point(291, 12);
			this.b_clear.Name = "b_clear";
			this.b_clear.Size = new System.Drawing.Size(85, 23);
			this.b_clear.TabIndex = 15;
			this.b_clear.Text = "Очистить";
			this.b_clear.UseVisualStyleBackColor = true;
			this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
			// 
			// nud_Prefix
			// 
			this.nud_Prefix.Location = new System.Drawing.Point(212, 58);
			this.nud_Prefix.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.nud_Prefix.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_Prefix.Name = "nud_Prefix";
			this.nud_Prefix.Size = new System.Drawing.Size(53, 22);
			this.nud_Prefix.TabIndex = 19;
			this.nud_Prefix.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_Prefix.ValueChanged += new System.EventHandler(this.nud_Prefix_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(194, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 16);
			this.label1.TabIndex = 23;
			this.label1.Text = "/";
			// 
			// iac_Mask
			// 
			this.iac_Mask.BackColor = System.Drawing.SystemColors.Window;
			this.iac_Mask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.iac_Mask.FirstMax = 255;
			this.iac_Mask.FirstMin = 128;
			this.iac_Mask.FourdMax = 255;
			this.iac_Mask.FourdMin = 0;
			this.iac_Mask.Location = new System.Drawing.Point(12, 58);
			this.iac_Mask.Name = "iac_Mask";
			this.iac_Mask.SecondMax = 255;
			this.iac_Mask.SecondMin = 0;
			this.iac_Mask.Size = new System.Drawing.Size(180, 25);
			this.iac_Mask.TabIndex = 22;
			this.iac_Mask.TextIP = "...";
			this.iac_Mask.ThirdMax = 255;
			this.iac_Mask.ThirdMin = 0;
			this.iac_Mask.IPChanched += new IP_addressInfo.EventHandler(this.iac_Mask_IPChanched);
			// 
			// iac_IPAddress
			// 
			this.iac_IPAddress.BackColor = System.Drawing.SystemColors.Window;
			this.iac_IPAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.iac_IPAddress.FirstMax = 255;
			this.iac_IPAddress.FirstMin = 0;
			this.iac_IPAddress.FourdMax = 255;
			this.iac_IPAddress.FourdMin = 0;
			this.iac_IPAddress.Location = new System.Drawing.Point(12, 12);
			this.iac_IPAddress.Name = "iac_IPAddress";
			this.iac_IPAddress.SecondMax = 255;
			this.iac_IPAddress.SecondMin = 0;
			this.iac_IPAddress.Size = new System.Drawing.Size(180, 25);
			this.iac_IPAddress.TabIndex = 21;
			this.iac_IPAddress.TextIP = "...";
			this.iac_IPAddress.ThirdMax = 255;
			this.iac_IPAddress.ThirdMin = 0;
			this.iac_IPAddress.IPChanched += new IP_addressInfo.EventHandler(this.iac_IPAddress_IPChanched);
			// 
			// b_IPTest
			// 
			this.b_IPTest.Location = new System.Drawing.Point(291, 98);
			this.b_IPTest.Name = "b_IPTest";
			this.b_IPTest.Size = new System.Drawing.Size(85, 23);
			this.b_IPTest.TabIndex = 24;
			this.b_IPTest.Text = "IP Test";
			this.b_IPTest.UseVisualStyleBackColor = true;
			this.b_IPTest.Click += new System.EventHandler(this.b_IPTest_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 302);
			this.Controls.Add(this.b_IPTest);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.iac_Mask);
			this.Controls.Add(this.iac_IPAddress);
			this.Controls.Add(this.nud_Prefix);
			this.Controls.Add(this.b_clear);
			this.Controls.Add(this.b_Result);
			this.Controls.Add(this.l_Info);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.nud_Prefix)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label l_Info;
		private System.Windows.Forms.Button b_Result;
		private System.Windows.Forms.Button b_clear;
		private System.Windows.Forms.NumericUpDown nud_Prefix;
		private IPAddressControl iac_IPAddress;
		private IPAddressControl iac_Mask;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button b_IPTest;
	}
}


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
			this.tb_OneNum = new System.Windows.Forms.TextBox();
			this.tb_TwoNum = new System.Windows.Forms.TextBox();
			this.tb_TreeNum = new System.Windows.Forms.TextBox();
			this.tb_FourNum = new System.Windows.Forms.TextBox();
			this.tb_MaskNum = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.b_Result = new System.Windows.Forms.Button();
			this.b_clear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// l_Info
			// 
			this.l_Info.AutoSize = true;
			this.l_Info.Location = new System.Drawing.Point(12, 93);
			this.l_Info.Name = "l_Info";
			this.l_Info.Size = new System.Drawing.Size(0, 16);
			this.l_Info.TabIndex = 1;
			// 
			// tb_OneNum
			// 
			this.tb_OneNum.Location = new System.Drawing.Point(28, 13);
			this.tb_OneNum.MaxLength = 3;
			this.tb_OneNum.Name = "tb_OneNum";
			this.tb_OneNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tb_OneNum.Size = new System.Drawing.Size(53, 22);
			this.tb_OneNum.TabIndex = 2;
			this.tb_OneNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tb_OneNum.TextChanged += new System.EventHandler(this.tb_FirstNum_TextChanged);
			this.tb_OneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
			// 
			// tb_TwoNum
			// 
			this.tb_TwoNum.Location = new System.Drawing.Point(101, 13);
			this.tb_TwoNum.MaxLength = 3;
			this.tb_TwoNum.Name = "tb_TwoNum";
			this.tb_TwoNum.Size = new System.Drawing.Size(53, 22);
			this.tb_TwoNum.TabIndex = 6;
			this.tb_TwoNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tb_TwoNum.TextChanged += new System.EventHandler(this.tb_TwoNum_TextChanged);
			this.tb_TwoNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
			// 
			// tb_TreeNum
			// 
			this.tb_TreeNum.Location = new System.Drawing.Point(177, 13);
			this.tb_TreeNum.MaxLength = 3;
			this.tb_TreeNum.Name = "tb_TreeNum";
			this.tb_TreeNum.Size = new System.Drawing.Size(50, 22);
			this.tb_TreeNum.TabIndex = 7;
			this.tb_TreeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tb_TreeNum.TextChanged += new System.EventHandler(this.tb_TreeNum_TextChanged);
			this.tb_TreeNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
			// 
			// tb_FourNum
			// 
			this.tb_FourNum.Location = new System.Drawing.Point(247, 13);
			this.tb_FourNum.MaxLength = 3;
			this.tb_FourNum.Name = "tb_FourNum";
			this.tb_FourNum.Size = new System.Drawing.Size(53, 22);
			this.tb_FourNum.TabIndex = 8;
			this.tb_FourNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tb_FourNum.TextChanged += new System.EventHandler(this.tb_FourNum_TextChanged);
			this.tb_FourNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
			// 
			// tb_MaskNum
			// 
			this.tb_MaskNum.Location = new System.Drawing.Point(321, 13);
			this.tb_MaskNum.MaxLength = 2;
			this.tb_MaskNum.Name = "tb_MaskNum";
			this.tb_MaskNum.Size = new System.Drawing.Size(40, 22);
			this.tb_MaskNum.TabIndex = 9;
			this.tb_MaskNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tb_MaskNum.TextChanged += new System.EventHandler(this.tb_MaskNum_TextChanged);
			this.tb_MaskNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(84, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = ".";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(157, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = ".";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(230, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = ".";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(303, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(15, 20);
			this.label5.TabIndex = 13;
			this.label5.Text = "/";
			// 
			// b_Result
			// 
			this.b_Result.Location = new System.Drawing.Point(28, 51);
			this.b_Result.Name = "b_Result";
			this.b_Result.Size = new System.Drawing.Size(85, 23);
			this.b_Result.TabIndex = 14;
			this.b_Result.Text = "Расчитать";
			this.b_Result.UseVisualStyleBackColor = true;
			this.b_Result.Click += new System.EventHandler(this.b_Result_Click);
			// 
			// b_clear
			// 
			this.b_clear.Location = new System.Drawing.Point(269, 51);
			this.b_clear.Name = "b_clear";
			this.b_clear.Size = new System.Drawing.Size(92, 23);
			this.b_clear.TabIndex = 15;
			this.b_clear.Text = "Очистить";
			this.b_clear.UseVisualStyleBackColor = true;
			this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 302);
			this.Controls.Add(this.b_clear);
			this.Controls.Add(this.b_Result);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_MaskNum);
			this.Controls.Add(this.tb_FourNum);
			this.Controls.Add(this.tb_TreeNum);
			this.Controls.Add(this.tb_TwoNum);
			this.Controls.Add(this.tb_OneNum);
			this.Controls.Add(this.l_Info);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label l_Info;
		private System.Windows.Forms.TextBox tb_OneNum;
		private System.Windows.Forms.TextBox tb_TwoNum;
		private System.Windows.Forms.TextBox tb_TreeNum;
		private System.Windows.Forms.TextBox tb_FourNum;
		private System.Windows.Forms.TextBox tb_MaskNum;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button b_Result;
		private System.Windows.Forms.Button b_clear;
	}
}


namespace IP_addressInfo
{
	partial class PingTest
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
			this.components = new System.ComponentModel.Container();
			this.lv_HostList = new System.Windows.Forms.ListView();
			this.ch_HostIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_HostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_PacketsSend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_PacketsReceived = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_PacketsLostPercent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tb_URL = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.b_AddHost = new System.Windows.Forms.Button();
			this.b_DeleteHost = new System.Windows.Forms.Button();
			this.t_Refresh = new System.Windows.Forms.Timer(this.components);
			this.ch_PacketsLost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.iac_IP = new IP_addressInfo.IPAddressControl();
			this.SuspendLayout();
			// 
			// lv_HostList
			// 
			this.lv_HostList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_HostList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_HostIP,
            this.ch_HostName,
            this.ch_Time,
            this.ch_PacketsSend,
            this.ch_PacketsReceived,
            this.ch_PacketsLost,
            this.ch_PacketsLostPercent});
			this.lv_HostList.FullRowSelect = true;
			this.lv_HostList.HideSelection = false;
			this.lv_HostList.Location = new System.Drawing.Point(12, 74);
			this.lv_HostList.Name = "lv_HostList";
			this.lv_HostList.Size = new System.Drawing.Size(998, 364);
			this.lv_HostList.TabIndex = 0;
			this.lv_HostList.UseCompatibleStateImageBehavior = false;
			this.lv_HostList.View = System.Windows.Forms.View.Details;
			// 
			// ch_HostIP
			// 
			this.ch_HostIP.Text = "Host IP";
			this.ch_HostIP.Width = 106;
			// 
			// ch_HostName
			// 
			this.ch_HostName.Text = "Host Name";
			this.ch_HostName.Width = 160;
			// 
			// ch_Time
			// 
			this.ch_Time.Text = "Time(ms)";
			this.ch_Time.Width = 95;
			// 
			// ch_PacketsSend
			// 
			this.ch_PacketsSend.Text = "Packets Send";
			this.ch_PacketsSend.Width = 106;
			// 
			// ch_PacketsReceived
			// 
			this.ch_PacketsReceived.Text = "Packets Received";
			this.ch_PacketsReceived.Width = 131;
			// 
			// ch_PacketsLostPercent
			// 
			this.ch_PacketsLostPercent.Text = "Packets Lost Percent";
			this.ch_PacketsLostPercent.Width = 147;
			// 
			// tb_URL
			// 
			this.tb_URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_URL.Location = new System.Drawing.Point(211, 30);
			this.tb_URL.Name = "tb_URL";
			this.tb_URL.Size = new System.Drawing.Size(637, 22);
			this.tb_URL.TabIndex = 2;
			this.tb_URL.Enter += new System.EventHandler(this.tb_URL_Enter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "IP";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(208, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "URL";
			// 
			// b_AddHost
			// 
			this.b_AddHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.b_AddHost.Location = new System.Drawing.Point(854, 29);
			this.b_AddHost.Name = "b_AddHost";
			this.b_AddHost.Size = new System.Drawing.Size(75, 23);
			this.b_AddHost.TabIndex = 5;
			this.b_AddHost.Text = "Add";
			this.b_AddHost.UseVisualStyleBackColor = true;
			this.b_AddHost.Click += new System.EventHandler(this.b_AddHost_Click);
			// 
			// b_DeleteHost
			// 
			this.b_DeleteHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.b_DeleteHost.Location = new System.Drawing.Point(935, 29);
			this.b_DeleteHost.Name = "b_DeleteHost";
			this.b_DeleteHost.Size = new System.Drawing.Size(75, 23);
			this.b_DeleteHost.TabIndex = 6;
			this.b_DeleteHost.Text = "Delete";
			this.b_DeleteHost.UseVisualStyleBackColor = true;
			this.b_DeleteHost.Click += new System.EventHandler(this.b_DeleteHost_Click);
			// 
			// t_Refresh
			// 
			this.t_Refresh.Interval = 1000;
			this.t_Refresh.Tick += new System.EventHandler(this.t_Refresh_Tick);
			// 
			// ch_PacketsLost
			// 
			this.ch_PacketsLost.Text = "Packets Lost";
			this.ch_PacketsLost.Width = 91;
			// 
			// iac_IP
			// 
			this.iac_IP.BackColor = System.Drawing.SystemColors.Window;
			this.iac_IP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.iac_IP.FirstMax = 255;
			this.iac_IP.FirstMin = 0;
			this.iac_IP.FourdMax = 255;
			this.iac_IP.FourdMin = 0;
			this.iac_IP.Location = new System.Drawing.Point(15, 27);
			this.iac_IP.Name = "iac_IP";
			this.iac_IP.SecondMax = 255;
			this.iac_IP.SecondMin = 0;
			this.iac_IP.Size = new System.Drawing.Size(180, 25);
			this.iac_IP.TabIndex = 1;
			this.iac_IP.TextIP = "...";
			this.iac_IP.ThirdMax = 255;
			this.iac_IP.ThirdMin = 0;
			this.iac_IP.Enter += new System.EventHandler(this.iac_IP_Enter);
			// 
			// PingTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1022, 450);
			this.Controls.Add(this.b_DeleteHost);
			this.Controls.Add(this.b_AddHost);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_URL);
			this.Controls.Add(this.iac_IP);
			this.Controls.Add(this.lv_HostList);
			this.Name = "PingTest";
			this.Text = "PingTest";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PingTest_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lv_HostList;
		private IPAddressControl iac_IP;
		private System.Windows.Forms.TextBox tb_URL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button b_AddHost;
		private System.Windows.Forms.Button b_DeleteHost;
		private System.Windows.Forms.ColumnHeader ch_HostIP;
		private System.Windows.Forms.ColumnHeader ch_HostName;
		private System.Windows.Forms.ColumnHeader ch_Time;
		private System.Windows.Forms.ColumnHeader ch_PacketsSend;
		private System.Windows.Forms.ColumnHeader ch_PacketsReceived;
		private System.Windows.Forms.ColumnHeader ch_PacketsLostPercent;
		private System.Windows.Forms.Timer t_Refresh;
		private System.Windows.Forms.ColumnHeader ch_PacketsLost;
	}
}
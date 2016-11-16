﻿namespace NToolbox.Windows
{
	partial class MainWindow
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
			this.panel1 = new NCore.UI.BorderedPanel();
			this.panel2 = new NCore.UI.BorderedPanel();
			this.MyEvicConfigurationButton = new NCore.UI.ExtendedButton();
			this.DeviceMonitorButton = new NCore.UI.ExtendedButton();
			this.ArcticFoxConfigurationButton = new NCore.UI.ExtendedButton();
			this.FirmwareUpdaterButton = new NCore.UI.ExtendedButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderBottom = false;
			this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
			this.panel1.BorderLeft = false;
			this.panel1.BorderRight = false;
			this.panel1.BorderTop = false;
			this.panel1.BorderWidth = 1F;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(240, 456);
			this.panel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderBottom = false;
			this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
			this.panel2.BorderLeft = false;
			this.panel2.BorderRight = false;
			this.panel2.BorderTop = false;
			this.panel2.BorderWidth = 1F;
			this.panel2.Controls.Add(this.MyEvicConfigurationButton);
			this.panel2.Controls.Add(this.DeviceMonitorButton);
			this.panel2.Controls.Add(this.ArcticFoxConfigurationButton);
			this.panel2.Controls.Add(this.FirmwareUpdaterButton);
			this.panel2.Location = new System.Drawing.Point(0, 214);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(240, 242);
			this.panel2.TabIndex = 4;
			// 
			// MyEvicConfigurationButton
			// 
			this.MyEvicConfigurationButton.AdditionalText = "";
			this.MyEvicConfigurationButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.MyEvicConfigurationButton.Image = global::NToolbox.Properties.Resources.configuration;
			this.MyEvicConfigurationButton.Location = new System.Drawing.Point(10, 64);
			this.MyEvicConfigurationButton.Name = "MyEvicConfigurationButton";
			this.MyEvicConfigurationButton.Size = new System.Drawing.Size(220, 52);
			this.MyEvicConfigurationButton.TabIndex = 1;
			this.MyEvicConfigurationButton.Text = "myEvic Configuration";
			// 
			// DeviceMonitorButton
			// 
			this.DeviceMonitorButton.AdditionalText = "";
			this.DeviceMonitorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.DeviceMonitorButton.Image = global::NToolbox.Properties.Resources.device_monitor;
			this.DeviceMonitorButton.Location = new System.Drawing.Point(10, 122);
			this.DeviceMonitorButton.Name = "DeviceMonitorButton";
			this.DeviceMonitorButton.Size = new System.Drawing.Size(220, 52);
			this.DeviceMonitorButton.TabIndex = 2;
			this.DeviceMonitorButton.Text = "Device Monitor";
			// 
			// ArcticFoxConfigurationButton
			// 
			this.ArcticFoxConfigurationButton.AdditionalText = "";
			this.ArcticFoxConfigurationButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ArcticFoxConfigurationButton.Image = global::NToolbox.Properties.Resources.arctic_fox;
			this.ArcticFoxConfigurationButton.Location = new System.Drawing.Point(10, 6);
			this.ArcticFoxConfigurationButton.Name = "ArcticFoxConfigurationButton";
			this.ArcticFoxConfigurationButton.Size = new System.Drawing.Size(220, 52);
			this.ArcticFoxConfigurationButton.TabIndex = 0;
			this.ArcticFoxConfigurationButton.Text = "Arctic Fox Configuration";
			// 
			// FirmwareUpdaterButton
			// 
			this.FirmwareUpdaterButton.AdditionalText = "";
			this.FirmwareUpdaterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.FirmwareUpdaterButton.Image = global::NToolbox.Properties.Resources.firmware_updater;
			this.FirmwareUpdaterButton.Location = new System.Drawing.Point(10, 180);
			this.FirmwareUpdaterButton.Name = "FirmwareUpdaterButton";
			this.FirmwareUpdaterButton.Size = new System.Drawing.Size(220, 52);
			this.FirmwareUpdaterButton.TabIndex = 3;
			this.FirmwareUpdaterButton.Text = "Firmware Updater";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox1.BackgroundImage = global::NToolbox.Properties.Resources.nfetoolbox;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Location = new System.Drawing.Point(28, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(184, 205);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(240, 456);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NFE Toolbox";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private NCore.UI.ExtendedButton ArcticFoxConfigurationButton;
		private NCore.UI.ExtendedButton MyEvicConfigurationButton;
		private NCore.UI.ExtendedButton DeviceMonitorButton;
		private NCore.UI.ExtendedButton FirmwareUpdaterButton;
		private NCore.UI.BorderedPanel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private NCore.UI.BorderedPanel panel2;
	}
}

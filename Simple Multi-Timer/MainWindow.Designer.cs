﻿namespace Simple_Multi_Timer
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
            components = new System.ComponentModel.Container();
            Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            topPanel = new Panel();
            addTimerButton = new Button();
            timersContainerPanel = new FlowLayoutPanel();
            trayIcon = new NotifyIcon(components);
            nameLabel = new Label();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(0, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(241, 37);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Simple Multi Timer";
            // 
            // topPanel
            // 
            topPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topPanel.Controls.Add(nameLabel);
            topPanel.Controls.Add(addTimerButton);
            topPanel.Location = new Point(12, 12);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(472, 40);
            topPanel.TabIndex = 0;
            // 
            // addTimerButton
            // 
            addTimerButton.Anchor = AnchorStyles.Right;
            addTimerButton.BackColor = Color.FromArgb(128, 255, 128);
            addTimerButton.FlatAppearance.BorderSize = 0;
            addTimerButton.FlatStyle = FlatStyle.Flat;
            addTimerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addTimerButton.Image = Properties.Resources.plus;
            addTimerButton.Location = new Point(435, 3);
            addTimerButton.Name = "addTimerButton";
            addTimerButton.Size = new Size(34, 34);
            addTimerButton.TabIndex = 1;
            addTimerButton.UseVisualStyleBackColor = false;
            addTimerButton.Click += addTimerButton_Click;
            // 
            // timersContainerPanel
            // 
            timersContainerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            timersContainerPanel.AutoScroll = true;
            timersContainerPanel.Location = new Point(12, 58);
            timersContainerPanel.Name = "timersContainerPanel";
            timersContainerPanel.Size = new Size(472, 531);
            timersContainerPanel.TabIndex = 1;
            // 
            // trayIcon
            // 
            trayIcon.Icon = Properties.Resources.icon;
            trayIcon.Text = "Simple Multi Timer";
            trayIcon.Click += trayIcon_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 32, 40);
            ClientSize = new Size(496, 601);
            Controls.Add(timersContainerPanel);
            Controls.Add(topPanel);
            MaximumSize = new Size(512, 640);
            MinimumSize = new Size(512, 640);
            Name = "MainWindow";
            Text = "Simple Multi Timer";
            Resize += MainWindow_Resize;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Button addTimerButton;
        private FlowLayoutPanel timersContainerPanel;
        private NotifyIcon trayIcon;
    }
}
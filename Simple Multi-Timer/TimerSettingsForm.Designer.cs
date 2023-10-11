namespace Simple_Multi_Timer
{
    partial class TimerSettingsForm
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
            Label timerNameLabel;
            Label hoursLabel;
            Label minutesLabel;
            Label secondsLabel;
            Label nameLabel;
            timerNameTextBox = new TextBox();
            hoursUpDown = new NumericUpDown();
            minutesUpDown = new NumericUpDown();
            secondsUpDown = new NumericUpDown();
            saveButton = new Button();
            CancelButton = new Button();
            errorLabel = new Label();
            timerNameLabel = new Label();
            hoursLabel = new Label();
            minutesLabel = new Label();
            secondsLabel = new Label();
            nameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)hoursUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minutesUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondsUpDown).BeginInit();
            SuspendLayout();
            // 
            // timerNameLabel
            // 
            timerNameLabel.AutoSize = true;
            timerNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            timerNameLabel.ForeColor = Color.White;
            timerNameLabel.Location = new Point(12, 57);
            timerNameLabel.Name = "timerNameLabel";
            timerNameLabel.Size = new Size(112, 25);
            timerNameLabel.TabIndex = 0;
            timerNameLabel.Text = "Timer name";
            // 
            // hoursLabel
            // 
            hoursLabel.AutoSize = true;
            hoursLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            hoursLabel.ForeColor = Color.White;
            hoursLabel.Location = new Point(12, 95);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new Size(62, 25);
            hoursLabel.TabIndex = 1;
            hoursLabel.Text = "Hours";
            // 
            // minutesLabel
            // 
            minutesLabel.AutoSize = true;
            minutesLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            minutesLabel.ForeColor = Color.White;
            minutesLabel.Location = new Point(12, 134);
            minutesLabel.Name = "minutesLabel";
            minutesLabel.Size = new Size(86, 25);
            minutesLabel.TabIndex = 2;
            minutesLabel.Text = "Munutes";
            // 
            // secondsLabel
            // 
            secondsLabel.AutoSize = true;
            secondsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            secondsLabel.ForeColor = Color.White;
            secondsLabel.Location = new Point(12, 173);
            secondsLabel.Name = "secondsLabel";
            secondsLabel.Size = new Size(82, 25);
            secondsLabel.TabIndex = 3;
            secondsLabel.Text = "Seconds";
            // 
            // timerNameTextBox
            // 
            timerNameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            timerNameTextBox.Location = new Point(132, 54);
            timerNameTextBox.Name = "timerNameTextBox";
            timerNameTextBox.Size = new Size(224, 33);
            timerNameTextBox.TabIndex = 4;
            // 
            // hoursUpDown
            // 
            hoursUpDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            hoursUpDown.Location = new Point(132, 93);
            hoursUpDown.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            hoursUpDown.Name = "hoursUpDown";
            hoursUpDown.Size = new Size(120, 33);
            hoursUpDown.TabIndex = 5;
            // 
            // minutesUpDown
            // 
            minutesUpDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            minutesUpDown.Location = new Point(132, 132);
            minutesUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minutesUpDown.Name = "minutesUpDown";
            minutesUpDown.Size = new Size(120, 33);
            minutesUpDown.TabIndex = 6;
            // 
            // secondsUpDown
            // 
            secondsUpDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            secondsUpDown.Location = new Point(132, 171);
            secondsUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            secondsUpDown.Name = "secondsUpDown";
            secondsUpDown.Size = new Size(120, 33);
            secondsUpDown.TabIndex = 7;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(183, 37);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Timer settings";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            saveButton.AutoSize = true;
            saveButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(12, 234);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(88, 35);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.AutoSize = true;
            CancelButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.Location = new Point(268, 234);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(88, 35);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            errorLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.FromArgb(255, 128, 128);
            errorLabel.Location = new Point(12, 206);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(100, 25);
            errorLabel.TabIndex = 11;
            errorLabel.Text = "Error label";
            // 
            // TimerEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 32, 40);
            ClientSize = new Size(368, 281);
            Controls.Add(errorLabel);
            Controls.Add(CancelButton);
            Controls.Add(saveButton);
            Controls.Add(nameLabel);
            Controls.Add(secondsUpDown);
            Controls.Add(minutesUpDown);
            Controls.Add(hoursUpDown);
            Controls.Add(timerNameTextBox);
            Controls.Add(secondsLabel);
            Controls.Add(minutesLabel);
            Controls.Add(hoursLabel);
            Controls.Add(timerNameLabel);
            Name = "TimerEditorForm";
            Text = "Timer settings";
            ((System.ComponentModel.ISupportInitialize)hoursUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)minutesUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondsUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timerNameLabel;
        private Label hoursLabel;
        private Label minutesLabel;
        private Label secondsLabel;
        private TextBox timerNameTextBox;
        private NumericUpDown hoursUpDown;
        private NumericUpDown minutesUpDown;
        private NumericUpDown secondsUpDown;
        private Button saveButton;
        private Button CancelButton;
        private Label errorLabel;
    }
}
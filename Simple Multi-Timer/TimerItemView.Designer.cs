namespace Simple_Multi_Timer
{
    partial class TimerItemView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            timerTimeLabel = new Label();
            timerNameLabel = new Label();
            PauseResumeButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            ResetButton = new Button();
            SuspendLayout();
            // 
            // timerTimeLabel
            // 
            timerTimeLabel.AutoSize = true;
            timerTimeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            timerTimeLabel.ForeColor = Color.White;
            timerTimeLabel.Location = new Point(42, 30);
            timerTimeLabel.Name = "timerTimeLabel";
            timerTimeLabel.Size = new Size(119, 37);
            timerTimeLabel.TabIndex = 9;
            timerTimeLabel.Text = "00:00:00";
            // 
            // timerNameLabel
            // 
            timerNameLabel.AutoSize = true;
            timerNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            timerNameLabel.ForeColor = Color.White;
            timerNameLabel.Location = new Point(3, 0);
            timerNameLabel.Name = "timerNameLabel";
            timerNameLabel.Size = new Size(112, 25);
            timerNameLabel.TabIndex = 1;
            timerNameLabel.Text = "Timer name";
            // 
            // PauseResumeButton
            // 
            PauseResumeButton.AutoSize = true;
            PauseResumeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PauseResumeButton.BackColor = Color.FromArgb(128, 255, 128);
            PauseResumeButton.FlatStyle = FlatStyle.Flat;
            PauseResumeButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PauseResumeButton.Image = Properties.Resources.play;
            PauseResumeButton.Location = new Point(3, 30);
            PauseResumeButton.Name = "PauseResumeButton";
            PauseResumeButton.Size = new Size(32, 32);
            PauseResumeButton.TabIndex = 2;
            PauseResumeButton.UseVisualStyleBackColor = false;
            PauseResumeButton.Click += PauseResumeButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteButton.AutoSize = true;
            DeleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeleteButton.BackColor = Color.FromArgb(255, 128, 128);
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Image = Properties.Resources.trash;
            DeleteButton.Location = new Point(431, 30);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(32, 32);
            DeleteButton.TabIndex = 10;
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditButton.AutoSize = true;
            EditButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditButton.BackColor = Color.FromArgb(128, 255, 128);
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Image = Properties.Resources.pencil;
            EditButton.Location = new Point(393, 30);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(32, 32);
            EditButton.TabIndex = 11;
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ResetButton.AutoSize = true;
            ResetButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ResetButton.BackColor = Color.FromArgb(128, 255, 128);
            ResetButton.FlatStyle = FlatStyle.Flat;
            ResetButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ResetButton.Image = Properties.Resources.reset;
            ResetButton.Location = new Point(355, 30);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(32, 32);
            ResetButton.TabIndex = 12;
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // TimerItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(38, 32, 40);
            Controls.Add(ResetButton);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(timerTimeLabel);
            Controls.Add(PauseResumeButton);
            Controls.Add(timerNameLabel);
            Name = "TimerItemView";
            Size = new Size(466, 67);
            Paint += TimerItemView_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PauseResumeButton;
        private Label timerNameLabel;
        private Button DeleteButton;
        private Button EditButton;
        private Button ResetButton;
        private Label timerTimeLabel;
    }
}

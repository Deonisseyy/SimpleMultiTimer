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
            PauseResumeButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PauseResumeButton.Location = new Point(3, 35);
            PauseResumeButton.Name = "PauseResumeButton";
            PauseResumeButton.Size = new Size(33, 35);
            PauseResumeButton.TabIndex = 2;
            PauseResumeButton.Text = "R";
            PauseResumeButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteButton.AutoSize = true;
            DeleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeleteButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(346, 30);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(35, 35);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "D";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditButton.AutoSize = true;
            EditButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(308, 30);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(32, 35);
            EditButton.TabIndex = 11;
            EditButton.Text = "E";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            ResetButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ResetButton.AutoSize = true;
            ResetButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ResetButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ResetButton.Location = new Point(269, 30);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(33, 35);
            ResetButton.TabIndex = 12;
            ResetButton.Text = "R";
            ResetButton.UseVisualStyleBackColor = true;
            // 
            // TimerItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(38, 32, 40);
            Controls.Add(ResetButton);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(timerTimeLabel);
            Controls.Add(PauseResumeButton);
            Controls.Add(timerNameLabel);
            Name = "TimerItemView";
            Size = new Size(384, 84);
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

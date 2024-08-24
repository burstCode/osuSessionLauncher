namespace Configurator
{
    partial class ConfigureForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PathToOsu = new TextBox();
            lblPathToOsu = new Label();
            lblPathToOBS = new Label();
            PathToOBS = new TextBox();
            lblPathToSC = new Label();
            PathToSC = new TextBox();
            btnApply = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            btnPathToOsu = new Button();
            btnPathToOBS = new Button();
            btnPathToSC = new Button();
            SuspendLayout();
            // 
            // PathToOsu
            // 
            PathToOsu.Location = new Point(12, 86);
            PathToOsu.Name = "PathToOsu";
            PathToOsu.Size = new Size(321, 27);
            PathToOsu.TabIndex = 0;
            // 
            // lblPathToOsu
            // 
            lblPathToOsu.AutoSize = true;
            lblPathToOsu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPathToOsu.Location = new Point(12, 55);
            lblPathToOsu.Name = "lblPathToOsu";
            lblPathToOsu.Size = new Size(184, 28);
            lblPathToOsu.TabIndex = 1;
            lblPathToOsu.Text = "Путь к папке с osu!";
            // 
            // lblPathToOBS
            // 
            lblPathToOBS.AutoSize = true;
            lblPathToOBS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPathToOBS.Location = new Point(12, 139);
            lblPathToOBS.Name = "lblPathToOBS";
            lblPathToOBS.Size = new Size(184, 28);
            lblPathToOBS.TabIndex = 3;
            lblPathToOBS.Text = "Путь к папке с OBS";
            // 
            // PathToOBS
            // 
            PathToOBS.Location = new Point(12, 170);
            PathToOBS.Name = "PathToOBS";
            PathToOBS.Size = new Size(321, 27);
            PathToOBS.TabIndex = 2;
            // 
            // lblPathToSC
            // 
            lblPathToSC.AutoSize = true;
            lblPathToSC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPathToSC.Location = new Point(12, 223);
            lblPathToSC.Name = "lblPathToSC";
            lblPathToSC.Size = new Size(310, 28);
            lblPathToSC.TabIndex = 5;
            lblPathToSC.Text = "Путь к папке с StreamCompanion";
            // 
            // PathToSC
            // 
            PathToSC.Location = new Point(12, 255);
            PathToSC.Name = "PathToSC";
            PathToSC.Size = new Size(321, 27);
            PathToSC.TabIndex = 4;
            // 
            // btnApply
            // 
            btnApply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnApply.Location = new Point(201, 317);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(160, 40);
            btnApply.TabIndex = 6;
            btnApply.Text = "Применить";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCancel.Location = new Point(12, 317);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(7, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(165, 38);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Настройки";
            // 
            // btnPathToOsu
            // 
            btnPathToOsu.Location = new Point(334, 86);
            btnPathToOsu.Name = "btnPathToOsu";
            btnPathToOsu.Size = new Size(27, 27);
            btnPathToOsu.TabIndex = 9;
            btnPathToOsu.Text = "...";
            btnPathToOsu.UseVisualStyleBackColor = true;
            btnPathToOsu.Click += btnPathToOsu_Click;
            // 
            // btnPathToOBS
            // 
            btnPathToOBS.Location = new Point(334, 170);
            btnPathToOBS.Name = "btnPathToOBS";
            btnPathToOBS.Size = new Size(27, 27);
            btnPathToOBS.TabIndex = 10;
            btnPathToOBS.Text = "...";
            btnPathToOBS.UseVisualStyleBackColor = true;
            btnPathToOBS.Click += btnPathToOBS_Click;
            // 
            // btnPathToSC
            // 
            btnPathToSC.Location = new Point(334, 255);
            btnPathToSC.Name = "btnPathToSC";
            btnPathToSC.Size = new Size(27, 27);
            btnPathToSC.TabIndex = 11;
            btnPathToSC.Text = "...";
            btnPathToSC.UseVisualStyleBackColor = true;
            btnPathToSC.Click += btnPathToSC_Click;
            // 
            // ConfigureForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 387);
            Controls.Add(btnPathToSC);
            Controls.Add(btnPathToOBS);
            Controls.Add(btnPathToOsu);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(lblPathToSC);
            Controls.Add(PathToSC);
            Controls.Add(lblPathToOBS);
            Controls.Add(PathToOBS);
            Controls.Add(lblPathToOsu);
            Controls.Add(PathToOsu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ConfigureForm";
            Text = "osu! Session Configure";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        
        private Label lblPathToOsu;
        private TextBox PathToOsu;
        private Button btnPathToOsu;

        private Label lblPathToOBS;
        private TextBox PathToOBS;
        private Button btnPathToOBS;

        private Label lblPathToSC;
        private TextBox PathToSC; 
        private Button btnPathToSC;

        private Button btnApply;
        private Button btnCancel;
    }
}

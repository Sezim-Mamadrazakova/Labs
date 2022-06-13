namespace ProgrammerForm
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProgramer = new System.Windows.Forms.TextBox();
            this.textBoxProgramerChild = new System.Windows.Forms.TextBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonInfoChild = new System.Windows.Forms.Button();
            this.buttonQuallity = new System.Windows.Forms.Button();
            this.buttonQuallityChild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Программист";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Программист наследник";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxProgramer
            // 
            this.textBoxProgramer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProgramer.Location = new System.Drawing.Point(12, 65);
            this.textBoxProgramer.Multiline = true;
            this.textBoxProgramer.Name = "textBoxProgramer";
            this.textBoxProgramer.Size = new System.Drawing.Size(660, 51);
            this.textBoxProgramer.TabIndex = 2;
            // 
            // textBoxProgramerChild
            // 
            this.textBoxProgramerChild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProgramerChild.Location = new System.Drawing.Point(12, 190);
            this.textBoxProgramerChild.Multiline = true;
            this.textBoxProgramerChild.Name = "textBoxProgramerChild";
            this.textBoxProgramerChild.Size = new System.Drawing.Size(660, 53);
            this.textBoxProgramerChild.TabIndex = 3;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInfo.Location = new System.Drawing.Point(12, 275);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(288, 73);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.Text = "Вывести информацию о программисте";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonInfoChild
            // 
            this.buttonInfoChild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInfoChild.Location = new System.Drawing.Point(12, 365);
            this.buttonInfoChild.Name = "buttonInfoChild";
            this.buttonInfoChild.Size = new System.Drawing.Size(288, 73);
            this.buttonInfoChild.TabIndex = 5;
            this.buttonInfoChild.Text = "Вывести информацию о программисте наследнике";
            this.buttonInfoChild.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonInfoChild.UseVisualStyleBackColor = true;
            this.buttonInfoChild.Click += new System.EventHandler(this.buttonInfoChild_Click);
            // 
            // buttonQuallity
            // 
            this.buttonQuallity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonQuallity.Location = new System.Drawing.Point(384, 275);
            this.buttonQuallity.Name = "buttonQuallity";
            this.buttonQuallity.Size = new System.Drawing.Size(288, 73);
            this.buttonQuallity.TabIndex = 6;
            this.buttonQuallity.Text = "Рассчитать качество программиста";
            this.buttonQuallity.UseVisualStyleBackColor = true;
            this.buttonQuallity.Click += new System.EventHandler(this.buttonQuallity_Click);
            // 
            // buttonQuallityChild
            // 
            this.buttonQuallityChild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonQuallityChild.Location = new System.Drawing.Point(384, 365);
            this.buttonQuallityChild.Name = "buttonQuallityChild";
            this.buttonQuallityChild.Size = new System.Drawing.Size(288, 73);
            this.buttonQuallityChild.TabIndex = 7;
            this.buttonQuallityChild.Text = "Рассчитать качество программиста наследника";
            this.buttonQuallityChild.UseVisualStyleBackColor = true;
            this.buttonQuallityChild.Click += new System.EventHandler(this.buttonQuallityChild_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.buttonQuallityChild);
            this.Controls.Add(this.buttonQuallity);
            this.Controls.Add(this.buttonInfoChild);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.textBoxProgramerChild);
            this.Controls.Add(this.textBoxProgramer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxProgramer;
        private TextBox textBoxProgramerChild;
        private Button buttonInfo;
        private Button buttonInfoChild;
        private Button buttonQuallity;
        private Button buttonQuallityChild;
    }
}
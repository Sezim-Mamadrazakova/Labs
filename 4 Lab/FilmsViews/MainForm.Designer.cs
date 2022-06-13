namespace FilmsViews
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
            this.listBoxClass = new System.Windows.Forms.ListBox();
            this.listBoxMethod = new System.Windows.Forms.ListBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxClass
            // 
            this.listBoxClass.FormattingEnabled = true;
            this.listBoxClass.ItemHeight = 15;
            this.listBoxClass.Location = new System.Drawing.Point(12, 12);
            this.listBoxClass.Name = "listBoxClass";
            this.listBoxClass.Size = new System.Drawing.Size(324, 154);
            this.listBoxClass.TabIndex = 0;
            // 
            // listBoxMethod
            // 
            this.listBoxMethod.FormattingEnabled = true;
            this.listBoxMethod.ItemHeight = 15;
            this.listBoxMethod.Location = new System.Drawing.Point(12, 172);
            this.listBoxMethod.Name = "listBoxMethod";
            this.listBoxMethod.Size = new System.Drawing.Size(324, 124);
            this.listBoxMethod.TabIndex = 1;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(355, 33);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(144, 23);
            this.comboBoxClass.TabIndex = 2;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Location = new System.Drawing.Point(355, 84);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(144, 23);
            this.comboBoxMethod.TabIndex = 3;
            this.comboBoxMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethod_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите класс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(355, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите метод";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(355, 125);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(144, 41);
            this.buttonCreate.TabIndex = 6;
            this.buttonCreate.Text = "Создать экземпляр класса";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(355, 190);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(144, 41);
            this.buttonEnter.TabIndex = 7;
            this.buttonEnter.Text = "Вввод параметров метода\r\n";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(355, 255);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(144, 41);
            this.buttonExecute.TabIndex = 8;
            this.buttonExecute.Text = "Выполнить метод";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 311);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMethod);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.listBoxMethod);
            this.Controls.Add(this.listBoxClass);
            this.Name = "MainForm";
            this.Text = "4 лаба ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxClass;
        private ListBox listBoxMethod;
        private ComboBox comboBoxClass;
        private ComboBox comboBoxMethod;
        private Label label1;
        private Label label2;
        private Button buttonCreate;
        private Button buttonEnter;
        private Button buttonExecute;
    }
}
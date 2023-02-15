namespace WindowsFormsUnos
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
            this.txtBoxMarka = new System.Windows.Forms.TextBox();
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.txtBoxIspis = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnObrada = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.comboBoxVozilo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxMarka
            // 
            this.txtBoxMarka.Location = new System.Drawing.Point(175, 61);
            this.txtBoxMarka.Name = "txtBoxMarka";
            this.txtBoxMarka.Size = new System.Drawing.Size(133, 20);
            this.txtBoxMarka.TabIndex = 0;
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Location = new System.Drawing.Point(175, 124);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(133, 20);
            this.txtBoxModel.TabIndex = 1;
            // 
            // txtBoxIspis
            // 
            this.txtBoxIspis.Location = new System.Drawing.Point(515, 60);
            this.txtBoxIspis.Multiline = true;
            this.txtBoxIspis.Name = "txtBoxIspis";
            this.txtBoxIspis.Size = new System.Drawing.Size(284, 149);
            this.txtBoxIspis.TabIndex = 3;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(175, 255);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(133, 23);
            this.btnUnos.TabIndex = 4;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(515, 255);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(136, 23);
            this.btnObrada.TabIndex = 5;
            this.btnObrada.Text = "Obrada";
            this.btnObrada.UseVisualStyleBackColor = true;
            this.btnObrada.Click += new System.EventHandler(this.btnObrada_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(674, 254);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(125, 23);
            this.btnIspis.TabIndex = 6;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // comboBoxVozilo
            // 
            this.comboBoxVozilo.FormattingEnabled = true;
            this.comboBoxVozilo.Items.AddRange(new object[] {
            "Avion",
            "Automobil",
            "Brod"});
            this.comboBoxVozilo.Location = new System.Drawing.Point(175, 187);
            this.comboBoxVozilo.Name = "comboBoxVozilo";
            this.comboBoxVozilo.Size = new System.Drawing.Size(133, 21);
            this.comboBoxVozilo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Marka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vrsta vozila";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(938, 496);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxVozilo);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.txtBoxIspis);
            this.Controls.Add(this.txtBoxModel);
            this.Controls.Add(this.txtBoxMarka);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUnos;
        private System.Windows.Forms.ComboBox comboBoxVozila;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Button buttonIspis;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonObrada;
        private System.Windows.Forms.TextBox txtBoxMarka;
        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.TextBox txtBoxIspis;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnObrada;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.ComboBox comboBoxVozilo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


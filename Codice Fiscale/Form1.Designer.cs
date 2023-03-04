namespace Codice_Fiscale
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.txb_cognome = new System.Windows.Forms.TextBox();
            this.comboBox_comune_nascita = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbtn_maschio = new System.Windows.Forms.RadioButton();
            this.rbtn_femmina = new System.Windows.Forms.RadioButton();
            this.btn_calcola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comune di nascta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data di Nascita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sesso";
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(70, 75);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(100, 20);
            this.tbx_nome.TabIndex = 5;
            // 
            // txb_cognome
            // 
            this.txb_cognome.Location = new System.Drawing.Point(70, 141);
            this.txb_cognome.Name = "txb_cognome";
            this.txb_cognome.Size = new System.Drawing.Size(100, 20);
            this.txb_cognome.TabIndex = 6;
            // 
            // comboBox_comune_nascita
            // 
            this.comboBox_comune_nascita.FormattingEnabled = true;
            this.comboBox_comune_nascita.Location = new System.Drawing.Point(70, 209);
            this.comboBox_comune_nascita.Name = "comboBox_comune_nascita";
            this.comboBox_comune_nascita.Size = new System.Drawing.Size(121, 21);
            this.comboBox_comune_nascita.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 278);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // rbtn_maschio
            // 
            this.rbtn_maschio.AutoSize = true;
            this.rbtn_maschio.Location = new System.Drawing.Point(70, 345);
            this.rbtn_maschio.Name = "rbtn_maschio";
            this.rbtn_maschio.Size = new System.Drawing.Size(65, 17);
            this.rbtn_maschio.TabIndex = 9;
            this.rbtn_maschio.TabStop = true;
            this.rbtn_maschio.Text = "Maschio";
            this.rbtn_maschio.UseVisualStyleBackColor = true;
            // 
            // rbtn_femmina
            // 
            this.rbtn_femmina.AutoSize = true;
            this.rbtn_femmina.Location = new System.Drawing.Point(203, 345);
            this.rbtn_femmina.Name = "rbtn_femmina";
            this.rbtn_femmina.Size = new System.Drawing.Size(67, 17);
            this.rbtn_femmina.TabIndex = 10;
            this.rbtn_femmina.TabStop = true;
            this.rbtn_femmina.Text = "Femmina";
            this.rbtn_femmina.UseVisualStyleBackColor = true;
            // 
            // btn_calcola
            // 
            this.btn_calcola.Location = new System.Drawing.Point(568, 169);
            this.btn_calcola.Name = "btn_calcola";
            this.btn_calcola.Size = new System.Drawing.Size(159, 23);
            this.btn_calcola.TabIndex = 11;
            this.btn_calcola.Text = "Calcola Codice Fiscale";
            this.btn_calcola.UseVisualStyleBackColor = true;
            this.btn_calcola.Click += new System.EventHandler(this.btn_calcola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calcola);
            this.Controls.Add(this.rbtn_femmina);
            this.Controls.Add(this.rbtn_maschio);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox_comune_nascita);
            this.Controls.Add(this.txb_cognome);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.TextBox txb_cognome;
        private System.Windows.Forms.ComboBox comboBox_comune_nascita;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbtn_maschio;
        private System.Windows.Forms.RadioButton rbtn_femmina;
        private System.Windows.Forms.Button btn_calcola;
    }
}


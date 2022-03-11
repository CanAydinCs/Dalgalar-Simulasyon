namespace Su_Dalgaları
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhiz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numBoy = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.numPer = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFrekans = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numBoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dalganın Hızı:";
            // 
            // lblhiz
            // 
            this.lblhiz.AutoSize = true;
            this.lblhiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblhiz.Location = new System.Drawing.Point(138, 9);
            this.lblhiz.Name = "lblhiz";
            this.lblhiz.Size = new System.Drawing.Size(20, 22);
            this.lblhiz.TabIndex = 1;
            this.lblhiz.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(209, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dalganın Boyu:";
            // 
            // numBoy
            // 
            this.numBoy.Location = new System.Drawing.Point(336, 9);
            this.numBoy.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numBoy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBoy.Name = "numBoy";
            this.numBoy.Size = new System.Drawing.Size(120, 20);
            this.numBoy.TabIndex = 3;
            this.numBoy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBoy.ValueChanged += new System.EventHandler(this.NumBoy_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // numPer
            // 
            this.numPer.Location = new System.Drawing.Point(641, 9);
            this.numPer.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPer.Name = "numPer";
            this.numPer.Size = new System.Drawing.Size(120, 20);
            this.numPer.TabIndex = 6;
            this.numPer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPer.ValueChanged += new System.EventHandler(this.NumPer_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(473, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dalganın Periyodu:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(16, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 161);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(41, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kaynak";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(170, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 336);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(473, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dalganın Frekansı:";
            // 
            // lblFrekans
            // 
            this.lblFrekans.AutoSize = true;
            this.lblFrekans.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblFrekans.Location = new System.Drawing.Point(628, 50);
            this.lblFrekans.Name = "lblFrekans";
            this.lblFrekans.Size = new System.Drawing.Size(20, 22);
            this.lblFrekans.TabIndex = 11;
            this.lblFrekans.Text = "1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFrekans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numPer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numBoy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblhiz);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numBoy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numPer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFrekans;
        private System.Windows.Forms.Timer timer1;
    }
}


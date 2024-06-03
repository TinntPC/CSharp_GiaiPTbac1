namespace CSharp_Phuongtrinhbac1
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
            this.lbla = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.lblb = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnGiaiPT = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ỨNG DỤNG GIẢI PHƯƠNG TRÌNH BẬC 1: ax + b = 0 ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(100, 138);
            this.lbla.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(77, 23);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "Nhập a ";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(240, 138);
            this.txta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(361, 30);
            this.txta.TabIndex = 3;
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(97, 228);
            this.lblb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(72, 23);
            this.lblb.TabIndex = 4;
            this.lblb.Text = "Nhập b";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(240, 221);
            this.txtb.Margin = new System.Windows.Forms.Padding(5);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(361, 30);
            this.txtb.TabIndex = 5;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(236, 312);
            this.lblKQ.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(81, 23);
            this.lblKQ.TabIndex = 6;
            this.lblKQ.Text = "Kết quả ";
            // 
            // btnGiaiPT
            // 
            this.btnGiaiPT.Location = new System.Drawing.Point(240, 375);
            this.btnGiaiPT.Name = "btnGiaiPT";
            this.btnGiaiPT.Size = new System.Drawing.Size(361, 85);
            this.btnGiaiPT.TabIndex = 7;
            this.btnGiaiPT.Text = "GIẢI PHƯƠNG TRÌNH";
            this.btnGiaiPT.UseVisualStyleBackColor = true;
            this.btnGiaiPT.Click += new System.EventHandler(this.btnGiaiPT_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(637, 138);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(378, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(637, 221);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(378, 45);
            this.trackBar2.TabIndex = 9;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 796);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnGiaiPT);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "ỨNG DỤNG GIẢI PHƯƠNG TRÌNH BẬC 1: ax + b = 0 ";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnGiaiPT;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}


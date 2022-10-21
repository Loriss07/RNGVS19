
namespace RNG_Client
{
    partial class Form1
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxNumber = new System.Windows.Forms.NumericUpDown();
            this.IPBar = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.Num = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(12, 12);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(89, 48);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "Connetti";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Enabled = false;
            this.BtnDisconnect.Location = new System.Drawing.Point(12, 281);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(89, 37);
            this.BtnDisconnect.TabIndex = 1;
            this.BtnDisconnect.Text = "Disconnetti";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(39, 103);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(78, 23);
            this.numAmount.TabIndex = 2;
            this.numAmount.ValueChanged += new System.EventHandler(this.Numbers_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numeri da estrarre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero massimo";
            // 
            // maxNumber
            // 
            this.maxNumber.Location = new System.Drawing.Point(39, 157);
            this.maxNumber.Name = "maxNumber";
            this.maxNumber.Size = new System.Drawing.Size(78, 23);
            this.maxNumber.TabIndex = 4;
            this.maxNumber.ValueChanged += new System.EventHandler(this.maxNumber_ValueChanged);
            // 
            // IPBar
            // 
            this.IPBar.Location = new System.Drawing.Point(12, 222);
            this.IPBar.Name = "IPBar";
            this.IPBar.Size = new System.Drawing.Size(100, 23);
            this.IPBar.TabIndex = 6;
            this.IPBar.TextChanged += new System.EventHandler(this.IPBar_TextChanged);
            // 
            // Generate
            // 
            this.Generate.Enabled = false;
            this.Generate.Location = new System.Drawing.Point(323, 308);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 7;
            this.Generate.Text = "Genera";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Num
            // 
            this.Num.FormattingEnabled = true;
            this.Num.ItemHeight = 15;
            this.Num.Location = new System.Drawing.Point(153, 12);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(164, 319);
            this.Num.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 373);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.IPBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.BtnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxNumber;
        private System.Windows.Forms.TextBox IPBar;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.ListBox Num;
    }
}


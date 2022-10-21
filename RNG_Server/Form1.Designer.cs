
namespace RNG_Server
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
            this.btnOpenConn = new System.Windows.Forms.Button();
            this.btnCloseConn = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOpenConn
            // 
            this.btnOpenConn.Location = new System.Drawing.Point(12, 12);
            this.btnOpenConn.Name = "btnOpenConn";
            this.btnOpenConn.Size = new System.Drawing.Size(89, 44);
            this.btnOpenConn.TabIndex = 0;
            this.btnOpenConn.Text = "Apri connessione";
            this.btnOpenConn.UseVisualStyleBackColor = true;
            this.btnOpenConn.Click += new System.EventHandler(this.btnOpenConn_Click);
            // 
            // btnCloseConn
            // 
            this.btnCloseConn.Location = new System.Drawing.Point(12, 62);
            this.btnCloseConn.Name = "btnCloseConn";
            this.btnCloseConn.Size = new System.Drawing.Size(85, 49);
            this.btnCloseConn.TabIndex = 1;
            this.btnCloseConn.Text = "Chiudi connessione";
            this.btnCloseConn.UseVisualStyleBackColor = true;
            this.btnCloseConn.Click += new System.EventHandler(this.btnCloseConn_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(31, 135);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(38, 15);
            this.status.TabIndex = 2;
            this.status.Text = "label1";
            // 
            // Log
            // 
            this.Log.FormattingEnabled = true;
            this.Log.ItemHeight = 15;
            this.Log.Location = new System.Drawing.Point(125, 12);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(197, 154);
            this.Log.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 177);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.status);
            this.Controls.Add(this.btnCloseConn);
            this.Controls.Add(this.btnOpenConn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenConn;
        private System.Windows.Forms.Button btnCloseConn;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ListBox Log;
    }
}



namespace PresontationLayer
{
    partial class AddressChange
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
            this.StreetInOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CityInOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StateInOut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ZipInOut = new System.Windows.Forms.TextBox();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change The Address";
            // 
            // StreetInOut
            // 
            this.StreetInOut.Location = new System.Drawing.Point(113, 72);
            this.StreetInOut.Name = "StreetInOut";
            this.StreetInOut.Size = new System.Drawing.Size(343, 23);
            this.StreetInOut.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Steet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "City";
            // 
            // CityInOut
            // 
            this.CityInOut.Location = new System.Drawing.Point(113, 121);
            this.CityInOut.Name = "CityInOut";
            this.CityInOut.Size = new System.Drawing.Size(144, 23);
            this.CityInOut.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "State";
            // 
            // StateInOut
            // 
            this.StateInOut.Location = new System.Drawing.Point(287, 120);
            this.StateInOut.Name = "StateInOut";
            this.StateInOut.Size = new System.Drawing.Size(55, 23);
            this.StateInOut.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Zip";
            // 
            // ZipInOut
            // 
            this.ZipInOut.Location = new System.Drawing.Point(368, 121);
            this.ZipInOut.Name = "ZipInOut";
            this.ZipInOut.Size = new System.Drawing.Size(88, 23);
            this.ZipInOut.TabIndex = 8;
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(316, 222);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(101, 23);
            this.SaveChanges.TabIndex = 9;
            this.SaveChanges.Text = "Save and Return";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddressChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.ZipInOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StateInOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CityInOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StreetInOut);
            this.Controls.Add(this.label1);
            this.Name = "AddressChange";
            this.Text = "AddressChange";
            this.Load += new System.EventHandler(this.AddressChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StreetInOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CityInOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StateInOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ZipInOut;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button button1;
    }
}
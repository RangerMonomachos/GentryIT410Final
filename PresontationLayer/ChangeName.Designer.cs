
namespace PresontationLayer
{
    partial class ChangeName
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
            this.FirstNameOutput = new System.Windows.Forms.TextBox();
            this.LastNameChange = new System.Windows.Forms.TextBox();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change the First Name";
            // 
            // FirstNameOutput
            // 
            this.FirstNameOutput.Location = new System.Drawing.Point(169, 76);
            this.FirstNameOutput.Name = "FirstNameOutput";
            this.FirstNameOutput.Size = new System.Drawing.Size(164, 23);
            this.FirstNameOutput.TabIndex = 1;
            // 
            // LastNameChange
            // 
            this.LastNameChange.Enabled = false;
            this.LastNameChange.Location = new System.Drawing.Point(386, 75);
            this.LastNameChange.Name = "LastNameChange";
            this.LastNameChange.Size = new System.Drawing.Size(186, 23);
            this.LastNameChange.TabIndex = 2;
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(310, 128);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(100, 23);
            this.SaveChanges.TabIndex = 3;
            this.SaveChanges.Text = "Save and Return";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.LastNameChange);
            this.Controls.Add(this.FirstNameOutput);
            this.Controls.Add(this.label1);
            this.Name = "ChangeName";
            this.Text = "ChangeName";
            this.Load += new System.EventHandler(this.ChangeName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameOutput;
        private System.Windows.Forms.TextBox LastNameChange;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
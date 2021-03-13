
namespace PresontationLayer
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameChangeGo = new System.Windows.Forms.Button();
            this.ChangeAddressGo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(775, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter_1);
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            // 
            // NameChangeGo
            // 
            this.NameChangeGo.Enabled = false;
            this.NameChangeGo.Location = new System.Drawing.Point(12, 46);
            this.NameChangeGo.Name = "NameChangeGo";
            this.NameChangeGo.Size = new System.Drawing.Size(100, 23);
            this.NameChangeGo.TabIndex = 1;
            this.NameChangeGo.Text = "Change Name";
            this.NameChangeGo.UseVisualStyleBackColor = true;
            this.NameChangeGo.Click += new System.EventHandler(this.NameChangeGo_Click);
            // 
            // ChangeAddressGo
            // 
            this.ChangeAddressGo.Enabled = false;
            this.ChangeAddressGo.Location = new System.Drawing.Point(681, 46);
            this.ChangeAddressGo.Name = "ChangeAddressGo";
            this.ChangeAddressGo.Size = new System.Drawing.Size(106, 23);
            this.ChangeAddressGo.TabIndex = 2;
            this.ChangeAddressGo.Text = "Change Address";
            this.ChangeAddressGo.UseVisualStyleBackColor = true;
            this.ChangeAddressGo.Click += new System.EventHandler(this.ChangeAddressGo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "CLick to declect rows";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(713, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 4;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChangeAddressGo);
            this.Controls.Add(this.NameChangeGo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button NameChangeGo;
        private System.Windows.Forms.Button ChangeAddressGo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Close;
    }
}
namespace JenkinsTrial
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
            this.lblSelectConfigKey = new System.Windows.Forms.Label();
            this.cmbSelectConfigKey = new System.Windows.Forms.ComboBox();
            this.btnReadConfigKeyValue = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectConfigKey
            // 
            this.lblSelectConfigKey.AutoSize = true;
            this.lblSelectConfigKey.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectConfigKey.Location = new System.Drawing.Point(23, 31);
            this.lblSelectConfigKey.Name = "lblSelectConfigKey";
            this.lblSelectConfigKey.Size = new System.Drawing.Size(116, 16);
            this.lblSelectConfigKey.TabIndex = 0;
            this.lblSelectConfigKey.Text = "Select config key :";
            // 
            // cmbSelectConfigKey
            // 
            this.cmbSelectConfigKey.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectConfigKey.FormattingEnabled = true;
            this.cmbSelectConfigKey.Items.AddRange(new object[] {
            "Key1",
            "Key2"});
            this.cmbSelectConfigKey.Location = new System.Drawing.Point(141, 29);
            this.cmbSelectConfigKey.Name = "cmbSelectConfigKey";
            this.cmbSelectConfigKey.Size = new System.Drawing.Size(77, 24);
            this.cmbSelectConfigKey.TabIndex = 1;
            this.cmbSelectConfigKey.Text = "Key1";
            // 
            // btnReadConfigKeyValue
            // 
            this.btnReadConfigKeyValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadConfigKeyValue.Location = new System.Drawing.Point(224, 28);
            this.btnReadConfigKeyValue.Name = "btnReadConfigKeyValue";
            this.btnReadConfigKeyValue.Size = new System.Drawing.Size(184, 23);
            this.btnReadConfigKeyValue.TabIndex = 2;
            this.btnReadConfigKeyValue.Text = "ReadConfigKeyValue";
            this.btnReadConfigKeyValue.UseVisualStyleBackColor = true;
            this.btnReadConfigKeyValue.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(83, 231);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(622, 22);
            this.txtStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(23, 231);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 16);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status :";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(26, 83);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(57, 22);
            this.txtA.TabIndex = 5;
            this.txtA.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "+";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(141, 83);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(57, 22);
            this.txtB.TabIndex = 7;
            this.txtB.Text = "3";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(224, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 265);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnReadConfigKeyValue);
            this.Controls.Add(this.cmbSelectConfigKey);
            this.Controls.Add(this.lblSelectConfigKey);
            this.Name = "Form1";
            this.Text = "Jenkins Trial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectConfigKey;
        private System.Windows.Forms.ComboBox cmbSelectConfigKey;
        private System.Windows.Forms.Button btnReadConfigKeyValue;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnAdd;
    }
}


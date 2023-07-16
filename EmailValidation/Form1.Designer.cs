namespace EmailValidation
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
            this.btnValidate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Invalid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DomainPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TldPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidate.Location = new System.Drawing.Point(521, 469);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(201, 39);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Validate Email";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmailAddress,
            this.Valid,
            this.Invalid,
            this.DomainPercentage,
            this.TldPercentage});
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 406);
            this.dataGridView1.TabIndex = 1;
            // 
            // EmailAddress
            // 
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Width = 150;
            // 
            // Valid
            // 
            this.Valid.HeaderText = "Valid";
            this.Valid.Name = "Valid";
            this.Valid.ReadOnly = true;
            this.Valid.Width = 80;
            // 
            // Invalid
            // 
            this.Invalid.HeaderText = "Invalid";
            this.Invalid.Name = "Invalid";
            this.Invalid.ReadOnly = true;
            this.Invalid.Width = 80;
            // 
            // DomainPercentage
            // 
            this.DomainPercentage.HeaderText = "DomainPercentage";
            this.DomainPercentage.Name = "DomainPercentage";
            this.DomainPercentage.ReadOnly = true;
            this.DomainPercentage.Width = 80;
            // 
            // TldPercentage
            // 
            this.TldPercentage.HeaderText = "TldPercentage";
            this.TldPercentage.Name = "TldPercentage";
            this.TldPercentage.ReadOnly = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(151, 39);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import Samples";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(169, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 39);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 520);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnValidate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validate Email Addresses";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Valid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Invalid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomainPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TldPercentage;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnClear;
    }
}


namespace InsertslxToSql
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
            this.BtnSelect = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.OpenFileD = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.Color.LightCoral;
            this.BtnSelect.Location = new System.Drawing.Point(32, 46);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(148, 54);
            this.BtnSelect.TabIndex = 0;
            this.BtnSelect.Text = "انتخاب فایل";
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(377, 64);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 18);
            this.lblPath.TabIndex = 1;
            this.lblPath.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPerson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPerson.Location = new System.Drawing.Point(0, 191);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.RowHeadersWidth = 51;
            this.dgvPerson.RowTemplate.Height = 24;
            this.dgvPerson.Size = new System.Drawing.Size(571, 315);
            this.dgvPerson.TabIndex = 2;
            // 
            // OpenFileD
            // 
            this.OpenFileD.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Location = new System.Drawing.Point(32, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 48);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "ذخیره فایل";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "شناسه";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "نام";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "family";
            this.Column3.HeaderText = "نام خانوادگی";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 506);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvPerson);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.BtnSelect);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.OpenFileDialog OpenFileD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}


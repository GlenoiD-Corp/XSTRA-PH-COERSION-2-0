namespace MailerChimp_2
{
    partial class addRecipient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radlblWarning = new Telerik.WinControls.UI.RadLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmail0 = new System.Windows.Forms.TextBox();
            this.txtLname0 = new System.Windows.Forms.TextBox();
            this.txtFname0 = new System.Windows.Forms.TextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel14 = new Telerik.WinControls.UI.RadLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radlblWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.radlblWarning);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtEmail0);
            this.panel1.Controls.Add(this.txtLname0);
            this.panel1.Controls.Add(this.txtFname0);
            this.panel1.Controls.Add(this.radLabel2);
            this.panel1.Controls.Add(this.radLabel1);
            this.panel1.Controls.Add(this.radLabel14);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 500);
            this.panel1.TabIndex = 0;
            // 
            // radlblWarning
            // 
            this.radlblWarning.BackColor = System.Drawing.Color.Brown;
            this.radlblWarning.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radlblWarning.ForeColor = System.Drawing.Color.White;
            this.radlblWarning.Location = new System.Drawing.Point(582, 5);
            this.radlblWarning.Name = "radlblWarning";
            this.radlblWarning.Size = new System.Drawing.Size(102, 21);
            this.radlblWarning.TabIndex = 43;
            this.radlblWarning.Text = "Email Duplicate!";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(610, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 32);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Tag = "";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(687, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 32);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmail0
            // 
            this.txtEmail0.BackColor = System.Drawing.Color.SkyBlue;
            this.txtEmail0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail0.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail0.ForeColor = System.Drawing.Color.Black;
            this.txtEmail0.Location = new System.Drawing.Point(464, 27);
            this.txtEmail0.Name = "txtEmail0";
            this.txtEmail0.Size = new System.Drawing.Size(220, 30);
            this.txtEmail0.TabIndex = 40;
            this.txtEmail0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail0.TextChanged += new System.EventHandler(this.txtEmail0_TextChanged);
            // 
            // txtLname0
            // 
            this.txtLname0.BackColor = System.Drawing.Color.SkyBlue;
            this.txtLname0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLname0.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname0.ForeColor = System.Drawing.Color.Black;
            this.txtLname0.Location = new System.Drawing.Point(235, 27);
            this.txtLname0.Name = "txtLname0";
            this.txtLname0.Size = new System.Drawing.Size(220, 30);
            this.txtLname0.TabIndex = 39;
            this.txtLname0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFname0
            // 
            this.txtFname0.BackColor = System.Drawing.Color.SkyBlue;
            this.txtFname0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFname0.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname0.ForeColor = System.Drawing.Color.Black;
            this.txtFname0.Location = new System.Drawing.Point(6, 27);
            this.txtFname0.Name = "txtFname0";
            this.txtFname0.Size = new System.Drawing.Size(220, 30);
            this.txtFname0.TabIndex = 38;
            this.txtFname0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.Location = new System.Drawing.Point(461, 3);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(53, 27);
            this.radLabel2.TabIndex = 37;
            this.radLabel2.Text = "Email";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Location = new System.Drawing.Point(232, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(95, 27);
            this.radLabel1.TabIndex = 36;
            this.radLabel1.Text = "Last Name";
            // 
            // radLabel14
            // 
            this.radLabel14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel14.ForeColor = System.Drawing.Color.Black;
            this.radLabel14.Location = new System.Drawing.Point(3, 3);
            this.radLabel14.Name = "radLabel14";
            this.radLabel14.Size = new System.Drawing.Size(97, 27);
            this.radLabel14.TabIndex = 35;
            this.radLabel14.Text = "First Name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(690, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 32);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(727, 25);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(31, 32);
            this.btnRemove.TabIndex = 44;
            this.btnRemove.Tag = "";
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // addRecipient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 536);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addRecipient";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Email";
            this.ThemeName = "VisualStudio2012Light";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radlblWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel14;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmail0;
        private System.Windows.Forms.TextBox txtLname0;
        private System.Windows.Forms.TextBox txtFname0;
        private System.Windows.Forms.Button btnCancel;
        private Telerik.WinControls.UI.RadLabel radlblWarning;
        private System.Windows.Forms.Button btnRemove;

    }
}
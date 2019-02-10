namespace WildLife
{
    partial class Company
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.txtNICNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.lblNICNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBoxFooter = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxSideBar = new System.Windows.Forms.GroupBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.groupBoxHeader.SuspendLayout();
            this.groupBoxFooter.SuspendLayout();
            this.groupBoxSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(22, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 17);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Register A Company";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(331, 165);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(220, 78);
            this.txtAddress.TabIndex = 17;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(331, 379);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(220, 20);
            this.txtMobileNumber.TabIndex = 20;
            // 
            // txtNICNumber
            // 
            this.txtNICNumber.Location = new System.Drawing.Point(331, 327);
            this.txtNICNumber.Name = "txtNICNumber";
            this.txtNICNumber.Size = new System.Drawing.Size(220, 20);
            this.txtNICNumber.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(331, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(440, 20);
            this.txtName.TabIndex = 16;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(226, 168);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address:";
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Location = new System.Drawing.Point(226, 386);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(79, 13);
            this.lblMobileNumber.TabIndex = 14;
            this.lblMobileNumber.Text = "Mobile number:";
            // 
            // lblNICNumber
            // 
            this.lblNICNumber.AutoSize = true;
            this.lblNICNumber.Location = new System.Drawing.Point(226, 334);
            this.lblNICNumber.Name = "lblNICNumber";
            this.lblNICNumber.Size = new System.Drawing.Size(66, 13);
            this.lblNICNumber.TabIndex = 13;
            this.lblNICNumber.Text = "NIC number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(226, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(616, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBoxHeader
            // 
            this.groupBoxHeader.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxHeader.Controls.Add(this.lblDescription);
            this.groupBoxHeader.Controls.Add(this.lblTitle);
            this.groupBoxHeader.Location = new System.Drawing.Point(0, -6);
            this.groupBoxHeader.Name = "groupBoxHeader";
            this.groupBoxHeader.Size = new System.Drawing.Size(886, 100);
            this.groupBoxHeader.TabIndex = 20;
            this.groupBoxHeader.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(44, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(189, 13);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "A new company can be registerd here.";
            // 
            // groupBoxFooter
            // 
            this.groupBoxFooter.Controls.Add(this.btnCancel);
            this.groupBoxFooter.Controls.Add(this.btnSave);
            this.groupBoxFooter.Location = new System.Drawing.Point(0, 452);
            this.groupBoxFooter.Name = "groupBoxFooter";
            this.groupBoxFooter.Size = new System.Drawing.Size(886, 60);
            this.groupBoxFooter.TabIndex = 21;
            this.groupBoxFooter.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(697, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBoxSideBar
            // 
            this.groupBoxSideBar.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSideBar.Controls.Add(this.lblSubtitle);
            this.groupBoxSideBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxSideBar.Location = new System.Drawing.Point(0, 86);
            this.groupBoxSideBar.Name = "groupBoxSideBar";
            this.groupBoxSideBar.Size = new System.Drawing.Size(200, 374);
            this.groupBoxSideBar.TabIndex = 22;
            this.groupBoxSideBar.TabStop = false;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(12, 16);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(121, 13);
            this.lblSubtitle.TabIndex = 12;
            this.lblSubtitle.Text = "Register A Company";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(332, 275);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(440, 20);
            this.txtOwnerName.TabIndex = 18;
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(226, 282);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(79, 13);
            this.lblOwnerName.TabIndex = 23;
            this.lblOwnerName.Text = "Owner\'s Name:";
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.txtNICNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblMobileNumber);
            this.Controls.Add(this.lblNICNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBoxHeader);
            this.Controls.Add(this.groupBoxFooter);
            this.Controls.Add(this.groupBoxSideBar);
            this.MaximizeBox = false;
            this.Name = "Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wildlife | Register A Company";
            this.groupBoxHeader.ResumeLayout(false);
            this.groupBoxHeader.PerformLayout();
            this.groupBoxFooter.ResumeLayout(false);
            this.groupBoxSideBar.ResumeLayout(false);
            this.groupBoxSideBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.TextBox txtNICNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.Label lblNICNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBoxHeader;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox groupBoxFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBoxSideBar;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label lblOwnerName;
    }
}
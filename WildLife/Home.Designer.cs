namespace WildLife
{
    partial class Home
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
            this.btnDriver = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDriver
            // 
            this.btnDriver.Location = new System.Drawing.Point(321, 152);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(75, 23);
            this.btnDriver.TabIndex = 0;
            this.btnDriver.Text = "Driver";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Location = new System.Drawing.Point(480, 152);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnVehicle.TabIndex = 1;
            this.btnVehicle.Text = "Vehicle";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(630, 152);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(75, 23);
            this.btnOwner.TabIndex = 2;
            this.btnOwner.Text = "Owner";
            this.btnOwner.UseVisualStyleBackColor = true;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(321, 202);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(75, 23);
            this.btnTicket.TabIndex = 3;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnOwner);
            this.Controls.Add(this.btnVehicle);
            this.Controls.Add(this.btnDriver);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Wildlife | Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnTicket;
    }
}
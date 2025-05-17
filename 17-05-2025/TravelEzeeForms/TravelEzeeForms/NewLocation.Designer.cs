namespace TravelEzeeForms
{
    partial class NewLocation
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
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.LocationNo = new System.Windows.Forms.Label();
            this.LocationName = new System.Windows.Forms.Label();
            this.LocationNumber = new System.Windows.Forms.TextBox();
            this.NewLocationName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(67, 142);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(228, 142);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseMnemonic = false;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // LocationNo
            // 
            this.LocationNo.AutoSize = true;
            this.LocationNo.Location = new System.Drawing.Point(45, 39);
            this.LocationNo.Name = "LocationNo";
            this.LocationNo.Size = new System.Drawing.Size(88, 13);
            this.LocationNo.TabIndex = 2;
            this.LocationNo.Text = "Location Number";
            // 
            // LocationName
            // 
            this.LocationName.AutoSize = true;
            this.LocationName.Location = new System.Drawing.Point(48, 89);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(79, 13);
            this.LocationName.TabIndex = 3;
            this.LocationName.Text = "Location Name";
            // 
            // LocationNumber
            // 
            this.LocationNumber.Location = new System.Drawing.Point(187, 32);
            this.LocationNumber.Name = "LocationNumber";
            this.LocationNumber.Size = new System.Drawing.Size(100, 20);
            this.LocationNumber.TabIndex = 4;
            // 
            // NewLocationName
            // 
            this.NewLocationName.Location = new System.Drawing.Point(203, 82);
            this.NewLocationName.Name = "NewLocationName";
            this.NewLocationName.Size = new System.Drawing.Size(100, 20);
            this.NewLocationName.TabIndex = 5;
            // 
            // NewLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewLocationName);
            this.Controls.Add(this.LocationNumber);
            this.Controls.Add(this.LocationName);
            this.Controls.Add(this.LocationNo);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Name = "NewLocation";
            this.Text = "NewLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label LocationNo;
        private System.Windows.Forms.Label LocationName;
        private System.Windows.Forms.TextBox LocationNumber;
        private System.Windows.Forms.TextBox NewLocationName;
    }
}
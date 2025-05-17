namespace TravelEzeeForms
{
    partial class AdminDashboard
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GridLocation = new System.Windows.Forms.DataGridView();
            this.AddNewLocation = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridService = new System.Windows.Forms.DataGridView();
            this.AddNewService = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLocation)).BeginInit();
            this.exit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridService)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridLocation);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // GridLocation
            // 
            this.GridLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLocation.Location = new System.Drawing.Point(48, 19);
            this.GridLocation.Name = "GridLocation";
            this.GridLocation.Size = new System.Drawing.Size(513, 130);
            this.GridLocation.TabIndex = 0;
            // 
            // AddNewLocation
            // 
            this.AddNewLocation.Location = new System.Drawing.Point(640, 73);
            this.AddNewLocation.Name = "AddNewLocation";
            this.AddNewLocation.Size = new System.Drawing.Size(132, 23);
            this.AddNewLocation.TabIndex = 1;
            this.AddNewLocation.Text = "Add New Location";
            this.AddNewLocation.UseVisualStyleBackColor = true;
            this.AddNewLocation.Click += new System.EventHandler(this.AddNewLocation_Click);
            // 
            // exit
            // 
            this.exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridService);
            this.groupBox2.Location = new System.Drawing.Point(42, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 204);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Service";
            // 
            // GridService
            // 
            this.GridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridService.Location = new System.Drawing.Point(6, 19);
            this.GridService.Name = "GridService";
            this.GridService.Size = new System.Drawing.Size(554, 150);
            this.GridService.TabIndex = 0;
            // 
            // AddNewService
            // 
            this.AddNewService.Location = new System.Drawing.Point(671, 287);
            this.AddNewService.Name = "AddNewService";
            this.AddNewService.Size = new System.Drawing.Size(101, 23);
            this.AddNewService.TabIndex = 3;
            this.AddNewService.Text = "Add New Service";
            this.AddNewService.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNewService);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AddNewLocation);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridLocation)).EndInit();
            this.exit.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridLocation;
        private System.Windows.Forms.Button AddNewLocation;
        private System.Windows.Forms.ContextMenuStrip exit;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridService;
        private System.Windows.Forms.Button AddNewService;
    }
}
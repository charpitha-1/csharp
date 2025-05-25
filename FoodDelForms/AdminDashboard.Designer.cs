namespace FoodDelForms
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
            groupBox1 = new GroupBox();
            GridLocation = new DataGridView();
            menuStrip1 = new MenuStrip();
            addLocationToolStripMenuItem = new ToolStripMenuItem();
            addRestaurantToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            GridRestaurant = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridLocation).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridRestaurant).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GridLocation);
            groupBox1.Location = new Point(25, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 149);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Location";
            // 
            // GridLocation
            // 
            GridLocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridLocation.Location = new Point(26, 26);
            GridLocation.Name = "GridLocation";
            GridLocation.RowHeadersWidth = 51;
            GridLocation.Size = new Size(533, 112);
            GridLocation.TabIndex = 0;
            //GridLocation.CellContentClick += this.GridLocation_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addLocationToolStripMenuItem, addRestaurantToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1038, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // addLocationToolStripMenuItem
            // 
            addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            addLocationToolStripMenuItem.Size = new Size(108, 24);
            addLocationToolStripMenuItem.Text = "AddLocation";
            addLocationToolStripMenuItem.Click += addLocationToolStripMenuItem_Click;
            // 
            // addRestaurantToolStripMenuItem
            // 
            addRestaurantToolStripMenuItem.Name = "addRestaurantToolStripMenuItem";
            addRestaurantToolStripMenuItem.Size = new Size(121, 24);
            addRestaurantToolStripMenuItem.Text = "AddRestaurant";
            addRestaurantToolStripMenuItem.Click += addRestaurantToolStripMenuItem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(GridRestaurant);
            groupBox2.Location = new Point(37, 245);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(568, 153);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Restaurant";
            // 
            // GridRestaurant
            // 
            GridRestaurant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridRestaurant.Location = new Point(14, 33);
            GridRestaurant.Name = "GridRestaurant";
            GridRestaurant.RowHeadersWidth = 51;
            GridRestaurant.Size = new Size(533, 114);
            GridRestaurant.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminDashboard";
            Text = "AdminDashboardcs";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridLocation).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridRestaurant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView GridLocation;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addLocationToolStripMenuItem;
        private ToolStripMenuItem addRestaurantToolStripMenuItem;
        private GroupBox groupBox2;
        private DataGridView GridRestaurant;
    }
}
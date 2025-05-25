namespace FoodDelForms
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
            label1 = new Label();
            label2 = new Label();
            LocationId = new TextBox();
            LocationName = new TextBox();
            Save = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 47);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "LocationId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 137);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "LocationName";
            // 
            // LocationId
            // 
            LocationId.Location = new Point(204, 57);
            LocationId.Name = "LocationId";
            LocationId.Size = new Size(125, 27);
            LocationId.TabIndex = 2;
            // 
            // LocationName
            // 
            LocationName.Location = new Point(204, 137);
            LocationName.Name = "LocationName";
            LocationName.Size = new Size(125, 27);
            LocationName.TabIndex = 3;
            // 
            // Save
            // 
            Save.Location = new Point(249, 282);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 4;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // NewLocation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Save);
            Controls.Add(LocationName);
            Controls.Add(LocationId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewLocation";
            Text = "NewLocation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox LocationId;
        private TextBox LocationName;
        private Button Save;
    }
}
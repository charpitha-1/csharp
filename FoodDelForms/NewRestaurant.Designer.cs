namespace FoodDelForms
{
    partial class NewRestaurant
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
            label3 = new Label();
            RestId = new TextBox();
            RestName = new TextBox();
            Save = new Button();
            RLocCombo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 52);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "RestId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 134);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "RestName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 208);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "RLocation";
            // 
            // RestId
            // 
            RestId.Location = new Point(169, 43);
            RestId.Name = "RestId";
            RestId.Size = new Size(125, 27);
            RestId.TabIndex = 3;
            // 
            // RestName
            // 
            RestName.Location = new Point(169, 127);
            RestName.Name = "RestName";
            RestName.Size = new Size(125, 27);
            RestName.TabIndex = 4;
            // 
            // Save
            // 
            Save.Location = new Point(152, 324);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 6;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click_1;
            // 
            // RLocCombo
            // 
            RLocCombo.FormattingEnabled = true;
            RLocCombo.Location = new Point(169, 200);
            RLocCombo.Name = "RLocCombo";
            RLocCombo.Size = new Size(151, 28);
            RLocCombo.TabIndex = 7;
           // RLocCombo.SelectedIndexChanged += RLocCombo_SelectedIndexChanged;
            // 
            // NewRestaurant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RLocCombo);
            Controls.Add(Save);
            Controls.Add(RestName);
            Controls.Add(RestId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewRestaurant";
            Text = "NewRestaurant";
            //Load += NewRestaurant_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox RestId;
        private TextBox RestName;
        private Button Save;
        private ComboBox RLocCombo;
    }
}
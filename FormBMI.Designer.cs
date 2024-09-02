namespace BMICalculatorWF
{
    partial class FormBMI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbLanguage = new ComboBox();
            lblLanguage = new Label();
            txtWeight = new TextBox();
            lblSystem = new Label();
            cbSystem = new ComboBox();
            lblSelectWeight = new Label();
            lblWeight = new Label();
            lblSelectHeight = new Label();
            txtHeight = new TextBox();
            lblHeight = new Label();
            btnCalc = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // cbLanguage
            // 
            cbLanguage.FormattingEnabled = true;
            cbLanguage.Items.AddRange(new object[] { "English", "Español" });
            cbLanguage.Location = new Point(138, 6);
            cbLanguage.Name = "cbLanguage";
            cbLanguage.Size = new Size(121, 23);
            cbLanguage.TabIndex = 1;
            cbLanguage.SelectedIndexChanged += cbLanguage_SelectedIndexChanged;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(12, 9);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(62, 15);
            lblLanguage.TabIndex = 2;
            lblLanguage.Text = "Language:";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(145, 92);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(74, 23);
            txtWeight.TabIndex = 3;
            // 
            // lblSystem
            // 
            lblSystem.AutoSize = true;
            lblSystem.Location = new Point(12, 38);
            lblSystem.Name = "lblSystem";
            lblSystem.Size = new Size(123, 15);
            lblSystem.TabIndex = 4;
            lblSystem.Text = "Measurement system:";
            // 
            // cbSystem
            // 
            cbSystem.FormattingEnabled = true;
            cbSystem.Location = new Point(138, 35);
            cbSystem.Name = "cbSystem";
            cbSystem.Size = new Size(121, 23);
            cbSystem.TabIndex = 2;
            cbSystem.SelectedIndexChanged += cbSystem_SelectedIndexChanged;
            // 
            // lblSelectWeight
            // 
            lblSelectWeight.AutoSize = true;
            lblSelectWeight.Location = new Point(12, 95);
            lblSelectWeight.Name = "lblSelectWeight";
            lblSelectWeight.Size = new Size(127, 15);
            lblSelectWeight.TabIndex = 7;
            lblSelectWeight.Text = "Introduce your weight:";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(225, 95);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(23, 15);
            lblWeight.TabIndex = 8;
            lblWeight.Text = "Lb.";
            // 
            // lblSelectHeight
            // 
            lblSelectHeight.AutoSize = true;
            lblSelectHeight.Location = new Point(12, 124);
            lblSelectHeight.Name = "lblSelectHeight";
            lblSelectHeight.Size = new Size(125, 15);
            lblSelectHeight.TabIndex = 9;
            lblSelectHeight.Text = "Introduce your height:";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(145, 121);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(74, 23);
            txtHeight.TabIndex = 4;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(225, 124);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(20, 15);
            lblHeight.TabIndex = 11;
            lblHeight.Text = "in.";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(145, 150);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(74, 23);
            btnCalc.TabIndex = 12;
            btnCalc.Text = "Evaluate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(12, 176);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(247, 38);
            lblResult.TabIndex = 13;
            lblResult.Text = "Your BMI is 55. You're extremely obese!";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Visible = false;
            // 
            // FormBMI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 223);
            Controls.Add(lblResult);
            Controls.Add(btnCalc);
            Controls.Add(lblHeight);
            Controls.Add(txtHeight);
            Controls.Add(lblSelectHeight);
            Controls.Add(lblWeight);
            Controls.Add(lblSelectWeight);
            Controls.Add(cbSystem);
            Controls.Add(lblSystem);
            Controls.Add(txtWeight);
            Controls.Add(lblLanguage);
            Controls.Add(cbLanguage);
            Name = "FormBMI";
            Text = "BMI Calculator";
            Load += FormBMI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbLanguage;
        private Label lblLanguage;
        private TextBox txtWeight;
        private Label lblSystem;
        private ComboBox cbSystem;
        private Label lblSelectWeight;
        private Label lblWeight;
        private Label lblSelectHeight;
        private TextBox txtHeight;
        private Label lblHeight;
        private Button btnCalc;
        private Label lblResult;
    }
}

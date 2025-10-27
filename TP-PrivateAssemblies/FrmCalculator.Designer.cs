namespace ClassLibraryDemo1
{
    partial class FrmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculator));
            label1 = new Label();
            txtBox1 = new TextBox();
            cbOperator = new ComboBox();
            txtBox2 = new TextBox();
            btnCompute = new Button();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(90, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(20, 63);
            txtBox1.Margin = new Padding(4, 3, 4, 3);
            txtBox1.Multiline = true;
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(300, 44);
            txtBox1.TabIndex = 1;
            // 
            // cbOperator
            // 
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(141, 115);
            cbOperator.Margin = new Padding(4, 3, 4, 3);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(62, 23);
            cbOperator.TabIndex = 2;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(20, 147);
            txtBox2.Margin = new Padding(4, 3, 4, 3);
            txtBox2.Multiline = true;
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(300, 44);
            txtBox2.TabIndex = 3;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.LimeGreen;
            btnCompute.FlatStyle = FlatStyle.Popup;
            btnCompute.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompute.ForeColor = Color.Black;
            btnCompute.Location = new Point(109, 337);
            btnCompute.Margin = new Padding(4, 3, 4, 3);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(125, 35);
            btnCompute.TabIndex = 4;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.BackColor = SystemColors.ActiveCaptionText;
            lblDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblDisplay.ForeColor = Color.FromArgb(0, 192, 0);
            lblDisplay.Location = new Point(20, 209);
            lblDisplay.Margin = new Padding(4, 0, 4, 0);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(301, 117);
            lblDisplay.TabIndex = 5;
            lblDisplay.Text = "label2";
            lblDisplay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(344, 386);
            Controls.Add(lblDisplay);
            Controls.Add(btnCompute);
            Controls.Add(txtBox2);
            Controls.Add(cbOperator);
            Controls.Add(txtBox1);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblDisplay;
    }
}
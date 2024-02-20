namespace Discriminant
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientInactiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Inter", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.RoyalBlue;
            textBox1.Location = new Point(49, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(60, 28);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GradientInactiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Inter", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.RoyalBlue;
            textBox2.Location = new Point(137, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(60, 28);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(318, 68);
            label1.Name = "label1";
            label1.Size = new Size(28, 28);
            label1.TabIndex = 2;
            label1.Text = "=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(372, 68);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(108, 122);
            button1.Name = "button1";
            button1.Size = new Size(276, 29);
            button1.TabIndex = 4;
            button1.Text = "Посчитать дискриминант";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.GradientInactiveCaption;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Inter", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.RoyalBlue;
            textBox3.Location = new Point(226, 68);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(60, 28);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(68, 37);
            label3.Name = "label3";
            label3.Size = new Size(25, 28);
            label3.TabIndex = 6;
            label3.Text = "a";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(155, 37);
            label4.Name = "label4";
            label4.Size = new Size(26, 28);
            label4.TabIndex = 7;
            label4.Text = "b";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(244, 37);
            label5.Name = "label5";
            label5.Size = new Size(25, 28);
            label5.TabIndex = 8;
            label5.Text = "c";
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("AmadeusAP", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(456, 160);
            button2.Name = "button2";
            button2.Size = new Size(29, 29);
            button2.TabIndex = 9;
            button2.Text = "i";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(497, 201);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Подсчет дискриминанта";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}

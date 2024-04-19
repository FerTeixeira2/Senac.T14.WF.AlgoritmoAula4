namespace WinFormsAppAlgoritmo
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(52, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 246);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de conta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 0;
            label1.Text = "Número da conta";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(36, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 34);
            textBox1.TabIndex = 1;
            textBox1.Text = "1234";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(278, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 34);
            textBox2.TabIndex = 2;
            textBox2.Text = "Fernando Teixeira";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 33);
            label2.Name = "label2";
            label2.Size = new Size(153, 28);
            label2.TabIndex = 3;
            label2.Text = "Titular da conta ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 132);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 7;
            label3.Text = "Tipo da conta";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaption;
            textBox3.Location = new Point(278, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 34);
            textBox3.TabIndex = 6;
            textBox3.Text = "Corrente";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.InactiveCaption;
            textBox4.Location = new Point(36, 169);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 34);
            textBox4.TabIndex = 5;
            textBox4.Text = "10000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 132);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 132);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 8;
            label5.Text = "Saída da conta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 429);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label5;
    }
}

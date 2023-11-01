namespace Practica_13
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 40);
            label1.Name = "label1";
            label1.Size = new Size(283, 24);
            label1.TabIndex = 0;
            label1.Text = "Dado como dato el sueldo de un";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 65);
            label2.Name = "label2";
            label2.Size = new Size(289, 24);
            label2.TabIndex = 1;
            label2.Text = "trabajador, el programa aplica un";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 90);
            label3.Name = "label3";
            label3.Size = new Size(278, 24);
            label3.TabIndex = 2;
            label3.Text = "aumento del 15% si el sueldo es";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 115);
            label4.Name = "label4";
            label4.Size = new Size(152, 24);
            label4.TabIndex = 3;
            label4.Text = "inferior a 400000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(61, 181);
            label5.Name = "label5";
            label5.Size = new Size(143, 24);
            label5.TabIndex = 4;
            label5.Text = "Ingresar sueldo:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(210, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 32);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(61, 247);
            button1.Name = "button1";
            button1.Size = new Size(99, 29);
            button1.TabIndex = 6;
            button1.Text = "Decisión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(216, 247);
            button2.Name = "button2";
            button2.Size = new Size(110, 29);
            button2.TabIndex = 7;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(60, 332);
            label6.Name = "label6";
            label6.Size = new Size(130, 24);
            label6.TabIndex = 8;
            label6.Text = "Nuevo sueldo:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(196, 332);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 32);
            textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(436, 416);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Aumento de sueldo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label6;
        private TextBox textBox2;
    }
}
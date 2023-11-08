namespace practica_3__ejercicio_3_U3
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
            f_num = new Label();
            Total = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 63);
            label1.Name = "label1";
            label1.Size = new Size(248, 15);
            label1.TabIndex = 0;
            label1.Text = "este programa suma los numeros capturados ";
            label1.Click += label1_Click;
            // 
            // f_num
            // 
            f_num.AutoSize = true;
            f_num.Location = new Point(252, 145);
            f_num.Name = "f_num";
            f_num.Size = new Size(120, 15);
            f_num.TabIndex = 1;
            f_num.Text = "Introduce un numero";
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(236, 315);
            Total.Name = "Total";
            Total.Size = new Size(119, 15);
            Total.TabIndex = 2;
            Total.Text = "la suma de todos son";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(574, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(188, 274);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(110, 301);
            button1.Name = "button1";
            button1.Size = new Size(93, 54);
            button1.TabIndex = 4;
            button1.Text = "sumar numeros";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(412, 189);
            button2.Name = "button2";
            button2.Size = new Size(100, 46);
            button2.TabIndex = 5;
            button2.Text = "Añadir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(394, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(375, 307);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(Total);
            Controls.Add(f_num);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label f_num;
        private Label Total;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
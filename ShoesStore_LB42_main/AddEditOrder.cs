using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStore_LB42_main
{
    public partial class AddEditOrder : Form
    {
        public AddEditOrder()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 67);
            panel1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(137, 44);
            button2.TabIndex = 1;
            button2.Text = "НАЗАД";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(635, 12);
            button1.Name = "button1";
            button1.Size = new Size(137, 44);
            button1.TabIndex = 0;
            button1.Text = "ВЫХОД";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(95, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 35);
            textBox1.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(95, 264);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 35);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(437, 194);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 35);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(437, 119);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 35);
            textBox5.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(95, 95);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 14;
            label1.Text = "Артикул";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(95, 170);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 15;
            label2.Text = "Статус заказа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(95, 240);
            label3.Name = "label3";
            label3.Size = new Size(164, 21);
            label3.TabIndex = 16;
            label3.Text = "Адрес пункта выдачи";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(437, 170);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 17;
            label4.Text = "Дата выдачи";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(437, 95);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 18;
            label5.Text = "Дата заказа";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.5F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Выдан", "В пути", "Собран", "В сборке" });
            comboBox1.Location = new Point(95, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 33);
            comboBox1.TabIndex = 19;
            // 
            // button3
            // 
            button3.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(234, 351);
            button3.Name = "button3";
            button3.Size = new Size(149, 59);
            button3.TabIndex = 20;
            button3.Text = "ОК";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.Location = new Point(419, 351);
            button4.Name = "button4";
            button4.Size = new Size(149, 59);
            button4.TabIndex = 21;
            button4.Text = "ОТМЕНА";
            button4.UseVisualStyleBackColor = true;
            // 
            // AddEditOrder
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddEditOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление и редактирование заказа";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private Button button1;
    }
}

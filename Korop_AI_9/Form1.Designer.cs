using System.Drawing;
using System.Windows.Forms;

namespace Korop_AI_9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        Label Label1;
        Label Label2;
        TextBox TextBox1;
        TextBox TextBox2;
        public Label canvas;
        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.canvas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label1.Location = new System.Drawing.Point(10, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(170, 18);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Время жизни окружности: ";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label2.Location = new System.Drawing.Point(10, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(170, 17);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Количество окружностей:";
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Pink;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox1.Location = new System.Drawing.Point(180, 7);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(32, 20);
            this.TextBox1.TabIndex = 2;
            this.TextBox1.TabStop = false;
            this.TextBox1.Text = "100";
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.Color.Pink;
            this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox2.Location = new System.Drawing.Point(180, 37);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(32, 20);
            this.TextBox2.TabIndex = 4;
            this.TextBox2.TabStop = false;
            this.TextBox2.Text = "10";
            this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(12, 60);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(595, 334);
            this.canvas.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(296, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отображать окружности на холсте";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(453, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Не отображать окружности на холсте";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(619, 403);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Circles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
    }
}


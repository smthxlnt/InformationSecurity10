
namespace infSec10_programmingHeadquarters
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
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.checkSpec = new System.Windows.Forms.CheckBox();
            this.checkNum = new System.Windows.Forms.CheckBox();
            this.checkLow = new System.Windows.Forms.CheckBox();
            this.checkUp = new System.Windows.Forms.CheckBox();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 295);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(494, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Проверка пароля";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результат";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lavender;
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(480, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.result);
            this.tabPage2.Controls.Add(this.checkSpec);
            this.tabPage2.Controls.Add(this.checkNum);
            this.tabPage2.Controls.Add(this.checkLow);
            this.tabPage2.Controls.Add(this.checkUp);
            this.tabPage2.Controls.Add(this.numLength);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(494, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Генерация пароля";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Lavender;
            this.result.Location = new System.Drawing.Point(6, 173);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(482, 31);
            this.result.TabIndex = 6;
            // 
            // checkSpec
            // 
            this.checkSpec.AutoSize = true;
            this.checkSpec.BackColor = System.Drawing.Color.Transparent;
            this.checkSpec.Location = new System.Drawing.Point(12, 139);
            this.checkSpec.Name = "checkSpec";
            this.checkSpec.Size = new System.Drawing.Size(264, 28);
            this.checkSpec.TabIndex = 5;
            this.checkSpec.Text = "использовать спецсимволы";
            this.checkSpec.UseVisualStyleBackColor = false;
            this.checkSpec.CheckedChanged += new System.EventHandler(this.CheckSpec_CheckedChanged);
            // 
            // checkNum
            // 
            this.checkNum.AutoSize = true;
            this.checkNum.BackColor = System.Drawing.Color.Transparent;
            this.checkNum.Location = new System.Drawing.Point(12, 105);
            this.checkNum.Name = "checkNum";
            this.checkNum.Size = new System.Drawing.Size(206, 28);
            this.checkNum.TabIndex = 4;
            this.checkNum.Text = "использовать цифры";
            this.checkNum.UseVisualStyleBackColor = false;
            this.checkNum.CheckedChanged += new System.EventHandler(this.CheckNum_CheckedChanged);
            // 
            // checkLow
            // 
            this.checkLow.AutoSize = true;
            this.checkLow.BackColor = System.Drawing.Color.Transparent;
            this.checkLow.Location = new System.Drawing.Point(12, 71);
            this.checkLow.Name = "checkLow";
            this.checkLow.Size = new System.Drawing.Size(282, 28);
            this.checkLow.TabIndex = 3;
            this.checkLow.Text = "использовать нижний регистр";
            this.checkLow.UseVisualStyleBackColor = false;
            this.checkLow.CheckedChanged += new System.EventHandler(this.CheckLow_CheckedChanged);
            // 
            // checkUp
            // 
            this.checkUp.AutoSize = true;
            this.checkUp.BackColor = System.Drawing.Color.Transparent;
            this.checkUp.Location = new System.Drawing.Point(12, 37);
            this.checkUp.Name = "checkUp";
            this.checkUp.Size = new System.Drawing.Size(287, 28);
            this.checkUp.TabIndex = 2;
            this.checkUp.Text = "использовать верхний регистр";
            this.checkUp.UseVisualStyleBackColor = false;
            this.checkUp.CheckedChanged += new System.EventHandler(this.CheckUp_CheckedChanged);
            // 
            // numLength
            // 
            this.numLength.BackColor = System.Drawing.Color.Lavender;
            this.numLength.Location = new System.Drawing.Point(142, 3);
            this.numLength.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(89, 31);
            this.numLength.TabIndex = 1;
            this.numLength.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numLength.ValueChanged += new System.EventHandler(this.NumLength_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Длина пароля";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(494, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Обработка файла";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Обзор";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Lavender;
            this.textBox2.Location = new System.Drawing.Point(4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(487, 31);
            this.textBox2.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Текстовый файл|*.txt";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 30);
            this.button3.TabIndex = 10;
            this.button3.Text = "Проверка";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 295);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Штаб программирования";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.CheckBox checkSpec;
        private System.Windows.Forms.CheckBox checkNum;
        private System.Windows.Forms.CheckBox checkLow;
        private System.Windows.Forms.CheckBox checkUp;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
    }
}


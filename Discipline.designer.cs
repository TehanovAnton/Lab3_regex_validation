
namespace OOP_SEM3_L2
{
    partial class Discipline
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
            this.label4 = new System.Windows.Forms.Label();
            this.Spec = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Exam = new System.Windows.Forms.RadioButton();
            this.Credit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FirstSemestr = new System.Windows.Forms.RadioButton();
            this.SecondSemestr = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.NameDis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumLec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumLab = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.DisciplineMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Специальность";
            // 
            // Spec
            // 
            this.Spec.FormattingEnabled = true;
            this.Spec.Items.AddRange(new object[] {
            "ПОИТ",
            "ДЭВИ",
            "ПОИМБС",
            "ИСиТ"});
            this.Spec.Location = new System.Drawing.Point(214, 59);
            this.Spec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Spec.Name = "Spec";
            this.Spec.Size = new System.Drawing.Size(136, 28);
            this.Spec.TabIndex = 21;
            this.Spec.SelectedIndexChanged += new System.EventHandler(this.Spec_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Exam);
            this.groupBox2.Controls.Add(this.Credit);
            this.groupBox2.Location = new System.Drawing.Point(36, 212);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(168, 96);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Форма контроля";
            // 
            // Exam
            // 
            this.Exam.AutoSize = true;
            this.Exam.Location = new System.Drawing.Point(32, 60);
            this.Exam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exam.Name = "Exam";
            this.Exam.Size = new System.Drawing.Size(100, 24);
            this.Exam.TabIndex = 2;
            this.Exam.TabStop = true;
            this.Exam.Text = "Экзамен";
            this.Exam.UseVisualStyleBackColor = true;
            this.Exam.CheckedChanged += new System.EventHandler(this.Exam_CheckedChanged);
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.Location = new System.Drawing.Point(32, 26);
            this.Credit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(81, 24);
            this.Credit.TabIndex = 1;
            this.Credit.TabStop = true;
            this.Credit.Text = "Зачёт";
            this.Credit.UseVisualStyleBackColor = true;
            this.Credit.CheckedChanged += new System.EventHandler(this.Credit_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FirstSemestr);
            this.groupBox1.Controls.Add(this.SecondSemestr);
            this.groupBox1.Location = new System.Drawing.Point(248, 212);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(102, 96);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Семестр";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FirstSemestr
            // 
            this.FirstSemestr.AutoSize = true;
            this.FirstSemestr.Location = new System.Drawing.Point(26, 26);
            this.FirstSemestr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstSemestr.Name = "FirstSemestr";
            this.FirstSemestr.Size = new System.Drawing.Size(43, 24);
            this.FirstSemestr.TabIndex = 7;
            this.FirstSemestr.TabStop = true;
            this.FirstSemestr.Text = "1";
            this.FirstSemestr.UseVisualStyleBackColor = true;
            this.FirstSemestr.CheckedChanged += new System.EventHandler(this.FirstSemestr_CheckedChanged);
            // 
            // SecondSemestr
            // 
            this.SecondSemestr.AutoSize = true;
            this.SecondSemestr.Location = new System.Drawing.Point(26, 60);
            this.SecondSemestr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SecondSemestr.Name = "SecondSemestr";
            this.SecondSemestr.Size = new System.Drawing.Size(43, 24);
            this.SecondSemestr.TabIndex = 8;
            this.SecondSemestr.TabStop = true;
            this.SecondSemestr.Text = "2";
            this.SecondSemestr.UseVisualStyleBackColor = true;
            this.SecondSemestr.CheckedChanged += new System.EventHandler(this.SecondSemestr_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Введите название дисциплины";
            // 
            // NameDis
            // 
            this.NameDis.Location = new System.Drawing.Point(36, 150);
            this.NameDis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameDis.Name = "NameDis";
            this.NameDis.Size = new System.Drawing.Size(313, 26);
            this.NameDis.TabIndex = 16;
            this.NameDis.TextChanged += new System.EventHandler(this.NameDis_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Выберите курс";
            // 
            // Course
            // 
            this.Course.FormattingEnabled = true;
            this.Course.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.Course.Location = new System.Drawing.Point(36, 59);
            this.Course.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(136, 28);
            this.Course.TabIndex = 14;
            this.Course.SelectedIndexChanged += new System.EventHandler(this.Course_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Введите количество лекций";
            // 
            // NumLec
            // 
            this.NumLec.Location = new System.Drawing.Point(36, 371);
            this.NumLec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumLec.Name = "NumLec";
            this.NumLec.Size = new System.Drawing.Size(232, 26);
            this.NumLec.TabIndex = 23;
            this.NumLec.TextChanged += new System.EventHandler(this.NumLec_TextChanged);
            this.NumLec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumLec_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Введите количество лаб";
            // 
            // NumLab
            // 
            this.NumLab.Location = new System.Drawing.Point(36, 448);
            this.NumLab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumLab.Name = "NumLab";
            this.NumLab.Size = new System.Drawing.Size(232, 26);
            this.NumLab.TabIndex = 25;
            this.NumLab.TextChanged += new System.EventHandler(this.NumLab_TextChanged);
            this.NumLab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumLab_KeyPress);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(36, 509);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(314, 28);
            this.OkButton.TabIndex = 28;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // DisciplineMessage
            // 
            this.DisciplineMessage.Location = new System.Drawing.Point(356, 59);
            this.DisciplineMessage.Name = "DisciplineMessage";
            this.DisciplineMessage.ReadOnly = true;
            this.DisciplineMessage.Size = new System.Drawing.Size(333, 415);
            this.DisciplineMessage.TabIndex = 30;
            this.DisciplineMessage.Text = "";
            // 
            // Discipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 571);
            this.Controls.Add(this.DisciplineMessage);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumLab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumLec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Spec);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameDis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Course);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Discipline";
            this.Text = "Дисциплина";
            this.Load += new System.EventHandler(this.Discipline_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Spec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Exam;
        private System.Windows.Forms.RadioButton Credit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FirstSemestr;
        private System.Windows.Forms.RadioButton SecondSemestr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameDis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumLec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NumLab;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.RichTextBox DisciplineMessage;
    }
}
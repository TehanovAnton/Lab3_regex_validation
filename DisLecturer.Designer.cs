
namespace OOP_SEM3_L2
{
    partial class DisLecturer
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
            this.label5 = new System.Windows.Forms.Label();
            this.NamePrepod = new System.Windows.Forms.TextBox();
            this.Departsment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Office = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Введите ФИО преподавателя";
            // 
            // NamePrepod
            // 
            this.NamePrepod.Location = new System.Drawing.Point(37, 66);
            this.NamePrepod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NamePrepod.Name = "NamePrepod";
            this.NamePrepod.Size = new System.Drawing.Size(232, 26);
            this.NamePrepod.TabIndex = 27;
            // 
            // Departsment
            // 
            this.Departsment.FormattingEnabled = true;
            this.Departsment.Items.AddRange(new object[] {
            "Кафедра ИСиТ",
            "Кафедра ИиВД",
            "Кафедра ПИ",
            "Кафедра физики",
            "Кафедра ИГ",
            "Кафедра ВМ"});
            this.Departsment.Location = new System.Drawing.Point(37, 142);
            this.Departsment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Departsment.Name = "Departsment";
            this.Departsment.Size = new System.Drawing.Size(136, 28);
            this.Departsment.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Кафедра";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 32;
            // 
            // Office
            // 
            this.Office.Location = new System.Drawing.Point(192, 145);
            this.Office.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Office.Name = "Office";
            this.Office.Size = new System.Drawing.Size(77, 26);
            this.Office.TabIndex = 31;
            this.Office.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Office_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Кабинет";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(37, 194);
            this.OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(233, 29);
            this.OK.TabIndex = 34;
            this.OK.Text = "ОК";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(275, 39);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ReadOnly = true;
            this.MessageBox.Size = new System.Drawing.Size(225, 184);
            this.MessageBox.TabIndex = 35;
            this.MessageBox.Text = "";
            // 
            // DisLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 238);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Office);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Departsment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NamePrepod);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DisLecturer";
            this.Text = "DisLecturer";
            this.Load += new System.EventHandler(this.DisLecturer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NamePrepod;
        private System.Windows.Forms.ComboBox Departsment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Office;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.RichTextBox MessageBox;
    }
}
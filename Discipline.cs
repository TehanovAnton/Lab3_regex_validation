using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OOP_SEM3_L2
{
    public partial class Discipline : Form
    {
        private DisLecturer disLecturer;       
        public DisciplineInfo discipline;
        public ActionForm actionForm;


        public Discipline()
        {
            InitializeComponent();
        }

        public Discipline(ActionForm actionForm)
        {
            InitializeComponent();
            discipline = new DisciplineInfo();
            disLecturer = new DisLecturer(actionForm);
            this.actionForm = actionForm;
        }

        private void Discipline_Load(object sender, EventArgs e)
        {

        }
        private void OkButton_Click(object sender, EventArgs e)
        {                        
            discipline.name = NameDis.Text;
            discipline.course = Course.Text;
            discipline.semester = FirstSemestr.Checked ? FirstSemestr.Text : SecondSemestr.Text;
            discipline.specialty = Spec.Text;
            discipline.controlType = Credit.Checked ? Credit.Text : Exam.Text;
            discipline.numLab = Convert.ToInt32(NumLab.Text);
            discipline.numLectures = Convert.ToInt32(NumLec.Text);
            actionForm.discplineList.Add(discipline);

            this.Hide();
            disLecturer.Show();
        }

        public bool EnterOnlyDigit(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number))
                return e.Handled = false;
            else
                return e.Handled = true;
        }

        private void NumLec_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterOnlyDigit(sender, e);
        }

        private void NumLab_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterOnlyDigit(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Spec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NameDis_TextChanged(object sender, EventArgs e)
        {

        }

        private void Credit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Exam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FirstSemestr_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SecondSemestr_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NumLec_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumLab_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

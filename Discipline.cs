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
using System.ComponentModel.DataAnnotations;

namespace OOP_SEM3_L2
{
    public partial class Discipline : Form
    {
        private DisLecturer disLecturer;
        public DisciplineInfo discipline;
        public ActionForm actionForm;

        private bool Validate(DisciplineInfo discipline) {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(discipline);
            if (!Validator.TryValidateObject(discipline, context, results, true))
            {
                foreach(var error in results)
                    DisciplineMessage.Text += error.ErrorMessage + "\r\n";

                return false;
            }

            return true;
        }


        public Discipline()
        {
            InitializeComponent();
        }

        public Discipline(ActionForm actionForm)
        {
            InitializeComponent();
            disLecturer = new DisLecturer(actionForm);
            this.actionForm = actionForm;
        }

        private void Discipline_Load(object sender, EventArgs e)
        {

        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            discipline = new DisciplineInfo(
                NameDis.Text,
                int.Parse(Course.Text),
                int.Parse(FirstSemestr.Checked ? FirstSemestr.Text : SecondSemestr.Text),
                Spec.Text,
                Credit.Checked ? Credit.Text : Exam.Text,
                int.Parse(NumLec.Text),
                int.Parse(NumLab.Text)
                );

            var results = new List<ValidationResult>();
            var context = new ValidationContext(discipline);
            if (!Validator.TryValidateObject(discipline, context, results, true))
            {
                foreach (var error in results)
                    DisciplineMessage.Text += error.ErrorMessage + "\r\n";
            }
            else
            {
                actionForm.discplineList.Add(discipline);
                this.Hide();
                disLecturer.Show();
            }
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

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_SEM3_L2
{
    public partial class DisLecturer : Form
    {
        public ActionForm actionForm;
        public int lastElement;

        public DisLecturer()
        {
            InitializeComponent();
        }

        public DisLecturer(ActionForm actionForm)
        {
            InitializeComponent();
            lastElement = actionForm.discplineList.Count - 1;
            this.actionForm = actionForm;
        }

        private void DisLecturer_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            lastElement = actionForm.discplineList.Count - 1;
            actionForm.discplineList[lastElement].lecturer.departament = Departsment.Text;
            actionForm.discplineList[lastElement].lecturer.office = Office.Text;
            actionForm.discplineList[lastElement].lecturer.NameLec = NamePrepod.Text;

            this.Hide();
            actionForm.Show();
        }

        private void Office_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number))
                e.Handled = false;
            else
                e.Handled = true; 
        }
    }
}

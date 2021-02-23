using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using OOP_4SEM_3;

namespace OOP_SEM3_L2
{    
    public partial class ActionForm : Form
    {
        public List<DisciplineInfo> discplineList = new List<DisciplineInfo>();
        private Discipline discipline;

        public ActionForm()
        {
            InitializeComponent();
            discipline = new Discipline(this);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewDiscipline_Click(object sender, EventArgs e)
        {
            this.Hide();
            discipline.Show();
        }

        
        private void ListDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutNameDis.Text = "";
            int Lenth = discplineList.Count;

            string JsonString = File.ReadAllText("user.json");
            List<DisciplineInfo> DeJson = JsonConvert.DeserializeObject<List<DisciplineInfo>>(JsonString);
            for (int j = 0; j < Lenth; j++)
            {
                OutNameDis.Text += Convert.ToString("Название дисциплины: " + DeJson[j].name + "\r\n");
                OutNameDis.Text += Convert.ToString("Специальность: " + DeJson[j].specialty + "\r\n");
                OutNameDis.Text += Convert.ToString("Курс: " + DeJson[j].course + "\r\n");
                OutNameDis.Text += Convert.ToString("Семестр: " + DeJson[j].semester + "\r\n");
                OutNameDis.Text += Convert.ToString("Тип контроля: " + DeJson[j].controlType + "\r\n");
                OutNameDis.Text += Convert.ToString("Количество лаб: " + DeJson[j].numLab + "\r\n");
                OutNameDis.Text += Convert.ToString("Количество лекций: " + DeJson[j].numLectures + "\r\n");
                OutNameDis.Text += Convert.ToString("Имя лектора: " + DeJson[j].lecturer.NameLec + "\r\n");
                OutNameDis.Text += Convert.ToString("Кафедра: " + DeJson[j].lecturer.departament + "\r\n");
                OutNameDis.Text += Convert.ToString("кабинет: " + DeJson[j].lecturer.office + "\r\n");
                OutNameDis.Text += "-------------------------" + "\r\n";
            }
        }

        private void FindedLector_Enter(object sender, EventArgs e)
        {
            //string strFindedLector = FindedLector.Text;
            //int Lenth = discplineList.Count;
            //for (int i = 0; i < Lenth; i++)
            //{
            //    if (discplineList[i].lecturer.NameLec == strFindedLector)
            //    {
            //        OutFindInf.Text += "Имя лектора-" + discplineList[i].lecturer.NameLec + "\r\n" +
            //            "Каьинет-" + discplineList[i].lecturer.office + "\r\n" +
            //            "Каыкдра-" + discplineList[i].lecturer.departament;
            //    }
            //    else
            //        OutFindInf.Text = "Нет результатов поиска";
            //}
        }

        private void FindedLector_DoubleClick(object sender, EventArgs e)
        {
            string strFindedLector = FindedLector.Text;
            int Lenth = discplineList.Count;
            OutFindInf.Text = "";
            for (int i = 0; i < Lenth; i++)
            {
                if (discplineList[i].lecturer.NameLec == strFindedLector)
                {
                    OutFindInf.Text += "Имя лектора-" + discplineList[i].lecturer.NameLec + "\r\n" +
                        "Каьинет-" + discplineList[i].lecturer.office + "\r\n" +
                        "Каыкдра-" + discplineList[i].lecturer.departament +
                        "----------" + "\r\n";
                }
                else
                    OutFindInf.Text = "Нет результатов поиска";
            }
            FindedLector.Text = "";
        }

        private void FindedCours_DoubleClick(object sender, EventArgs e)
        {
            string strFindedCourse = FindedCours.Text;
            int Lenth = discplineList.Count;
            OutFindInf.Text = "";
            for (int i = 0; i < Lenth; i++)
            {
                if (discplineList[i].semester == strFindedCourse)
                {
                    OutFindInf.Text += "Имя лектора-" + discplineList[i].lecturer.NameLec + "\r\n" +
                        "Название дисциплины-" + discplineList[i].name + "\r\n" +
                        "----------" + "\r\n";
                }
                else
                    OutFindInf.Text = "Нет результатов поиска";
            }
            FindedCours.Text = "";
        }

        private void FindedSem_DoubleClick(object sender, EventArgs e)
        {
            string strFindedCourse = FindedSem.Text;
            int Lenth = discplineList.Count;
            OutFindInf.Text = "";
            for (int i = 0; i < Lenth; i++)
            {
                if (discplineList[i].course == strFindedCourse)
                {
                    OutFindInf.Text += "Имя лектора-" + discplineList[i].lecturer.NameLec + "\r\n" +
                        "Название дисциплины-" + discplineList[i].name + "\r\n" +
                        "----------" + "\r\n";
                }
                else
                    OutFindInf.Text = "Нет результатов поиска";
            }
            FindedSem.Text = "";
        }

        public void outDisciplineFields(int Lenth)
        {
            for (int j = 0; j < Lenth; j++)
            {
                OutFindInf.Text += Convert.ToString("Название дисциплины: " + discplineList[j].name + "\r\n");
                OutFindInf.Text += Convert.ToString("Специальность: " + discplineList[j].specialty + "\r\n");
                OutFindInf.Text += Convert.ToString("Курс: " + discplineList[j].course + "\r\n");
                OutFindInf.Text += Convert.ToString("Семестр: " + discplineList[j].semester + "\r\n");
                OutFindInf.Text += Convert.ToString("Тип контроля: " + discplineList[j].controlType + "\r\n");
                OutFindInf.Text += Convert.ToString("Количество лаб: " + discplineList[j].numLab + "\r\n");
                OutFindInf.Text += Convert.ToString("Количество лекций: " + discplineList[j].numLectures + "\r\n");
                OutFindInf.Text += Convert.ToString("Имя лектора: " + discplineList[j].lecturer.NameLec + "\r\n");
                OutFindInf.Text += Convert.ToString("Кафедра: " + discplineList[j].lecturer.departament + "\r\n");
                OutFindInf.Text += Convert.ToString("кабинет: " + discplineList[j].lecturer.office + "\r\n");
                OutFindInf.Text += "-------------------------" + "\r\n";
            }
        }
        private void ByCourse_Click(object sender, EventArgs e)
        {
            OutFindInf.Text = "";
            int Lenth = discplineList.Count;
            OOP_4SEM_3.SortinByCourse arg = new OOP_4SEM_3.SortinByCourse();
            discplineList.Sort((IComparer<DisciplineInfo>)arg);
            outDisciplineFields(Lenth);
        }

        private void ByControlType_Click(object sender, EventArgs e)
        {
            OutFindInf.Text = "";
            int Lenth = discplineList.Count;
            OOP_4SEM_3.SortingByControlType arg = new OOP_4SEM_3.SortingByControlType();
            discplineList.Sort((IComparer<DisciplineInfo>)arg);
            outDisciplineFields(Lenth);
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveAs newForm = new SaveAs();
            newForm.Show();

        }

        private void Alldiscipline_Click(object sender, EventArgs e)
        {
            ListDiscipline.Items.Clear();
            for (int i = 0; i < discplineList.Count; i++)
            {
                ListDiscipline.Items.Add(discplineList[i].name);
            }
            File.WriteAllText("user.json", JsonConvert.SerializeObject(discplineList));
        }
    }

    public class Lecturer
    {
        public string departament;
        public string NameLec;
        public string office;
    }
    public class DisciplineInfo
    {
        public Lecturer lecturer = new Lecturer();
        public string name;
        public string course;
        public string semester;
        public string specialty;
        public string controlType;
        public int numLectures;
        public int numLab;
    }
}

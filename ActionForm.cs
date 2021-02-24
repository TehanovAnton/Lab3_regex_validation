using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using OOP_4SEM_3;

namespace OOP_SEM3_L2
{    
    public partial class ActionForm : Form
    {
        public List<DisciplineInfo> discplineList;
        private Discipline discipline;

        public ActionForm()
        {
            InitializeComponent();
            discipline = new Discipline(this);
            discplineList = new List<DisciplineInfo>();
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
                OutNameDis.Text += Convert.ToString("Имя лектора: " + DeJson[j].lecturer.nameLecturer + "\r\n");
                OutNameDis.Text += Convert.ToString("Кафедра: " + DeJson[j].lecturer.departament + "\r\n");
                OutNameDis.Text += Convert.ToString("кабинет: " + DeJson[j].lecturer.office + "\r\n");
                OutNameDis.Text += "-------------------------" + "\r\n";
            }
        }

        private void FindedLector_DoubleClick(object sender, EventArgs e)
        {
            OutFindInf.Text = "";
            foreach (var el in from n in discplineList where n.lecturer.nameLecturer == FindedLector.Text select n.lecturer)
            {
                OutFindInf.Text += "Имя лектора-" + el.nameLecturer + "\r\n" +
                    "Кабинет-" + el.office + "\r\n" +
                    "Кафедра-" + el.departament +
                    "----------" + "\r\n";
            }
            FindedLector.Text = "";
        }

        private void FindedCours_DoubleClick(object sender, EventArgs e)
        {
            
            OutFindInf.Text = "";
            foreach (var el in from n in discplineList where n.course.ToString() == FindedCours.Text select n.lecturer)
            {
                OutFindInf.Text += "Имя лектора-" + el.nameLecturer + "\r\n" +
                        "Название дисциплины-" + el.nameLecturer + "\r\n" +
                        "----------" + "\r\n";
            }
            FindedCours.Text = "";
        }

        private void FindedSem_DoubleClick(object sender, EventArgs e)
        {
            OutFindInf.Text = "";
            foreach (var el in from n in discplineList where n.semester.ToString() == FindedSem.Text select n.lecturer)
            {
                OutFindInf.Text += "Имя лектора-" + el.nameLecturer + "\r\n" +
                        "Название дисциплины-" + el.nameLecturer + "\r\n" +
                        "----------" + "\r\n";
            }
            FindedSem.Text = "";
        }

        public void outDisciplineFields(int Lenth)
        {
            for (int j = 0; j < Lenth; j++)
            {
                DisciplineInfo el = discplineList[j];
                OutFindInf.Text += "Название дисциплины: " + el.name + "\r\n" +
                "Специальность: " + el.specialty + "\r\n" +
                "Курс: " + el.course + "\r\n" +
                "Семестр: " + el.semester + "\r\n" +
                "Тип контроля: " + el.controlType + "\r\n" +
                "Количество лаб: " + el.numLab + "\r\n" +
                "Количество лекций: " + el.numLectures + "\r\n" +
                "Имя лектора: " + el.lecturer.nameLecturer + "\r\n" +
                "Кафедра: " + el.lecturer.departament + "\r\n" +
                "кабинет: " + el.lecturer.office + "\r\n" +
                "-------------------------" + "\r\n";
            }
        }
        private void ByCourse_Click(object sender, EventArgs e)
        {
            OutFindInf.Text = "";
            SortinByCourse arg = new SortinByCourse();
            discplineList.Sort(arg);
            outDisciplineFields(discplineList.Count);
        }

        private void ByControlType_Click(object sender, EventArgs e)
        {
            OutFindInf.Text = "";
            SortingByControlType arg = new SortingByControlType();
            discplineList.Sort(arg);
            outDisciplineFields(discplineList.Count);
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

        private void FindedLector_KeyPress(object sender, KeyPressEventArgs e)
        {
            OutFindInf.Text = "";
            Regex regex = new Regex($@"^{e.KeyChar}\w+");
            foreach (var el in from n in discplineList where regex.IsMatch(n.lecturer.nameLecturer) select n.lecturer)
            {
                OutFindInf.Text += "Имя лектора-" + el.nameLecturer + "\r\n" +
                    "Кабинет-" + el.office + "\r\n" +
                    "Кафедра-" + el.departament +
                    "----------" + "\r\n";
            }
            OutFindInf.Text += ".";
        }
    }

    public class Lecturer
    {
        [Required(AllowEmptyStrings = true)]
        [RegularExpression(@"[а-я, ]+", ErrorMessage = "недопустимое название кафедры")]
        public string departament { get; set; }

        [Required(AllowEmptyStrings = true)]
        [RegularExpression(@"[А-Я,а-я, ,.]", ErrorMessage = "недопустимое название лекции")]
        public string nameLecturer { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "недопустимый/не указаный номер аудитория")]
        public int office { get; set; }

        public Lecturer(string departament, string nameLecturer, int office)
        {
            this.departament = departament;
            this.nameLecturer = nameLecturer;
            this.office = office;
        }

        public Lecturer()
        {
            this.departament = "";
            this.nameLecturer = "";
            this.office = 1;
        }
    }
    public class DisciplineInfo
    {
        [Required]
        public Lecturer lecturer;

        [Required(AllowEmptyStrings = true)]
        [RegularExpression(@"[А-Я,а-я, ]+", ErrorMessage = "недопустимое имя дисциплины")]
        public string name { get; set; }

        [Required]
        [Range(1, 4, ErrorMessage = "недопустимое значение курса")]
        public int course { get; set; }

        [Required]
        [Range(1, 2, ErrorMessage = "недопустимое значение семестра")]
        public int semester { get; set; }

        [Required(AllowEmptyStrings = true)]
        [RegularExpression(@"[А-Я]+", ErrorMessage = "недопустимое имя специальности")]
        public string specialty { get; set; }

        [Required]
        [RegularExpression(@"(Зачёт|Экзамен)", ErrorMessage = "недопустимое имя специальности")]
        public string controlType { get; set; }

        [Required]
        [Range(1, 30, ErrorMessage = "недопустимое количество лекций")]
        public int numLectures { get; set; }

        [Required]
        [Range(1, 15, ErrorMessage = "недопустимое количество лабораторных")]
        public int numLab { get; set; }

        public DisciplineInfo(string name, int course, int semester, string specialty, string controlTyp, int numLectures, int numLab)
        {
            this.name = name;
            this.course = course;
            this.semester = semester;
            this.specialty = specialty;
            this.controlType = controlTyp;
            this.numLectures = numLectures;
            this.numLab = numLab;
        }

        public DisciplineInfo()
        {
            this.name = "";
            this.course = 1;
            this.semester = 1;
            this.specialty = "";
            this.controlType = "з";
            this.numLectures = 1;
            this.numLab = 1;
        }
    }
}

using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class TimingForm : Form
    {
        private Dictionary<string, List<Lesson>> schedule;
    

        public TimingForm()
        {
            InitializeComponent();
            schedule = new Dictionary<string, List<Lesson>>
            {
                { "Понедельник", new List<Lesson> { new Lesson("8:00-9:30", "Матанализ", "109", "Сидоров А.М."), new Lesson("10:10-11:40", "Английский язык", "504", "Юзмухаметова Л.Н.") } },
                { "Вторник", new List<Lesson> { new Lesson("8:00-9:30", "Физическая культура", "УНИКС", "Михайлович С.Д."), new Lesson("10:10-11:40", "Русский язык", "1008", "Суянгулова Л.Н.") } },
                { "Среда", new List<Lesson> { new Lesson("8:00-9:30", "Алгебра и геометрия", "1210", "Карчевский Е.М."), new Lesson("10:10-11:40", "Алгебра и геометрия", "1105", "Гинеятова Д.Х."), new Lesson("12.10 - 13.40", "Матанализ", "109", "Сидоров А.М.") } },
                { "Четверг", new List<Lesson> { new Lesson("8:00-9:30", "История", "109", "Бродовская Л.Н.") } },
                { "Пятница", new List<Lesson> { new Lesson("8:00-9:30", "Физическая культура", "УНИКС", "Михайлович С.Д.") } },
                    { "Суббота", new List<Lesson> { new Lesson("8:00-9:30", "Программирование", "907", "Латыпова Д.С., Фадеева Е.В.") } },
            };
            foreach (var day in schedule.Keys)
            {
                cmbDays.Items.Add(day);
            }
        }
        /// <summary>
        /// для меню с днями недели и для заполнения таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSchedule.Rows.Clear();
            string selectedDay = cmbDays.SelectedItem.ToString();
            foreach (var lesson in schedule[selectedDay])
            {
                dgvSchedule.Rows.Add(lesson.Time, lesson.Subject, lesson.Classroom, lesson.Teacher);
            }
        }
        /// <summary>
        /// для кнопки "Посмотреть карточку занятия"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnViewLessonCard_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count > 0)
            {
                int selectedRow = dgvSchedule.SelectedRows[0].Index;
                string time = dgvSchedule.Rows[selectedRow].Cells[0].Value.ToString();
                string subject = dgvSchedule.Rows[selectedRow].Cells[1].Value.ToString();
                string room = dgvSchedule.Rows[selectedRow].Cells[2].Value.ToString();
                string teacher = dgvSchedule.Rows[selectedRow].Cells[3].Value.ToString();
                string lessonCard = $"Карточка занятий для:\nВремя: {time}\nДисциплина: {subject}\nКабинет: {room}\nПреподаватель: {teacher}";
                MessageBox.Show(lessonCard);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку с необходимым занятием");
            }
        }

        private void GradBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AccForm accForm = new AccForm();    
            accForm.Show();
        }

        private void MarkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MarkForm mark = new MarkForm();
            mark.Show();
        }
    }
}

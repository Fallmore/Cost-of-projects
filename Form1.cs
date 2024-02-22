using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitializeFactorsArrays(); 
            LoadFactors();  
        }

        private void InitializeFactorsArrays() // Инициализация массива факторов элементами формы
        {
            ComboBox[] tempCBox = { PREC, FLEX, RESL, TEAM, PMAT,
                                    RELY, DATA, CPLX, RUSE, DOCU,
                                    ACAP, PCAP, AEXP, PEXP, LTEX, PCON,
                                    TIME, STOR, PVOL,
                                    TOOL, SITE, SCED }; // Создаём временный массив, чтобы удобно заполнить его
                                                        // через список инициализации. Порядок важен, поэтому без foreach
            cBox = tempCBox;    // Присваиваем массиву элементы

            TextBox[] tempTBox = {A, BRAK,
                                  KALOC, AT, ATPROD, SIZEnew, SIZEreuse,
                                  SALARY };             // Создаём временный массив, чтобы удобно заполнить его
                                                        // через список инициализации. Порядок важен, поэтому без foreach
            tBox = tempTBox;    // Присваиваем массиву элементы
        }

        private void LoadFactors() // Загрузка факторов из параметров проекта
        {
            if (Properties.Settings.Default.ComboBoxFactors.Length != 0) // Если параметр не пустой
            {
                for (int i = 0, j = 0; i < cBox.Length; i++, j++) // Проходимся по всему массиву ComboBox
                {
                    if (Properties.Settings.Default.ComboBoxFactors[j] != '-') // Если char не равен "-"
                    {
                        cBox[i].SelectedIndex = Properties.Settings.Default.ComboBoxFactors[j] - '0'; // Обычное присваивание значения
                    }
                    else // Если встречается "-", значит индекс поля ComboBox  "-1"
                    {
                        ++j; // Смещаемся на следующий индекс, на "1"
                        cBox[i].SelectedIndex = Properties.Settings.Default.ComboBoxFactors[j] - '0' - 2; // Присваиваем число -1
                    }
                }
            }

            if (Properties.Settings.Default.TextBoxFactors.Length != 0) // Если параметр не пустой
            {
                string[] nums = Properties.Settings.Default.TextBoxFactors.Split(' '); // Инициализируем массив строк
                                                                                                // с числами из параметра
                for (int i = 0; i < tBox.Length; i++)
                    tBox[i].Text = nums[i];             // Присваивание значения
            }
        }

        private void button1_Click(object sender, EventArgs e) //Кнопка очистить
        {
            foreach (TextBox t in tBox)
                t.Text = string.Empty;
            foreach (ComboBox c in cBox)
                c.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e) //Кнопка рассчитать B
        {
            double prec, flex, resl, team, pmat;

            for (int i = 0; i < 5; i++) // Проверка нужных ComboBox'ов
            {
                if (cBox[i].SelectedIndex == -1)
                {
                    MessageBox.Show("Проверьте введенные данные!", "ПУСТЫЕ ПОЛЯ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            prec = Convert.ToDouble(PREC.Text);
            flex = Convert.ToDouble(FLEX.Text);
            resl = Convert.ToDouble(RESL.Text);
            team = Convert.ToDouble(TEAM.Text);
            pmat = Convert.ToDouble(PMAT.Text);
            B.Text = (1.01 + (prec + flex + resl + team + pmat) / 100).ToString();
        }

        private void button3_Click(object sender, EventArgs e) //Кнопка рассчитать Mp
        {
            double MFP, MFPer, MFPl, MFPr;
            // Множители взяты из приложения А
            // Пустые значения множителя заполнены предыдущим/последующим значением
            double[]
                MFP1 = { 0.75, 0.88, 1.0, 1.15, 1.39, 1.39 },
                MFP2 = { 0.93, 0.93, 1.0, 1.09, 1.19, 1.19 },
                MFP3 = { 0.75, 0.88, 1.0, 1.15, 1.3, 1.66 },
                MFP4 = { 0.91, 0.91, 1.0, 1.14, 1.29, 1.49 },
                MFP5 = { 0.89, 0.95, 1.0, 1.06, 1.13, 1.13 }; //факторы продукта 

            double[]
                MFPer1 = { 1.5, 1.22, 1.0, 0.83, 0.67, 0.67 },
                MFPer2 = { 1.37, 1.16, 1.0, 0.87, 0.74, 0.74 },
                MFPer3 = { 1.22, 1.1, 1.0, 0.89, 0.81, 0.81 },
                MFPer4 = { 1.25, 1.12, 1.0, 0.88, 0.81, 0.81 },
                MFPer5 = { 1.22, 1.1, 1.0, 0.91, 0.84, 0.84 },
                MFPer6 = { 1.24, 1.1, 1.0, 0.92, 0.84, 0.84 }; //факторы персонала

            double[]
                MFPl1 = { 1.0, 1.0, 1.0, 1.11, 1.31, 1.67 },
                MFPl2 = { 1.0, 1.0, 1.0, 1.06, 1.21, 1.57 },
                MFPl3 = { 0.87, 0.87, 1.0, 1.15, 1.3, 1.3 };  //факторы платформы

            double[]
                MFPr1 = { 1.24, 1.12, 1.0, 0.86, 0.72, 0.72 },
                MFPr2 = { 1.25, 1.1, 1.0, 0.92, 0.84, 0.78 },
                MFPr3 = { 1.29, 1.1, 1.0, 1.0, 1.0, 1.0 };   //факторы проекта

            for (int i = 5; i < 22; i++) // Проверка нужных ComboBox'ов
            {
                if (cBox[i].SelectedIndex == -1) 
                {
                    MessageBox.Show("Проверьте введенные данные!", "ПУСТЫЕ ПОЛЯ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //Произведение факторов продукта 
            MFP = MFP1[RELY.SelectedIndex] * MFP2[DATA.SelectedIndex] * MFP3[CPLX.SelectedIndex] *
                  MFP4[RUSE.SelectedIndex] * MFP5[DOCU.SelectedIndex];
            //Произведение факторов персонала
            MFPer = MFPer1[ACAP.SelectedIndex] * MFPer2[PCAP.SelectedIndex] * MFPer3[AEXP.SelectedIndex] *
                    MFPer4[PEXP.SelectedIndex] * MFPer5[LTEX.SelectedIndex] * MFPer6[PCON.SelectedIndex];
            //Произведение факторов платформы
            MFPl = MFPl1[TIME.SelectedIndex] * MFPl2[STOR.SelectedIndex] * MFPl3[PVOL.SelectedIndex];
            //Произведение факторов проекта
            MFPr = MFPr1[TOOL.SelectedIndex] * MFPr2[SITE.SelectedIndex] * MFPr3[SCED.SelectedIndex];

            Mp.Text = (MFPr * MFPl * MFPer * MFP).ToString();

        }

        private void button4_Click(object sender, EventArgs e) //Кнопка рассчитать ЗАТРАТЫ (auto)
        {
            double kaloc, at, atprod;

            if (KALOC.TextLength == 0 || AT.TextLength == 0 || ATPROD.TextLength == 0) // Проверка TextBox'ов
            {
                MessageBox.Show("Проверьте введенные данные!", "ПУСТЫЕ ПОЛЯ", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToDouble(AT.Text) > 101 || Convert.ToDouble(AT.Text) < 0) // Проверка процента генерации кода
            {
                MessageBox.Show("AT должно быть в пределах от 0 до 100!", "ПУСТЫЕ ПОЛЯ", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            kaloc = Convert.ToDouble(KALOC.Text);
            at = Convert.ToDouble(AT.Text);
            atprod = Convert.ToDouble(ATPROD.Text);
            if (atprod != 0)
                AUTO.Text = ((kaloc * (at / 100)) / atprod).ToString();
            else AUTO.Text = "0"; // при эффективности - atprod - равной нулю пусть затраты будут равны нулю
        }

        private void button5_Click(object sender, EventArgs e) //Кнопка рассчитать ЗАТРАТЫ
        {
            double a, brak, K, mp, b, sumAuto, size, humMonth;

            TextBox[] tempBox = { B, Mp, AUTO}; // временная переменная только для foreach

            foreach (TextBox tb in tempBox) // Проверка TextBox'ов
            {
                if (tb.TextLength == 0)
                {
                    MessageBox.Show($"Расcчитайте {tb.Name}!", "ПУСТЫЕ ПОЛЯ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (A.TextLength == 0 || BRAK.TextLength == 0 || SIZEnew.TextLength == 0 || SIZEreuse.TextLength == 0) // Проверка TextBox'ов
            {
                MessageBox.Show("Проверьте введенные данные!", "ПУСТЫЕ ПОЛЯ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            a = Convert.ToDouble(A.Text);
            brak = Convert.ToDouble(BRAK.Text);
            b = Convert.ToDouble(B.Text);
            mp = Convert.ToDouble(Mp.Text);
            sumAuto = Convert.ToDouble(AUTO.Text);
            K = 1 + (brak / 100);
            size = Convert.ToDouble(SIZEnew.Text) + Convert.ToDouble(SIZEreuse.Text);
            humMonth = a * K * Math.Pow(size, b) * mp + sumAuto;
            HUMMONTH.Text = (humMonth).ToString();
        }

        private void button_sum_Click(object sender, EventArgs e) //Кнопка рассчитать Итоговую стоимость
        {
            double salary, humMonth;

            if (SALARY.TextLength == 0) // Если пусто
            {
                MessageBox.Show("Проверьте среднее значение рабочего коэффициента (зарплата)!", "ПУСТЫЕ ПОЛЯ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (HUMMONTH.TextLength == 0) // Если пусто
            {
                MessageBox.Show("Расcчитайте ЗАТРАТЫ (чел.-мес.)!", "ПУСТЫЕ ПОЛЯ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            salary = Convert.ToDouble(SALARY.Text);
            humMonth = Convert.ToDouble(HUMMONTH.Text);

            SUM.Text = (Convert.ToInt64(salary * humMonth)).ToString();
        }
    }
}

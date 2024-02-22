using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private ComboBox[] cBox = new ComboBox[22]; // Массив для быстрого и упорядоченного доступа к факторам
        private TextBox[] tBox = new TextBox[8];    // Массив для быстрого и упорядоченного доступа к факторам

        protected override void Dispose(bool disposing)
        {
            SaveFactors();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void SaveFactors() // Сохранение факторов
        {
            Properties.Settings.Default.ComboBoxFactors = "";
            Properties.Settings.Default.TextBoxFactors = "";

            for (int i = 0; i < cBox.Length; i++)
                Properties.Settings.Default.ComboBoxFactors += cBox[i].SelectedIndex.ToString();
            for (int i = 0; i < tBox.Length; i++)
                Properties.Settings.Default.TextBoxFactors += (tBox[i].TextLength != 0 ? tBox[i].Text : "0") + " ";

            Properties.Settings.Default.Save();
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.BRAK = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.Mp = new System.Windows.Forms.TextBox();
            this.KALOC = new System.Windows.Forms.TextBox();
            this.AT = new System.Windows.Forms.TextBox();
            this.ATPROD = new System.Windows.Forms.TextBox();
            this.AUTO = new System.Windows.Forms.TextBox();
            this.HUMMONTH = new System.Windows.Forms.TextBox();
            this.PREC = new System.Windows.Forms.ComboBox();
            this.Clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.FLEX = new System.Windows.Forms.ComboBox();
            this.RESL = new System.Windows.Forms.ComboBox();
            this.TEAM = new System.Windows.Forms.ComboBox();
            this.PMAT = new System.Windows.Forms.ComboBox();
            this.RELY = new System.Windows.Forms.ComboBox();
            this.DATA = new System.Windows.Forms.ComboBox();
            this.CPLX = new System.Windows.Forms.ComboBox();
            this.RUSE = new System.Windows.Forms.ComboBox();
            this.DOCU = new System.Windows.Forms.ComboBox();
            this.TIME = new System.Windows.Forms.ComboBox();
            this.STOR = new System.Windows.Forms.ComboBox();
            this.PVOL = new System.Windows.Forms.ComboBox();
            this.ACAP = new System.Windows.Forms.ComboBox();
            this.PCAP = new System.Windows.Forms.ComboBox();
            this.AEXP = new System.Windows.Forms.ComboBox();
            this.PEXP = new System.Windows.Forms.ComboBox();
            this.LTEX = new System.Windows.Forms.ComboBox();
            this.PCON = new System.Windows.Forms.ComboBox();
            this.TOOL = new System.Windows.Forms.ComboBox();
            this.SITE = new System.Windows.Forms.ComboBox();
            this.SCED = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.SIZEnew = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.SIZEreuse = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.SALARY = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.SUM = new System.Windows.Forms.TextBox();
            this.button_sum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Процент кода, отброшенного из-за изменения требований BRAK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оценка маштабных факторов (0 - высокое, 5 - низкое):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Предсказуемость:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Гибкость разработки:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Разрешение архитектуры/риска:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(358, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Связность группы:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(358, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Зрелость процесса:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(358, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "B =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(25, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(684, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Для определения множителей поправки Мр оцените следущие факторы затрат (1 - низко" +
    "е, 6 - высокое):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(25, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Факторы продукта:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(25, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Размер базы данных:";
            // 
            // A
            // 
            this.A.AllowDrop = true;
            this.A.Location = new System.Drawing.Point(498, 16);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(75, 20);
            this.A.TabIndex = 1;
            this.A.Text = "2,5";
            // 
            // BRAK
            // 
            this.BRAK.AllowDrop = true;
            this.BRAK.Location = new System.Drawing.Point(498, 48);
            this.BRAK.Name = "BRAK";
            this.BRAK.Size = new System.Drawing.Size(75, 20);
            this.BRAK.TabIndex = 2;
            this.BRAK.Text = "20";
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(392, 167);
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Size = new System.Drawing.Size(75, 20);
            this.B.TabIndex = 9;
            // 
            // Mp
            // 
            this.Mp.Location = new System.Drawing.Point(520, 538);
            this.Mp.Name = "Mp";
            this.Mp.ReadOnly = true;
            this.Mp.Size = new System.Drawing.Size(112, 20);
            this.Mp.TabIndex = 28;
            // 
            // KALOC
            // 
            this.KALOC.AllowDrop = true;
            this.KALOC.Location = new System.Drawing.Point(520, 602);
            this.KALOC.Name = "KALOC";
            this.KALOC.Size = new System.Drawing.Size(75, 20);
            this.KALOC.TabIndex = 29;
            this.KALOC.Text = "1";
            // 
            // AT
            // 
            this.AT.AllowDrop = true;
            this.AT.Location = new System.Drawing.Point(520, 631);
            this.AT.Name = "AT";
            this.AT.Size = new System.Drawing.Size(75, 20);
            this.AT.TabIndex = 30;
            this.AT.Text = "3";
            // 
            // ATPROD
            // 
            this.ATPROD.AllowDrop = true;
            this.ATPROD.Location = new System.Drawing.Point(520, 660);
            this.ATPROD.Name = "ATPROD";
            this.ATPROD.Size = new System.Drawing.Size(75, 20);
            this.ATPROD.TabIndex = 31;
            this.ATPROD.Text = "1";
            // 
            // AUTO
            // 
            this.AUTO.Location = new System.Drawing.Point(148, 750);
            this.AUTO.Name = "AUTO";
            this.AUTO.ReadOnly = true;
            this.AUTO.Size = new System.Drawing.Size(90, 20);
            this.AUTO.TabIndex = 33;
            // 
            // HUMMONTH
            // 
            this.HUMMONTH.Location = new System.Drawing.Point(495, 749);
            this.HUMMONTH.Name = "HUMMONTH";
            this.HUMMONTH.ReadOnly = true;
            this.HUMMONTH.Size = new System.Drawing.Size(58, 20);
            this.HUMMONTH.TabIndex = 35;
            // 
            // PREC
            // 
            this.PREC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PREC.FormattingEnabled = true;
            this.PREC.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.PREC.Location = new System.Drawing.Point(250, 107);
            this.PREC.Name = "PREC";
            this.PREC.Size = new System.Drawing.Size(75, 21);
            this.PREC.TabIndex = 3;
            // 
            // Clear
            // 
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(665, 12);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(172, 70);
            this.Clear.TabIndex = 36;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(498, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 8;
            this.button2.Text = "Рассчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(731, 537);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 20);
            this.button3.TabIndex = 27;
            this.button3.Text = "Рассчитать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(246, 749);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 20);
            this.button4.TabIndex = 32;
            this.button4.Text = "Рассчитать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(559, 750);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 20);
            this.button5.TabIndex = 34;
            this.button5.Text = "Рассчитать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FLEX
            // 
            this.FLEX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FLEX.FormattingEnabled = true;
            this.FLEX.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.FLEX.Location = new System.Drawing.Point(250, 136);
            this.FLEX.Name = "FLEX";
            this.FLEX.Size = new System.Drawing.Size(75, 21);
            this.FLEX.TabIndex = 4;
            // 
            // RESL
            // 
            this.RESL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RESL.FormattingEnabled = true;
            this.RESL.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RESL.Location = new System.Drawing.Point(250, 166);
            this.RESL.Name = "RESL";
            this.RESL.Size = new System.Drawing.Size(75, 21);
            this.RESL.TabIndex = 5;
            // 
            // TEAM
            // 
            this.TEAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TEAM.FormattingEnabled = true;
            this.TEAM.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.TEAM.Location = new System.Drawing.Point(498, 110);
            this.TEAM.Name = "TEAM";
            this.TEAM.Size = new System.Drawing.Size(75, 21);
            this.TEAM.TabIndex = 6;
            // 
            // PMAT
            // 
            this.PMAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PMAT.FormattingEnabled = true;
            this.PMAT.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.PMAT.Location = new System.Drawing.Point(498, 139);
            this.PMAT.Name = "PMAT";
            this.PMAT.Size = new System.Drawing.Size(75, 21);
            this.PMAT.TabIndex = 7;
            // 
            // RELY
            // 
            this.RELY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RELY.FormattingEnabled = true;
            this.RELY.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.RELY.Location = new System.Drawing.Point(379, 253);
            this.RELY.Name = "RELY";
            this.RELY.Size = new System.Drawing.Size(75, 21);
            this.RELY.TabIndex = 10;
            // 
            // DATA
            // 
            this.DATA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DATA.FormattingEnabled = true;
            this.DATA.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.DATA.Location = new System.Drawing.Point(379, 282);
            this.DATA.Name = "DATA";
            this.DATA.Size = new System.Drawing.Size(75, 21);
            this.DATA.TabIndex = 11;
            // 
            // CPLX
            // 
            this.CPLX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CPLX.FormattingEnabled = true;
            this.CPLX.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CPLX.Location = new System.Drawing.Point(379, 311);
            this.CPLX.Name = "CPLX";
            this.CPLX.Size = new System.Drawing.Size(75, 21);
            this.CPLX.TabIndex = 12;
            // 
            // RUSE
            // 
            this.RUSE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RUSE.FormattingEnabled = true;
            this.RUSE.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.RUSE.Location = new System.Drawing.Point(379, 340);
            this.RUSE.Name = "RUSE";
            this.RUSE.Size = new System.Drawing.Size(75, 21);
            this.RUSE.TabIndex = 13;
            // 
            // DOCU
            // 
            this.DOCU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DOCU.FormattingEnabled = true;
            this.DOCU.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.DOCU.Location = new System.Drawing.Point(379, 369);
            this.DOCU.Name = "DOCU";
            this.DOCU.Size = new System.Drawing.Size(75, 21);
            this.DOCU.TabIndex = 14;
            // 
            // TIME
            // 
            this.TIME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TIME.FormattingEnabled = true;
            this.TIME.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.TIME.Location = new System.Drawing.Point(731, 253);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(75, 21);
            this.TIME.TabIndex = 15;
            // 
            // STOR
            // 
            this.STOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.STOR.FormattingEnabled = true;
            this.STOR.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.STOR.Location = new System.Drawing.Point(731, 282);
            this.STOR.Name = "STOR";
            this.STOR.Size = new System.Drawing.Size(75, 21);
            this.STOR.TabIndex = 16;
            // 
            // PVOL
            // 
            this.PVOL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PVOL.FormattingEnabled = true;
            this.PVOL.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.PVOL.Location = new System.Drawing.Point(731, 314);
            this.PVOL.Name = "PVOL";
            this.PVOL.Size = new System.Drawing.Size(75, 21);
            this.PVOL.TabIndex = 17;
            // 
            // ACAP
            // 
            this.ACAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ACAP.FormattingEnabled = true;
            this.ACAP.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.ACAP.Location = new System.Drawing.Point(379, 424);
            this.ACAP.Name = "ACAP";
            this.ACAP.Size = new System.Drawing.Size(75, 21);
            this.ACAP.TabIndex = 18;
            // 
            // PCAP
            // 
            this.PCAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PCAP.FormattingEnabled = true;
            this.PCAP.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.PCAP.Location = new System.Drawing.Point(379, 453);
            this.PCAP.Name = "PCAP";
            this.PCAP.Size = new System.Drawing.Size(75, 21);
            this.PCAP.TabIndex = 19;
            // 
            // AEXP
            // 
            this.AEXP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AEXP.FormattingEnabled = true;
            this.AEXP.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.AEXP.Location = new System.Drawing.Point(379, 482);
            this.AEXP.Name = "AEXP";
            this.AEXP.Size = new System.Drawing.Size(75, 21);
            this.AEXP.TabIndex = 20;
            // 
            // PEXP
            // 
            this.PEXP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PEXP.FormattingEnabled = true;
            this.PEXP.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.PEXP.Location = new System.Drawing.Point(379, 511);
            this.PEXP.Name = "PEXP";
            this.PEXP.Size = new System.Drawing.Size(75, 21);
            this.PEXP.TabIndex = 21;
            // 
            // LTEX
            // 
            this.LTEX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LTEX.FormattingEnabled = true;
            this.LTEX.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.LTEX.Location = new System.Drawing.Point(379, 540);
            this.LTEX.Name = "LTEX";
            this.LTEX.Size = new System.Drawing.Size(75, 21);
            this.LTEX.TabIndex = 22;
            // 
            // PCON
            // 
            this.PCON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PCON.FormattingEnabled = true;
            this.PCON.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.PCON.Location = new System.Drawing.Point(379, 569);
            this.PCON.Name = "PCON";
            this.PCON.Size = new System.Drawing.Size(75, 21);
            this.PCON.TabIndex = 23;
            // 
            // TOOL
            // 
            this.TOOL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TOOL.FormattingEnabled = true;
            this.TOOL.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.TOOL.Location = new System.Drawing.Point(731, 426);
            this.TOOL.Name = "TOOL";
            this.TOOL.Size = new System.Drawing.Size(75, 21);
            this.TOOL.TabIndex = 24;
            // 
            // SITE
            // 
            this.SITE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SITE.FormattingEnabled = true;
            this.SITE.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.SITE.Location = new System.Drawing.Point(731, 455);
            this.SITE.Name = "SITE";
            this.SITE.Size = new System.Drawing.Size(75, 21);
            this.SITE.TabIndex = 25;
            // 
            // SCED
            // 
            this.SCED.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SCED.FormattingEnabled = true;
            this.SCED.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.SCED.Location = new System.Drawing.Point(731, 484);
            this.SCED.Name = "SCED";
            this.SCED.Size = new System.Drawing.Size(75, 21);
            this.SCED.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(25, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 16);
            this.label13.TabIndex = 74;
            this.label13.Text = "Сложность продукта:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(25, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(267, 16);
            this.label14.TabIndex = 75;
            this.label14.Text = "Требуемая повторная используемость:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(25, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 16);
            this.label15.TabIndex = 76;
            this.label15.Text = "Требуемая надежность:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(25, 371);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(352, 16);
            this.label16.TabIndex = 77;
            this.label16.Text = "Документированние требований жизненного цикла:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(476, 226);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(349, 17);
            this.label17.TabIndex = 78;
            this.label17.Text = "Факторы платформы (виртуальной машины):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(476, 255);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(240, 16);
            this.label18.TabIndex = 79;
            this.label18.Text = "Ограничения времени выполнения:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(476, 284);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(237, 16);
            this.label19.TabIndex = 80;
            this.label19.Text = "Ограничения оперативной памяти:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(476, 313);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(185, 16);
            this.label20.TabIndex = 81;
            this.label20.Text = "Изменчивость платформы:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(25, 400);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(166, 17);
            this.label21.TabIndex = 82;
            this.label21.Text = "Факторы персонала:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(25, 429);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(172, 16);
            this.label22.TabIndex = 83;
            this.label22.Text = "Возможности аналитика:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "Масштабный коэффициент (А):";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(25, 458);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(193, 16);
            this.label23.TabIndex = 85;
            this.label23.Text = "Возможности программиста";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(25, 487);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(198, 16);
            this.label24.TabIndex = 86;
            this.label24.Text = "Опыт работы с приложением:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(25, 516);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(191, 16);
            this.label25.TabIndex = 87;
            this.label25.Text = "Опыт работы с платформой:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(25, 545);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(241, 16);
            this.label26.TabIndex = 88;
            this.label26.Text = "Опыт работы с языком и утилитами:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(25, 574);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(188, 16);
            this.label27.TabIndex = 89;
            this.label27.Text = "Непрерывность персонала:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(476, 400);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(147, 17);
            this.label28.TabIndex = 90;
            this.label28.Text = "Факторы проекта:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(476, 429);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(253, 16);
            this.label29.TabIndex = 91;
            this.label29.Text = "Использование программных утилит:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(476, 458);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(193, 16);
            this.label30.TabIndex = 92;
            this.label30.Text = "Мультисетевая разработка:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(476, 487);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(217, 16);
            this.label31.TabIndex = 93;
            this.label31.Text = "Требуемый график разработки:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(481, 540);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(36, 16);
            this.label32.TabIndex = 94;
            this.label32.Text = "Мр =";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.Location = new System.Drawing.Point(25, 603);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(493, 32);
            this.label33.TabIndex = 95;
            this.label33.Text = "Количество строк автоматически генерируемого кода (тыс. строк) KALOC:\r\n\r\n";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.Location = new System.Drawing.Point(25, 632);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(488, 16);
            this.label34.TabIndex = 96;
            this.label34.Text = "Процент автоматически генерируемого кода (от всего кода системы) AT:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.Location = new System.Drawing.Point(25, 661);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(430, 16);
            this.label35.TabIndex = 97;
            this.label35.Text = "Производительность автоматической генерации кода ATPROD:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.Location = new System.Drawing.Point(25, 752);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(119, 16);
            this.label36.TabIndex = 98;
            this.label36.Text = "ЗАТРАТЫ (auto) =";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.Location = new System.Drawing.Point(341, 751);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(151, 16);
            this.label37.TabIndex = 99;
            this.label37.Text = "ЗАТРАТЫ (чел.-мес.) =";
            // 
            // SIZEnew
            // 
            this.SIZEnew.AllowDrop = true;
            this.SIZEnew.Location = new System.Drawing.Point(520, 687);
            this.SIZEnew.Name = "SIZEnew";
            this.SIZEnew.Size = new System.Drawing.Size(75, 20);
            this.SIZEnew.TabIndex = 103;
            this.SIZEnew.Text = "1";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label40.Location = new System.Drawing.Point(25, 688);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(317, 16);
            this.label40.TabIndex = 105;
            this.label40.Text = "Размер нового программного кода (тыс. строк):";
            // 
            // SIZEreuse
            // 
            this.SIZEreuse.AllowDrop = true;
            this.SIZEreuse.Location = new System.Drawing.Point(520, 717);
            this.SIZEreuse.Name = "SIZEreuse";
            this.SIZEreuse.Size = new System.Drawing.Size(75, 20);
            this.SIZEreuse.TabIndex = 101;
            this.SIZEreuse.Text = "0,1";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label38.Location = new System.Drawing.Point(25, 718);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(438, 16);
            this.label38.TabIndex = 100;
            this.label38.Text = "Размер повторно используемого программного кода (тыс. строк):";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.Location = new System.Drawing.Point(643, 616);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(199, 32);
            this.label39.TabIndex = 106;
            this.label39.Text = "Среднее значение рабочего \r\nкоэффициента (зарплата):";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SALARY
            // 
            this.SALARY.AllowDrop = true;
            this.SALARY.Location = new System.Drawing.Point(705, 661);
            this.SALARY.Name = "SALARY";
            this.SALARY.Size = new System.Drawing.Size(75, 20);
            this.SALARY.TabIndex = 107;
            this.SALARY.Text = "1000";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.Location = new System.Drawing.Point(663, 695);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(162, 16);
            this.label41.TabIndex = 108;
            this.label41.Text = "Итоговая стоимость:";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SUM
            // 
            this.SUM.Location = new System.Drawing.Point(665, 724);
            this.SUM.Name = "SUM";
            this.SUM.ReadOnly = true;
            this.SUM.Size = new System.Drawing.Size(159, 20);
            this.SUM.TabIndex = 109;
            this.SUM.Text = "0";
            // 
            // button_sum
            // 
            this.button_sum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sum.Location = new System.Drawing.Point(665, 752);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(158, 27);
            this.button_sum.TabIndex = 110;
            this.button_sum.Text = "Рассчитать";
            this.button_sum.UseVisualStyleBackColor = true;
            this.button_sum.Click += new System.EventHandler(this.button_sum_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 791);
            this.Controls.Add(this.button_sum);
            this.Controls.Add(this.SUM);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.SALARY);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.SIZEnew);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.SIZEreuse);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.PVOL);
            this.Controls.Add(this.ACAP);
            this.Controls.Add(this.PCAP);
            this.Controls.Add(this.AEXP);
            this.Controls.Add(this.PEXP);
            this.Controls.Add(this.LTEX);
            this.Controls.Add(this.PCON);
            this.Controls.Add(this.TOOL);
            this.Controls.Add(this.SITE);
            this.Controls.Add(this.SCED);
            this.Controls.Add(this.STOR);
            this.Controls.Add(this.TIME);
            this.Controls.Add(this.DOCU);
            this.Controls.Add(this.RUSE);
            this.Controls.Add(this.CPLX);
            this.Controls.Add(this.DATA);
            this.Controls.Add(this.RELY);
            this.Controls.Add(this.PMAT);
            this.Controls.Add(this.TEAM);
            this.Controls.Add(this.RESL);
            this.Controls.Add(this.FLEX);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.PREC);
            this.Controls.Add(this.HUMMONTH);
            this.Controls.Add(this.AUTO);
            this.Controls.Add(this.ATPROD);
            this.Controls.Add(this.AT);
            this.Controls.Add(this.KALOC);
            this.Controls.Add(this.Mp);
            this.Controls.Add(this.B);
            this.Controls.Add(this.BRAK);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Расчет затрат на ПО";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox BRAK;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox Mp;
        private System.Windows.Forms.TextBox KALOC;
        private System.Windows.Forms.TextBox AT;
        private System.Windows.Forms.TextBox ATPROD;
        private System.Windows.Forms.TextBox AUTO;
        private System.Windows.Forms.TextBox HUMMONTH;
        public System.Windows.Forms.ComboBox PREC;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox FLEX;
        private System.Windows.Forms.ComboBox RESL;
        private System.Windows.Forms.ComboBox TEAM;
        private System.Windows.Forms.ComboBox PMAT;
        private System.Windows.Forms.ComboBox RELY;
        private System.Windows.Forms.ComboBox DATA;
        private System.Windows.Forms.ComboBox CPLX;
        private System.Windows.Forms.ComboBox RUSE;
        private System.Windows.Forms.ComboBox DOCU;
        private System.Windows.Forms.ComboBox TIME;
        private System.Windows.Forms.ComboBox STOR;
        private System.Windows.Forms.ComboBox PVOL;
        private System.Windows.Forms.ComboBox ACAP;
        private System.Windows.Forms.ComboBox PCAP;
        private System.Windows.Forms.ComboBox AEXP;
        private System.Windows.Forms.ComboBox PEXP;
        private System.Windows.Forms.ComboBox LTEX;
        private System.Windows.Forms.ComboBox PCON;
        private System.Windows.Forms.ComboBox TOOL;
        private System.Windows.Forms.ComboBox SITE;
        private System.Windows.Forms.ComboBox SCED;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox SIZEnew;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox SIZEreuse;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox SALARY;
        private Label label41;
        private TextBox SUM;
        private Button button_sum;
    }
}


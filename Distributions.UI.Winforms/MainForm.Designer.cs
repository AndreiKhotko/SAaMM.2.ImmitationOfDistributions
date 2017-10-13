namespace Distributions.UI.Winforms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxDistributions = new System.Windows.Forms.GroupBox();
            this.radioBtnSimpsons = new System.Windows.Forms.RadioButton();
            this.radioBtnExponential = new System.Windows.Forms.RadioButton();
            this.radioBtnGaussian = new System.Windows.Forms.RadioButton();
            this.radioBtnTriangular = new System.Windows.Forms.RadioButton();
            this.radioBtnUniform = new System.Windows.Forms.RadioButton();
            this.radioBtnGamma = new System.Windows.Forms.RadioButton();
            this.groupBoxUniform = new System.Windows.Forms.GroupBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.groupBoxGaussian = new System.Windows.Forms.GroupBox();
            this.textBoxQParameter = new System.Windows.Forms.TextBox();
            this.textBoxMParameter = new System.Windows.Forms.TextBox();
            this.lblQParameter = new System.Windows.Forms.Label();
            this.lblMParameter = new System.Windows.Forms.Label();
            this.groupBoxExponential = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLambda = new System.Windows.Forms.TextBox();
            this.lblLambda = new System.Windows.Forms.Label();
            this.groupBoxGamma = new System.Windows.Forms.GroupBox();
            this.numericUpDownEta = new System.Windows.Forms.NumericUpDown();
            this.lblEta = new System.Windows.Forms.Label();
            this.textBoxLambdaG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxGeneratedValues = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxEvaluations = new System.Windows.Forms.GroupBox();
            this.textBoxQActual = new System.Windows.Forms.TextBox();
            this.textBoxDActual = new System.Windows.Forms.TextBox();
            this.textBoxMActual = new System.Windows.Forms.TextBox();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.groupBoxTriangular = new System.Windows.Forms.GroupBox();
            this.groupBoxVariant = new System.Windows.Forms.GroupBox();
            this.radioBtnVariant2 = new System.Windows.Forms.RadioButton();
            this.radioBtnVariant1 = new System.Windows.Forms.RadioButton();
            this.textBoxBT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxSimpsons = new System.Windows.Forms.GroupBox();
            this.textBoxBS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxDistributions.SuspendLayout();
            this.groupBoxUniform.SuspendLayout();
            this.groupBoxGaussian.SuspendLayout();
            this.groupBoxExponential.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBoxGamma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBoxEvaluations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            this.groupBoxTriangular.SuspendLayout();
            this.groupBoxVariant.SuspendLayout();
            this.groupBoxSimpsons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDistributions
            // 
            this.groupBoxDistributions.Controls.Add(this.radioBtnSimpsons);
            this.groupBoxDistributions.Controls.Add(this.radioBtnExponential);
            this.groupBoxDistributions.Controls.Add(this.radioBtnGaussian);
            this.groupBoxDistributions.Controls.Add(this.radioBtnTriangular);
            this.groupBoxDistributions.Controls.Add(this.radioBtnUniform);
            this.groupBoxDistributions.Controls.Add(this.radioBtnGamma);
            this.groupBoxDistributions.Location = new System.Drawing.Point(22, 26);
            this.groupBoxDistributions.Name = "groupBoxDistributions";
            this.groupBoxDistributions.Size = new System.Drawing.Size(234, 230);
            this.groupBoxDistributions.TabIndex = 0;
            this.groupBoxDistributions.TabStop = false;
            this.groupBoxDistributions.Text = "Распределение";
            // 
            // radioBtnSimpsons
            // 
            this.radioBtnSimpsons.AutoSize = true;
            this.radioBtnSimpsons.Location = new System.Drawing.Point(15, 192);
            this.radioBtnSimpsons.Name = "radioBtnSimpsons";
            this.radioBtnSimpsons.Size = new System.Drawing.Size(154, 17);
            this.radioBtnSimpsons.TabIndex = 6;
            this.radioBtnSimpsons.TabStop = true;
            this.radioBtnSimpsons.Text = "Распределение Симпсона";
            this.radioBtnSimpsons.UseVisualStyleBackColor = true;
            this.radioBtnSimpsons.CheckedChanged += new System.EventHandler(this.radioBtnSimpsons_CheckedChanged);
            // 
            // radioBtnExponential
            // 
            this.radioBtnExponential.AutoSize = true;
            this.radioBtnExponential.Location = new System.Drawing.Point(15, 95);
            this.radioBtnExponential.Name = "radioBtnExponential";
            this.radioBtnExponential.Size = new System.Drawing.Size(202, 17);
            this.radioBtnExponential.TabIndex = 3;
            this.radioBtnExponential.TabStop = true;
            this.radioBtnExponential.Text = "Экспоненциальное распределение";
            this.radioBtnExponential.UseVisualStyleBackColor = true;
            this.radioBtnExponential.CheckedChanged += new System.EventHandler(this.radioBtnExponential_CheckedChanged);
            // 
            // radioBtnGaussian
            // 
            this.radioBtnGaussian.AutoSize = true;
            this.radioBtnGaussian.Location = new System.Drawing.Point(15, 62);
            this.radioBtnGaussian.Name = "radioBtnGaussian";
            this.radioBtnGaussian.Size = new System.Drawing.Size(169, 17);
            this.radioBtnGaussian.TabIndex = 2;
            this.radioBtnGaussian.TabStop = true;
            this.radioBtnGaussian.Text = "Гауссовское распределение";
            this.radioBtnGaussian.UseVisualStyleBackColor = true;
            this.radioBtnGaussian.CheckedChanged += new System.EventHandler(this.radioBtnGaussian_CheckedChanged);
            // 
            // radioBtnTriangular
            // 
            this.radioBtnTriangular.AutoSize = true;
            this.radioBtnTriangular.Location = new System.Drawing.Point(15, 160);
            this.radioBtnTriangular.Name = "radioBtnTriangular";
            this.radioBtnTriangular.Size = new System.Drawing.Size(171, 17);
            this.radioBtnTriangular.TabIndex = 5;
            this.radioBtnTriangular.TabStop = true;
            this.radioBtnTriangular.Text = "Треугольное распределение";
            this.radioBtnTriangular.UseVisualStyleBackColor = true;
            this.radioBtnTriangular.CheckedChanged += new System.EventHandler(this.radioBtnTriangular_CheckedChanged);
            // 
            // radioBtnUniform
            // 
            this.radioBtnUniform.AutoSize = true;
            this.radioBtnUniform.Location = new System.Drawing.Point(15, 30);
            this.radioBtnUniform.Name = "radioBtnUniform";
            this.radioBtnUniform.Size = new System.Drawing.Size(172, 17);
            this.radioBtnUniform.TabIndex = 1;
            this.radioBtnUniform.TabStop = true;
            this.radioBtnUniform.Text = "Равномерное распределение";
            this.radioBtnUniform.UseVisualStyleBackColor = true;
            this.radioBtnUniform.CheckedChanged += new System.EventHandler(this.radioBtnUniform_CheckedChanged);
            // 
            // radioBtnGamma
            // 
            this.radioBtnGamma.AutoSize = true;
            this.radioBtnGamma.Location = new System.Drawing.Point(15, 127);
            this.radioBtnGamma.Name = "radioBtnGamma";
            this.radioBtnGamma.Size = new System.Drawing.Size(137, 17);
            this.radioBtnGamma.TabIndex = 4;
            this.radioBtnGamma.TabStop = true;
            this.radioBtnGamma.Text = "Гамма-распределение";
            this.radioBtnGamma.UseVisualStyleBackColor = true;
            this.radioBtnGamma.CheckedChanged += new System.EventHandler(this.radioBtnGamma_CheckedChanged);
            // 
            // groupBoxUniform
            // 
            this.groupBoxUniform.Controls.Add(this.textBoxB);
            this.groupBoxUniform.Controls.Add(this.textBoxA);
            this.groupBoxUniform.Controls.Add(this.lblB);
            this.groupBoxUniform.Controls.Add(this.lblA);
            this.groupBoxUniform.Location = new System.Drawing.Point(12, 587);
            this.groupBoxUniform.Name = "groupBoxUniform";
            this.groupBoxUniform.Size = new System.Drawing.Size(222, 171);
            this.groupBoxUniform.TabIndex = 1;
            this.groupBoxUniform.TabStop = false;
            this.groupBoxUniform.Text = "Параметры";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(50, 59);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 21);
            this.textBoxB.TabIndex = 3;
            this.textBoxB.Text = "1";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(50, 30);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 21);
            this.textBoxA.TabIndex = 2;
            this.textBoxA.Text = "0";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(18, 62);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(13, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "b";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(18, 30);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(13, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "a";
            // 
            // groupBoxGaussian
            // 
            this.groupBoxGaussian.Controls.Add(this.textBoxQParameter);
            this.groupBoxGaussian.Controls.Add(this.textBoxMParameter);
            this.groupBoxGaussian.Controls.Add(this.lblQParameter);
            this.groupBoxGaussian.Controls.Add(this.lblMParameter);
            this.groupBoxGaussian.Location = new System.Drawing.Point(480, 586);
            this.groupBoxGaussian.Name = "groupBoxGaussian";
            this.groupBoxGaussian.Size = new System.Drawing.Size(222, 170);
            this.groupBoxGaussian.TabIndex = 9;
            this.groupBoxGaussian.TabStop = false;
            this.groupBoxGaussian.Text = "Параметры";
            // 
            // textBoxQParameter
            // 
            this.textBoxQParameter.Location = new System.Drawing.Point(50, 59);
            this.textBoxQParameter.Name = "textBoxQParameter";
            this.textBoxQParameter.Size = new System.Drawing.Size(100, 21);
            this.textBoxQParameter.TabIndex = 3;
            this.textBoxQParameter.Text = "1";
            // 
            // textBoxMParameter
            // 
            this.textBoxMParameter.Location = new System.Drawing.Point(50, 30);
            this.textBoxMParameter.Name = "textBoxMParameter";
            this.textBoxMParameter.Size = new System.Drawing.Size(100, 21);
            this.textBoxMParameter.TabIndex = 2;
            this.textBoxMParameter.Text = "0";
            // 
            // lblQParameter
            // 
            this.lblQParameter.AutoSize = true;
            this.lblQParameter.Location = new System.Drawing.Point(18, 62);
            this.lblQParameter.Name = "lblQParameter";
            this.lblQParameter.Size = new System.Drawing.Size(13, 13);
            this.lblQParameter.TabIndex = 1;
            this.lblQParameter.Text = "q";
            // 
            // lblMParameter
            // 
            this.lblMParameter.AutoSize = true;
            this.lblMParameter.Location = new System.Drawing.Point(18, 30);
            this.lblMParameter.Name = "lblMParameter";
            this.lblMParameter.Size = new System.Drawing.Size(15, 13);
            this.lblMParameter.TabIndex = 0;
            this.lblMParameter.Text = "m";
            // 
            // groupBoxExponential
            // 
            this.groupBoxExponential.Controls.Add(this.numericUpDown3);
            this.groupBoxExponential.Controls.Add(this.label3);
            this.groupBoxExponential.Controls.Add(this.textBoxLambda);
            this.groupBoxExponential.Controls.Add(this.lblLambda);
            this.groupBoxExponential.Location = new System.Drawing.Point(723, 586);
            this.groupBoxExponential.Name = "groupBoxExponential";
            this.groupBoxExponential.Size = new System.Drawing.Size(222, 170);
            this.groupBoxExponential.TabIndex = 10;
            this.groupBoxExponential.TabStop = false;
            this.groupBoxExponential.Text = "Параметры";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(50, 192);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Длина последовательности:";
            // 
            // textBoxLambda
            // 
            this.textBoxLambda.Location = new System.Drawing.Point(65, 27);
            this.textBoxLambda.Name = "textBoxLambda";
            this.textBoxLambda.Size = new System.Drawing.Size(100, 21);
            this.textBoxLambda.TabIndex = 2;
            this.textBoxLambda.Text = "4";
            // 
            // lblLambda
            // 
            this.lblLambda.AutoSize = true;
            this.lblLambda.Location = new System.Drawing.Point(18, 30);
            this.lblLambda.Name = "lblLambda";
            this.lblLambda.Size = new System.Drawing.Size(41, 13);
            this.lblLambda.TabIndex = 0;
            this.lblLambda.Text = "lambda";
            // 
            // groupBoxGamma
            // 
            this.groupBoxGamma.Controls.Add(this.numericUpDownEta);
            this.groupBoxGamma.Controls.Add(this.lblEta);
            this.groupBoxGamma.Controls.Add(this.textBoxLambdaG);
            this.groupBoxGamma.Controls.Add(this.label5);
            this.groupBoxGamma.Location = new System.Drawing.Point(242, 587);
            this.groupBoxGamma.Name = "groupBoxGamma";
            this.groupBoxGamma.Size = new System.Drawing.Size(222, 169);
            this.groupBoxGamma.TabIndex = 11;
            this.groupBoxGamma.TabStop = false;
            this.groupBoxGamma.Text = "Параметры";
            // 
            // numericUpDownEta
            // 
            this.numericUpDownEta.Location = new System.Drawing.Point(62, 68);
            this.numericUpDownEta.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownEta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEta.Name = "numericUpDownEta";
            this.numericUpDownEta.Size = new System.Drawing.Size(103, 21);
            this.numericUpDownEta.TabIndex = 7;
            this.numericUpDownEta.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.Location = new System.Drawing.Point(33, 70);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(23, 13);
            this.lblEta.TabIndex = 8;
            this.lblEta.Text = "eta";
            // 
            // textBoxLambdaG
            // 
            this.textBoxLambdaG.Location = new System.Drawing.Point(62, 27);
            this.textBoxLambdaG.Name = "textBoxLambdaG";
            this.textBoxLambdaG.Size = new System.Drawing.Size(100, 21);
            this.textBoxLambdaG.TabIndex = 2;
            this.textBoxLambdaG.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "lambda";
            // 
            // listBoxGeneratedValues
            // 
            this.listBoxGeneratedValues.FormattingEnabled = true;
            this.listBoxGeneratedValues.Location = new System.Drawing.Point(617, 44);
            this.listBoxGeneratedValues.Name = "listBoxGeneratedValues";
            this.listBoxGeneratedValues.Size = new System.Drawing.Size(208, 212);
            this.listBoxGeneratedValues.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сгенерированная последовательность:";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(22, 278);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "GeneratedValues";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(544, 300);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart";
            // 
            // groupBoxEvaluations
            // 
            this.groupBoxEvaluations.Controls.Add(this.textBoxQActual);
            this.groupBoxEvaluations.Controls.Add(this.textBoxDActual);
            this.groupBoxEvaluations.Controls.Add(this.textBoxMActual);
            this.groupBoxEvaluations.Controls.Add(this.lblQ);
            this.groupBoxEvaluations.Controls.Add(this.lblD);
            this.groupBoxEvaluations.Controls.Add(this.lblM);
            this.groupBoxEvaluations.Location = new System.Drawing.Point(617, 278);
            this.groupBoxEvaluations.Name = "groupBoxEvaluations";
            this.groupBoxEvaluations.Size = new System.Drawing.Size(200, 300);
            this.groupBoxEvaluations.TabIndex = 5;
            this.groupBoxEvaluations.TabStop = false;
            this.groupBoxEvaluations.Text = "Оценки";
            // 
            // textBoxQActual
            // 
            this.textBoxQActual.Location = new System.Drawing.Point(78, 242);
            this.textBoxQActual.Name = "textBoxQActual";
            this.textBoxQActual.Size = new System.Drawing.Size(109, 21);
            this.textBoxQActual.TabIndex = 5;
            // 
            // textBoxDActual
            // 
            this.textBoxDActual.Location = new System.Drawing.Point(78, 141);
            this.textBoxDActual.Name = "textBoxDActual";
            this.textBoxDActual.Size = new System.Drawing.Size(109, 21);
            this.textBoxDActual.TabIndex = 4;
            // 
            // textBoxMActual
            // 
            this.textBoxMActual.Location = new System.Drawing.Point(78, 52);
            this.textBoxMActual.Name = "textBoxMActual";
            this.textBoxMActual.Size = new System.Drawing.Size(109, 21);
            this.textBoxMActual.TabIndex = 3;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(6, 214);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(181, 13);
            this.lblQ.TabIndex = 2;
            this.lblQ.Text = "Среднеквадратичное отклонение";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(5, 113);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(61, 13);
            this.lblD.TabIndex = 1;
            this.lblD.Text = "Дисперсия";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(6, 27);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(146, 13);
            this.lblM.TabIndex = 0;
            this.lblM.Text = "Математическое ожидание";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(522, 118);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(89, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Генерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.Location = new System.Drawing.Point(344, 232);
            this.numericUpDownLength.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownLength.TabIndex = 6;
            this.numericUpDownLength.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(327, 214);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(153, 13);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Длина последовательности:";
            // 
            // groupBoxTriangular
            // 
            this.groupBoxTriangular.Controls.Add(this.groupBoxVariant);
            this.groupBoxTriangular.Controls.Add(this.textBoxBT);
            this.groupBoxTriangular.Controls.Add(this.label2);
            this.groupBoxTriangular.Controls.Add(this.textBoxAT);
            this.groupBoxTriangular.Controls.Add(this.label4);
            this.groupBoxTriangular.Location = new System.Drawing.Point(294, 28);
            this.groupBoxTriangular.Name = "groupBoxTriangular";
            this.groupBoxTriangular.Size = new System.Drawing.Size(222, 170);
            this.groupBoxTriangular.TabIndex = 12;
            this.groupBoxTriangular.TabStop = false;
            this.groupBoxTriangular.Text = "Параметры";
            // 
            // groupBoxVariant
            // 
            this.groupBoxVariant.Controls.Add(this.radioBtnVariant2);
            this.groupBoxVariant.Controls.Add(this.radioBtnVariant1);
            this.groupBoxVariant.Location = new System.Drawing.Point(38, 84);
            this.groupBoxVariant.Name = "groupBoxVariant";
            this.groupBoxVariant.Size = new System.Drawing.Size(150, 78);
            this.groupBoxVariant.TabIndex = 5;
            this.groupBoxVariant.TabStop = false;
            this.groupBoxVariant.Text = "Вариант плотности:";
            // 
            // radioBtnVariant2
            // 
            this.radioBtnVariant2.AutoSize = true;
            this.radioBtnVariant2.Location = new System.Drawing.Point(7, 47);
            this.radioBtnVariant2.Name = "radioBtnVariant2";
            this.radioBtnVariant2.Size = new System.Drawing.Size(31, 17);
            this.radioBtnVariant2.TabIndex = 1;
            this.radioBtnVariant2.TabStop = true;
            this.radioBtnVariant2.Text = "2";
            this.radioBtnVariant2.UseVisualStyleBackColor = true;
            // 
            // radioBtnVariant1
            // 
            this.radioBtnVariant1.AutoSize = true;
            this.radioBtnVariant1.Checked = true;
            this.radioBtnVariant1.Location = new System.Drawing.Point(7, 24);
            this.radioBtnVariant1.Name = "radioBtnVariant1";
            this.radioBtnVariant1.Size = new System.Drawing.Size(31, 17);
            this.radioBtnVariant1.TabIndex = 0;
            this.radioBtnVariant1.TabStop = true;
            this.radioBtnVariant1.Text = "1";
            this.radioBtnVariant1.UseVisualStyleBackColor = true;
            // 
            // textBoxBT
            // 
            this.textBoxBT.Location = new System.Drawing.Point(62, 57);
            this.textBoxBT.Name = "textBoxBT";
            this.textBoxBT.Size = new System.Drawing.Size(100, 21);
            this.textBoxBT.TabIndex = 4;
            this.textBoxBT.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "b";
            // 
            // textBoxAT
            // 
            this.textBoxAT.Location = new System.Drawing.Point(62, 27);
            this.textBoxAT.Name = "textBoxAT";
            this.textBoxAT.Size = new System.Drawing.Size(100, 21);
            this.textBoxAT.TabIndex = 2;
            this.textBoxAT.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "a";
            // 
            // groupBoxSimpsons
            // 
            this.groupBoxSimpsons.Controls.Add(this.textBoxBS);
            this.groupBoxSimpsons.Controls.Add(this.label6);
            this.groupBoxSimpsons.Controls.Add(this.textBoxAS);
            this.groupBoxSimpsons.Controls.Add(this.label7);
            this.groupBoxSimpsons.Location = new System.Drawing.Point(837, 278);
            this.groupBoxSimpsons.Name = "groupBoxSimpsons";
            this.groupBoxSimpsons.Size = new System.Drawing.Size(222, 170);
            this.groupBoxSimpsons.TabIndex = 13;
            this.groupBoxSimpsons.TabStop = false;
            this.groupBoxSimpsons.Text = "Параметры";
            // 
            // textBoxBS
            // 
            this.textBoxBS.Location = new System.Drawing.Point(62, 57);
            this.textBoxBS.Name = "textBoxBS";
            this.textBoxBS.Size = new System.Drawing.Size(100, 21);
            this.textBoxBS.TabIndex = 4;
            this.textBoxBS.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "b";
            // 
            // textBoxAS
            // 
            this.textBoxAS.Location = new System.Drawing.Point(62, 27);
            this.textBoxAS.Name = "textBoxAS";
            this.textBoxAS.Size = new System.Drawing.Size(100, 21);
            this.textBoxAS.TabIndex = 2;
            this.textBoxAS.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "a";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(875, 610);
            this.Controls.Add(this.groupBoxGaussian);
            this.Controls.Add(this.groupBoxExponential);
            this.Controls.Add(this.groupBoxGamma);
            this.Controls.Add(this.groupBoxSimpsons);
            this.Controls.Add(this.groupBoxTriangular);
            this.Controls.Add(this.numericUpDownLength);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBoxUniform);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.groupBoxEvaluations);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGeneratedValues);
            this.Controls.Add(this.groupBoxDistributions);
            this.Name = "MainForm";
            this.Text = "САиММОД (Лаб 2) - Иммитация различных распределений";
            this.groupBoxDistributions.ResumeLayout(false);
            this.groupBoxDistributions.PerformLayout();
            this.groupBoxUniform.ResumeLayout(false);
            this.groupBoxUniform.PerformLayout();
            this.groupBoxGaussian.ResumeLayout(false);
            this.groupBoxGaussian.PerformLayout();
            this.groupBoxExponential.ResumeLayout(false);
            this.groupBoxExponential.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBoxGamma.ResumeLayout(false);
            this.groupBoxGamma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBoxEvaluations.ResumeLayout(false);
            this.groupBoxEvaluations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
            this.groupBoxTriangular.ResumeLayout(false);
            this.groupBoxTriangular.PerformLayout();
            this.groupBoxVariant.ResumeLayout(false);
            this.groupBoxVariant.PerformLayout();
            this.groupBoxSimpsons.ResumeLayout(false);
            this.groupBoxSimpsons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDistributions;
        private System.Windows.Forms.RadioButton radioBtnSimpsons;
        private System.Windows.Forms.RadioButton radioBtnExponential;
        private System.Windows.Forms.RadioButton radioBtnGaussian;
        private System.Windows.Forms.RadioButton radioBtnTriangular;
        private System.Windows.Forms.RadioButton radioBtnUniform;
        private System.Windows.Forms.RadioButton radioBtnGamma;
        private System.Windows.Forms.GroupBox groupBoxUniform;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ListBox listBoxGeneratedValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBoxEvaluations;
        private System.Windows.Forms.TextBox textBoxQActual;
        private System.Windows.Forms.TextBox textBoxDActual;
        private System.Windows.Forms.TextBox textBoxMActual;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBoxGaussian;
        private System.Windows.Forms.TextBox textBoxQParameter;
        private System.Windows.Forms.TextBox textBoxMParameter;
        private System.Windows.Forms.Label lblQParameter;
        private System.Windows.Forms.Label lblMParameter;
        private System.Windows.Forms.GroupBox groupBoxExponential;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLambda;
        private System.Windows.Forms.Label lblLambda;
        private System.Windows.Forms.GroupBox groupBoxGamma;
        private System.Windows.Forms.TextBox textBoxLambdaG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.NumericUpDown numericUpDownEta;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.GroupBox groupBoxTriangular;
        private System.Windows.Forms.TextBox textBoxAT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxVariant;
        private System.Windows.Forms.RadioButton radioBtnVariant2;
        private System.Windows.Forms.RadioButton radioBtnVariant1;
        private System.Windows.Forms.TextBox textBoxBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxSimpsons;
        private System.Windows.Forms.TextBox textBoxBS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAS;
        private System.Windows.Forms.Label label7;
    }
}


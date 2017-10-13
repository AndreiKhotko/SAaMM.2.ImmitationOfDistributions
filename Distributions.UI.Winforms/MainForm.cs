using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Distributions.UI.Winforms.Data;
using LemerAlgorithm;

namespace Distributions.UI.Winforms
{
    public partial class MainForm : Form
    {
        private enum DistributionType
        {
            Uniform,
            Gaussian,
            Exponential,
            Gamma,
            Triangular,
            Simpsons
        };

        private DistributionType distributionType;
        private List<GroupBox> groupBoxes;
        private List<double> generatedValues;

        public MainForm()
        {
            InitializeComponent();

            InitGroupBoxes();
            HideAllGroupBoxes();

            radioBtnUniform.Checked = true;
        }

        private void InitGroupBoxes()
        {
            groupBoxes = new List<GroupBox>
            {
                groupBoxUniform,
                groupBoxGaussian,
                groupBoxExponential,
                groupBoxGamma,
                groupBoxTriangular,
                groupBoxSimpsons
            };

            foreach (var groupBox in groupBoxes)
            {
                groupBox.Left = 295;
                groupBox.Top = 28;
            }
        }
        private void HideAllGroupBoxes()
        {
            foreach (var groupBox in groupBoxes)
            {
                groupBox.Hide();
            }
        }

        private void radioBtnUniform_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnUniform.Checked)
            {
                distributionType = DistributionType.Uniform;
                HideAllGroupBoxes();
                groupBoxUniform.Show();
            }
        }

        private void radioBtnGaussian_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnGaussian.Checked)
            {
                distributionType = DistributionType.Gaussian;
                HideAllGroupBoxes();
                groupBoxGaussian.Show();
            }
        }

        private void radioBtnExponential_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnExponential.Checked)
            {
                distributionType = DistributionType.Exponential;
                HideAllGroupBoxes();
                groupBoxExponential.Show();
            }
        }

        private void radioBtnGamma_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnGamma.Checked)
            {
                distributionType = DistributionType.Gamma;
                HideAllGroupBoxes();
                groupBoxGamma.Show();
            }
        }

        private void radioBtnTriangular_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnTriangular.Checked)
            {
                distributionType = DistributionType.Triangular;
                HideAllGroupBoxes();
                groupBoxTriangular.Show();
            }
        }

        private void radioBtnSimpsons_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnSimpsons.Checked)
            {
                distributionType = DistributionType.Simpsons;
                HideAllGroupBoxes();
                groupBoxSimpsons.Show();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string error;
            if (!ValidateInput(out error))
            {
                MessageBox.Show(error);
                return;
            }

            Distribution distribution = null;
            var generator = new Generator();

            switch (distributionType)
            {
                case DistributionType.Uniform:
                    var a = double.Parse(textBoxA.Text);
                    var b = double.Parse(textBoxB.Text);
                    distribution = new UniformDistribution(generator, a, b);
                    break;
                case DistributionType.Gaussian:
                    var mean = double.Parse(textBoxMParameter.Text);
                    var standartDeviation = double.Parse(textBoxQParameter.Text);
                    distribution = new GaussianDistribution(generator, mean, standartDeviation);
                    break;
                case DistributionType.Exponential:
                    var lambda = double.Parse(textBoxLambda.Text);
                    distribution = new ExponentialDistribution(generator, lambda);
                    break;
                case DistributionType.Gamma:
                    var eta = Convert.ToInt32(numericUpDownEta.Text);
                    var lambdaG = double.Parse(textBoxLambdaG.Text);
                    distribution = new GammaDistribution(generator, eta, lambdaG);
                    break;
                case DistributionType.Triangular:
                    var aT = double.Parse(textBoxAT.Text);
                    var bT = double.Parse(textBoxBT.Text);
                    var isFirstVariant = radioBtnVariant1.Checked;
                    distribution = new TriangularDistribution(generator, aT, bT, isFirstVariant);
                    break;
                case DistributionType.Simpsons:
                    var aS = double.Parse(textBoxAS.Text);
                    var bS = double.Parse(textBoxBS.Text);
                    distribution = new SimpsonsDistribution(generator, aS, bS);
                    break;
                default:
                    distribution = null;
                    break;
            }

            if (ReferenceEquals(distribution, null))
            {
                MessageBox.Show("Error: distribution is undefined");
                return;
            }

            var n = Convert.ToInt32(numericUpDownLength.Text);
            generatedValues = new List<double>();
            listBoxGeneratedValues.Items.Clear();

            for (int i = 0; i < n; i++)
            {
                var value = distribution.GetNext();
                generatedValues.Add(value);
                listBoxGeneratedValues.Items.Add(value);
            }

            DrawChart();

            var m = CalcM(generatedValues);
            var d = CalcD(generatedValues, m);
            var q = Math.Sqrt(d);

            textBoxMActual.Text = m.ToString(CultureInfo.InvariantCulture);
            textBoxDActual.Text = d.ToString(CultureInfo.InvariantCulture);
            textBoxQActual.Text = q.ToString(CultureInfo.InvariantCulture);
        }

        private static double CalcM(List<double> values) => values.Sum() / values.Count;
        private static double CalcD(List<double> values, double m) => values.Sum(number => Sqr(number - m)) / values.Count;

        private static double Sqr(double num) => num * num;

        private void DrawChart()
        {
            var infoForDrawingBarChart = DataTransformer.Transform(generatedValues, 20);

            chart.DataSource = infoForDrawingBarChart.Counts;
            chart.Series.Clear();
            chart.Series.Add("GeneratedValues").YValueMembers = "Count";
            chart.Series["GeneratedValues"].ChartType = SeriesChartType.Column;
            chart.Series["GeneratedValues"].YValueType = ChartValueType.Int32;

            chart.DataBind();
        }

        private static void CopyListOfIntsToObjectCollectionInListBox(IEnumerable<YData> src, ListBox.ObjectCollection dest)
        {
            dest.Clear();
            foreach (var i in src)
                dest.Add(i.Count);
        }

        private bool ValidateInput(out string error)
        {
            error = string.Empty;

            switch (distributionType)
            {
                case DistributionType.Uniform:
                    if (!IsDouble(textBoxA.Text))
                    {
                        error = "Ошибка: Проверьте поле А.";
                        return false;
                    }

                    if (!IsDouble(textBoxB.Text))
                    {
                        error = "Ошибка: Проверьте поле B.";
                        return false;
                    }
                    break;

                case DistributionType.Gaussian:
                    if (!IsDouble(textBoxMParameter.Text))
                    {
                        error = "Ошибка: Проверьте поле m.";
                        return false;
                    }

                    if (!IsDouble(textBoxQParameter.Text))
                    {
                        error = "Ошибка: Проверьте поле q.";
                        return false;
                    }
                    break;

                case DistributionType.Exponential:
                    if (!IsDoubleAndPositive(textBoxLambda.Text))
                    {
                        error = "Ошибка: Проверьте поле lambda. Возможно, значение отрицательно.";
                        return false;
                    }
                    break;

                case DistributionType.Gamma:
                    if (!IsDoubleAndPositive(textBoxLambdaG.Text))
                    {
                        error = "Ошибка: Проверьте поле lambda. Возможно, значение отрицательно.";
                        return false;
                    }
                    break;

                case DistributionType.Triangular:
                    if (!IsDouble(textBoxAT.Text))
                    {
                        error = "Ошибка: Проверьте поле А.";
                        return false;
                    }

                    if (!IsDouble(textBoxBT.Text))
                    {
                        error = "Ошибка: Проверьте поле B.";
                        return false;
                    }
                    break;

                case DistributionType.Simpsons:
                    if (!IsDouble(textBoxAS.Text))
                    {
                        error = "Ошибка: Проверьте поле А.";
                        return false;
                    }

                    if (!IsDouble(textBoxBS.Text))
                    {
                        error = "Ошибка: Проверьте поле B.";
                        return false;
                    }
                    break;

                default:
                    error = "Error: distribution is not initialized";
                    return false;
            }

            return true;

        }

        private static bool IsDouble(string s)
        {
            double d;

            return double.TryParse(s, out d);
        }

        private static bool IsDoubleAndPositive(string s)
        {
            double d;

            return double.TryParse(s, out d) && d > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forecast.Entities;
using ZedGraph;
using Accord;
using Accord.Controls;
using Accord.IO;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math;
using Accord.Statistics.Kernels;
namespace Forecast
{
    public partial class PaginaPrevizionare : UserControl
    {
        private Database database;
        private SupportVectorMachine<IKernel> svm;
        private List<DateTime> date;
        private List<Valoare> valori;
        private String perecheValutara;
        private DateTime dataInceput;
        private DateTime dataFinal;
        private List<KeyValuePair<int, double>> dictionarDate;
        public PaginaPrevizionare()
        {
            InitializeComponent();
            database = new Database();
            date = new List<DateTime>();
            valori = new List<Valoare>();
            dictionarDate = new List<KeyValuePair<int, double>>();
            selectareBtn.Enabled = false;
            dezactiveazaDtp();
            getControlsData();

        }

        private void previzionareBtn_Click(object sender, EventArgs e)
        {
            List<float> closePriceList = database.SelectClosePriceValoriList(perecheValutara);

        }

        private void getControlsData()
        {
            DataSet dataSet = database.SelectTotPerecheValutaraDataset();
            if (dataSet != null)
            {
                perecheValutaraModelCb.DisplayMember = "Simbol";
                perecheValutaraModelCb.ValueMember = "Simbol";
                perecheValutaraModelCb.DataSource = dataSet.Tables[Constante.DATASET_NAME_PERECHI_VALUTARE];
            }
            else
            {
                MessageBox.Show(Constante.DB_EROARE_SELECT_PERECHI_VALUTARE);
            }

        }

        

        private void perecheValutaraModelCb_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                perecheValutara = perecheValutaraModelCb.SelectedValue.ToString();
                date = database.SelectDateValoriList(perecheValutara);
                if (date != null && date.Count > 0)
                {
                    date.Sort();
                    seteazaDtp();
                    activeazaDtp();
                }
                else
                {
                    MessageBox.Show(Constante.EROARE_DATE_PERECHI_VALUTARE);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void activeazaDtp()
        {
            deLaDataDtp.Enabled = true;
            panaLaDataDtp.Enabled = true;
        }

        private void dezactiveazaDtp()
        {
            deLaDataDtp.Enabled = false;
            panaLaDataDtp.Enabled = false;
        }

        private void seteazaDtp()
        {
            deLaDataDtp.MinDate = date[0];
            deLaDataDtp.MaxDate = date[date.Count - 1];
            panaLaDataDtp.MinDate = date[0];
            panaLaDataDtp.MaxDate = date[date.Count - 1];
            selectareBtn.Enabled = true;
        }

        private void selectareBtn_Click(object sender, EventArgs e)
        {
            valori = database.SelectValoriListaDupaData(perecheValutara, dataInceput, dataFinal);
            if (valori != null)
            {
                dateInvatareDgv.DataSource = valori;
               
                creareGrafic(zedGraphControl,perecheValutara, valori);

            }
        }

        private void deLaDataDtp_ValueChanged(object sender, EventArgs e)
        {
            dataInceput = deLaDataDtp.Value.Date;
            panaLaDataDtp.MinDate = deLaDataDtp.Value;
        }

        private void panaLaDataDtp_ValueChanged(object sender, EventArgs e)
        {
            dataFinal = panaLaDataDtp.Value.Date;
        }
        
        private void creareGrafic(ZedGraphControl zgc,String pv, List<Valoare> valori)
        {
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();

            myPane.Title.IsVisible = false;
            myPane.XAxis.Title.Text = "Timp";
            myPane.YAxis.Title.Text = "Preț";


            var list1 = new PointPairList();
            for (int i = 0; i < valori.Count; i++)
            {
                list1.Add(i, valori[i].Close);
            }

            LineItem myCurve = myPane.AddCurve(pv, list1, Color.BlueViolet, SymbolType.Diamond);
            myCurve.Line.IsVisible = true;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.BlueViolet);

            zgc.AxisChange();
            zgc.Invalidate();

        }


        private void creazaBtn_Click(object sender, EventArgs e)
        {
            if (dateInvatareDgv.DataSource == null)
            {
                MessageBox.Show(Constante.EROARE_CREARE_MASINA_FARA_DATE);
                return;
            }
            double[][] inputs = new double[valori.Count][];
            double[] outputs = new double[valori.Count];
            for (int i = 0; i < valori.Count; i++)
            {
                inputs[i] = new double[1];
                inputs[i][0] = i+1;
                outputs[i] = valori[i].Close;
                dictionarDate.Add(new KeyValuePair<int,double>(i + 1, valori[i].Close));
            }
            

            IKernel kernel = createKernel();

            var teacher = new SequentialMinimalOptimizationRegression()
            {
                Complexity = (double)numC.Value,
                Tolerance = (double)numT.Value,
                Epsilon = (double)numEpsilon.Value,
                Kernel = kernel
            };


            try
            {
                svm = teacher.Learn(inputs, outputs);
            }
            catch (ConvergenceException)
            {
                MessageBox.Show("Mașina creata înca poate fi folosită.");
            }


            if (svm.SupportVectors.Length == 0)
            {
                supportVectorsDgv.DataSource = null;
                graficSupportVectors.GraphPane.CurveList.Clear();
                return;
            }



            double[][] supportVectorsWeights = svm.SupportVectors.InsertColumn(svm.Weights);

            
            supportVectorsDgv.DataSource = new ArrayDataView(supportVectorsWeights, new string[] { "X", "Weight" });



            var supportVectorLabels = new double[svm.SupportVectors.Length];
            for (int i = 0; i < supportVectorLabels.Length; i++)
            {
                int j = inputs.Find(sv => sv == svm.SupportVectors[i])[0];
                supportVectorLabels[i] = outputs[j];
            }

            double[][] graph = svm.SupportVectors.InsertColumn(supportVectorLabels);

            CreareScatterplot(graficSupportVectors, graph);



            DoubleRange range = new DoubleRange(1,valori.Count);

            double[][] map = Vector.Range(range, stepSize: 0.05).ToJagged();

            double[][] surface = map.InsertColumn(svm.Score(map));

            CreareScatterplot(zedGraphControl, surface);
        }



        private IKernel createKernel()
        {
            if (rbGaussian.Checked)
                return new Accord.Statistics.Kernels.Gaussian((double)numSigma.Value);

            if (rbLaplacian.Checked)
                return new Laplacian((double)numLaplacianSigma.Value);

            if (rbSigmoid.Checked)
                return new Sigmoid((double)numSigAlpha.Value, (double)numSigB.Value);

            else throw new Exception();
        }

        private void estimareGaussianBtn_Click(object sender, EventArgs e)
        {
            double[][] inputs = new double[valori.Count][];
         
            for (int i = 0; i < valori.Count; i++)
            {
                inputs[i] = new double[2];
                inputs[i][0] = i + 1;
                inputs[i][1] = valori[i].Close;
            }

            DoubleRange range; 
            Gaussian gaussian = Gaussian.Estimate(inputs, inputs.Length, out range);

            numSigma.Value = (decimal)gaussian.Sigma;
        }

        private void estimareLaplacianBtn_Click(object sender, EventArgs e)
        {
            double[][] inputs = new double[valori.Count][];

            for (int i = 0; i < valori.Count; i++)
            {
                inputs[i] = new double[2];
                inputs[i][0] = i + 1;
                inputs[i][1] = valori[i].Close;
            }

            DoubleRange range; 
            var laplacian = Laplacian.Estimate(inputs, inputs.Length, out range);

            numLaplacianSigma.Value = (decimal)laplacian.Sigma;
        }

        private void estimareSigBtn_Click(object sender, EventArgs e)
        {
            double[][] inputs = new double[valori.Count][];

            for (int i = 0; i < valori.Count; i++)
            {
                inputs[i] = new double[2];
                inputs[i][0] = i + 1;
                inputs[i][1] = valori[i].Close;
            }

            DoubleRange range; // valid range will be returned as an out parameter
            var sigmoid = Sigmoid.Estimate(inputs, inputs.Length, out range);

            if (sigmoid.Alpha < (double)Decimal.MaxValue && sigmoid.Alpha > (double)Decimal.MinValue)
                numSigAlpha.Value = (decimal)sigmoid.Alpha;

            if (sigmoid.Constant < (double)Decimal.MaxValue && sigmoid.Constant > (double)Decimal.MinValue)
                numSigB.Value = (decimal)sigmoid.Constant;
        }

        private void estimareCBtn_Click(object sender, EventArgs e)
        {
            double[][] inputs = new double[valori.Count][];

            for (int i = 0; i < valori.Count; i++)
            {
                inputs[i] = new double[2];
                inputs[i][0] = i + 1;
                inputs[i][1] = valori[i].Close;
            }

            IKernel kernel = createKernel();

            double c = kernel.EstimateComplexity(inputs);

            numC.Value = (decimal)c;
        }

        public void CreareScatterplot(ZedGraphControl zgc, double[][] graph)
        {
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();

            myPane.Title.IsVisible = false;
            myPane.XAxis.Title.Text = "Timp";
            myPane.YAxis.Title.Text = "Preț";


            var list1 = new PointPairList();
            for (int i = 0; i < graph.Length; i++)
                list1.Add(graph[i][0], graph[i][1]);

            LineItem myCurve = myPane.AddCurve("Y", list1, Color.Blue, SymbolType.Default);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Size = 2f;

            myCurve.Symbol.Fill = new Fill(Color.Blue);

            zgc.AxisChange();
            zgc.Invalidate();
        }

        private void ruleazaBtn_Click(object sender, EventArgs e)
        {
            string text = numarZilePrevizionareTb.Text;
            int result;
            if (!int.TryParse(text, out result))
            {
                MessageBox.Show("Numar de zile incorect!");
                return;
            }
            int numarZilePrevizionare = int.Parse(text);
            if (svm == null || dateInvatareDgv.DataSource == null)
            {
                MessageBox.Show("Crează o mașină!");
                return;
            }
            dateTestareDgv.DataSource = dictionarDate;

            double[][] inputs = new double[valori.Count+numarZilePrevizionare][];
            double[] expected = new double[valori.Count];
            for (int i = 0; i < valori.Count; i++)
            {
                inputs[i] = new double[1];
                inputs[i][0] = i + 1;
                expected[i] = valori[i].Close;
            }
            for(int i =0; i<numarZilePrevizionare; i++)
            {
                inputs[valori.Count+i] = new double[1];
                inputs[valori.Count+i][0] = valori.Count + i + 1;
            }
           

            double[] output = svm.Score(inputs);

            double rSquared = Accord.Statistics.Tools.Determination(output, expected);
            double error = Elementwise.Pow(expected.Subtract(output), 2).Sum() / output.Length;

            var r = new { RSquared = rSquared, Error = error };
            dgvPerformance.DataSource = (new[] { r }).ToList();

            CreazaScatterplotRezultat(testareZedGraphControl, inputs, expected, output, numarZilePrevizionare);
        }

        public void CreazaScatterplotRezultat(ZedGraphControl zgc, double[][] inputs, double[] expected, double[] output, int numar)
        {
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();

            // Set the titles
            myPane.Title.IsVisible = false;
            myPane.XAxis.Title.Text = "Timp";
            myPane.YAxis.Title.Text = "Preț";


            PointPairList list1 = new PointPairList(); // svm output
            PointPairList list2 = new PointPairList(); // expected
            for (int i = 0; i < inputs.Length - numar; i++)
            {
                list1.Add(inputs[i][0], output[i]);
                list2.Add(inputs[i][0], expected[i]);
            }

            for(int i = 0; i < numar; i++)
            {
                list1.Add(inputs[valori.Count + i][0], output[valori.Count + i]);
            }

            LineItem myCurve = myPane.AddCurve("Rezultate model", list1, Color.Blue, SymbolType.Diamond);
            myCurve.Line.IsVisible = true;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Blue);

            myCurve = myPane.AddCurve("Date initiale", list2, Color.Red, SymbolType.Diamond);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Red);

            zgc.AxisChange();
            zgc.Invalidate();
        }

        
    }
    
}

using ScottPlot;

namespace GraphGUITest4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {
            ConfigurePlot1();
            ConfigurePlot2();
            ConfigurePlot3();
            ConfigurePlot4();

            scatter();

        }

        private void ConfigurePlot1()
        {
            var labels = new string[] { "Spotify", "YouTube", "Uber Eats" };
            var data = new double[] { 4, 10, 2 };
            var postions = new double[] { 0, 1, 2 };
            var colours = new Color[] { Color.Green, Color.Red, Color.Black };

            for (int i = 0; i < data.Length; i++)
            {
                var bar = barPlot.Plot.AddBar(
                    values: new double[] { data[i] },
                    positions: new double[] { postions[i] },
                    color: colours[i]
                    );
            }

            barPlot.Plot.XLabel("Application");
            barPlot.Plot.YLabel("Screen Time (Hrs)");
            barPlot.Plot.Title("Screen Usage");

            //formsPlot1.Plot.AddBar(data, postions);
            barPlot.Plot.XTicks(postions, labels);
            barPlot.Plot.SetAxisLimits(yMin: 0);

            barPlot.Plot.Grid(false);

            // disable left-click-drag pan
            barPlot.Configuration.Pan = false;

            // disable right-click-drag zoom
            barPlot.Configuration.Zoom = false;

            // disable scroll wheel zoom
            barPlot.Configuration.ScrollWheelZoom = false;

            // disable middle-click-drag zoom window
            barPlot.Configuration.MiddleClickDragZoom = false;

            barPlot.Refresh();
        }

        private double[] GenerateDoublesList(int size)
        {
            double[] doublesArray = new double[size + 1];

            // Generate doubles ranging from 0 to 'x'
            for (int i = 0; i <= size; i++)
            {
                doublesArray[i] = (double)i;
            }

            return doublesArray;
        }

        /** Genereates random doubles that have a trend
         **/
        private double[] RandomDoubles(int size)
        {
            // Parameters
            double currentValue = 0; // Starting value of the sequence
            double baseIncrement = 5; // Base increment per step in the sequence
            double incrementVar = 20.0; // Random variability in the increment
            double anomalyFreq = 0.1; // Frequency of anomalies (0 to 1)
            double anomalyVar = 20.0; // Variance of the anomaly values

            // Create the array
            Random random = new Random();
            double[] array = new double[size + 1];


            for (int i = 0; i < size; i++)
            {

                // Apply a random increment variability
                double increment = (baseIncrement + (random.NextDouble() - 0.5) * incrementVar);

                // Decide if this value should be an anomaly
                if (random.NextDouble() < anomalyFreq)
                {
                    // Apply anomaly by adding a random value based on the anomaly variance
                    array[i] = Math.Round(currentValue + (random.NextDouble() - 0.5) * anomalyVar, 2);
                }
                else
                {
                    // Follow the normal incremented value
                    array[i] = Math.Round(currentValue + ((random.NextDouble() - 0.5) * incrementVar), 2);
                }
                if (array[i] < 0)
                {
                    array[i] = 0;
                }
                // Update the current value with the randomized increment
                currentValue += increment;
            }

            return array;
        }


        private void scatter()
        {
            scat.Plot.Clear();

            // create funcion to retreive the max value req for X axis
            int maxHours = 10;


            //generates ints as doubles from 0 to maxHours
            double[] xs = GenerateDoublesList(maxHours);
            // ys is dud data and should be changed when proper data can be accessed
            double[] ys = RandomDoubles(maxHours);

            // plot original data as a scatter plot
            var sp = scat.Plot.AddScatter(xs, ys);
            sp.LineStyle = LineStyle.None;
            sp.MarkerSize = 10;

            // calculate the regression line
            ScottPlot.Statistics.LinearRegressionLine reg = new(xs, ys);

            // plot the regression line
            Coordinate pt1 = new(xs.First(), reg.GetValueAt(xs.First()));
            Coordinate pt2 = new(xs.Last(), reg.GetValueAt(xs.Last()));
            scat.Plot.AddLine((pt1.X), (pt1.Y), (pt2.X), (pt2.Y));
            // naming Axis
            scat.Plot.XLabel("Screen Time");
            scat.Plot.YLabel("Spending");
            // set limit 
            scat.Plot.SetAxisLimits(0, maxHours, 0, ys.Max() + 10);
            lblScat.Font = new Font(lblScat.Font.FontFamily, 10, System.Drawing.FontStyle.Bold);
            lblScat.Text = "Screen Time & Spending " + Environment.NewLine + "Y = " + Math.Round(reg.slope, 2) + "X + " + Math.Round(reg.offset, 2) + " ( R^2 = " + Math.Round(reg.rSquared, 2) + " )";
            scat.Refresh();
        }



        private void ConfigurePlot2()
        {
            double[] values = { 178, 322 };
            string centerText = $"£{values[0]} / £{values.Sum()}";
            Color color1 = Color.Yellow;
            Color color2 = Color.YellowGreen;

            var pie = Plot2.Plot.AddPie(values);
            pie.DonutSize = .6;
            pie.DonutLabel = centerText;
            pie.CenterFont.Color = color2;
            pie.CenterFont.Size = 25;
            pie.OutlineSize = 2;
            pie.SliceFillColors = new Color[] { color1, color2 };


            // disable left-click-drag pan
            Plot2.Configuration.Pan = false;

            // disable right-click-drag zoom
            Plot2.Configuration.Zoom = false;

            // disable scroll wheel zoom
            Plot2.Configuration.ScrollWheelZoom = false;

            // disable middle-click-drag zoom window
            Plot2.Configuration.MiddleClickDragZoom = false;


            Plot2.Refresh();

        }

        private void ConfigurePlot3()
        {
            double[] mondays = { 7, 4, 8, 2 };
            double[] tuesdays = { 10, 2, 4, 7 };
            double[] wednesdays = { 6, 5, 9, 5 };
            double[] thursdays = { 2, 4, 1, 4 };
            double[] fridays = { 11, 9, 13, 10 };
            double[] saturdays = { 13, 14, 10, 9 };
            double[] sundays = { 1, 5, 6, 7 };



            string[] seriesNames = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] groupNames = { "Week 1", "Week 2", "Week 3", "Week 4" };
            double[][] valuesBySeries = { mondays, tuesdays, wednesdays, thursdays, fridays, saturdays, sundays };


            Plot3.Plot.AddBarGroups(groupNames, seriesNames, valuesBySeries, null);
            Plot3.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            Plot3.Plot.SetAxisLimits(yMin: 0);

            Plot3.Plot.XLabel("Week");
            Plot3.Plot.YLabel("Screen Time in Hours");

            // disable left-click-drag pan
            Plot3.Configuration.Pan = false;

            // disable right-click-drag zoom
            Plot3.Configuration.Zoom = false;

            // disable scroll wheel zoom
            Plot3.Configuration.ScrollWheelZoom = false;

            // disable middle-click-drag zoom window
            Plot3.Configuration.MiddleClickDragZoom = false;

            Plot3.Refresh();

        }

        private void ConfigurePlot4()
        {
            double[] week1 = { 7, 10, 6, 2, 11, 13, 1 };
            double[] week2 = { 4, 2, 5, 4, 9, 13, 5 };
            double[] week3 = { 8, 4, 9, 1, 13, 14, 6 };
            double[] week4 = { 2, 7, 5, 4, 10, 9, 7 };

            string[] groupNames = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] seriesNames = { "Week 1", "Week 2", "Week 3", "Week 4" };
            double[][] valuesBySeries = { week1, week2, week3, week4 };

            Plot4.Plot.AddBarGroups(groupNames, seriesNames, valuesBySeries, null);
            Plot4.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            Plot4.Plot.SetAxisLimits(yMin: 0);

            Plot4.Plot.XLabel("Day of the Week");
            Plot4.Plot.YLabel("Screen Time in Hours");

            // disable left-click-drag pan
            Plot4.Configuration.Pan = false;

            // disable right-click-drag zoom
            Plot4.Configuration.Zoom = false;

            // disable scroll wheel zoom
            Plot4.Configuration.ScrollWheelZoom = false;

            // disable middle-click-drag zoom window
            Plot4.Configuration.MiddleClickDragZoom = false;

            Plot4.Refresh();
        }

        private void formsPlot2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click_1(object sender, EventArgs e)
        {
            scatter();
        }
    }
}
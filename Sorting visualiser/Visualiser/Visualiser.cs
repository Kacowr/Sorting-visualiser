using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Timers;
using System.Windows.Forms;

namespace Sorting_visualiser
{
    static class Visualiser
    {
        public static void SetGraph(int[] array, int arrayLength, Chart chart)
        {
            chart.Series[0].Points.Clear();
            for(int i=0;i<arrayLength;i++)
            {
                chart.Series[0].Points.Add(array[i]);
            }
        }

        public static void Visualise(Chart chart, List<List<SetValue>> valuesOrder)
        {
            foreach (List<SetValue> values in valuesOrder)
            {
                foreach (SetValue value in values)
                {
                    chart.Series[0].Points[value.index].Color = Color.Red;
                }
                Wait(100);

                foreach(SetValue value in values)
                {
                    chart.Series[0].Points[value.index].YValues[0] = value.value;
                }
                Wait(100);

                foreach(SetValue value in values)
                {
                    chart.Series[0].Points[value.index].Color = Color.Empty;
                }
                Wait(100);
            }
        }

        private static void Wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer.Interval = milliseconds;
            timer.Enabled = true;
            timer.Start();

            timer.Tick += (s, e) =>
            {
                timer.Enabled = false;
                timer.Stop();
            };

            while (timer.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}

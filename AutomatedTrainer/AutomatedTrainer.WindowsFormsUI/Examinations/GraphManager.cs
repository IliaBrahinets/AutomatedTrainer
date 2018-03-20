using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using AutomatedTrainer.Models;

namespace AutomatedTrainer.WindowsFormsUI.Examinations
{
    class GraphManager
    {
        private Chart[] Graphs { get; set; }
        private PhysicalIndicator[] PhysicalIndicators { get; set; }

        public GraphManager(PhysicalIndicator[] physicalIndicators, params Chart[] graphs)
        {
            Graphs = graphs;
            PhysicalIndicators = physicalIndicators;

            GraphsInit();
        }

        private void GraphsInit()
        {
            for(int i = 0; i < PhysicalIndicators.Length; i++)
            {
                Graphs[i].Titles.Add($"{i + 1}. {PhysicalIndicators[i]}");
                Graphs[i].Series[0].ChartType = SeriesChartType.Spline;
                
            }
            for(int i = 0; i < Graphs.Length; i++)
            {
                Graphs[i].Series[0].IsVisibleInLegend = false;
            }
        }

        public void Step(int time)
        {
            for (int i = 0; i < PhysicalIndicators.Length; i++)
            {
                Graphs[i].Series[0].Points.AddXY(time, PhysicalIndicators[i].GetValue());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public class LogEntry
    {
        // Defining the LogEntryIndex as a static attribute
        public static int LogEntryIndex = 0;

        public ListView HistoryLogListView;
        public ListViewItem newItem;
        public SolverInput Input;
        public double SideB;
        public double nIteration;

        // Constructor
        public LogEntry(ListView _historyLog, SolverInput _input, double _sideB, double _nIteration)
        {
            HistoryLogListView = _historyLog;
            Input = _input;
            SideB = _sideB;
            nIteration = _nIteration;
        }

        // Constructor that refers to null
        public LogEntry(ListView _historyLog)
        {
            HistoryLogListView = _historyLog;
        }

        public void UpdateLog()
        {
            // Increasing the static attribute LogEntryIndex by 1
            LogEntryIndex += 1;

            // Adding a new item into the ListView with the current LogEntryIndex
            newItem = HistoryLogListView.Items.Add(LogEntryIndex.ToString());

            // === Adding the subitems === //
            // TargetSurfaceArea
            newItem.SubItems.Add(Input.TargetSurfaceArea.ToString());

            // SideA
            newItem.SubItems.Add(Input.SideA.ToString());

            // SideB
            newItem.SubItems.Add(SideB.ToString());

            // StartValue
            newItem.SubItems.Add(Input.StartValue.ToString());

            // DeltaStep
            newItem.SubItems.Add(Input.DeltaStep.ToString());

            // RelativeAccuracy
            newItem.SubItems.Add(Input.RelativeAccuracy.ToString());

            // MaxSteps
            newItem.SubItems.Add(Input.MaxSteps.ToString());

            // NumberofIterations (taken to calculated SideB)
            newItem.SubItems.Add(nIteration.ToString());
        }

        // Method to reset the static attribute LogEntryIndex
        public void ResetLogEntryIndex()
        {
            LogEntryIndex = 0;
        }
    }
}

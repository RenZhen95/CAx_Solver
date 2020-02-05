using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CAx_Solver
{
    // "Form1" inherits everything the super-class "Form" has
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitiateListView();
        }

        /// <summary>
        /// Initiating the ListView for Log History ListView. Involves fixing some parameters
        /// </summary>
        private void InitiateListView()
        {
            // Set the view to show details.
            HistoryLog_List.View = View.Details;
            // Select the item and subitems when selection is made.
            HistoryLog_List.FullRowSelect = true;
            // Allow the user to rearrange columns.
            HistoryLog_List.AllowColumnReorder = true;
            // Display grid lines.
            HistoryLog_List.GridLines = true;

            // https://stackoverflow.com/questions/1257500/c-sharp-listview-column-width-auto
            // Auto resizes column according to content in the header
            HistoryLog_List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// Carries out following functions when clicked:
        /// - Create object Input that gets inputs from user in the textboxes and checks them for valid values
        /// - Obtain SideB and IterationCount
        /// - Outputs SideB as string in SideB Textbox
        /// - For every calculation the History Log is updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartSolverButton_Click(object sender, EventArgs e)
        {
            // Create object "Input" of class "SolverInput"
            SolverInput Input = getInputs();

            // Caching: Creating a cache object of Class "SolverInput"
            // To be used in creating a log
            SolverInput cacheInput = Input;

            if (Input == null)
            {
                return;

            }
            // Call iterator and iterate for SideB
            else
            {
                double SideB = iterateSideB(Input)[0];
                double IterationCount = iterateSideB(Input)[1];

                // Displaying iterated value of SideB in the textbox
                SideB_Output.Text = SideB.ToString();

                // Updating the History Log
                LogEntry LogEntryItem = new LogEntry(HistoryLog_List, Input, SideB, IterationCount);
                LogEntryItem.UpdateLog();
                return;
            }
        }

        /// <summary>
        /// Pass input values from the textboxes and check if they are of the double variable type  
        /// </summary>
        /// <returns></returns>
        public double okVariable(TextBox _textbox, Label _label)
        {
            // If user inputs "," as a decimal point, replace it automatically with "."
            _textbox.Text = _textbox.Text.Replace(",", ".");
            /*
             * NumberStyles.Any indicates that all styles (e.g. $ (currency), spaces) can be used, except hexadecimal
             * CultureInfo.InvariantCulture is an object that is culture-independent
             */
            if (!Double.TryParse(_textbox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double _checkVariable))
            { 
                MessageBox.Show($"Please input a double in {_label.Text}");
                _checkVariable = 0;
                //System.Diagnostics.Debug.WriteLine("This is NOT a double value");
            }
            else if (_checkVariable <= 0)
            {
                //System.Diagnostics.Debug.WriteLine("This is a double value");
                MessageBox.Show($"Please input a positive real number in {_label.Text}");
                _checkVariable = 0;
            }

            // Specifically for the Relative Accuracy Input >> Values must lie between 0 - 100 [%]
            if (_textbox.Name == "RelativeAccuracy_Input")
            {
                if (_checkVariable <= 0 || _checkVariable >= 100)
                {
                    MessageBox.Show($"Please input a value between 0 - 100 [%] in {RelativeAccuracy_Label.Text}");
                    _checkVariable = 0;
                }
            }
            return _checkVariable;
        }

        /// <summary>
        /// This method grabs the user inputs from the textbox and assigns it to the attribute variables in the object
        /// Inputs: (None)
        /// Outputs: An object of the "SolverInput" class
        /// </summary>
        private SolverInput getInputs()
        {
            // Target Surface Area Check for Double
            double _targetSurfaceArea = okVariable(TargetSurfaceArea_Input, TargetSurfaceArea_Label);

            // Side A Check for Double
            double _sideA = okVariable(SideA_Input, SideA_Label);

            // Start Value Check for Double
            double _startValue = okVariable(StartValue_Input, StartValue_Label);

            // Iterator Steps Check for Double
            double _deltaStep = okVariable(DeltaStep_Input, DeltaStep_Label);

            // Relative Accuracy Check for Double
            double _relativeAccuracy = okVariable(RelativeAccuracy_Input, RelativeAccuracy_Label);

            // Max Steps Check for Double
            double _maxSteps = okVariable(MaxSteps_Input, MaxSteps_Label);

            // The output object: An object of the class variable
            SolverInput _input = new SolverInput(_targetSurfaceArea, _sideA, _startValue, _deltaStep, _relativeAccuracy, _maxSteps);
            return _input;
        }

        /// <summary>
        /// Iterator function/method that iterates for SideB for a given length of SideA and Target Surface Area
        /// </summary>
        /// <param name="_targetSurfaceArea"></param>
        /// <param name="_sideA"></param>
        /// <param name="_startValue"></param>
        /// <param name="_deltaStep"></param>
        /// <param name="_relativeAccuracy"></param>
        /// <param name="_maxSteps"></param>
        /// <returns></returns>
        private static double[] iterateSideB(SolverInput _input)
        {
            // Variable Declaration
            double SideB;               // Variable SideB which we want to solve via iteration
            double calcArea;            // Calculated area, product of SideA and the estimated SideB
            double currentAccuracy;
            double deltaH;
            int currentDirection;
            int lastDirection;
            double count = 0;
            double[] returnValues = new double[2];

            // Calculating the area based on a start value, which will be approximated to the target surface area
            SideB = _input.StartValue;
            calcArea = _input.SideA * SideB;

            // Flags to determine if iteration step width is too large and iteration must be reversed
            currentDirection = 1;
            lastDirection = currentDirection;

            // Current Accuracy Calculation
            currentAccuracy = (1 - Math.Abs((_input.TargetSurfaceArea - calcArea) / _input.TargetSurfaceArea))*100;

            // Assigning user given _deltaSteps to variable deltaH
            deltaH = _input.DeltaStep;

            // A little logic puzzle...
            // Our conditions must be so that the loop is BROKE when:
            // count > _input.Maxsteps OR _input.RelativeAccuracy <= currentAccuracy
            // Hence, the inverse must apply for the loop to RUN!!
            while (count < _input.MaxSteps && _input.RelativeAccuracy >= currentAccuracy)
            {
                // If the calculated area is bigger than the target surface area, SideB must be reduced and iteration direction reversed
                if (calcArea > _input.TargetSurfaceArea)
                {
                    SideB = SideB - deltaH;
                    currentDirection = -1;
                }
                // If the calculated area is smaller than the target surface area, SideB must be increased and iteration direction reversed
                else
                {
                    SideB = SideB + deltaH;
                    currentDirection = 1;
                }
                
                // Now obviously when current direction does not match the previous direction, this implies that the iteration step was too big
                if (currentDirection != lastDirection)
                {
                    deltaH = deltaH / 2;
                    lastDirection = currentDirection;
                }

                calcArea = _input.SideA * SideB;
                currentAccuracy = (1 - Math.Abs((_input.TargetSurfaceArea - calcArea) / _input.TargetSurfaceArea))*100;
                count = count + 1;
            }

            // Return {SideB, count} as an array of double type
            returnValues[0] = SideB;
            returnValues[1] = count;

            return returnValues;
        }

        /// <summary>
        /// Clears the history log and sets the static attribute in the LogEntry class to zero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear all items and subitems
            HistoryLog_List.Items.Clear();

            // Resetting the static attribute LogEntryIndex
            LogEntry LogEntryTemp = new LogEntry(HistoryLog_List);
            LogEntryTemp.ResetLogEntryIndex();
        }
    }
}
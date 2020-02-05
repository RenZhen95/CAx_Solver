using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CAx_Solver
{
    // There are two options here:
    // public class SolverInput:
    //  - Acts as a class, where objects of this specific class can be instantiated
    //  - Methods can be defined, etc.
    // public struct SolverInput:
    //  - A "struct" is simply a data container
    //  - When initializing an object, all input arguments MUST be given
    
    public class SolverInput
    {
        // Variable Declaration (Deklarieren)
        // Simply use double to stay safe
        public double TargetSurfaceArea;
        public double SideA;
        public double StartValue;
        public double DeltaStep;
        public double RelativeAccuracy;
        public double MaxSteps;

        // Constructor
        public SolverInput(double _targetSurfaceArea, 
                           double _sideA,
                           double _startValue,
                           double _deltaStep,
                           double _relativeAccuracy,
                           double _maxSteps)
        {
            TargetSurfaceArea = _targetSurfaceArea;
            SideA = _sideA;
            StartValue = _startValue;
            DeltaStep = _deltaStep;
            RelativeAccuracy = _relativeAccuracy;
            MaxSteps = _maxSteps;
        }
    }
}
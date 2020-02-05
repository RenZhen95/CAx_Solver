namespace CAx_Solver
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TargetSurfaceArea_Input = new System.Windows.Forms.TextBox();
            this.SideA_Input = new System.Windows.Forms.TextBox();
            this.StartValue_Input = new System.Windows.Forms.TextBox();
            this.RelativeAccuracy_Input = new System.Windows.Forms.TextBox();
            this.MaxSteps_Input = new System.Windows.Forms.TextBox();
            this.TargetSurfaceArea_Label = new System.Windows.Forms.Label();
            this.SideA_Label = new System.Windows.Forms.Label();
            this.StartValue_Label = new System.Windows.Forms.Label();
            this.RelativeAccuracy_Label = new System.Windows.Forms.Label();
            this.MaxSteps_Label = new System.Windows.Forms.Label();
            this.SideB_Label = new System.Windows.Forms.Label();
            this.SideB_Output = new System.Windows.Forms.TextBox();
            this.DeltaStep_Label = new System.Windows.Forms.Label();
            this.DeltaStep_Input = new System.Windows.Forms.TextBox();
            this.StartSolverButton = new System.Windows.Forms.Button();
            this.HistoryLog_List = new System.Windows.Forms.ListView();
            this.HistoryLog_Label = new System.Windows.Forms.Label();
            this.Input_Col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TargetSurfaceArea_Col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SideA_Col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Schrittweite_Col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RelativeAccuracy_Col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxSteps_Col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IterationTaken_Col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SideB_Col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartValue_Col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TargetSurfaceArea_Input
            // 
            this.TargetSurfaceArea_Input.Location = new System.Drawing.Point(139, 29);
            this.TargetSurfaceArea_Input.Name = "TargetSurfaceArea_Input";
            this.TargetSurfaceArea_Input.Size = new System.Drawing.Size(51, 20);
            this.TargetSurfaceArea_Input.TabIndex = 0;
            // 
            // SideA_Input
            // 
            this.SideA_Input.Location = new System.Drawing.Point(139, 57);
            this.SideA_Input.Name = "SideA_Input";
            this.SideA_Input.Size = new System.Drawing.Size(51, 20);
            this.SideA_Input.TabIndex = 1;
            // 
            // StartValue_Input
            // 
            this.StartValue_Input.Location = new System.Drawing.Point(139, 87);
            this.StartValue_Input.Name = "StartValue_Input";
            this.StartValue_Input.Size = new System.Drawing.Size(51, 20);
            this.StartValue_Input.TabIndex = 2;
            // 
            // RelativeAccuracy_Input
            // 
            this.RelativeAccuracy_Input.Location = new System.Drawing.Point(139, 145);
            this.RelativeAccuracy_Input.Name = "RelativeAccuracy_Input";
            this.RelativeAccuracy_Input.Size = new System.Drawing.Size(51, 20);
            this.RelativeAccuracy_Input.TabIndex = 3;
            // 
            // MaxSteps_Input
            // 
            this.MaxSteps_Input.BackColor = System.Drawing.Color.FloralWhite;
            this.MaxSteps_Input.Location = new System.Drawing.Point(139, 173);
            this.MaxSteps_Input.Name = "MaxSteps_Input";
            this.MaxSteps_Input.Size = new System.Drawing.Size(51, 20);
            this.MaxSteps_Input.TabIndex = 4;
            // 
            // TargetSurfaceArea_Label
            // 
            this.TargetSurfaceArea_Label.AutoSize = true;
            this.TargetSurfaceArea_Label.Location = new System.Drawing.Point(25, 32);
            this.TargetSurfaceArea_Label.Name = "TargetSurfaceArea_Label";
            this.TargetSurfaceArea_Label.Size = new System.Drawing.Size(76, 13);
            this.TargetSurfaceArea_Label.TabIndex = 6;
            this.TargetSurfaceArea_Label.Text = "Zielfläche [m²]:";
            // 
            // SideA_Label
            // 
            this.SideA_Label.AutoSize = true;
            this.SideA_Label.Location = new System.Drawing.Point(25, 60);
            this.SideA_Label.Name = "SideA_Label";
            this.SideA_Label.Size = new System.Drawing.Size(58, 13);
            this.SideA_Label.TabIndex = 7;
            this.SideA_Label.Text = "Side A [m]:";
            // 
            // StartValue_Label
            // 
            this.StartValue_Label.AutoSize = true;
            this.StartValue_Label.Location = new System.Drawing.Point(25, 90);
            this.StartValue_Label.Name = "StartValue_Label";
            this.StartValue_Label.Size = new System.Drawing.Size(69, 13);
            this.StartValue_Label.TabIndex = 8;
            this.StartValue_Label.Text = "Startwert [m]:";
            // 
            // RelativeAccuracy_Label
            // 
            this.RelativeAccuracy_Label.AutoSize = true;
            this.RelativeAccuracy_Label.Location = new System.Drawing.Point(25, 148);
            this.RelativeAccuracy_Label.Name = "RelativeAccuracy_Label";
            this.RelativeAccuracy_Label.Size = new System.Drawing.Size(109, 13);
            this.RelativeAccuracy_Label.TabIndex = 9;
            this.RelativeAccuracy_Label.Text = "Rel. Genauigkeit [%]: ";
            // 
            // MaxSteps_Label
            // 
            this.MaxSteps_Label.AutoSize = true;
            this.MaxSteps_Label.Location = new System.Drawing.Point(25, 176);
            this.MaxSteps_Label.Name = "MaxSteps_Label";
            this.MaxSteps_Label.Size = new System.Drawing.Size(86, 13);
            this.MaxSteps_Label.TabIndex = 10;
            this.MaxSteps_Label.Text = "Max. Iterationen:";
            // 
            // SideB_Label
            // 
            this.SideB_Label.AutoSize = true;
            this.SideB_Label.Location = new System.Drawing.Point(161, 213);
            this.SideB_Label.Name = "SideB_Label";
            this.SideB_Label.Size = new System.Drawing.Size(58, 13);
            this.SideB_Label.TabIndex = 11;
            this.SideB_Label.Text = "Side B [m]:";
            // 
            // SideB_Output
            // 
            this.SideB_Output.Location = new System.Drawing.Point(225, 210);
            this.SideB_Output.Name = "SideB_Output";
            this.SideB_Output.Size = new System.Drawing.Size(75, 20);
            this.SideB_Output.TabIndex = 12;
            // 
            // DeltaStep_Label
            // 
            this.DeltaStep_Label.AutoSize = true;
            this.DeltaStep_Label.Location = new System.Drawing.Point(25, 120);
            this.DeltaStep_Label.Name = "DeltaStep_Label";
            this.DeltaStep_Label.Size = new System.Drawing.Size(82, 13);
            this.DeltaStep_Label.TabIndex = 14;
            this.DeltaStep_Label.Text = "Schrittweite [m]:";
            // 
            // DeltaStep_Input
            // 
            this.DeltaStep_Input.Location = new System.Drawing.Point(139, 117);
            this.DeltaStep_Input.Name = "DeltaStep_Input";
            this.DeltaStep_Input.Size = new System.Drawing.Size(51, 20);
            this.DeltaStep_Input.TabIndex = 15;
            // 
            // StartSolverButton
            // 
            this.StartSolverButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StartSolverButton.Image = global::CAx_Solver.Properties.Resources.StartIcon1;
            this.StartSolverButton.Location = new System.Drawing.Point(210, 86);
            this.StartSolverButton.Name = "StartSolverButton";
            this.StartSolverButton.Size = new System.Drawing.Size(96, 61);
            this.StartSolverButton.TabIndex = 13;
            this.StartSolverButton.UseVisualStyleBackColor = false;
            this.StartSolverButton.Click += new System.EventHandler(this.StartSolverButton_Click);
            // 
            // HistoryLog_List
            // 
            this.HistoryLog_List.AutoArrange = false;
            this.HistoryLog_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Input_Col,
            this.TargetSurfaceArea_Col,
            this.SideA_Col,
            this.SideB_Col,
            this.StartValue_Col,
            this.Schrittweite_Col,
            this.RelativeAccuracy_Col,
            this.MaxSteps_Col,
            this.IterationTaken_Col});
            this.HistoryLog_List.HideSelection = false;
            this.HistoryLog_List.Location = new System.Drawing.Point(324, 31);
            this.HistoryLog_List.Name = "HistoryLog_List";
            this.HistoryLog_List.Size = new System.Drawing.Size(642, 179);
            this.HistoryLog_List.TabIndex = 17;
            this.HistoryLog_List.UseCompatibleStateImageBehavior = false;
            // 
            // HistoryLog_Label
            // 
            this.HistoryLog_Label.AutoSize = true;
            this.HistoryLog_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryLog_Label.Location = new System.Drawing.Point(323, 9);
            this.HistoryLog_Label.Name = "HistoryLog_Label";
            this.HistoryLog_Label.Size = new System.Drawing.Size(76, 16);
            this.HistoryLog_Label.TabIndex = 18;
            this.HistoryLog_Label.Text = "History Log";
            // 
            // Input_Col
            // 
            this.Input_Col.Text = "   ";
            this.Input_Col.Width = 50;
            // 
            // TargetSurfaceArea_Col
            // 
            this.TargetSurfaceArea_Col.Text = "Zielfläche [m²]";
            this.TargetSurfaceArea_Col.Width = 80;
            // 
            // SideA_Col
            // 
            this.SideA_Col.Text = "Side A [m]";
            this.SideA_Col.Width = 50;
            // 
            // Schrittweite_Col
            // 
            this.Schrittweite_Col.DisplayIndex = 4;
            this.Schrittweite_Col.Text = "Schrittweite [m]";
            this.Schrittweite_Col.Width = 70;
            // 
            // RelativeAccuracy_Col
            // 
            this.RelativeAccuracy_Col.DisplayIndex = 5;
            this.RelativeAccuracy_Col.Text = "Rel. Genauigkeit [%]";
            this.RelativeAccuracy_Col.Width = 90;
            // 
            // MaxSteps_Col
            // 
            this.MaxSteps_Col.DisplayIndex = 6;
            this.MaxSteps_Col.Text = "Max. Iterationen";
            // 
            // IterationTaken_Col
            // 
            this.IterationTaken_Col.DisplayIndex = 7;
            this.IterationTaken_Col.Text = "Iteration";
            // 
            // SideB_Col
            // 
            this.SideB_Col.DisplayIndex = 8;
            this.SideB_Col.Text = "Side B [m]";
            // 
            // StartValue_Col
            // 
            this.StartValue_Col.DisplayIndex = 3;
            this.StartValue_Col.Text = "StartWert [m]";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(326, 218);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 250);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.HistoryLog_Label);
            this.Controls.Add(this.HistoryLog_List);
            this.Controls.Add(this.DeltaStep_Input);
            this.Controls.Add(this.DeltaStep_Label);
            this.Controls.Add(this.StartSolverButton);
            this.Controls.Add(this.SideB_Output);
            this.Controls.Add(this.SideB_Label);
            this.Controls.Add(this.MaxSteps_Label);
            this.Controls.Add(this.RelativeAccuracy_Label);
            this.Controls.Add(this.StartValue_Label);
            this.Controls.Add(this.SideA_Label);
            this.Controls.Add(this.TargetSurfaceArea_Label);
            this.Controls.Add(this.MaxSteps_Input);
            this.Controls.Add(this.RelativeAccuracy_Input);
            this.Controls.Add(this.StartValue_Input);
            this.Controls.Add(this.SideA_Input);
            this.Controls.Add(this.TargetSurfaceArea_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TargetSurfaceArea_Input;
        private System.Windows.Forms.TextBox SideA_Input;
        private System.Windows.Forms.TextBox StartValue_Input;
        private System.Windows.Forms.TextBox RelativeAccuracy_Input;
        private System.Windows.Forms.TextBox MaxSteps_Input;
        private System.Windows.Forms.Label TargetSurfaceArea_Label;
        private System.Windows.Forms.Label SideA_Label;
        private System.Windows.Forms.Label StartValue_Label;
        private System.Windows.Forms.Label RelativeAccuracy_Label;
        private System.Windows.Forms.Label MaxSteps_Label;
        private System.Windows.Forms.Label SideB_Label;
        private System.Windows.Forms.TextBox SideB_Output;
        private System.Windows.Forms.Button StartSolverButton;
        private System.Windows.Forms.Label DeltaStep_Label;
        private System.Windows.Forms.TextBox DeltaStep_Input;
        private System.Windows.Forms.ListView HistoryLog_List;
        private System.Windows.Forms.Label HistoryLog_Label;
        private System.Windows.Forms.ColumnHeader Input_Col;
        private System.Windows.Forms.ColumnHeader TargetSurfaceArea_Col;
        private System.Windows.Forms.ColumnHeader SideA_Col;
        private System.Windows.Forms.ColumnHeader Schrittweite_Col;
        private System.Windows.Forms.ColumnHeader RelativeAccuracy_Col;
        private System.Windows.Forms.ColumnHeader MaxSteps_Col;
        private System.Windows.Forms.ColumnHeader IterationTaken_Col;
        private System.Windows.Forms.ColumnHeader SideB_Col;
        private System.Windows.Forms.ColumnHeader StartValue_Col;
        private System.Windows.Forms.Button ClearButton;
    }
}
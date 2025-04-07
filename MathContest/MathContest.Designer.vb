<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.MathOperationTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.CurrentMathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.SecondNumLabel = New System.Windows.Forms.Label()
        Me.FirstNumLabel = New System.Windows.Forms.Label()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.MathOperationTypeGroupBox.SuspendLayout()
        Me.CurrentMathProblemGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(611, 36)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(158, 74)
        Me.SubmitButton.TabIndex = 7
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(611, 116)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(158, 74)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(611, 196)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(158, 74)
        Me.SummaryButton.TabIndex = 9
        Me.SummaryButton.Text = "Summar&y"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(611, 276)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(158, 74)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.NameLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeTextBox)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(32, 46)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(501, 122)
        Me.StudentInfoGroupBox.TabIndex = 4
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 39)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(44, 16)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Name"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(312, 39)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(32, 16)
        Me.AgeLabel.TabIndex = 4
        Me.AgeLabel.Text = "Age"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(397, 39)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(45, 16)
        Me.GradeLabel.TabIndex = 3
        Me.GradeLabel.Text = "Grade"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(9, 58)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(267, 22)
        Me.NameTextBox.TabIndex = 0
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(394, 58)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(48, 22)
        Me.GradeTextBox.TabIndex = 2
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(315, 58)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(48, 22)
        Me.AgeTextBox.TabIndex = 1
        '
        'MathOperationTypeGroupBox
        '
        Me.MathOperationTypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathOperationTypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathOperationTypeGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MathOperationTypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathOperationTypeGroupBox.Location = New System.Drawing.Point(285, 174)
        Me.MathOperationTypeGroupBox.Name = "MathOperationTypeGroupBox"
        Me.MathOperationTypeGroupBox.Size = New System.Drawing.Size(248, 209)
        Me.MathOperationTypeGroupBox.TabIndex = 5
        Me.MathOperationTypeGroupBox.TabStop = False
        Me.MathOperationTypeGroupBox.Text = "Math Operation Type"
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(18, 156)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(67, 20)
        Me.DivideRadioButton.TabIndex = 6
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(18, 114)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(73, 20)
        Me.MultiplyRadioButton.TabIndex = 5
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(18, 76)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(77, 20)
        Me.SubtractRadioButton.TabIndex = 4
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(18, 39)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(53, 20)
        Me.AddRadioButton.TabIndex = 3
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'CurrentMathProblemGroupBox
        '
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.SecondNumLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.FirstNumLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.SecondNumTextBox)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.FirstNumTextBox)
        Me.CurrentMathProblemGroupBox.Location = New System.Drawing.Point(32, 174)
        Me.CurrentMathProblemGroupBox.Name = "CurrentMathProblemGroupBox"
        Me.CurrentMathProblemGroupBox.Size = New System.Drawing.Size(247, 209)
        Me.CurrentMathProblemGroupBox.TabIndex = 6
        Me.CurrentMathProblemGroupBox.TabStop = False
        Me.CurrentMathProblemGroupBox.Text = "Current Math Problem"
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(13, 135)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(99, 16)
        Me.StudentAnswerLabel.TabIndex = 8
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'SecondNumLabel
        '
        Me.SecondNumLabel.AutoSize = True
        Me.SecondNumLabel.Location = New System.Drawing.Point(13, 83)
        Me.SecondNumLabel.Name = "SecondNumLabel"
        Me.SecondNumLabel.Size = New System.Drawing.Size(80, 16)
        Me.SecondNumLabel.TabIndex = 7
        Me.SecondNumLabel.Text = "2nd Number"
        '
        'FirstNumLabel
        '
        Me.FirstNumLabel.AutoSize = True
        Me.FirstNumLabel.Location = New System.Drawing.Point(13, 29)
        Me.FirstNumLabel.Name = "FirstNumLabel"
        Me.FirstNumLabel.Size = New System.Drawing.Size(75, 16)
        Me.FirstNumLabel.TabIndex = 6
        Me.FirstNumLabel.Text = "1st Number"
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(16, 154)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(181, 22)
        Me.StudentAnswerTextBox.TabIndex = 5
        '
        'SecondNumTextBox
        '
        Me.SecondNumTextBox.Location = New System.Drawing.Point(16, 102)
        Me.SecondNumTextBox.Name = "SecondNumTextBox"
        Me.SecondNumTextBox.Size = New System.Drawing.Size(181, 22)
        Me.SecondNumTextBox.TabIndex = 4
        '
        'FirstNumTextBox
        '
        Me.FirstNumTextBox.Location = New System.Drawing.Point(16, 48)
        Me.FirstNumTextBox.Name = "FirstNumTextBox"
        Me.FirstNumTextBox.Size = New System.Drawing.Size(181, 22)
        Me.FirstNumTextBox.TabIndex = 3
        '
        'MathContest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CurrentMathProblemGroupBox)
        Me.Controls.Add(Me.MathOperationTypeGroupBox)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Name = "MathContest"
        Me.Text = "Math Contest"
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.MathOperationTypeGroupBox.ResumeLayout(False)
        Me.MathOperationTypeGroupBox.PerformLayout()
        Me.CurrentMathProblemGroupBox.ResumeLayout(False)
        Me.CurrentMathProblemGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents MathOperationTypeGroupBox As GroupBox
    Friend WithEvents CurrentMathProblemGroupBox As GroupBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents GradeLabel As Label
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SecondNumLabel As Label
    Friend WithEvents FirstNumLabel As Label
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents SecondNumTextBox As TextBox
    Friend WithEvents FirstNumTextBox As TextBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class

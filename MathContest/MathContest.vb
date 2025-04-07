'Noah Holloway
'RCET 2265
'Spring 2025
'Math Contest
'https://github.com/hollnoah/MathContest.git

Option Strict On
Option Explicit On
Option Compare Text

Public Class MathContest
    Dim correctAnswers As Integer = 0
    Dim totalAnswers As Integer = 0
    Dim random As New Random()
    Dim firstnum As Integer
    Dim secondnum As Integer
    Dim currentOperation As String = "Add"

    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddRadioButton.Checked = True
        GenerateNumbers()
        Me.AcceptButton = SubmitButton
        Me.CancelButton = ClearButton

        ToolTip1.SetToolTip(StudentInfoGroupBox, "Enter student information")
        ToolTip1.SetToolTip(CurrentMathProblemGroupBox, "Enter students answer")
        ToolTip1.SetToolTip(MathOperationTypeGroupBox, "Select Math Operation")
        ToolTip1.SetToolTip(SubmitButton, "Submit the students answer")
        ToolTip1.SetToolTip(ClearButton, "Clear the form")
        ToolTip1.SetToolTip(SummaryButton, "Show total score summary")
        ToolTip1.SetToolTip(ExitButton, "Exit the application")

    End Sub

    Private Sub GenerateNumbers()
        firstnum = random.Next(1, 21)
        secondnum = random.Next(1, 21)
        If DivideRadioButton.Checked Then
            firstnum = firstnum * secondnum
        End If
        FirstNumTextBox.Text = firstnum.ToString()
        SecondNumTextBox.Text = secondnum.ToString()
    End Sub

    Private Sub OperationChanged(sender As Object, e As EventArgs) _
        Handles AddRadioButton.CheckedChanged, SubtractRadioButton.CheckedChanged, MultiplyRadioButton.CheckedChanged, DivideRadioButton.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            currentOperation = CType(sender, RadioButton).Text
            GenerateNumbers()
        End If
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If Not ValidateInputs() Then Exit Sub

        Dim studentAnswer As Integer
        If Not Integer.TryParse(StudentAnswerTextBox.Text, studentAnswer) Then
            MessageBox.Show("Please enter a valid number for the student's answer.")
            StudentAnswerTextBox.Clear()
            StudentAnswerTextBox.Focus()
            Exit Sub
        End If

        Dim correctAnswer As Integer = 0
        Select Case currentOperation
            Case "Add"
                correctAnswer = firstnum + secondnum
            Case "Subtract"
                correctAnswer = firstnum - secondnum
            Case "Multiply"
                correctAnswer = firstnum * secondnum
            Case "Divide"
                correctAnswer = firstnum \ secondnum
        End Select

        totalAnswers += 1

        If studentAnswer = correctAnswer Then
            correctAnswers += 1
            MessageBox.Show("Congratulations! That is correct.")
        Else
            MessageBox.Show("Incorrect. The correct answer is: " & correctAnswer.ToString())
        End If

        GenerateNumbers()
        StudentAnswerTextBox.Clear()
        StudentAnswerTextBox.Focus()
    End Sub

    Private Function ValidateInputs() As Boolean
        If NameTextBox.Text.Trim() = "" Then
            MessageBox.Show("Name is required.")
            NameTextBox.Focus()
            Return False
        End If

        Dim grade As Integer
        If GradeTextBox.Text.Trim() = "" OrElse Not Integer.TryParse(GradeTextBox.Text, grade) OrElse grade < 1 OrElse grade > 4 Then
            MessageBox.Show("Grade must be a number between 1 and 4.")
            GradeTextBox.Clear()
            GradeTextBox.Focus()
            Return False
        End If

        Dim age As Integer
        If AgeTextBox.Text.Trim() = "" OrElse Not Integer.TryParse(AgeTextBox.Text, age) OrElse age < 7 OrElse age > 11 Then
            MessageBox.Show("Age must be a number between 7 and 11.")
            AgeTextBox.Clear()
            AgeTextBox.Focus()
            Return False
        End If

        Return True
    End Function


    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Dim name = NameTextBox.Text.Trim()
        Dim message = If(totalAnswers > 0, $"{name} got {correctAnswers} answers correct out of possible {totalAnswers}", "No answers submitted yet.")
        MessageBox.Show(message, "Total Score")
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Clear()
        GradeTextBox.Clear()
        AgeTextBox.Clear()
        StudentAnswerTextBox.Clear()
        AddRadioButton.Checked = True
        NameTextBox.Focus()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class

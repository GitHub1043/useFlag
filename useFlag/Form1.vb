Public Class Form1

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        ' Program will ask for numbers until user enters 0
        ' An average will be displayed

        Dim intNumber As Integer
        Dim intTotal As Integer = 0
        ' Accumulator variable
        ' collect values with each iteration
        ' not predictable growth (typical)
        Dim intCount As Integer = 0
        ' how many numbers
        ' Counter variable
        ' grows predictably (+1) to count
        Dim intAverage As Integer

        Const FLAG As Integer = 0
        ' Flag variable
        ' when loop ends

        Do
            intNumber = Val(InputBox("Enter A Number Or 0 To Quit"))
            If intNumber <> FLAG Then
                intTotal = intTotal + intNumber
                intCount = intCount + 1
            End If
        Loop While intNumber <> FLAG

        intAverage = intTotal / intCount
        MessageBox.Show(intAverage)
    End Sub

    Private Sub btnBank_Click(sender As Object, e As EventArgs) Handles btnBank.Click
        Const FLAG As Integer = 0
        Const INTEREST As Single = 1.02
        Dim sngDeposit As Single
        Dim sngBank As Single = 100
        Dim intTemp As Integer
        Dim sngDisplay As Single
        ' sngBank = 1345.781123
        ' intTemp = 134578
        ' sngDisplay = 1345.78
        Do

            sngDeposit = Val(InputBox("Current Balance: $" & sngBank & " Enter Deposit Or 0 To Quit"))

            sngBank = sngBank + sngDeposit
            sngBank = sngBank * INTEREST

            intTemp = sngBank * 100
            sngDisplay = intTemp / 100

        Loop While sngDeposit <> FLAG

        
        MessageBox.Show("Final Balance: $" & sngDisplay)
    End Sub
End Class

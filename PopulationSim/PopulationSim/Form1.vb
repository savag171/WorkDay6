Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim CurrentYear As Integer
        Dim CurentPopulation As Double

        CurrentYear = 2012
        CurentPopulation = 7000

        Do While (CurentPopulation > 6)
            CurentPopulation = CurentPopulation / 2
            CurrentYear = CurrentYear - 50

        Loop

        MessageBox.Show("the year is " & CurrentYear, "Error")

    End Sub
End Class

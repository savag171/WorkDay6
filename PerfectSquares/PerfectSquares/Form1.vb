Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        lstResult.Items.Clear()
        Dim I As Integer
       
        I = 1
        Do While (I <= 10)
            lstResult.Items.Add("number is " & I ^ 2)
            I = I + 1
        Loop



    End Sub
End Class

Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim strSpeedInput As String
        Dim strTimeInput As String

        Dim intSpeed As Integer
        Dim intTime As Integer

        lstOutput.Items.Clear()

        strSpeedInput = InputBox("Enter a speed.", "Provide a Value")

        If strSpeedInput.Length = 0 Then
            MsgBox("Nothing entered.")
        Else
            Try
                intSpeed = CInt(strSpeedInput)
            Catch
                MsgBox("Please enter a valid integer")
            End Try
        End If

        strTimeInput = InputBox("Enter a time.", "Provide a Value")

        If strTimeInput.Length = 0 Then
            MsgBox("Nothing entered.")
        Else
            Try
                intTime = CInt(strTimeInput)
            Catch
                MsgBox("Please enter a valid integer")
            End Try
        End If

        If strSpeedInput.Length & strTimeInput.Length = 0 Then
            MsgBox("Please enter an integer.")
        Else
            Try
                lstOutput.Items.Add("Vehicle Speed: " & strSpeedInput + " MPH")
                lstOutput.Items.Add("Time Traveled: " & strTimeInput + " hours")
                lstOutput.Items.Add("Hours      Distance Traveled")
                lstOutput.Items.Add("--------------------------------------------")

                For i = 1 To intTime
                    lstOutput.Items.Add(i & "              " & i * intSpeed)
                Next

                lstOutput.Items.Add("Total Distance: " & intTime * intSpeed)
            Catch
                MsgBox("Please enter a valid integer")
            End Try
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
Imports System.Net
Public Class Form1

    Dim num1 As Integer
    Dim num2 As Integer
    Dim Sum As String
    Dim Url As String = "https://www.google.co.th/?hl=th"
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        Sum = "/"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "3"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "4"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "6"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "7"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "8"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "9"

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text + "0"
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        Sum = "+"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        Sum = "-"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        Sum = "*"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        num2 = TextBox1.Text
        If Sum = "+" Then
            TextBox1.Text = num1 + num2
        ElseIf Sum = "-" Then
            TextBox1.Text = num1 - num2
        ElseIf Sum = "*" Then
            TextBox1.Text = num1 * num2
            If num1 = 25 And num2 = 25 Then
                TextBox1.Text = "255"
                TextBox2.Text = "https://youtu.be/6ACg16U_KeQ?t=1505"
            ElseIf num1 = 60 And num2 = 24 Then
                TextBox1.Text = "3600"
                TextBox2.Text = "https://youtu.be/iRoe5q0zs1c?t=183"
            ElseIf num1 = 600 And num2 = 12 Then
                TextBox1.Text = "6000"
                TextBox2.Text = "https://youtu.be/iRoe5q0zs1c?t=768"
            End If
        ElseIf Sum = "/" Then
            TextBox1.Text = num1 / num2
        End If
        If TextBox2.Text = "Github" Then
            TextBox2.Text = "https://github.com/DEVPOB/9Calc"
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = ""
    End Sub
End Class

Imports System.ComponentModel

Public Class registerwarning
    Dim user = register.user
    Private Sub Registerwarning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "您的用户账号是" & user & "，请您及时保存！"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.TextBox1.Text = user
        register.Close()
        Me.Finalize()
    End Sub
End Class
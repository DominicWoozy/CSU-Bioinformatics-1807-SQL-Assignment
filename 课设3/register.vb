Public Class register
    Public user As String
    Dim nickname As String, password As String, sex As String, birthdate As String, intro As String

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If Trim(TextBox2.Text) = "" Then
            TextBox3.Enabled = False
        Else
            If Trim(TextBox2.Text).Length < 8 Then
                TextBox3.Enabled = False
                Label8.Text = "密码太短，请重新设置！"
            Else
                Label8.Text = ""
                TextBox3.Enabled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = TextBox2.Text Then
            Label1.Text = "通过"
            Button1.Enabled = True
        Else
            Label1.Text = "密码有误，请重新检查！"
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        nickname = TextBox1.Text
        password = TextBox2.Text
        sex = ComboBox1.Text
        birthdate = DateTimePicker1.Value.ToShortDateString
        intro = RichTextBox1.Text
        login.User_infoTableAdapter.Insert(password, nickname, sex, birthdate, intro)
        login.User_infoTableAdapter.Fill(login.MusicDataSet.user_info)
        i = login.UserinfoBindingSource.Count
        user = login.MusicDataSet.user_info.Rows(i - 1)(0)
        registerwarning.Show()
    End Sub
End Class
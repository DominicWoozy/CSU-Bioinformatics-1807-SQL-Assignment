Public Class login
    Public user As Integer

    Dim count As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer, p As String
        user = Val(TextBox1.Text)
        i = UserinfoBindingSource.Find("user_id", user)
        If Trim(TextBox1.Text) = "" Then
            MsgBox("你还没有输入账户")
            TextBox1.Select()
        Else
            If Trim(TextBox2.Text) = "" Then
                MsgBox("你还没有输入密码")
                TextBox2.Select()
            Else
                If i = -1 Then
                    MsgBox("没有此用户")
                    TextBox1.Clear()
                    TextBox1.Select()
                Else
                    p = MusicDataSet.user_info.Rows(i)(1)
                    If p = Trim(TextBox2.Text) Then
                        MsgBox("登陆成功")
                        Form1.Show()
                        Form1.userid = user
                        Me.Finalize()
                    Else
                        If count = 3 Then
                            MsgBox("你已经没有更多机会")
                            Me.Button1.PerformClick()
                        Else
                            MsgBox("密码错误, 你还有" & (3 - count) & "次机会！")
                            TextBox2.Clear()
                            TextBox2.Select()
                            count = count + 1
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“MusicDataSet.user_info”中。您可以根据需要移动或删除它。
        Me.User_infoTableAdapter.Fill(Me.MusicDataSet.user_info)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(13) Then
            Me.TextBox2.Select()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = ChrW(13) Then
            Me.Button2.PerformClick()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        register.Show()
    End Sub
End Class
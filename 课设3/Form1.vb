Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Public MusicFilePath As String
    Public sqlcon As New SqlConnection("server=(local);database=music;Integrated Security=True")
    Public artist As String
    Public album As String
    Public userid As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“MusicDataSet.music_file”中。您可以根据需要移动或删除它。
        Me.Music_fileTableAdapter.Fill(Me.MusicDataSet.music_file)
        'TODO: 这行代码将数据加载到表“MusicDataSet.music_info”中。您可以根据需要移动或删除它。
        Me.Music_infoTableAdapter.Fill(Me.MusicDataSet.music_info)
        'TODO: 这行代码将数据加载到表“MusicDataSet.music_info”中。您可以根据需要移动或删除它。
        Me.Music_infoTableAdapter.Fill(Me.MusicDataSet.music_info)

    End Sub


    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim x As Integer, y As Integer, a As Integer, b As Integer, i As Integer, j As Integer, musicname As String
        x = DataGridView1.CurrentCellAddress.X
        y = DataGridView1.CurrentCellAddress.Y
        b = DataGridView1.Rows(y).Cells(x - 1).Value
        musicname = DataGridView1.CurrentCell.Value
        If x = 1 Then
            a = MusicfileBindingSource.Find("music_id", b)
            If a = -1 Then
                MsgBox("此音乐没有对应文件")
            Else
                MusicFilePath = MusicDataSet.music_file.Rows(a)("music_file")
                AxWindowsMediaPlayer1.URL = System.IO.Path.GetFullPath(MusicFilePath)
                i = User_dataTableAdapter.IfMusicExists(userid, b)
                If i = 0 Then
                    User_dataTableAdapter.InsertNewUserdata(userid, b, musicname, 1, 0)
                Else
                    User_dataTableAdapter.UserdataMusicCountPlusOne(userid, b)
                    MsgBox(User_dataTableAdapter.SumAllCounts(userid))
                End If
            End If
        End If
        If DataGridView1.CurrentCell.ColumnIndex = 3 Then
            artist = b
            Form2.Show()
        End If
        If DataGridView1.CurrentCell.ColumnIndex = 5 Then
            album = b
            Form3.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MusicinfoBindingSource.Filter = "music_name like '%" & TextBox1.Text & "%'"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MusicinfoBindingSource.Filter = "artist like '%" & TextBox1.Text & "%'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MusicinfoBindingSource.Filter = "album like '%" & TextBox1.Text & "%'"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MusicinfoBindingSource.Filter = "lyrics like '%" & TextBox1.Text & "%'"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form4.Show()
    End Sub

    Private Sub DataGridView1_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseUp

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(13) Then
            Me.Button1.PerformClick()
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form2.Close()
        Form3.Close()
        Form4.Close()
        End
    End Sub

End Class

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“MusicDataSet.music_file”中。您可以根据需要移动或删除它。
        Me.Music_fileTableAdapter.Fill(Me.MusicDataSet.music_file)
        'TODO: 这行代码将数据加载到表“MusicDataSet.artist”中。您可以根据需要移动或删除它。
        Me.ArtistTableAdapter.Fill(Me.MusicDataSet.artist)
        'TODO: 这行代码将数据加载到表“MusicDataSet.music_info”中。您可以根据需要移动或删除它。
        Me.Music_infoTableAdapter.Fill(Me.MusicDataSet.music_info)
        'TODO: 这行代码将数据加载到表“MusicDataSet.artist”中。您可以根据需要移动或删除它。
        Me.ArtistTableAdapter.Fill(Me.MusicDataSet.artist)
        MusicinfoBindingSource.Filter = "artist_id = '" & Form1.artist & "'"
        Dim i As Integer
        i = ArtistBindingSource.Find("artist_id", Form1.artist)
        TextBox1.Text = MusicDataSet.artist.Rows(i)(1)
        TextBox2.Text = MusicDataSet.artist.Rows(i)(2)
        If IsDBNull(MusicDataSet.artist.Rows(i)(3)) Then
            TextBox3.Text = "无"
        Else
            TextBox3.Text = MusicDataSet.artist.Rows(i)(3)
        End If
        If IsDBNull(MusicDataSet.artist.Rows(i)(4)) Then
            TextBox4.Text = "无"
        Else
            TextBox4.Text = MusicDataSet.artist.Rows(i)(4)
        End If

        If IsDBNull(MusicDataSet.artist.Rows(i)(5)) Then
            TextBox5.Text = "无"
        Else
            TextBox5.Text = MusicDataSet.artist.Rows(i)(5)
        End If
        If IsDBNull(MusicDataSet.artist.Rows(i)(6)) Then
            RichTextBox1.Text = "无"
        Else
            RichTextBox1.Text = MusicDataSet.artist.Rows(i)(6)
        End If
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim a As Integer, b As Integer, MusicFilePath As String
        b = DataGridView1.CurrentRow.Cells(0).Value
        a = MusicfileBindingSource.Find("music_id", b)
        If a = -1 Then
            MsgBox("此音乐没有对应文件")
        Else
            MusicFilePath = MusicDataSet.music_file.Rows(a)("music_file")
            Form1.AxWindowsMediaPlayer1.URL = System.IO.Path.GetFullPath(MusicFilePath)
        End If
    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MusicDataSet = New 课设3.MusicDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MusicidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MusicnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtistidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlbumidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlbumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MusictypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MusicinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Music_infoTableAdapter = New 课设3.MusicDataSetTableAdapters.music_infoTableAdapter()
        Me.ArtistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArtistTableAdapter = New 课设3.MusicDataSetTableAdapters.artistTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MusicfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Music_fileTableAdapter = New 课设3.MusicDataSetTableAdapters.music_fileTableAdapter()
        CType(Me.MusicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusicinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusicfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MusicDataSet
        '
        Me.MusicDataSet.DataSetName = "MusicDataSet"
        Me.MusicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MusicidDataGridViewTextBoxColumn, Me.MusicnameDataGridViewTextBoxColumn, Me.ArtistidDataGridViewTextBoxColumn, Me.ArtistDataGridViewTextBoxColumn, Me.AlbumidDataGridViewTextBoxColumn, Me.AlbumDataGridViewTextBoxColumn, Me.MusictypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MusicinfoBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 752)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(889, 200)
        Me.DataGridView1.TabIndex = 0
        '
        'MusicidDataGridViewTextBoxColumn
        '
        Me.MusicidDataGridViewTextBoxColumn.DataPropertyName = "music_id"
        Me.MusicidDataGridViewTextBoxColumn.HeaderText = "music_id"
        Me.MusicidDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MusicidDataGridViewTextBoxColumn.Name = "MusicidDataGridViewTextBoxColumn"
        Me.MusicidDataGridViewTextBoxColumn.ReadOnly = True
        Me.MusicidDataGridViewTextBoxColumn.Visible = False
        '
        'MusicnameDataGridViewTextBoxColumn
        '
        Me.MusicnameDataGridViewTextBoxColumn.DataPropertyName = "music_name"
        Me.MusicnameDataGridViewTextBoxColumn.HeaderText = "music_name"
        Me.MusicnameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MusicnameDataGridViewTextBoxColumn.Name = "MusicnameDataGridViewTextBoxColumn"
        Me.MusicnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArtistidDataGridViewTextBoxColumn
        '
        Me.ArtistidDataGridViewTextBoxColumn.DataPropertyName = "artist_id"
        Me.ArtistidDataGridViewTextBoxColumn.HeaderText = "artist_id"
        Me.ArtistidDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ArtistidDataGridViewTextBoxColumn.Name = "ArtistidDataGridViewTextBoxColumn"
        Me.ArtistidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ArtistidDataGridViewTextBoxColumn.Visible = False
        '
        'ArtistDataGridViewTextBoxColumn
        '
        Me.ArtistDataGridViewTextBoxColumn.DataPropertyName = "artist"
        Me.ArtistDataGridViewTextBoxColumn.HeaderText = "artist"
        Me.ArtistDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ArtistDataGridViewTextBoxColumn.Name = "ArtistDataGridViewTextBoxColumn"
        Me.ArtistDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlbumidDataGridViewTextBoxColumn
        '
        Me.AlbumidDataGridViewTextBoxColumn.DataPropertyName = "album_id"
        Me.AlbumidDataGridViewTextBoxColumn.HeaderText = "album_id"
        Me.AlbumidDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AlbumidDataGridViewTextBoxColumn.Name = "AlbumidDataGridViewTextBoxColumn"
        Me.AlbumidDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlbumidDataGridViewTextBoxColumn.Visible = False
        '
        'AlbumDataGridViewTextBoxColumn
        '
        Me.AlbumDataGridViewTextBoxColumn.DataPropertyName = "album"
        Me.AlbumDataGridViewTextBoxColumn.HeaderText = "album"
        Me.AlbumDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AlbumDataGridViewTextBoxColumn.Name = "AlbumDataGridViewTextBoxColumn"
        Me.AlbumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MusictypeDataGridViewTextBoxColumn
        '
        Me.MusictypeDataGridViewTextBoxColumn.DataPropertyName = "music_type"
        Me.MusictypeDataGridViewTextBoxColumn.HeaderText = "music_type"
        Me.MusictypeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MusictypeDataGridViewTextBoxColumn.Name = "MusictypeDataGridViewTextBoxColumn"
        Me.MusictypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MusicinfoBindingSource
        '
        Me.MusicinfoBindingSource.DataMember = "music_info"
        Me.MusicinfoBindingSource.DataSource = Me.MusicDataSet
        '
        'Music_infoTableAdapter
        '
        Me.Music_infoTableAdapter.ClearBeforeFill = True
        '
        'ArtistBindingSource
        '
        Me.ArtistBindingSource.DataMember = "artist"
        Me.ArtistBindingSource.DataSource = Me.MusicDataSet
        '
        'ArtistTableAdapter
        '
        Me.ArtistTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(188, 68)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 55)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(505, 68)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(182, 55)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(188, 211)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(224, 55)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(505, 211)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(173, 55)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(186, 318)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(224, 55)
        Me.TextBox5.TabIndex = 5
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(186, 419)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(543, 232)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'MusicfileBindingSource
        '
        Me.MusicfileBindingSource.DataMember = "music_file"
        Me.MusicfileBindingSource.DataSource = Me.MusicDataSet
        '
        'Music_fileTableAdapter
        '
        Me.Music_fileTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 952)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.MusicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MusicDataSet As MusicDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MusicinfoBindingSource As BindingSource
    Friend WithEvents Music_infoTableAdapter As MusicDataSetTableAdapters.music_infoTableAdapter
    Friend WithEvents ArtistBindingSource As BindingSource
    Friend WithEvents ArtistTableAdapter As MusicDataSetTableAdapters.artistTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents MusicidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MusicnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArtistidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArtistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlbumidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlbumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MusictypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MusicfileBindingSource As BindingSource
    Friend WithEvents Music_fileTableAdapter As MusicDataSetTableAdapters.music_fileTableAdapter
End Class

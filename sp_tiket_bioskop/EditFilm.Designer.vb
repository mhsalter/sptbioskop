﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditFilm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnEditGambar = New System.Windows.Forms.Button()
        Me.BtnTambahFilm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBInggris = New System.Windows.Forms.RadioButton()
        Me.RBIndonesia = New System.Windows.Forms.RadioButton()
        Me.TxtHargaFilm = New System.Windows.Forms.TextBox()
        Me.DateReleaseFilm = New System.Windows.Forms.DateTimePicker()
        Me.TxtDirector = New System.Windows.Forms.TextBox()
        Me.RTBDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.CBGenreFilm = New System.Windows.Forms.ComboBox()
        Me.TxtNamaFilm = New System.Windows.Forms.TextBox()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialogFoto = New System.Windows.Forms.OpenFileDialog()
        Me.BtnEditFilm = New System.Windows.Forms.Button()
        Me.DTPDuration = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEditGambar
        '
        Me.BtnEditGambar.Location = New System.Drawing.Point(11, 124)
        Me.BtnEditGambar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEditGambar.Name = "BtnEditGambar"
        Me.BtnEditGambar.Size = New System.Drawing.Size(95, 26)
        Me.BtnEditGambar.TabIndex = 64
        Me.BtnEditGambar.Text = "Edit Gambar"
        Me.BtnEditGambar.UseVisualStyleBackColor = True
        '
        'BtnTambahFilm
        '
        Me.BtnTambahFilm.Location = New System.Drawing.Point(459, 374)
        Me.BtnTambahFilm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTambahFilm.Name = "BtnTambahFilm"
        Me.BtnTambahFilm.Size = New System.Drawing.Size(95, 26)
        Me.BtnTambahFilm.TabIndex = 65
        Me.BtnTambahFilm.Text = "Tambah Film"
        Me.BtnTambahFilm.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBInggris)
        Me.GroupBox1.Controls.Add(Me.RBIndonesia)
        Me.GroupBox1.Location = New System.Drawing.Point(234, 221)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(183, 59)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'RBInggris
        '
        Me.RBInggris.AutoSize = True
        Me.RBInggris.Location = New System.Drawing.Point(4, 36)
        Me.RBInggris.Margin = New System.Windows.Forms.Padding(2)
        Me.RBInggris.Name = "RBInggris"
        Me.RBInggris.Size = New System.Drawing.Size(89, 17)
        Me.RBInggris.TabIndex = 1
        Me.RBInggris.TabStop = True
        Me.RBInggris.Text = "Bahasa Iggris"
        Me.RBInggris.UseVisualStyleBackColor = True
        '
        'RBIndonesia
        '
        Me.RBIndonesia.AutoSize = True
        Me.RBIndonesia.Location = New System.Drawing.Point(4, 16)
        Me.RBIndonesia.Margin = New System.Windows.Forms.Padding(2)
        Me.RBIndonesia.Name = "RBIndonesia"
        Me.RBIndonesia.Size = New System.Drawing.Size(110, 17)
        Me.RBIndonesia.TabIndex = 0
        Me.RBIndonesia.TabStop = True
        Me.RBIndonesia.Text = "Bahasa Indonesia"
        Me.RBIndonesia.UseVisualStyleBackColor = True
        '
        'TxtHargaFilm
        '
        Me.TxtHargaFilm.Location = New System.Drawing.Point(234, 200)
        Me.TxtHargaFilm.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtHargaFilm.Name = "TxtHargaFilm"
        Me.TxtHargaFilm.Size = New System.Drawing.Size(185, 20)
        Me.TxtHargaFilm.TabIndex = 62
        '
        'DateReleaseFilm
        '
        Me.DateReleaseFilm.Location = New System.Drawing.Point(234, 173)
        Me.DateReleaseFilm.Margin = New System.Windows.Forms.Padding(2)
        Me.DateReleaseFilm.Name = "DateReleaseFilm"
        Me.DateReleaseFilm.Size = New System.Drawing.Size(185, 20)
        Me.DateReleaseFilm.TabIndex = 61
        '
        'TxtDirector
        '
        Me.TxtDirector.Location = New System.Drawing.Point(234, 124)
        Me.TxtDirector.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDirector.Name = "TxtDirector"
        Me.TxtDirector.Size = New System.Drawing.Size(185, 20)
        Me.TxtDirector.TabIndex = 59
        '
        'RTBDeskripsi
        '
        Me.RTBDeskripsi.Location = New System.Drawing.Point(234, 55)
        Me.RTBDeskripsi.Margin = New System.Windows.Forms.Padding(2)
        Me.RTBDeskripsi.Name = "RTBDeskripsi"
        Me.RTBDeskripsi.Size = New System.Drawing.Size(185, 64)
        Me.RTBDeskripsi.TabIndex = 58
        Me.RTBDeskripsi.Text = ""
        '
        'CBGenreFilm
        '
        Me.CBGenreFilm.FormattingEnabled = True
        Me.CBGenreFilm.Items.AddRange(New Object() {"Horror", "Action", "Comedy", "Drama", "Romance"})
        Me.CBGenreFilm.Location = New System.Drawing.Point(234, 33)
        Me.CBGenreFilm.Margin = New System.Windows.Forms.Padding(2)
        Me.CBGenreFilm.Name = "CBGenreFilm"
        Me.CBGenreFilm.Size = New System.Drawing.Size(185, 21)
        Me.CBGenreFilm.TabIndex = 57
        '
        'TxtNamaFilm
        '
        Me.TxtNamaFilm.Location = New System.Drawing.Point(234, 11)
        Me.TxtNamaFilm.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNamaFilm.Name = "TxtNamaFilm"
        Me.TxtNamaFilm.Size = New System.Drawing.Size(185, 20)
        Me.TxtNamaFilm.TabIndex = 56
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(11, 11)
        Me.PicFoto.Margin = New System.Windows.Forms.Padding(2)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(95, 103)
        Me.PicFoto.TabIndex = 55
        Me.PicFoto.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(110, 219)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Bahasa :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(110, 199)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Harga Film :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(110, 173)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Date Release Film :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(110, 145)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Durasi Film :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 124)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Director :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Deskripsi :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Genre Film :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Nama Film :"
        '
        'OpenFileDialogFoto
        '
        Me.OpenFileDialogFoto.FileName = "OpenFileDialogFoto"
        '
        'BtnEditFilm
        '
        Me.BtnEditFilm.Location = New System.Drawing.Point(234, 284)
        Me.BtnEditFilm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEditFilm.Name = "BtnEditFilm"
        Me.BtnEditFilm.Size = New System.Drawing.Size(95, 26)
        Me.BtnEditFilm.TabIndex = 66
        Me.BtnEditFilm.Text = "Edit Film"
        Me.BtnEditFilm.UseVisualStyleBackColor = True
        '
        'DTPDuration
        '
        Me.DTPDuration.CustomFormat = "HH:mm:ss"
        Me.DTPDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPDuration.Location = New System.Drawing.Point(234, 148)
        Me.DTPDuration.Name = "DTPDuration"
        Me.DTPDuration.ShowUpDown = True
        Me.DTPDuration.Size = New System.Drawing.Size(185, 20)
        Me.DTPDuration.TabIndex = 67
        '
        'EditFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(443, 323)
        Me.Controls.Add(Me.DTPDuration)
        Me.Controls.Add(Me.BtnEditFilm)
        Me.Controls.Add(Me.BtnEditGambar)
        Me.Controls.Add(Me.BtnTambahFilm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtHargaFilm)
        Me.Controls.Add(Me.DateReleaseFilm)
        Me.Controls.Add(Me.TxtDirector)
        Me.Controls.Add(Me.RTBDeskripsi)
        Me.Controls.Add(Me.CBGenreFilm)
        Me.Controls.Add(Me.TxtNamaFilm)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EditFilm"
        Me.Text = "EditFilm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEditGambar As Button
    Friend WithEvents BtnTambahFilm As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBInggris As RadioButton
    Friend WithEvents RBIndonesia As RadioButton
    Friend WithEvents TxtHargaFilm As TextBox
    Friend WithEvents DateReleaseFilm As DateTimePicker
    Friend WithEvents TxtDirector As TextBox
    Friend WithEvents RTBDeskripsi As RichTextBox
    Friend WithEvents CBGenreFilm As ComboBox
    Friend WithEvents TxtNamaFilm As TextBox
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialogFoto As OpenFileDialog
    Friend WithEvents BtnEditFilm As Button
    Friend WithEvents DTPDuration As DateTimePicker
End Class

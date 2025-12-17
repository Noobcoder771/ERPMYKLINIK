<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucRekamMedis
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.txtResepView = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvRiwayat = New System.Windows.Forms.DataGridView()
        Me.NoRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeluhanAwal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtalergi = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtDiagnosa = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txttindakan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel15.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.Color.Black
        Me.btnbatal.Location = New System.Drawing.Point(349, 3)
        Me.btnbatal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(145, 25)
        Me.btnbatal.TabIndex = 9
        Me.btnbatal.Text = "BATAL"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Panel15.Controls.Add(Me.txtResepView)
        Me.Panel15.Location = New System.Drawing.Point(7, 36)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(467, 165)
        Me.Panel15.TabIndex = 15
        '
        'txtResepView
        '
        Me.txtResepView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtResepView.Location = New System.Drawing.Point(0, 0)
        Me.txtResepView.Multiline = True
        Me.txtResepView.Name = "txtResepView"
        Me.txtResepView.ReadOnly = True
        Me.txtResepView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResepView.Size = New System.Drawing.Size(467, 165)
        Me.txtResepView.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel9.Controls.Add(Me.Panel15)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Location = New System.Drawing.Point(455, 244)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(476, 202)
        Me.Panel9.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(7, 10)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 19)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Tindakan Medis"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel14.Controls.Add(Me.btnbatal)
        Me.Panel14.Controls.Add(Me.Button5)
        Me.Panel14.Location = New System.Drawing.Point(120, 523)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(761, 32)
        Me.Panel14.TabIndex = 17
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LimeGreen
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(185, 3)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(145, 25)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "SELESAI PEMERIKSAAN"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 4)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Diagnosa Medis"
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(311, 10)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(74, 25)
        Me.btnCari.TabIndex = 10
        Me.btnCari.Text = "CARI PASIEN"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.White
        Me.Panel16.Controls.Add(Me.txtcari)
        Me.Panel16.Location = New System.Drawing.Point(212, 11)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(95, 24)
        Me.Panel16.TabIndex = 9
        '
        'txtcari
        '
        Me.txtcari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcari.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtcari.Location = New System.Drawing.Point(5, 5)
        Me.txtcari.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(77, 13)
        Me.txtcari.TabIndex = 0
        Me.txtcari.Text = "Cari Pasien"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(2, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Riwayat Kunjungan Pasien"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.dgvRiwayat)
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 169)
        Me.Panel2.TabIndex = 0
        '
        'dgvRiwayat
        '
        Me.dgvRiwayat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRiwayat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoRM, Me.KeluhanAwal})
        Me.dgvRiwayat.Location = New System.Drawing.Point(7, 11)
        Me.dgvRiwayat.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRiwayat.Name = "dgvRiwayat"
        Me.dgvRiwayat.RowHeadersWidth = 62
        Me.dgvRiwayat.Size = New System.Drawing.Size(364, 136)
        Me.dgvRiwayat.TabIndex = 0
        '
        'NoRM
        '
        Me.NoRM.HeaderText = "No. RM"
        Me.NoRM.MinimumWidth = 8
        Me.NoRM.Name = "NoRM"
        Me.NoRM.Width = 150
        '
        'KeluhanAwal
        '
        Me.KeluhanAwal.HeaderText = "Keluhan Awal"
        Me.KeluhanAwal.MinimumWidth = 8
        Me.KeluhanAwal.Name = "KeluhanAwal"
        Me.KeluhanAwal.Width = 150
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel8.Controls.Add(Me.txtalergi)
        Me.Panel8.Controls.Add(Me.TextBox3)
        Me.Panel8.Location = New System.Drawing.Point(318, 36)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(144, 122)
        Me.Panel8.TabIndex = 13
        '
        'txtalergi
        '
        Me.txtalergi.Location = New System.Drawing.Point(3, 25)
        Me.txtalergi.Multiline = True
        Me.txtalergi.Name = "txtalergi"
        Me.txtalergi.ReadOnly = True
        Me.txtalergi.Size = New System.Drawing.Size(138, 94)
        Me.txtalergi.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(5, 6)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(103, 13)
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.Text = "Alergi Obat"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtDiagnosa)
        Me.Panel4.Location = New System.Drawing.Point(2, 36)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(286, 43)
        Me.Panel4.TabIndex = 0
        '
        'txtDiagnosa
        '
        Me.txtDiagnosa.Location = New System.Drawing.Point(12, 19)
        Me.txtDiagnosa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiagnosa.Name = "txtDiagnosa"
        Me.txtDiagnosa.ReadOnly = True
        Me.txtDiagnosa.Size = New System.Drawing.Size(272, 20)
        Me.txtDiagnosa.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(455, 64)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(476, 180)
        Me.Panel3.TabIndex = 15
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel5.Controls.Add(Me.txttindakan)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(3, 92)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(283, 84)
        Me.Panel5.TabIndex = 9
        '
        'txttindakan
        '
        Me.txttindakan.Location = New System.Drawing.Point(6, 21)
        Me.txttindakan.Multiline = True
        Me.txttindakan.Name = "txttindakan"
        Me.txttindakan.ReadOnly = True
        Me.txttindakan.Size = New System.Drawing.Size(274, 60)
        Me.txttindakan.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 5)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tindakan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(7, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Detail Pemeriksaan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.btnCari)
        Me.Panel1.Controls.Add(Me.Panel16)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(32, 64)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 254)
        Me.Panel1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(380, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Sistem Informasi Rumah Sakit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(338, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 30)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Rekam Medis Elektronik"
        '
        'ucRekamMedis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucRekamMedis"
        Me.Size = New System.Drawing.Size(948, 600)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnbatal As Button
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents Panel16 As Panel
    Friend WithEvents txtcari As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvRiwayat As DataGridView
    Friend WithEvents NoRM As DataGridViewTextBoxColumn
    Friend WithEvents KeluhanAwal As DataGridViewTextBoxColumn
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtDiagnosa As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtalergi As TextBox
    Friend WithEvents txttindakan As TextBox
    Friend WithEvents txtResepView As TextBox
End Class

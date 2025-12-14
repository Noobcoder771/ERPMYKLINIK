<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucFarmasi
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
        Me.components = New System.ComponentModel.Container()
        Me.PnlContent = New System.Windows.Forms.Panel()
        Me.pnlWorkspace = New System.Windows.Forms.Panel()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpLeft = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblSatuan = New System.Windows.Forms.Label()
        Me.lblStok = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cbSatuan = New System.Windows.Forms.ComboBox()
        Me.nudStok = New System.Windows.Forms.NumericUpDown()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.dgvObat = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip4 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip5 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip6 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip7 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip8 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.PnlContent.SuspendLayout()
        Me.pnlWorkspace.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.tlpLeft.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nudStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlContent
        '
        Me.PnlContent.Controls.Add(Me.pnlWorkspace)
        Me.PnlContent.Controls.Add(Me.pnlSearch)
        Me.PnlContent.Controls.Add(Me.Label2)
        Me.PnlContent.Controls.Add(Me.Label1)
        Me.PnlContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlContent.Location = New System.Drawing.Point(0, 0)
        Me.PnlContent.Name = "PnlContent"
        Me.PnlContent.Padding = New System.Windows.Forms.Padding(10)
        Me.PnlContent.Size = New System.Drawing.Size(940, 519)
        Me.PnlContent.TabIndex = 0
        '
        'pnlWorkspace
        '
        Me.pnlWorkspace.Controls.Add(Me.tlpMain)
        Me.pnlWorkspace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWorkspace.Location = New System.Drawing.Point(10, 134)
        Me.pnlWorkspace.Name = "pnlWorkspace"
        Me.pnlWorkspace.Size = New System.Drawing.Size(920, 375)
        Me.pnlWorkspace.TabIndex = 3
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.67391!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.32609!))
        Me.tlpMain.Controls.Add(Me.tlpLeft, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 1
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 375.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 375.0!))
        Me.tlpMain.Size = New System.Drawing.Size(920, 375)
        Me.tlpMain.TabIndex = 0
        '
        'tlpLeft
        '
        Me.tlpLeft.ColumnCount = 1
        Me.tlpLeft.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLeft.Controls.Add(Me.pnlForm, 0, 0)
        Me.tlpLeft.Controls.Add(Me.dgvObat, 0, 2)
        Me.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLeft.Location = New System.Drawing.Point(3, 3)
        Me.tlpLeft.Name = "tlpLeft"
        Me.tlpLeft.RowCount = 3
        Me.tlpLeft.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLeft.Size = New System.Drawing.Size(819, 369)
        Me.tlpLeft.TabIndex = 3
        '
        'pnlForm
        '
        Me.pnlForm.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlForm.Location = New System.Drawing.Point(3, 3)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(813, 168)
        Me.pnlForm.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblKode, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNama, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSatuan, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblStok, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblHarga, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtKode, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNama, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbSatuan, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nudStok, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtHarga, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(813, 168)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblKode
        '
        Me.lblKode.AutoSize = True
        Me.lblKode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKode.Location = New System.Drawing.Point(3, 5)
        Me.lblKode.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(124, 30)
        Me.lblKode.TabIndex = 0
        Me.lblKode.Text = "No. Kode Obat"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNama.Location = New System.Drawing.Point(3, 40)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(124, 30)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "Nama Obat"
        '
        'lblSatuan
        '
        Me.lblSatuan.AutoSize = True
        Me.lblSatuan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSatuan.Location = New System.Drawing.Point(3, 75)
        Me.lblSatuan.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblSatuan.Name = "lblSatuan"
        Me.lblSatuan.Size = New System.Drawing.Size(124, 30)
        Me.lblSatuan.TabIndex = 2
        Me.lblSatuan.Text = "Satuan"
        '
        'lblStok
        '
        Me.lblStok.AutoSize = True
        Me.lblStok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStok.Location = New System.Drawing.Point(3, 110)
        Me.lblStok.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Size = New System.Drawing.Size(124, 30)
        Me.lblStok.TabIndex = 3
        Me.lblStok.Text = "Stok Saat Ini"
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHarga.Location = New System.Drawing.Point(3, 145)
        Me.lblHarga.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(124, 30)
        Me.lblHarga.TabIndex = 4
        Me.lblHarga.Text = "Harga Jual"
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(133, 3)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(200, 23)
        Me.txtKode.TabIndex = 5
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(133, 38)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(200, 23)
        Me.txtNama.TabIndex = 6
        '
        'cbSatuan
        '
        Me.cbSatuan.FormattingEnabled = True
        Me.cbSatuan.Location = New System.Drawing.Point(133, 73)
        Me.cbSatuan.Name = "cbSatuan"
        Me.cbSatuan.Size = New System.Drawing.Size(200, 23)
        Me.cbSatuan.TabIndex = 7
        '
        'nudStok
        '
        Me.nudStok.Location = New System.Drawing.Point(133, 108)
        Me.nudStok.Name = "nudStok"
        Me.nudStok.Size = New System.Drawing.Size(200, 23)
        Me.nudStok.TabIndex = 8
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(133, 143)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(200, 23)
        Me.txtHarga.TabIndex = 9
        '
        'dgvObat
        '
        Me.dgvObat.AllowUserToAddRows = False
        Me.dgvObat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvObat.BackgroundColor = System.Drawing.Color.White
        Me.dgvObat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column10})
        Me.dgvObat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvObat.Location = New System.Drawing.Point(3, 197)
        Me.dgvObat.Margin = New System.Windows.Forms.Padding(3, 15, 15, 3)
        Me.dgvObat.Name = "dgvObat"
        Me.dgvObat.RowHeadersVisible = False
        Me.dgvObat.Size = New System.Drawing.Size(801, 169)
        Me.dgvObat.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.FillWeight = 97.13808!
        Me.Column1.HeaderText = "No. Kode Obat"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.FillWeight = 93.56505!
        Me.Column2.HeaderText = "Nama Obat"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.FillWeight = 82.21445!
        Me.Column3.HeaderText = "Satuan"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.FillWeight = 100.1789!
        Me.Column4.HeaderText = "Stok"
        Me.Column4.Name = "Column4"
        '
        'Column10
        '
        Me.Column10.FillWeight = 126.9036!
        Me.Column10.HeaderText = "Harga Jual"
        Me.Column10.Name = "Column10"
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.btnhapus)
        Me.pnlSearch.Controls.Add(Me.btnsimpan)
        Me.pnlSearch.Controls.Add(Me.btnCari)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.Label3)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSearch.Location = New System.Drawing.Point(10, 72)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(920, 62)
        Me.pnlSearch.TabIndex = 2
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(202, 13)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 32)
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(173, 23)
        Me.txtSearch.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cari Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(10, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.Label2.Size = New System.Drawing.Size(179, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sistem Informasi Rumah Sakit"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manajemen Farmasi / Obat"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip4
        '
        Me.ContextMenuStrip4.Name = "ContextMenuStrip4"
        Me.ContextMenuStrip4.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip5
        '
        Me.ContextMenuStrip5.Name = "ContextMenuStrip5"
        Me.ContextMenuStrip5.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip6
        '
        Me.ContextMenuStrip6.Name = "ContextMenuStrip6"
        Me.ContextMenuStrip6.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip7
        '
        Me.ContextMenuStrip7.Name = "ContextMenuStrip7"
        Me.ContextMenuStrip7.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip8
        '
        Me.ContextMenuStrip8.Name = "ContextMenuStrip8"
        Me.ContextMenuStrip8.Size = New System.Drawing.Size(61, 4)
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(321, 18)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 3
        Me.btnsimpan.Text = "Button1"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(416, 19)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 4
        Me.btnhapus.Text = "Button2"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'ucFarmasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PnlContent)
        Me.Name = "ucFarmasi"
        Me.Size = New System.Drawing.Size(940, 503)
        Me.PnlContent.ResumeLayout(False)
        Me.PnlContent.PerformLayout()
        Me.pnlWorkspace.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.tlpLeft.ResumeLayout(False)
        Me.pnlForm.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.nudStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlContent As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlWorkspace As Panel
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip4 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip5 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip6 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip7 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip8 As ContextMenuStrip
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpLeft As TableLayoutPanel
    Friend WithEvents pnlForm As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblKode As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblSatuan As Label
    Friend WithEvents lblStok As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cbSatuan As ComboBox
    Friend WithEvents nudStok As NumericUpDown
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents dgvObat As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnsimpan As Button
End Class

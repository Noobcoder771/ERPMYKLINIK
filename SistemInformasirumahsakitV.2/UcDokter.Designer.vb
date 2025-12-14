<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucDokter
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlPeriksa = New System.Windows.Forms.Panel()
        Me.txtPlanning = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDiagnosa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObjective = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSubjective = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKeluhanawal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDetailPasien = New System.Windows.Forms.Label()
        Me.lblNamaPasien = New System.Windows.Forms.Label()
        Me.pnlResep = New System.Windows.Forms.Panel()
        Me.flpKontenKanan = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAlergi = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTindakan = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnRiwayat = New System.Windows.Forms.Button()
        Me.btnSimpanperiksa = New System.Windows.Forms.Button()
        Me.pnlList = New System.Windows.Forms.Panel()
        Me.flpDaftarPasien = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblAntrianPasien = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlPeriksa.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlResep.SuspendLayout()
        Me.flpKontenKanan.SuspendLayout()
        Me.pnlList.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlPeriksa, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlResep, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlList, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1000, 600)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'pnlPeriksa
        '
        Me.pnlPeriksa.BackColor = System.Drawing.Color.White
        Me.pnlPeriksa.Controls.Add(Me.txtPlanning)
        Me.pnlPeriksa.Controls.Add(Me.Label8)
        Me.pnlPeriksa.Controls.Add(Me.txtDiagnosa)
        Me.pnlPeriksa.Controls.Add(Me.Label7)
        Me.pnlPeriksa.Controls.Add(Me.txtObjective)
        Me.pnlPeriksa.Controls.Add(Me.Label6)
        Me.pnlPeriksa.Controls.Add(Me.txtSubjective)
        Me.pnlPeriksa.Controls.Add(Me.Label5)
        Me.pnlPeriksa.Controls.Add(Me.Label4)
        Me.pnlPeriksa.Controls.Add(Me.txtKeluhanawal)
        Me.pnlPeriksa.Controls.Add(Me.Label3)
        Me.pnlPeriksa.Controls.Add(Me.Panel1)
        Me.pnlPeriksa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPeriksa.Location = New System.Drawing.Point(265, 10)
        Me.pnlPeriksa.Margin = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.pnlPeriksa.Name = "pnlPeriksa"
        Me.pnlPeriksa.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlPeriksa.Size = New System.Drawing.Size(360, 580)
        Me.pnlPeriksa.TabIndex = 1
        '
        'txtPlanning
        '
        Me.txtPlanning.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPlanning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlanning.Location = New System.Drawing.Point(18, 507)
        Me.txtPlanning.Multiline = True
        Me.txtPlanning.Name = "txtPlanning"
        Me.txtPlanning.Size = New System.Drawing.Size(327, 60)
        Me.txtPlanning.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 487)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "P (Planning - Rencana/Tindakan)"
        '
        'txtDiagnosa
        '
        Me.txtDiagnosa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiagnosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiagnosa.Location = New System.Drawing.Point(18, 415)
        Me.txtDiagnosa.Multiline = True
        Me.txtDiagnosa.Name = "txtDiagnosa"
        Me.txtDiagnosa.Size = New System.Drawing.Size(327, 60)
        Me.txtDiagnosa.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 393)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "A (Assesment - Diagnosa"
        '
        'txtObjective
        '
        Me.txtObjective.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObjective.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObjective.Location = New System.Drawing.Point(18, 321)
        Me.txtObjective.Multiline = True
        Me.txtObjective.Name = "txtObjective"
        Me.txtObjective.Size = New System.Drawing.Size(327, 60)
        Me.txtObjective.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "O (Objective - Fisik)"
        '
        'txtSubjective
        '
        Me.txtSubjective.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubjective.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubjective.Location = New System.Drawing.Point(18, 226)
        Me.txtSubjective.Multiline = True
        Me.txtSubjective.Name = "txtSubjective"
        Me.txtSubjective.Size = New System.Drawing.Size(327, 60)
        Me.txtSubjective.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "S (Subjective - Anamnesa)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "2. Catatan Pemeriksaan (SOAP)"
        '
        'txtKeluhanawal
        '
        Me.txtKeluhanawal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeluhanawal.BackColor = System.Drawing.Color.White
        Me.txtKeluhanawal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKeluhanawal.Location = New System.Drawing.Point(22, 117)
        Me.txtKeluhanawal.Multiline = True
        Me.txtKeluhanawal.Name = "txtKeluhanawal"
        Me.txtKeluhanawal.ReadOnly = True
        Me.txtKeluhanawal.Size = New System.Drawing.Size(323, 60)
        Me.txtKeluhanawal.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "1. Data Pendaftaran (Keluhan Utama)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblDetailPasien)
        Me.Panel1.Controls.Add(Me.lblNamaPasien)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(15, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 60)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.person_24dp_5985E1_FILL0_wght400_GRAD0_opsz24
        Me.PictureBox1.Location = New System.Drawing.Point(11, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblDetailPasien
        '
        Me.lblDetailPasien.AutoSize = True
        Me.lblDetailPasien.ForeColor = System.Drawing.Color.Gray
        Me.lblDetailPasien.Location = New System.Drawing.Point(41, 32)
        Me.lblDetailPasien.Name = "lblDetailPasien"
        Me.lblDetailPasien.Size = New System.Drawing.Size(213, 15)
        Me.lblDetailPasien.TabIndex = 1
        Me.lblDetailPasien.Text = "Laki-laki, 45 Tahun | RM-00123 | Umum"
        '
        'lblNamaPasien
        '
        Me.lblNamaPasien.AutoSize = True
        Me.lblNamaPasien.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaPasien.Location = New System.Drawing.Point(39, 5)
        Me.lblNamaPasien.Name = "lblNamaPasien"
        Me.lblNamaPasien.Size = New System.Drawing.Size(122, 25)
        Me.lblNamaPasien.TabIndex = 0
        Me.lblNamaPasien.Text = "Budi Santoso"
        '
        'pnlResep
        '
        Me.pnlResep.BackColor = System.Drawing.Color.White
        Me.pnlResep.Controls.Add(Me.flpKontenKanan)
        Me.pnlResep.Controls.Add(Me.btnSimpanperiksa)
        Me.pnlResep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlResep.Location = New System.Drawing.Point(635, 10)
        Me.pnlResep.Margin = New System.Windows.Forms.Padding(5, 10, 10, 10)
        Me.pnlResep.Name = "pnlResep"
        Me.pnlResep.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlResep.Size = New System.Drawing.Size(355, 580)
        Me.pnlResep.TabIndex = 2
        '
        'flpKontenKanan
        '
        Me.flpKontenKanan.AutoScroll = True
        Me.flpKontenKanan.Controls.Add(Me.Label9)
        Me.flpKontenKanan.Controls.Add(Me.txtAlergi)
        Me.flpKontenKanan.Controls.Add(Me.Label11)
        Me.flpKontenKanan.Controls.Add(Me.txtTindakan)
        Me.flpKontenKanan.Controls.Add(Me.Label12)
        Me.flpKontenKanan.Controls.Add(Me.btnRiwayat)
        Me.flpKontenKanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpKontenKanan.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpKontenKanan.Location = New System.Drawing.Point(15, 15)
        Me.flpKontenKanan.Name = "flpKontenKanan"
        Me.flpKontenKanan.Size = New System.Drawing.Size(325, 498)
        Me.flpKontenKanan.TabIndex = 1
        Me.flpKontenKanan.WrapContents = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 5)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Catatan Dan Alergi"
        '
        'txtAlergi
        '
        Me.txtAlergi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlergi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtAlergi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlergi.Location = New System.Drawing.Point(3, 32)
        Me.txtAlergi.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txtAlergi.Multiline = True
        Me.txtAlergi.Name = "txtAlergi"
        Me.txtAlergi.Size = New System.Drawing.Size(319, 44)
        Me.txtAlergi.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 95)
        Me.Label11.Margin = New System.Windows.Forms.Padding(3, 16, 3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "E=Resep Dan Tindakan"
        '
        'txtTindakan
        '
        Me.txtTindakan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTindakan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTindakan.Location = New System.Drawing.Point(3, 127)
        Me.txtTindakan.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.txtTindakan.Multiline = True
        Me.txtTindakan.Name = "txtTindakan"
        Me.txtTindakan.Size = New System.Drawing.Size(319, 266)
        Me.txtTindakan.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 421)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3, 25, 3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "AKSI LANJUTAN"
        '
        'btnRiwayat
        '
        Me.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRiwayat.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRiwayat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnRiwayat.Location = New System.Drawing.Point(3, 441)
        Me.btnRiwayat.Name = "btnRiwayat"
        Me.btnRiwayat.Size = New System.Drawing.Size(319, 48)
        Me.btnRiwayat.TabIndex = 5
        Me.btnRiwayat.Text = "Lihat Riwayat Lama"
        Me.btnRiwayat.UseVisualStyleBackColor = True
        '
        'btnSimpanperiksa
        '
        Me.btnSimpanperiksa.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSimpanperiksa.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSimpanperiksa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanperiksa.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanperiksa.ForeColor = System.Drawing.Color.White
        Me.btnSimpanperiksa.Location = New System.Drawing.Point(15, 513)
        Me.btnSimpanperiksa.Name = "btnSimpanperiksa"
        Me.btnSimpanperiksa.Size = New System.Drawing.Size(325, 52)
        Me.btnSimpanperiksa.TabIndex = 0
        Me.btnSimpanperiksa.Text = "SIMPAN DAN SELESAIKAN"
        Me.btnSimpanperiksa.UseVisualStyleBackColor = False
        '
        'pnlList
        '
        Me.pnlList.BackColor = System.Drawing.Color.White
        Me.pnlList.Controls.Add(Me.flpDaftarPasien)
        Me.pnlList.Controls.Add(Me.lblAntrianPasien)
        Me.pnlList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlList.Location = New System.Drawing.Point(10, 10)
        Me.pnlList.Margin = New System.Windows.Forms.Padding(10, 10, 5, 10)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlList.Size = New System.Drawing.Size(245, 580)
        Me.pnlList.TabIndex = 3
        '
        'flpDaftarPasien
        '
        Me.flpDaftarPasien.AutoScroll = True
        Me.flpDaftarPasien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpDaftarPasien.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpDaftarPasien.Location = New System.Drawing.Point(15, 36)
        Me.flpDaftarPasien.Name = "flpDaftarPasien"
        Me.flpDaftarPasien.Size = New System.Drawing.Size(215, 529)
        Me.flpDaftarPasien.TabIndex = 1
        Me.flpDaftarPasien.WrapContents = False
        '
        'lblAntrianPasien
        '
        Me.lblAntrianPasien.AutoSize = True
        Me.lblAntrianPasien.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAntrianPasien.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAntrianPasien.Location = New System.Drawing.Point(15, 15)
        Me.lblAntrianPasien.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblAntrianPasien.Name = "lblAntrianPasien"
        Me.lblAntrianPasien.Size = New System.Drawing.Size(121, 21)
        Me.lblAntrianPasien.TabIndex = 0
        Me.lblAntrianPasien.Text = "Antrian Pasien"
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
        'ucDokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ucDokter"
        Me.Size = New System.Drawing.Size(1000, 600)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlPeriksa.ResumeLayout(False)
        Me.pnlPeriksa.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlResep.ResumeLayout(False)
        Me.flpKontenKanan.ResumeLayout(False)
        Me.flpKontenKanan.PerformLayout()
        Me.pnlList.ResumeLayout(False)
        Me.pnlList.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pnlPeriksa As Panel
    Friend WithEvents pnlResep As Panel
    Friend WithEvents lblAntrianPasien As Label
    Friend WithEvents pnlList As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents flpDaftarPasien As FlowLayoutPanel
    Friend WithEvents lblNamaPasien As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKeluhanawal As TextBox
    Friend WithEvents txtSubjective As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtObjective As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPlanning As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDiagnosa As TextBox
    Friend WithEvents btnSimpanperiksa As Button
    Friend WithEvents flpKontenKanan As FlowLayoutPanel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label9 As Label
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents lblDetailPasien As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtAlergi As TextBox
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTindakan As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnRiwayat As Button
End Class

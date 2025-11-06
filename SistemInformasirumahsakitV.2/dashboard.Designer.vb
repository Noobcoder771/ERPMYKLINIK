<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Btnmenu = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Btnpendaftaran = New System.Windows.Forms.Button()
        Me.Btnmanajemen = New System.Windows.Forms.Button()
        Me.Btnjanji = New System.Windows.Forms.Button()
        Me.Btnrekam = New System.Windows.Forms.Button()
        Me.Btnfarmasi = New System.Windows.Forms.Button()
        Me.Btnbilling = New System.Windows.Forms.Button()
        Me.PanelTopBar = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.PanelMainContent = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnljanji = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Pnldokter = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlCardDokterAktif = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblpasien = New System.Windows.Forms.Label()
        Me.angka = New System.Windows.Forms.Label()
        Me.lblWelcomeERP = New System.Windows.Forms.Label()
        Me.sidebarTimer = New System.Windows.Forms.Timer(Me.components)
        Me.sidebarPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelTopBar.SuspendLayout()
        Me.PanelMainContent.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnljanji.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnldokter.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCardDokterAktif.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidebarPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btnmenu
        '
        Me.Btnmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Btnmenu.FlatAppearance.BorderSize = 0
        Me.Btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnmenu.ForeColor = System.Drawing.Color.White
        Me.Btnmenu.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.menu_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnmenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btnmenu.Location = New System.Drawing.Point(0, 0)
        Me.Btnmenu.Name = "Btnmenu"
        Me.Btnmenu.Size = New System.Drawing.Size(200, 50)
        Me.Btnmenu.TabIndex = 5
        Me.Btnmenu.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.home_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 48)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(200, 70)
        Me.btnHome.TabIndex = 2
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'Btnpendaftaran
        '
        Me.Btnpendaftaran.AutoSize = True
        Me.Btnpendaftaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Btnpendaftaran.FlatAppearance.BorderSize = 0
        Me.Btnpendaftaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnpendaftaran.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Btnpendaftaran.ForeColor = System.Drawing.Color.White
        Me.Btnpendaftaran.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.app_registration_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnpendaftaran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnpendaftaran.Location = New System.Drawing.Point(0, 124)
        Me.Btnpendaftaran.Name = "Btnpendaftaran"
        Me.Btnpendaftaran.Size = New System.Drawing.Size(200, 70)
        Me.Btnpendaftaran.TabIndex = 3
        Me.Btnpendaftaran.Text = "Pendaftaran Pasien"
        Me.Btnpendaftaran.UseVisualStyleBackColor = False
        '
        'Btnmanajemen
        '
        Me.Btnmanajemen.AutoSize = True
        Me.Btnmanajemen.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Btnmanajemen.FlatAppearance.BorderSize = 0
        Me.Btnmanajemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnmanajemen.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Btnmanajemen.ForeColor = System.Drawing.Color.White
        Me.Btnmanajemen.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.article_person_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnmanajemen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnmanajemen.Location = New System.Drawing.Point(0, 200)
        Me.Btnmanajemen.Name = "Btnmanajemen"
        Me.Btnmanajemen.Size = New System.Drawing.Size(200, 70)
        Me.Btnmanajemen.TabIndex = 2
        Me.Btnmanajemen.Text = "Manajemen Pasien"
        Me.Btnmanajemen.UseVisualStyleBackColor = False
        '
        'Btnjanji
        '
        Me.Btnjanji.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Btnjanji.FlatAppearance.BorderSize = 0
        Me.Btnjanji.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnjanji.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Btnjanji.ForeColor = System.Drawing.Color.White
        Me.Btnjanji.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.assignment_ind_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnjanji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnjanji.Location = New System.Drawing.Point(0, 276)
        Me.Btnjanji.Name = "Btnjanji"
        Me.Btnjanji.Size = New System.Drawing.Size(197, 70)
        Me.Btnjanji.TabIndex = 4
        Me.Btnjanji.Text = "Janji Temu"
        Me.Btnjanji.UseVisualStyleBackColor = False
        '
        'Btnrekam
        '
        Me.Btnrekam.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Btnrekam.FlatAppearance.BorderSize = 0
        Me.Btnrekam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnrekam.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Btnrekam.ForeColor = System.Drawing.Color.White
        Me.Btnrekam.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.prescriptions_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnrekam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnrekam.Location = New System.Drawing.Point(0, 352)
        Me.Btnrekam.Name = "Btnrekam"
        Me.Btnrekam.Size = New System.Drawing.Size(197, 70)
        Me.Btnrekam.TabIndex = 3
        Me.Btnrekam.Text = "Rekam Medis"
        Me.Btnrekam.UseVisualStyleBackColor = False
        '
        'Btnfarmasi
        '
        Me.Btnfarmasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Btnfarmasi.FlatAppearance.BorderSize = 0
        Me.Btnfarmasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnfarmasi.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Btnfarmasi.ForeColor = System.Drawing.Color.White
        Me.Btnfarmasi.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.pill_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnfarmasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnfarmasi.Location = New System.Drawing.Point(3, 428)
        Me.Btnfarmasi.Name = "Btnfarmasi"
        Me.Btnfarmasi.Size = New System.Drawing.Size(197, 70)
        Me.Btnfarmasi.TabIndex = 2
        Me.Btnfarmasi.Text = "Farmasi"
        Me.Btnfarmasi.UseVisualStyleBackColor = False
        '
        'Btnbilling
        '
        Me.Btnbilling.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Btnbilling.FlatAppearance.BorderSize = 0
        Me.Btnbilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnbilling.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Btnbilling.ForeColor = System.Drawing.Color.White
        Me.Btnbilling.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.payments_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnbilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnbilling.Location = New System.Drawing.Point(0, 504)
        Me.Btnbilling.Name = "Btnbilling"
        Me.Btnbilling.Size = New System.Drawing.Size(197, 70)
        Me.Btnbilling.TabIndex = 3
        Me.Btnbilling.Text = "Billing Kasir"
        Me.Btnbilling.UseVisualStyleBackColor = False
        '
        'PanelTopBar
        '
        Me.PanelTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelTopBar.Controls.Add(Me.Button1)
        Me.PanelTopBar.Controls.Add(Me.lblAppName)
        Me.PanelTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTopBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelTopBar.Name = "PanelTopBar"
        Me.PanelTopBar.Size = New System.Drawing.Size(1184, 60)
        Me.PanelTopBar.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = True
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.account_circle_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1069, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Hi, ..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.ForeColor = System.Drawing.Color.White
        Me.lblAppName.Location = New System.Drawing.Point(15, 15)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(238, 21)
        Me.lblAppName.TabIndex = 0
        Me.lblAppName.Text = "Sistem Informasi Rumah Sakit"
        '
        'PanelMainContent
        '
        Me.PanelMainContent.BackColor = System.Drawing.Color.White
        Me.PanelMainContent.Controls.Add(Me.Panel2)
        Me.PanelMainContent.Controls.Add(Me.sidebarPanel)
        Me.PanelMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMainContent.Location = New System.Drawing.Point(0, 60)
        Me.PanelMainContent.Name = "PanelMainContent"
        Me.PanelMainContent.Size = New System.Drawing.Size(1184, 601)
        Me.PanelMainContent.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Chart1)
        Me.Panel1.Location = New System.Drawing.Point(43, 352)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 222)
        Me.Panel1.TabIndex = 4
        '
        'Chart1
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(541, 222)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'pnljanji
        '
        Me.pnljanji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnljanji.Controls.Add(Me.PictureBox3)
        Me.pnljanji.Controls.Add(Me.Label3)
        Me.pnljanji.Controls.Add(Me.Label4)
        Me.pnljanji.Location = New System.Drawing.Point(667, 124)
        Me.pnljanji.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.pnljanji.Name = "pnljanji"
        Me.pnljanji.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.pnljanji.Size = New System.Drawing.Size(250, 150)
        Me.pnljanji.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.person_24dp_434343_FILL0_wght400_GRAD0_opsz24
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(44, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Janji Tamu Hari Ini"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(3, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 65)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "0"
        '
        'Pnldokter
        '
        Me.Pnldokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnldokter.Controls.Add(Me.PictureBox2)
        Me.Pnldokter.Controls.Add(Me.Label1)
        Me.Pnldokter.Controls.Add(Me.Label2)
        Me.Pnldokter.Location = New System.Drawing.Point(354, 124)
        Me.Pnldokter.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Pnldokter.Name = "Pnldokter"
        Me.Pnldokter.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Pnldokter.Size = New System.Drawing.Size(250, 150)
        Me.Pnldokter.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.person_24dp_434343_FILL0_wght400_GRAD0_opsz24
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " Dokter Hari Ini"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(3, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 65)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "0"
        '
        'pnlCardDokterAktif
        '
        Me.pnlCardDokterAktif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardDokterAktif.Controls.Add(Me.PictureBox1)
        Me.pnlCardDokterAktif.Controls.Add(Me.lblpasien)
        Me.pnlCardDokterAktif.Controls.Add(Me.angka)
        Me.pnlCardDokterAktif.Location = New System.Drawing.Point(43, 124)
        Me.pnlCardDokterAktif.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.pnlCardDokterAktif.Name = "pnlCardDokterAktif"
        Me.pnlCardDokterAktif.Padding = New System.Windows.Forms.Padding(0, 0, 11, 0)
        Me.pnlCardDokterAktif.Size = New System.Drawing.Size(250, 150)
        Me.pnlCardDokterAktif.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.person_24dp_434343_FILL0_wght400_GRAD0_opsz24
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblpasien
        '
        Me.lblpasien.AutoSize = True
        Me.lblpasien.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpasien.Location = New System.Drawing.Point(53, 0)
        Me.lblpasien.Name = "lblpasien"
        Me.lblpasien.Size = New System.Drawing.Size(120, 21)
        Me.lblpasien.TabIndex = 1
        Me.lblpasien.Text = "Pasien Hari Ini"
        '
        'angka
        '
        Me.angka.AutoSize = True
        Me.angka.BackColor = System.Drawing.Color.Transparent
        Me.angka.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.angka.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.angka.ForeColor = System.Drawing.Color.RoyalBlue
        Me.angka.Location = New System.Drawing.Point(3, 41)
        Me.angka.Name = "angka"
        Me.angka.Size = New System.Drawing.Size(56, 65)
        Me.angka.TabIndex = 2
        Me.angka.Text = "0"
        '
        'lblWelcomeERP
        '
        Me.lblWelcomeERP.AutoSize = True
        Me.lblWelcomeERP.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeERP.Location = New System.Drawing.Point(32, 19)
        Me.lblWelcomeERP.Name = "lblWelcomeERP"
        Me.lblWelcomeERP.Size = New System.Drawing.Size(539, 65)
        Me.lblWelcomeERP.TabIndex = 0
        Me.lblWelcomeERP.Text = "Selamat datang di ERP"
        '
        'sidebarTimer
        '
        Me.sidebarTimer.Interval = 15
        '
        'sidebarPanel
        '
        Me.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.sidebarPanel.Controls.Add(Me.Btnrekam)
        Me.sidebarPanel.Controls.Add(Me.Btnjanji)
        Me.sidebarPanel.Controls.Add(Me.Btnbilling)
        Me.sidebarPanel.Controls.Add(Me.Btnfarmasi)
        Me.sidebarPanel.Controls.Add(Me.Btnmenu)
        Me.sidebarPanel.Controls.Add(Me.Btnmanajemen)
        Me.sidebarPanel.Controls.Add(Me.Btnpendaftaran)
        Me.sidebarPanel.Controls.Add(Me.btnHome)
        Me.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebarPanel.Location = New System.Drawing.Point(0, 0)
        Me.sidebarPanel.Name = "sidebarPanel"
        Me.sidebarPanel.Size = New System.Drawing.Size(200, 601)
        Me.sidebarPanel.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.lblWelcomeERP)
        Me.Panel2.Controls.Add(Me.pnljanji)
        Me.Panel2.Controls.Add(Me.pnlCardDokterAktif)
        Me.Panel2.Controls.Add(Me.Pnldokter)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 601)
        Me.Panel2.TabIndex = 7
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.PanelMainContent)
        Me.Controls.Add(Me.PanelTopBar)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Informasi Rumah Sakit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTopBar.ResumeLayout(False)
        Me.PanelTopBar.PerformLayout()
        Me.PanelMainContent.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnljanji.ResumeLayout(False)
        Me.pnljanji.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnldokter.ResumeLayout(False)
        Me.Pnldokter.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCardDokterAktif.ResumeLayout(False)
        Me.pnlCardDokterAktif.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidebarPanel.ResumeLayout(False)
        Me.sidebarPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTopBar As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents Btnpendaftaran As Button
    Friend WithEvents Btnmanajemen As Button
    Friend WithEvents Btnrekam As Button
    Friend WithEvents Btnfarmasi As Button
    Friend WithEvents Btnbilling As Button
    Friend WithEvents Btnjanji As Button
    Friend WithEvents lblAppName As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Btnmenu As Button
    Friend WithEvents PanelMainContent As Panel
    Friend WithEvents lblWelcomeERP As Label
    Friend WithEvents pnlCardDokterAktif As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblpasien As Label
    Friend WithEvents angka As Label
    Friend WithEvents pnljanji As FlowLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Pnldokter As FlowLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents sidebarTimer As Timer
    Friend WithEvents sidebarPanel As Panel
    Friend WithEvents Panel2 As Panel
End Class

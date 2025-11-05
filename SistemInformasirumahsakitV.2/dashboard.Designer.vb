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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.PanelTopBar = New System.Windows.Forms.Panel()
        Me.Btnmanajemen = New System.Windows.Forms.Button()
        Me.Btnrekam = New System.Windows.Forms.Button()
        Me.Btnfarmasi = New System.Windows.Forms.Button()
        Me.Btnbilling = New System.Windows.Forms.Button()
        Me.Btnjanji = New System.Windows.Forms.Button()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btnmenu = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Btnpendaftaran = New System.Windows.Forms.Button()
        Me.PanelMainContent = New System.Windows.Forms.Panel()
        Me.lblWelcomeERP = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlSidebar.SuspendLayout()
        Me.PanelTopBar.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PanelMainContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(200, 661)
        Me.pnlSidebar.TabIndex = 0
        '
        'PanelTopBar
        '
        Me.PanelTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelTopBar.Controls.Add(Me.Button1)
        Me.PanelTopBar.Controls.Add(Me.lblAppName)
        Me.PanelTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTopBar.Location = New System.Drawing.Point(200, 0)
        Me.PanelTopBar.Name = "PanelTopBar"
        Me.PanelTopBar.Size = New System.Drawing.Size(984, 60)
        Me.PanelTopBar.TabIndex = 1
        '
        'Btnmanajemen
        '
        Me.Btnmanajemen.AutoSize = True
        Me.Btnmanajemen.BackColor = System.Drawing.Color.Transparent
        Me.Btnmanajemen.FlatAppearance.BorderSize = 0
        Me.Btnmanajemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnmanajemen.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Btnmanajemen.ForeColor = System.Drawing.Color.White
        Me.Btnmanajemen.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.article_person_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnmanajemen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnmanajemen.Location = New System.Drawing.Point(3, 211)
        Me.Btnmanajemen.Name = "Btnmanajemen"
        Me.Btnmanajemen.Size = New System.Drawing.Size(197, 70)
        Me.Btnmanajemen.TabIndex = 2
        Me.Btnmanajemen.Text = "Manajemen Pasien"
        Me.Btnmanajemen.UseVisualStyleBackColor = False
        '
        'Btnrekam
        '
        Me.Btnrekam.BackColor = System.Drawing.Color.Transparent
        Me.Btnrekam.FlatAppearance.BorderSize = 0
        Me.Btnrekam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnrekam.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Btnrekam.ForeColor = System.Drawing.Color.White
        Me.Btnrekam.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.prescriptions_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnrekam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnrekam.Location = New System.Drawing.Point(3, 363)
        Me.Btnrekam.Name = "Btnrekam"
        Me.Btnrekam.Size = New System.Drawing.Size(197, 70)
        Me.Btnrekam.TabIndex = 3
        Me.Btnrekam.Text = "Rekam Medis"
        Me.Btnrekam.UseVisualStyleBackColor = False
        '
        'Btnfarmasi
        '
        Me.Btnfarmasi.FlatAppearance.BorderSize = 0
        Me.Btnfarmasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnfarmasi.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Btnfarmasi.ForeColor = System.Drawing.Color.White
        Me.Btnfarmasi.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.pill_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnfarmasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnfarmasi.Location = New System.Drawing.Point(3, 439)
        Me.Btnfarmasi.Name = "Btnfarmasi"
        Me.Btnfarmasi.Size = New System.Drawing.Size(197, 70)
        Me.Btnfarmasi.TabIndex = 2
        Me.Btnfarmasi.Text = "Farmasi"
        Me.Btnfarmasi.UseVisualStyleBackColor = True
        '
        'Btnbilling
        '
        Me.Btnbilling.FlatAppearance.BorderSize = 0
        Me.Btnbilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnbilling.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Btnbilling.ForeColor = System.Drawing.Color.White
        Me.Btnbilling.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.payments_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnbilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnbilling.Location = New System.Drawing.Point(3, 515)
        Me.Btnbilling.Name = "Btnbilling"
        Me.Btnbilling.Size = New System.Drawing.Size(197, 70)
        Me.Btnbilling.TabIndex = 3
        Me.Btnbilling.Text = "Billing Kasir"
        Me.Btnbilling.UseVisualStyleBackColor = True
        '
        'Btnjanji
        '
        Me.Btnjanji.FlatAppearance.BorderSize = 0
        Me.Btnjanji.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnjanji.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Btnjanji.ForeColor = System.Drawing.Color.White
        Me.Btnjanji.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.assignment_ind_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnjanji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnjanji.Location = New System.Drawing.Point(3, 287)
        Me.Btnjanji.Name = "Btnjanji"
        Me.Btnjanji.Size = New System.Drawing.Size(197, 70)
        Me.Btnjanji.TabIndex = 4
        Me.Btnjanji.Text = "Janji Temu"
        Me.Btnjanji.UseVisualStyleBackColor = True
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(897, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Btnmenu)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnHome)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btnpendaftaran)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btnmanajemen)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btnjanji)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btnrekam)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btnfarmasi)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btnbilling)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 661)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'Btnmenu
        '
        Me.Btnmenu.FlatAppearance.BorderSize = 0
        Me.Btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnmenu.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.menu_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnmenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btnmenu.Location = New System.Drawing.Point(3, 3)
        Me.Btnmenu.Name = "Btnmenu"
        Me.Btnmenu.Size = New System.Drawing.Size(197, 50)
        Me.Btnmenu.TabIndex = 5
        Me.Btnmenu.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.home_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(3, 59)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(197, 70)
        Me.btnHome.TabIndex = 2
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'Btnpendaftaran
        '
        Me.Btnpendaftaran.AutoSize = True
        Me.Btnpendaftaran.BackColor = System.Drawing.Color.Transparent
        Me.Btnpendaftaran.FlatAppearance.BorderSize = 0
        Me.Btnpendaftaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnpendaftaran.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Btnpendaftaran.ForeColor = System.Drawing.Color.White
        Me.Btnpendaftaran.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.app_registration_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnpendaftaran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnpendaftaran.Location = New System.Drawing.Point(3, 135)
        Me.Btnpendaftaran.Name = "Btnpendaftaran"
        Me.Btnpendaftaran.Size = New System.Drawing.Size(197, 70)
        Me.Btnpendaftaran.TabIndex = 3
        Me.Btnpendaftaran.Text = "Pendaftaran Pasien"
        Me.Btnpendaftaran.UseVisualStyleBackColor = False
        '
        'PanelMainContent
        '
        Me.PanelMainContent.BackColor = System.Drawing.Color.White
        Me.PanelMainContent.Controls.Add(Me.FlowLayoutPanel2)
        Me.PanelMainContent.Controls.Add(Me.lblWelcomeERP)
        Me.PanelMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMainContent.Location = New System.Drawing.Point(200, 60)
        Me.PanelMainContent.Name = "PanelMainContent"
        Me.PanelMainContent.Size = New System.Drawing.Size(984, 601)
        Me.PanelMainContent.TabIndex = 2
        '
        'lblWelcomeERP
        '
        Me.lblWelcomeERP.AutoSize = True
        Me.lblWelcomeERP.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeERP.Location = New System.Drawing.Point(20, 20)
        Me.lblWelcomeERP.Name = "lblWelcomeERP"
        Me.lblWelcomeERP.Size = New System.Drawing.Size(539, 65)
        Me.lblWelcomeERP.TabIndex = 0
        Me.lblWelcomeERP.Text = "Selamat datang di ERP"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(168, 192)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(200, 100)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.PanelMainContent)
        Me.Controls.Add(Me.PanelTopBar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Informasi Rumah Sakit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.PanelTopBar.ResumeLayout(False)
        Me.PanelTopBar.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.PanelMainContent.ResumeLayout(False)
        Me.PanelMainContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
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
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Btnmenu As Button
    Friend WithEvents PanelMainContent As Panel
    Friend WithEvents lblWelcomeERP As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.PanelTopBar = New System.Windows.Forms.Panel()
        Me.lblnamauser = New System.Windows.Forms.Button()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.PanelMainContent = New System.Windows.Forms.Panel()
        Me.mainContentPanel = New System.Windows.Forms.Panel()
        Me.pnlkonten = New System.Windows.Forms.Panel()
        Me.btndokter = New System.Windows.Forms.Button()
        Me.Btnrekam = New System.Windows.Forms.Button()
        Me.Btnjanji = New System.Windows.Forms.Button()
        Me.Btnbilling = New System.Windows.Forms.Button()
        Me.Btnfarmasi = New System.Windows.Forms.Button()
        Me.Btnmenu = New System.Windows.Forms.Button()
        Me.Btnmanajemen = New System.Windows.Forms.Button()
        Me.Btnpendaftaran = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.sidebarTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PanelTopBar.SuspendLayout()
        Me.PanelMainContent.SuspendLayout()
        Me.pnlkonten.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTopBar
        '
        Me.PanelTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelTopBar.Controls.Add(Me.lblnamauser)
        Me.PanelTopBar.Controls.Add(Me.lblAppName)
        Me.PanelTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTopBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelTopBar.Name = "PanelTopBar"
        Me.PanelTopBar.Size = New System.Drawing.Size(1184, 60)
        Me.PanelTopBar.TabIndex = 1
        '
        'lblnamauser
        '
        Me.lblnamauser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnamauser.AutoSize = True
        Me.lblnamauser.FlatAppearance.BorderSize = 0
        Me.lblnamauser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblnamauser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamauser.ForeColor = System.Drawing.Color.White
        Me.lblnamauser.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.account_circle_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.lblnamauser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblnamauser.Location = New System.Drawing.Point(942, 15)
        Me.lblnamauser.Name = "lblnamauser"
        Me.lblnamauser.Size = New System.Drawing.Size(230, 32)
        Me.lblnamauser.TabIndex = 1
        Me.lblnamauser.Text = "Hi, ..."
        Me.lblnamauser.UseVisualStyleBackColor = True
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
        Me.PanelMainContent.Controls.Add(Me.mainContentPanel)
        Me.PanelMainContent.Controls.Add(Me.pnlkonten)
        Me.PanelMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMainContent.Location = New System.Drawing.Point(0, 60)
        Me.PanelMainContent.Name = "PanelMainContent"
        Me.PanelMainContent.Size = New System.Drawing.Size(1184, 601)
        Me.PanelMainContent.TabIndex = 2
        '
        'mainContentPanel
        '
        Me.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainContentPanel.Location = New System.Drawing.Point(200, 0)
        Me.mainContentPanel.Name = "mainContentPanel"
        Me.mainContentPanel.Size = New System.Drawing.Size(984, 601)
        Me.mainContentPanel.TabIndex = 7
        '
        'pnlkonten
        '
        Me.pnlkonten.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pnlkonten.Controls.Add(Me.Btnmenu)
        Me.pnlkonten.Controls.Add(Me.btndokter)
        Me.pnlkonten.Controls.Add(Me.Btnrekam)
        Me.pnlkonten.Controls.Add(Me.Btnjanji)
        Me.pnlkonten.Controls.Add(Me.Btnbilling)
        Me.pnlkonten.Controls.Add(Me.Btnfarmasi)
        Me.pnlkonten.Controls.Add(Me.Btnmanajemen)
        Me.pnlkonten.Controls.Add(Me.Btnpendaftaran)
        Me.pnlkonten.Controls.Add(Me.btnHome)
        Me.pnlkonten.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlkonten.Location = New System.Drawing.Point(0, 0)
        Me.pnlkonten.Name = "pnlkonten"
        Me.pnlkonten.Size = New System.Drawing.Size(200, 601)
        Me.pnlkonten.TabIndex = 6
        '
        'btndokter
        '
        Me.btndokter.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btndokter.FlatAppearance.BorderSize = 0
        Me.btndokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndokter.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btndokter.ForeColor = System.Drawing.Color.White
        Me.btndokter.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.clinical_notes_24dp_F3F3F3_FILL0_wght400_GRAD0_opsz24
        Me.btndokter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndokter.Location = New System.Drawing.Point(3, 352)
        Me.btndokter.Name = "btndokter"
        Me.btndokter.Size = New System.Drawing.Size(197, 70)
        Me.btndokter.TabIndex = 4
        Me.btndokter.Text = "Dokter"
        Me.btndokter.UseVisualStyleBackColor = False
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
        Me.Btnrekam.Location = New System.Drawing.Point(0, 423)
        Me.Btnrekam.Name = "Btnrekam"
        Me.Btnrekam.Size = New System.Drawing.Size(197, 70)
        Me.Btnrekam.TabIndex = 3
        Me.Btnrekam.Text = "Rekam Medis"
        Me.Btnrekam.UseVisualStyleBackColor = False
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
        'Btnbilling
        '
        Me.Btnbilling.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Btnbilling.FlatAppearance.BorderSize = 0
        Me.Btnbilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnbilling.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Btnbilling.ForeColor = System.Drawing.Color.White
        Me.Btnbilling.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.payments_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnbilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnbilling.Location = New System.Drawing.Point(0, 575)
        Me.Btnbilling.Name = "Btnbilling"
        Me.Btnbilling.Size = New System.Drawing.Size(197, 70)
        Me.Btnbilling.TabIndex = 3
        Me.Btnbilling.Text = "Billing Kasir"
        Me.Btnbilling.UseVisualStyleBackColor = False
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
        Me.Btnfarmasi.Location = New System.Drawing.Point(3, 499)
        Me.Btnfarmasi.Name = "Btnfarmasi"
        Me.Btnfarmasi.Size = New System.Drawing.Size(197, 70)
        Me.Btnfarmasi.TabIndex = 2
        Me.Btnfarmasi.Text = "Farmasi"
        Me.Btnfarmasi.UseVisualStyleBackColor = False
        '
        'Btnmenu
        '
        Me.Btnmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Btnmenu.FlatAppearance.BorderSize = 0
        Me.Btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnmenu.ForeColor = System.Drawing.Color.White
        Me.Btnmenu.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.menu_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.Btnmenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btnmenu.Location = New System.Drawing.Point(3, 6)
        Me.Btnmenu.Name = "Btnmenu"
        Me.Btnmenu.Size = New System.Drawing.Size(200, 50)
        Me.Btnmenu.TabIndex = 5
        Me.Btnmenu.UseVisualStyleBackColor = False
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
        'sidebarTimer
        '
        Me.sidebarTimer.Interval = 15
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
        Me.pnlkonten.ResumeLayout(False)
        Me.pnlkonten.PerformLayout()
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
    Friend WithEvents lblnamauser As Button
    Friend WithEvents Btnmenu As Button
    Friend WithEvents PanelMainContent As Panel
    Friend WithEvents sidebarTimer As Timer
    Friend WithEvents pnlkonten As Panel
    Friend WithEvents mainContentPanel As Panel
    Friend WithEvents btndokter As Button
End Class

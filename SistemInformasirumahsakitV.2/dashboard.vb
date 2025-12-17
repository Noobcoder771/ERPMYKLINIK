Imports System.Windows.Forms
Public Class frmDashboard
    Private sidebarExpandedWidth As Integer = 200
    Private sidebarCollapsedWidth As Integer = 40
    Private isSidebarCollapsed As Boolean = True
    Private animationStep As Integer = 10

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Saat form pertama kali dimuat, pastikan sidebar dalam keadaan terbuka
        isSidebarCollapsed = False
        pnlkonten.Width = sidebarExpandedWidth
        UpdateMenuButtonText()
        LoadUserControl(New ucHome())
        Call BukaHalaman(New ucHome)
        lblnamauser.Text = "Hi, " & ModulKoneksi.UserName & " ▼" ' Tambah panah biar user tau bisa diklik
        lblnamauser.Cursor = Cursors.Hand ' Ubah kursor jadi tangan saat disorot

        ' B. Tampilkan Nama & Role di dalam Menu Dropdown
        itemNamaUser.Text = ModulKoneksi.UserName & vbCrLf & "(" & ModulKoneksi.UserRole & ")"
        itemNamaUser.Enabled = False
    End Sub

    ' --- 2. FUNGSI GANTI HALAMAN (Helper) ---
    Sub BukaHalaman(Halaman As UserControl)
    End Sub

    Private Sub Btnfarmasi_Click(sender As Object, e As EventArgs) Handles Btnfarmasi.Click
        LoadUserControl(New ucFarmasi())
    End Sub

    Private Sub Btnbilling_Click(sender As Object, e As EventArgs) Handles Btnbilling.Click
        If ModulKoneksi.UserRole = "Staff" Then
            MsgBox("Akses Ditolak! Menu Kasir hanya untuk Admin.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        LoadUserControl(New ucbilling())
    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub sidebarPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        LoadUserControl(New ucHome())
        Call BukaHalaman(New ucHome)
    End Sub

    Private Sub Btnpendaftaran_Click(sender As Object, e As EventArgs) Handles Btnpendaftaran.Click
        If ModulKoneksi.UserRole = "Staff" Then
            MsgBox("Akses Ditolak! Menu ini hanya untuk Admin & Dokter.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        LoadUserControl(New ucPendaftaranPasien())
    End Sub

    Private Sub Btnmenu_Click(sender As Object, e As EventArgs) Handles Btnmenu.Click
        sidebarTimer.Start()
    End Sub

    Private Sub sidebarTimer_Tick(sender As Object, e As EventArgs) Handles sidebarTimer.Tick
        If isSidebarCollapsed Then
            ' --- PROSES MEMBUKA SIDEBAR ---

            ' Tambah lebar panel
            pnlkonten.Width += animationStep

            ' Jika sudah mencapai atau melebihi lebar target
            If pnlkonten.Width >= sidebarExpandedWidth Then
                ' Hentikan timer agar tidak overshoot
                sidebarTimer.Stop()
                ' Atur lebar pasti
                pnlkonten.Width = sidebarExpandedWidth
                ' Ubah status
                isSidebarCollapsed = False
                ' Tampilkan teks pada tombol
                UpdateMenuButtonText()
            End If

        Else
            ' --- PROSES MENUTUP SIDEBAR ---

            ' Sembunyikan teks DULU agar tidak aneh saat mengecil
            If pnlkonten.Width = sidebarExpandedWidth Then
                UpdateMenuButtonText()
            End If

            ' Kurangi lebar panel
            pnlkonten.Width -= animationStep

            ' Jika sudah mencapai atau melebihi lebar target
            If pnlkonten.Width <= sidebarCollapsedWidth Then
                ' Hentikan timer
                sidebarTimer.Stop()
                ' Atur lebar pasti
                pnlkonten.Width = sidebarCollapsedWidth
                ' Ubah status
                isSidebarCollapsed = True
            End If
        End If
    End Sub
    Private Sub UpdateMenuButtonText()
        If isSidebarCollapsed Then
        Else
        End If

    End Sub
    Private Sub LoadUserControl(uc As UserControl)
        ' Pastikan Anda punya Panel di Desainer (bernama 'mainContentPanel')
        ' yang properti Dock-nya diatur ke 'Fill'.

        mainContentPanel.Controls.Clear()
        uc.Dock = DockStyle.Fill
        mainContentPanel.Controls.Add(uc)
    End Sub

    Private Sub lblWelcomeERP_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mainContentPanel_Paint(sender As Object, e As PaintEventArgs) Handles mainContentPanel.Paint

    End Sub

    Private Sub Btnmanajemen_Click(sender As Object, e As EventArgs) Handles Btnmanajemen.Click
        If ModulKoneksi.UserRole = "Staff" Then
            MsgBox("Akses Ditolak! Anda tidak memiliki izin Admin.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        LoadUserControl(New ucManajemenPasien())
    End Sub

    Private Sub Btnjanji_Click(sender As Object, e As EventArgs) Handles Btnjanji.Click
        If ModulKoneksi.UserRole = "Staff" Then
            MsgBox("Akses Ditolak! Staff Gudang/Apotek tidak mengurus pendaftaran.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        LoadUserControl(New ucjanjitemu)
    End Sub

    Private Sub Btnrekam_Click(sender As Object, e As EventArgs) Handles Btnrekam.Click
        LoadUserControl(New ucRekamMedis())
        If ModulKoneksi.UserRole = "Staff" Then
            MsgBox("Akses Ditolak! Silakan hubungi Admin.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btndokter.Click
        If ModulKoneksi.UserRole = "Admin" Then
            MsgBox("Admin DILARANG mengakses modul Dokter demi keamanan medis!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ModulKoneksi.UserRole = "Staff" Then
            MsgBox("Akses Ditolak! Menu ini khusus Dokter.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        LoadUserControl(New ucDokter())
    End Sub

    Private Sub PanelTopBar_Paint(sender As Object, e As PaintEventArgs) Handles PanelTopBar.Paint

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsUserMenu.Opening

    End Sub

    Private Sub lblnamauser_Click(sender As Object, e As EventArgs) Handles lblnamauser.Click
        cmsUserMenu.Show(lblnamauser, 0, lblnamauser.Height)
    End Sub
    Private Sub itemLogout_Click(sender As Object, e As EventArgs) Handles itemLogout.Click
        If MsgBox("Yakin ingin logout?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Dim Login As New Menulogin
            Login.Show()
            Me.Close()
        End If
    End Sub
End Class

Imports System.Windows.Forms
Public Class frmDashboard
    Private sidebarExpandedWidth As Integer = 200
    Private sidebarCollapsedWidth As Integer = 40
    Private isSidebarCollapsed As Boolean = True
    Private animationStep As Integer = 10

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Saat form pertama kali dimuat, pastikan sidebar dalam keadaan terbuka
        isSidebarCollapsed = True
        sidebarPanel.Width = sidebarExpandedWidth
        UpdateMenuButtonText()
        LoadUserControl(New ucHome())
    End Sub

    Private Sub Btnfarmasi_Click(sender As Object, e As EventArgs) Handles Btnfarmasi.Click

    End Sub

    Private Sub Btnbilling_Click(sender As Object, e As EventArgs) Handles Btnbilling.Click

    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub sidebarPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        LoadUserControl(New ucHome())
    End Sub

    Private Sub Btnpendaftaran_Click(sender As Object, e As EventArgs) Handles Btnpendaftaran.Click
        LoadUserControl(New ucPendaftaranPasien())
    End Sub

    Private Sub Btnmenu_Click(sender As Object, e As EventArgs) Handles Btnmenu.Click
        sidebarTimer.Start()
    End Sub

    Private Sub sidebarTimer_Tick(sender As Object, e As EventArgs) Handles sidebarTimer.Tick
        If isSidebarCollapsed Then
            ' --- PROSES MEMBUKA SIDEBAR ---

            ' Tambah lebar panel
            sidebarPanel.Width += animationStep

            ' Jika sudah mencapai atau melebihi lebar target
            If sidebarPanel.Width >= sidebarExpandedWidth Then
                ' Hentikan timer agar tidak overshoot
                sidebarTimer.Stop()
                ' Atur lebar pasti
                sidebarPanel.Width = sidebarExpandedWidth
                ' Ubah status
                isSidebarCollapsed = False
                ' Tampilkan teks pada tombol
                UpdateMenuButtonText()
            End If

        Else
            ' --- PROSES MENUTUP SIDEBAR ---

            ' Sembunyikan teks DULU agar tidak aneh saat mengecil
            If sidebarPanel.Width = sidebarExpandedWidth Then
                UpdateMenuButtonText()
            End If

            ' Kurangi lebar panel
            sidebarPanel.Width -= animationStep

            ' Jika sudah mencapai atau melebihi lebar target
            If sidebarPanel.Width <= sidebarCollapsedWidth Then
                ' Hentikan timer
                sidebarTimer.Stop()
                ' Atur lebar pasti
                sidebarPanel.Width = sidebarCollapsedWidth
                ' Ubah status
                isSidebarCollapsed = True
            End If
        End If
    End Sub
    Private Sub UpdateMenuButtonText()
        If isSidebarCollapsed Then
            ' Sembunyikan teks, hanya tampilkan ikon
            ' (Kita atur Text jadi string kosong)
            ' Asumsi Anda punya tombol-tombol ini di desainer:
            ' btnHome, btnPendaftaran, btnManajemen, btnJanji, btnRekam, btnFarmasi, btnBilling

            ' Contoh:
            ' btnMenu.Text = ""
            ' btnHome.Text = ""
            ' btnPendaftaran.Text = ""
            ' btnManajemen.Text = ""
            ' ... dan seterusnya untuk semua tombol menu

            ' Agar rapi, ikon mungkin perlu di-set ulang paddingnya
            ' (Namun, untuk .NET 4.8, menyembunyikan teks saja sudah cukup)

        Else
            ' Tampilkan teks di samping ikon
            ' (Kita kembalikan teksnya)

            ' Contoh:
            ' btnMenu.Text = "  Menu"
            ' btnHome.Text = "  Home"
            ' btnPendaftaran.Text = "  Pendaftaran Pasien"
            ' btnManajemen.Text = "  Manajemen Pasien"
            ' ... dan seterusnya

        End If

        ' Catatan: Pastikan properti ImageAlign dan TextAlign pada tombol
        ' diatur ke MiddleLeft agar ikon dan teks sejajar.
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
End Class

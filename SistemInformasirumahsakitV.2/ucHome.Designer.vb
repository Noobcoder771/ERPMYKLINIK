<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucHome
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblWelcomeERP = New System.Windows.Forms.Label()
        Me.pnljanji = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlCardDokterAktif = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblpasien = New System.Windows.Forms.Label()
        Me.angka = New System.Windows.Forms.Label()
        Me.Pnldokter = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnljanji.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCardDokterAktif.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnldokter.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcomeERP
        '
        Me.lblWelcomeERP.AutoSize = True
        Me.lblWelcomeERP.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeERP.Location = New System.Drawing.Point(32, 15)
        Me.lblWelcomeERP.Name = "lblWelcomeERP"
        Me.lblWelcomeERP.Size = New System.Drawing.Size(539, 65)
        Me.lblWelcomeERP.TabIndex = 4
        Me.lblWelcomeERP.Text = "Selamat datang di ERP"
        '
        'pnljanji
        '
        Me.pnljanji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnljanji.Controls.Add(Me.PictureBox3)
        Me.pnljanji.Controls.Add(Me.Label3)
        Me.pnljanji.Controls.Add(Me.Label4)
        Me.pnljanji.Location = New System.Drawing.Point(657, 122)
        Me.pnljanji.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.pnljanji.Name = "pnljanji"
        Me.pnljanji.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.pnljanji.Size = New System.Drawing.Size(250, 150)
        Me.pnljanji.TabIndex = 7
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
        'pnlCardDokterAktif
        '
        Me.pnlCardDokterAktif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardDokterAktif.Controls.Add(Me.PictureBox1)
        Me.pnlCardDokterAktif.Controls.Add(Me.lblpasien)
        Me.pnlCardDokterAktif.Controls.Add(Me.angka)
        Me.pnlCardDokterAktif.Location = New System.Drawing.Point(43, 122)
        Me.pnlCardDokterAktif.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.pnlCardDokterAktif.Name = "pnlCardDokterAktif"
        Me.pnlCardDokterAktif.Padding = New System.Windows.Forms.Padding(0, 0, 11, 0)
        Me.pnlCardDokterAktif.Size = New System.Drawing.Size(250, 150)
        Me.pnlCardDokterAktif.TabIndex = 5
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
        'Pnldokter
        '
        Me.Pnldokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnldokter.Controls.Add(Me.PictureBox2)
        Me.Pnldokter.Controls.Add(Me.Label1)
        Me.Pnldokter.Controls.Add(Me.Label2)
        Me.Pnldokter.Location = New System.Drawing.Point(350, 122)
        Me.Pnldokter.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Pnldokter.Name = "Pnldokter"
        Me.Pnldokter.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Pnldokter.Size = New System.Drawing.Size(250, 150)
        Me.Pnldokter.TabIndex = 6
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
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(43, 341)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(557, 222)
        Me.Chart1.TabIndex = 8
        Me.Chart1.Text = "Chart1"
        '
        'ucHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.lblWelcomeERP)
        Me.Controls.Add(Me.pnljanji)
        Me.Controls.Add(Me.pnlCardDokterAktif)
        Me.Controls.Add(Me.Pnldokter)
        Me.Name = "ucHome"
        Me.Size = New System.Drawing.Size(948, 600)
        Me.pnljanji.ResumeLayout(False)
        Me.pnljanji.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCardDokterAktif.ResumeLayout(False)
        Me.pnlCardDokterAktif.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnldokter.ResumeLayout(False)
        Me.Pnldokter.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcomeERP As Label
    Friend WithEvents pnljanji As FlowLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlCardDokterAktif As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblpasien As Label
    Friend WithEvents angka As Label
    Friend WithEvents Pnldokter As FlowLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class

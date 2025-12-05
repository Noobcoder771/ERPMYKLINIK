<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucPendaftaranPasien
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbkelamin = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtplahir = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnik = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttelepon = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.CentralPanel = New System.Windows.Forms.Panel()
        Me.cmbpoli = New System.Windows.Forms.ComboBox()
        Me.dtpRegistrasi = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CentralPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pendaftaran Pasien Baru"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(372, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sistem Informasi Rumah Sakit"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbkelamin
        '
        Me.cmbkelamin.FormattingEnabled = True
        Me.cmbkelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cmbkelamin.Location = New System.Drawing.Point(305, 246)
        Me.cmbkelamin.Name = "cmbkelamin"
        Me.cmbkelamin.Size = New System.Drawing.Size(119, 21)
        Me.cmbkelamin.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(215, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(215, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Jenis Kelamin"
        '
        'dtplahir
        '
        Me.dtplahir.CustomFormat = "dd MMMM yyyy"
        Me.dtplahir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtplahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtplahir.Location = New System.Drawing.Point(305, 210)
        Me.dtplahir.Name = "dtplahir"
        Me.dtplahir.Size = New System.Drawing.Size(151, 21)
        Me.dtplahir.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(511, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "POLI"
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(218, 171)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(206, 21)
        Me.txtnama.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(328, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 29)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "SIMPAN DATA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(466, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 29)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "BATAL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(215, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 15)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Nama Lengkap"
        '
        'txtnik
        '
        Me.txtnik.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnik.Location = New System.Drawing.Point(514, 286)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(203, 21)
        Me.txtnik.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(511, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 15)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Nomor Telepon"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(511, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 15)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Tgl. Registrasi"
        '
        'txtalamat
        '
        Me.txtalamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(217, 313)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(207, 21)
        Me.txtalamat.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(511, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 15)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "NIK"
        '
        'txttelepon
        '
        Me.txttelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelepon.Location = New System.Drawing.Point(514, 171)
        Me.txttelepon.Name = "txttelepon"
        Me.txttelepon.Size = New System.Drawing.Size(207, 21)
        Me.txttelepon.TabIndex = 38
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.person_24dp_1F1F1F_FILL1_wght400_GRAD0_opsz24__1_
        Me.PictureBox1.Location = New System.Drawing.Point(189, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.document_scanner_24dp_1F1F1F_FILL1_wght400_GRAD0_opsz24
        Me.PictureBox8.Location = New System.Drawing.Point(485, 323)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 42
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.id_card_24dp_1F1F1F_FILL1_wght400_GRAD0_opsz24
        Me.PictureBox7.Location = New System.Drawing.Point(485, 261)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 41
        Me.PictureBox7.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.calendar_clock_24dp_1F1F1F_FILL1_wght400_GRAD0_opsz24
        Me.PictureBox2.Location = New System.Drawing.Point(189, 210)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.event_note_24dp_1F1F1F_FILL1_wght400_GRAD0_opsz24
        Me.PictureBox6.Location = New System.Drawing.Point(485, 205)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 40
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.man_24dp_1F1F1F_FILL1_wght400_GRAD0_opsz24
        Me.PictureBox5.Location = New System.Drawing.Point(189, 246)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 39
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.location_on_24dp_1F1F1F_FILL1_wght400_GRAD0_opsz24
        Me.PictureBox3.Location = New System.Drawing.Point(189, 286)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.call_24dp_1F1F1F_FILL1_wght400_GRAD0_opsz24
        Me.PictureBox4.Location = New System.Drawing.Point(485, 144)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 33
        Me.PictureBox4.TabStop = False
        '
        'CentralPanel
        '
        Me.CentralPanel.Controls.Add(Me.dtpRegistrasi)
        Me.CentralPanel.Controls.Add(Me.cmbpoli)
        Me.CentralPanel.Controls.Add(Me.Label1)
        Me.CentralPanel.Controls.Add(Me.PictureBox4)
        Me.CentralPanel.Controls.Add(Me.Label2)
        Me.CentralPanel.Controls.Add(Me.Label7)
        Me.CentralPanel.Controls.Add(Me.PictureBox1)
        Me.CentralPanel.Controls.Add(Me.Label4)
        Me.CentralPanel.Controls.Add(Me.PictureBox3)
        Me.CentralPanel.Controls.Add(Me.Button1)
        Me.CentralPanel.Controls.Add(Me.cmbkelamin)
        Me.CentralPanel.Controls.Add(Me.Button2)
        Me.CentralPanel.Controls.Add(Me.Label5)
        Me.CentralPanel.Controls.Add(Me.Label9)
        Me.CentralPanel.Controls.Add(Me.PictureBox8)
        Me.CentralPanel.Controls.Add(Me.PictureBox5)
        Me.CentralPanel.Controls.Add(Me.dtplahir)
        Me.CentralPanel.Controls.Add(Me.Label8)
        Me.CentralPanel.Controls.Add(Me.PictureBox6)
        Me.CentralPanel.Controls.Add(Me.PictureBox7)
        Me.CentralPanel.Controls.Add(Me.Label3)
        Me.CentralPanel.Controls.Add(Me.Label6)
        Me.CentralPanel.Controls.Add(Me.Label10)
        Me.CentralPanel.Controls.Add(Me.txtnama)
        Me.CentralPanel.Controls.Add(Me.PictureBox2)
        Me.CentralPanel.Controls.Add(Me.txtnik)
        Me.CentralPanel.Controls.Add(Me.txttelepon)
        Me.CentralPanel.Controls.Add(Me.txtalamat)
        Me.CentralPanel.Location = New System.Drawing.Point(0, 0)
        Me.CentralPanel.Name = "CentralPanel"
        Me.CentralPanel.Size = New System.Drawing.Size(948, 600)
        Me.CentralPanel.TabIndex = 44
        '
        'cmbpoli
        '
        Me.cmbpoli.FormattingEnabled = True
        Me.cmbpoli.Location = New System.Drawing.Point(514, 351)
        Me.cmbpoli.Name = "cmbpoli"
        Me.cmbpoli.Size = New System.Drawing.Size(203, 21)
        Me.cmbpoli.TabIndex = 44
        '
        'dtpRegistrasi
        '
        Me.dtpRegistrasi.CustomFormat = "dd MMMM yyyy"
        Me.dtpRegistrasi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRegistrasi.Location = New System.Drawing.Point(514, 223)
        Me.dtpRegistrasi.Name = "dtpRegistrasi"
        Me.dtpRegistrasi.Size = New System.Drawing.Size(200, 20)
        Me.dtpRegistrasi.TabIndex = 45
        '
        'ucPendaftaranPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.CentralPanel)
        Me.Name = "ucPendaftaranPasien"
        Me.Size = New System.Drawing.Size(948, 600)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CentralPanel.ResumeLayout(False)
        Me.CentralPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbkelamin As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtplahir As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnik As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txttelepon As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents CentralPanel As Panel
    Friend WithEvents cmbpoli As ComboBox
    Friend WithEvents dtpRegistrasi As DateTimePicker
End Class

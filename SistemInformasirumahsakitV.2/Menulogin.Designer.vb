<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menulogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menulogin))
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblaja = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mainPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainPanel
        '
        Me.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mainPanel.Controls.Add(Me.lblErrorMessage)
        Me.mainPanel.Controls.Add(Me.PictureBox2)
        Me.mainPanel.Controls.Add(Me.PictureBox1)
        Me.mainPanel.Controls.Add(Me.txtPassword)
        Me.mainPanel.Controls.Add(Me.Button1)
        Me.mainPanel.Controls.Add(Me.txtUsername)
        Me.mainPanel.Controls.Add(Me.lblaja)
        Me.mainPanel.Controls.Add(Me.Label1)
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(884, 561)
        Me.mainPanel.TabIndex = 0
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.AutoSize = True
        Me.lblErrorMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMessage.Location = New System.Drawing.Point(386, 307)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(0, 17)
        Me.lblErrorMessage.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemInformasirumahsakitV._2.My.Resources.Resources.key_24dp_434343_FILL0_wght400_GRAD0_opsz24
        Me.PictureBox2.Location = New System.Drawing.Point(292, 260)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(292, 205)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtPassword.Location = New System.Drawing.Point(346, 258)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(258, 35)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(346, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(255, 59)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtUsername.Location = New System.Drawing.Point(346, 204)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(258, 35)
        Me.txtUsername.TabIndex = 2
        '
        'lblaja
        '
        Me.lblaja.AutoSize = True
        Me.lblaja.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblaja.Location = New System.Drawing.Point(324, 100)
        Me.lblaja.Name = "lblaja"
        Me.lblaja.Size = New System.Drawing.Size(260, 25)
        Me.lblaja.TabIndex = 1
        Me.lblaja.Text = "Sistem informasi Rumah Sakit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(258, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selamat Datang"
        '
        'Menulogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.mainPanel)
        Me.Name = "Menulogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menulogin"
        Me.mainPanel.ResumeLayout(False)
        Me.mainPanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblaja As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblErrorMessage As Label
End Class

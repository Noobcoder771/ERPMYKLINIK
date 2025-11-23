<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRekamMedis
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
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        Label3 = New Label()
        Panel2 = New Panel()
        DataGridView_CariPasien = New DataGridView()
        NoRM = New DataGridViewTextBoxColumn()
        KeluhanAwal = New DataGridViewTextBoxColumn()
        Panel3 = New Panel()
        Panel8 = New Panel()
        TextBox3 = New TextBox()
        Panel7 = New Panel()
        TextBox2 = New TextBox()
        Panel6 = New Panel()
        Label8 = New Label()
        Label7 = New Label()
        Panel5 = New Panel()
        Label6 = New Label()
        Label4 = New Label()
        Panel4 = New Panel()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Panel9 = New Panel()
        Panel15 = New Panel()
        DataGridView_ResepObat = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        qty = New DataGridViewTextBoxColumn()
        Panel10 = New Panel()
        Panel13 = New Panel()
        Button4 = New Button()
        TextBox6 = New TextBox()
        Panel12 = New Panel()
        Button3 = New Button()
        TextBox5 = New TextBox()
        Panel11 = New Panel()
        Button2 = New Button()
        TextBox4 = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        ComboBox1 = New ComboBox()
        Label10 = New Label()
        Label9 = New Label()
        Panel14 = New Panel()
        Button6 = New Button()
        Button5 = New Button()
        Panel16 = New Panel()
        PictureBox1 = New PictureBox()
        TextBox7 = New TextBox()
        Button7 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView_CariPasien, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel9.SuspendLayout()
        Panel15.SuspendLayout()
        CType(DataGridView_ResepObat, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        Panel13.SuspendLayout()
        Panel12.SuspendLayout()
        Panel11.SuspendLayout()
        Panel14.SuspendLayout()
        Panel16.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(332, 35)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 15)
        Label2.TabIndex = 3
        Label2.Text = "Sistem Informasi Rumah Sakit"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(294, 5)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(261, 30)
        Label1.TabIndex = 2
        Label1.Text = "Rekam Medis Elektronik"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Panel16)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(11, 55)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(373, 293)
        Panel1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(8, 255)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 29)
        Button1.TabIndex = 8
        Button1.Text = "PERIKSA PASIEN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.Location = New Point(2, 13)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(158, 19)
        Label3.TabIndex = 5
        Label3.Text = "Antrian Pasien Hari Ini"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.Controls.Add(DataGridView_CariPasien)
        Panel2.Location = New Point(0, 47)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(362, 195)
        Panel2.TabIndex = 0
        ' 
        ' DataGridView_CariPasien
        ' 
        DataGridView_CariPasien.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView_CariPasien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_CariPasien.Columns.AddRange(New DataGridViewColumn() {NoRM, KeluhanAwal})
        DataGridView_CariPasien.Location = New Point(8, 13)
        DataGridView_CariPasien.Margin = New Padding(2)
        DataGridView_CariPasien.Name = "DataGridView_CariPasien"
        DataGridView_CariPasien.RowHeadersWidth = 62
        DataGridView_CariPasien.Size = New Size(352, 155)
        DataGridView_CariPasien.TabIndex = 0
        ' 
        ' NoRM
        ' 
        NoRM.HeaderText = "No. RM"
        NoRM.MinimumWidth = 8
        NoRM.Name = "NoRM"
        NoRM.Width = 150
        ' 
        ' KeluhanAwal
        ' 
        KeluhanAwal.HeaderText = "Keluhan Awal"
        KeluhanAwal.MinimumWidth = 8
        KeluhanAwal.Name = "KeluhanAwal"
        KeluhanAwal.Width = 150
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightGray
        Panel3.Controls.Add(Panel8)
        Panel3.Controls.Add(Panel7)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Panel4)
        Panel3.Location = New Point(416, 55)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(458, 208)
        Panel3.TabIndex = 9
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.ControlLight
        Panel8.Controls.Add(TextBox3)
        Panel8.Location = New Point(312, 155)
        Panel8.Margin = New Padding(2)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(134, 30)
        Panel8.TabIndex = 13
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ControlLight
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Location = New Point(6, 7)
        TextBox3.Margin = New Padding(2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(120, 16)
        TextBox3.TabIndex = 11
        TextBox3.Text = "Alergi Obat"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(TextBox2)
        Panel7.Location = New Point(312, 107)
        Panel7.Margin = New Padding(2)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(134, 30)
        Panel7.TabIndex = 12
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(6, 7)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(120, 16)
        TextBox2.TabIndex = 11
        TextBox2.Text = "Dokter"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ButtonHighlight
        Panel6.Controls.Add(PictureBox1)
        Panel6.Controls.Add(Label8)
        Panel6.Controls.Add(Label7)
        Panel6.Location = New Point(8, 147)
        Panel6.Margin = New Padding(2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(300, 47)
        Panel6.TabIndex = 10
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(48, 23)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(185, 15)
        Label8.TabIndex = 3
        Label8.Text = "(luthemnaax (ICD-10 ogeiexnusia)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(48, 7)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(136, 15)
        Label7.TabIndex = 2
        Label7.Text = "Konsultail Doteer Umam"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ControlLight
        Panel5.Controls.Add(Label6)
        Panel5.Location = New Point(8, 107)
        Panel5.Margin = New Padding(2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(300, 30)
        Panel5.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(3, 6)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 15)
        Label6.TabIndex = 2
        Label6.Text = "Diagnosa Medis"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label4.Location = New Point(8, 13)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 19)
        Label4.TabIndex = 5
        Label4.Text = "Detail Pemeriksaan"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ControlLight
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(TextBox1)
        Panel4.Location = New Point(0, 47)
        Panel4.Margin = New Padding(2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(308, 44)
        Panel4.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(11, 5)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 15)
        Label5.TabIndex = 1
        Label5.Text = "Anamessia Bedon"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(8, 24)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(289, 23)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Diegness (ICD-10/11)"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Gainsboro
        Panel9.Controls.Add(Panel15)
        Panel9.Controls.Add(Panel10)
        Panel9.Controls.Add(Label9)
        Panel9.Location = New Point(416, 263)
        Panel9.Margin = New Padding(2)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(458, 233)
        Panel9.TabIndex = 10
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = SystemColors.MenuBar
        Panel15.Controls.Add(DataGridView_ResepObat)
        Panel15.Location = New Point(8, 123)
        Panel15.Margin = New Padding(2)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(445, 109)
        Panel15.TabIndex = 15
        ' 
        ' DataGridView_ResepObat
        ' 
        DataGridView_ResepObat.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView_ResepObat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_ResepObat.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, qty})
        DataGridView_ResepObat.Location = New Point(8, 10)
        DataGridView_ResepObat.Margin = New Padding(2)
        DataGridView_ResepObat.Name = "DataGridView_ResepObat"
        DataGridView_ResepObat.RowHeadersWidth = 62
        DataGridView_ResepObat.Size = New Size(416, 97)
        DataGridView_ResepObat.TabIndex = 1
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "Resep Obat"
        DataGridViewTextBoxColumn1.MinimumWidth = 8
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.Width = 150
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Obat yang diresepkan"
        DataGridViewTextBoxColumn2.MinimumWidth = 8
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.Width = 150
        ' 
        ' qty
        ' 
        qty.HeaderText = "+"
        qty.MinimumWidth = 8
        qty.Name = "qty"
        qty.Width = 150
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = SystemColors.MenuBar
        Panel10.Controls.Add(Panel13)
        Panel10.Controls.Add(Panel12)
        Panel10.Controls.Add(Panel11)
        Panel10.Controls.Add(Label13)
        Panel10.Controls.Add(Label12)
        Panel10.Controls.Add(Label11)
        Panel10.Controls.Add(ComboBox1)
        Panel10.Controls.Add(Label10)
        Panel10.Location = New Point(7, 33)
        Panel10.Margin = New Padding(2)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(445, 86)
        Panel10.TabIndex = 2
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.White
        Panel13.Controls.Add(Button4)
        Panel13.Controls.Add(TextBox6)
        Panel13.Location = New Point(159, 51)
        Panel13.Margin = New Padding(2)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(134, 25)
        Panel13.TabIndex = 14
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ControlLight
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 12F)
        Button4.Location = New Point(107, -1)
        Button4.Margin = New Padding(2)
        Button4.Name = "Button4"
        Button4.Size = New Size(27, 26)
        Button4.TabIndex = 11
        Button4.Text = "+"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.BorderStyle = BorderStyle.None
        TextBox6.Location = New Point(6, 5)
        TextBox6.Margin = New Padding(2)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(104, 16)
        TextBox6.TabIndex = 11
        TextBox6.Text = "10"
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.White
        Panel12.Controls.Add(Button3)
        Panel12.Controls.Add(TextBox5)
        Panel12.Location = New Point(301, 52)
        Panel12.Margin = New Padding(2)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(134, 25)
        Panel12.TabIndex = 14
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonShadow
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 12F)
        Button3.Location = New Point(107, -1)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(27, 26)
        Button3.TabIndex = 11
        Button3.Text = "+"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Location = New Point(6, 5)
        TextBox5.Margin = New Padding(2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(104, 16)
        TextBox5.TabIndex = 11
        TextBox5.Text = "Dosis"
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.White
        Panel11.Controls.Add(Button2)
        Panel11.Controls.Add(TextBox4)
        Panel11.Location = New Point(301, 27)
        Panel11.Margin = New Padding(2)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(134, 25)
        Panel11.TabIndex = 13
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonShadow
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.Location = New Point(107, -1)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(27, 26)
        Button2.TabIndex = 11
        Button2.Text = "+"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Location = New Point(6, 5)
        TextBox4.Margin = New Padding(2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(104, 16)
        TextBox4.TabIndex = 11
        TextBox4.Text = "Jumlah"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(301, 5)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(82, 15)
        Label13.TabIndex = 6
        Label13.Text = "Tndosin Meba"
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.White
        Label12.Location = New Point(159, 27)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(134, 23)
        Label12.TabIndex = 5
        Label12.Text = "Jumlah"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(11, 52)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(137, 15)
        Label11.TabIndex = 3
        Label11.Text = "Tindakan yang diberikan"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(11, 23)
        ComboBox1.Margin = New Padding(2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(129, 23)
        ComboBox1.TabIndex = 2
        ComboBox1.Text = "Tindakan Medis"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(11, 5)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(82, 15)
        Label10.TabIndex = 1
        Label10.Text = "Pilih Tindakan"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label9.Location = New Point(8, 11)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(114, 19)
        Label9.TabIndex = 14
        Label9.Text = "Tindakan Medis"
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = SystemColors.ControlDark
        Panel14.Controls.Add(Button6)
        Panel14.Controls.Add(Button5)
        Panel14.Location = New Point(-1, 508)
        Panel14.Margin = New Padding(2)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(888, 37)
        Panel14.TabIndex = 11
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.ControlLight
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.Black
        Button6.Location = New Point(407, 4)
        Button6.Margin = New Padding(2)
        Button6.Name = "Button6"
        Button6.Size = New Size(169, 29)
        Button6.TabIndex = 9
        Button6.Text = "BATAL"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.LimeGreen
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(216, 4)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(169, 29)
        Button5.TabIndex = 9
        Button5.Text = "SELESAI PEMERIKSAAN"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = Color.White
        Panel16.Controls.Add(TextBox7)
        Panel16.Location = New Point(164, 11)
        Panel16.Margin = New Padding(2)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(111, 28)
        Panel16.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.calendar_regular
        PictureBox1.Location = New Point(11, 9)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(31, 27)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' TextBox7
        ' 
        TextBox7.BorderStyle = BorderStyle.None
        TextBox7.ForeColor = SystemColors.ActiveBorder
        TextBox7.Location = New Point(6, 6)
        TextBox7.Margin = New Padding(2)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(90, 16)
        TextBox7.TabIndex = 0
        TextBox7.Text = "Cari Pasien"
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.SteelBlue
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.White
        Button7.Location = New Point(279, 11)
        Button7.Margin = New Padding(2)
        Button7.Name = "Button7"
        Button7.Size = New Size(86, 29)
        Button7.TabIndex = 10
        Button7.Text = "CARI PASIEN"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' FrmRekamMedis
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(890, 546)
        Controls.Add(Panel14)
        Controls.Add(Panel9)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "FrmRekamMedis"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rekam Medis Elektronik"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(DataGridView_CariPasien, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel15.ResumeLayout(False)
        CType(DataGridView_ResepObat, ComponentModel.ISupportInitialize).EndInit()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel14.ResumeLayout(False)
        Panel16.ResumeLayout(False)
        Panel16.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView_CariPasien As DataGridView
    Friend WithEvents NoRM As DataGridViewTextBoxColumn
    Friend WithEvents KeluhanAwal As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents DataGridView_ResepObat As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel16 As Panel
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

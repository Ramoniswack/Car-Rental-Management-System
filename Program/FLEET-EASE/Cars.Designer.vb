<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cars
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TxtAvaiable = New System.Windows.Forms.ComboBox()
        Me.TxtLastmaintenancedate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtRegNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.LblColor = New System.Windows.Forms.Label()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.BtnAddCustomer = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.Txtmodel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCarname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.Fleetease = New System.Windows.Forms.PictureBox()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnStats = New System.Windows.Forms.Button()
        Me.BtnCustomers = New System.Windows.Forms.Button()
        Me.BtnUsers = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtInitialKm = New System.Windows.Forms.TextBox()
        Me.FleeteaseDataSet = New FLEET_EASE.fleeteaseDataSet()
        Me.TblcarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblcarsTableAdapter = New FLEET_EASE.fleeteaseDataSetTableAdapters.tblcarsTableAdapter()
        Me.CarID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fleetease, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FleeteaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Location = New System.Drawing.Point(219, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1114, 684)
        Me.Panel1.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 27)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Cars"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel9.Controls.Add(Me.TxtAvaiable)
        Me.Panel9.Controls.Add(Me.TxtLastmaintenancedate)
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Controls.Add(Me.TxtInitialKm)
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Controls.Add(Me.TxtRegNum)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.BtnUpdate)
        Me.Panel9.Controls.Add(Me.LblColor)
        Me.Panel9.Controls.Add(Me.Dgv)
        Me.Panel9.Controls.Add(Me.BtnAddCustomer)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.TxtColor)
        Me.Panel9.Controls.Add(Me.Txtmodel)
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Controls.Add(Me.TxtCarname)
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.Location = New System.Drawing.Point(12, 39)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1091, 633)
        Me.Panel9.TabIndex = 1
        '
        'TxtAvaiable
        '
        Me.TxtAvaiable.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAvaiable.FormattingEnabled = True
        Me.TxtAvaiable.Items.AddRange(New Object() {"Yes", "No"})
        Me.TxtAvaiable.Location = New System.Drawing.Point(220, 254)
        Me.TxtAvaiable.Name = "TxtAvaiable"
        Me.TxtAvaiable.Size = New System.Drawing.Size(121, 31)
        Me.TxtAvaiable.TabIndex = 70
        '
        'TxtLastmaintenancedate
        '
        Me.TxtLastmaintenancedate.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLastmaintenancedate.Location = New System.Drawing.Point(361, 346)
        Me.TxtLastmaintenancedate.Name = "TxtLastmaintenancedate"
        Me.TxtLastmaintenancedate.Size = New System.Drawing.Size(200, 28)
        Me.TxtLastmaintenancedate.TabIndex = 69
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(85, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(270, 27)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Last Maintenance Date"
        '
        'TxtRegNum
        '
        Me.TxtRegNum.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegNum.Location = New System.Drawing.Point(220, 200)
        Me.TxtRegNum.Name = "TxtRegNum"
        Me.TxtRegNum.Size = New System.Drawing.Size(146, 36)
        Me.TxtRegNum.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(99, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 27)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "RegNo"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdate.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.BtnUpdate.Location = New System.Drawing.Point(818, 233)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(160, 127)
        Me.BtnUpdate.TabIndex = 63
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'LblColor
        '
        Me.LblColor.AutoSize = True
        Me.LblColor.BackColor = System.Drawing.Color.Transparent
        Me.LblColor.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.LblColor.Location = New System.Drawing.Point(85, 262)
        Me.LblColor.Name = "LblColor"
        Me.LblColor.Size = New System.Drawing.Size(120, 27)
        Me.LblColor.TabIndex = 62
        Me.LblColor.Text = "Available"
        '
        'Dgv
        '
        Me.Dgv.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv.ColumnHeadersHeight = 40
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CarID, Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4, Me.Column6, Me.Column7, Me.Column8})
        Me.Dgv.Location = New System.Drawing.Point(22, 380)
        Me.Dgv.Name = "Dgv"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.RowHeadersWidth = 51
        Me.Dgv.RowTemplate.Height = 24
        Me.Dgv.Size = New System.Drawing.Size(1042, 250)
        Me.Dgv.TabIndex = 60
        '
        'BtnAddCustomer
        '
        Me.BtnAddCustomer.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddCustomer.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.BtnAddCustomer.Location = New System.Drawing.Point(640, 233)
        Me.BtnAddCustomer.Name = "BtnAddCustomer"
        Me.BtnAddCustomer.Size = New System.Drawing.Size(160, 127)
        Me.BtnAddCustomer.TabIndex = 58
        Me.BtnAddCustomer.Text = "ADD CAR"
        Me.BtnAddCustomer.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(114, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 27)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Color"
        '
        'TxtColor
        '
        Me.TxtColor.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColor.Location = New System.Drawing.Point(220, 142)
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.Size = New System.Drawing.Size(722, 36)
        Me.TxtColor.TabIndex = 53
        '
        'Txtmodel
        '
        Me.Txtmodel.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmodel.Location = New System.Drawing.Point(220, 84)
        Me.Txtmodel.Name = "Txtmodel"
        Me.Txtmodel.Size = New System.Drawing.Size(722, 36)
        Me.Txtmodel.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(55, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 27)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Model Name"
        '
        'TxtCarname
        '
        Me.TxtCarname.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCarname.Location = New System.Drawing.Point(220, 27)
        Me.TxtCarname.Name = "TxtCarname"
        Me.TxtCarname.Size = New System.Drawing.Size(722, 36)
        Me.TxtCarname.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(85, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 27)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Car Name"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.LblUsername.Location = New System.Drawing.Point(85, 50)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(0, 27)
        Me.LblUsername.TabIndex = 57
        '
        'Fleetease
        '
        Me.Fleetease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Fleetease.Image = Global.FLEET_EASE.My.Resources.Resources.Fleet_Ease_black_removebg_preview
        Me.Fleetease.Location = New System.Drawing.Point(1, 10)
        Me.Fleetease.Name = "Fleetease"
        Me.Fleetease.Size = New System.Drawing.Size(100, 96)
        Me.Fleetease.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Fleetease.TabIndex = 56
        Me.Fleetease.TabStop = False
        '
        'BtnLogout
        '
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnLogout.Image = Global.FLEET_EASE.My.Resources.Resources.sublogout
        Me.BtnLogout.Location = New System.Drawing.Point(14, 629)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(206, 67)
        Me.BtnLogout.TabIndex = 152
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnHome
        '
        Me.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnHome.FlatAppearance.BorderSize = 0
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnHome.Image = Global.FLEET_EASE.My.Resources.Resources.Subhome
        Me.BtnHome.Location = New System.Drawing.Point(13, 170)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(207, 67)
        Me.BtnHome.TabIndex = 151
        Me.BtnHome.Text = "Home"
        Me.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Button1.Image = Global.FLEET_EASE.My.Resources.Resources.Car__1_1
        Me.Button1.Location = New System.Drawing.Point(14, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 74)
        Me.Button1.TabIndex = 150
        Me.Button1.Text = "Cars"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(1, 629)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(14, 67)
        Me.Panel7.TabIndex = 146
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 540)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(14, 67)
        Me.Panel6.TabIndex = 145
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 453)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(14, 67)
        Me.Panel5.TabIndex = 144
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 364)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(14, 67)
        Me.Panel4.TabIndex = 143
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 270)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(15, 74)
        Me.Panel3.TabIndex = 142
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(1, 170)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(14, 67)
        Me.Panel2.TabIndex = 141
        '
        'BtnStats
        '
        Me.BtnStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnStats.FlatAppearance.BorderSize = 0
        Me.BtnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStats.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStats.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnStats.Image = Global.FLEET_EASE.My.Resources.Resources.substats
        Me.BtnStats.Location = New System.Drawing.Point(14, 540)
        Me.BtnStats.Name = "BtnStats"
        Me.BtnStats.Size = New System.Drawing.Size(204, 67)
        Me.BtnStats.TabIndex = 149
        Me.BtnStats.Text = "Stats"
        Me.BtnStats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnStats.UseVisualStyleBackColor = True
        '
        'BtnCustomers
        '
        Me.BtnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCustomers.FlatAppearance.BorderSize = 0
        Me.BtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCustomers.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustomers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnCustomers.Image = Global.FLEET_EASE.My.Resources.Resources.subcustomers1
        Me.BtnCustomers.Location = New System.Drawing.Point(12, 453)
        Me.BtnCustomers.Name = "BtnCustomers"
        Me.BtnCustomers.Size = New System.Drawing.Size(207, 67)
        Me.BtnCustomers.TabIndex = 148
        Me.BtnCustomers.Text = "Customers"
        Me.BtnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCustomers.UseVisualStyleBackColor = True
        '
        'BtnUsers
        '
        Me.BtnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnUsers.FlatAppearance.BorderSize = 0
        Me.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsers.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnUsers.Image = Global.FLEET_EASE.My.Resources.Resources.Users1
        Me.BtnUsers.Location = New System.Drawing.Point(12, 364)
        Me.BtnUsers.Name = "BtnUsers"
        Me.BtnUsers.Size = New System.Drawing.Size(206, 67)
        Me.BtnUsers.TabIndex = 147
        Me.BtnUsers.Text = "Users"
        Me.BtnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnUsers.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(85, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 27)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Initial K.M"
        '
        'TxtInitialKm
        '
        Me.TxtInitialKm.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInitialKm.Location = New System.Drawing.Point(220, 295)
        Me.TxtInitialKm.Name = "TxtInitialKm"
        Me.TxtInitialKm.Size = New System.Drawing.Size(146, 36)
        Me.TxtInitialKm.TabIndex = 67
        '
        'FleeteaseDataSet
        '
        Me.FleeteaseDataSet.DataSetName = "fleeteaseDataSet"
        Me.FleeteaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblcarsBindingSource
        '
        Me.TblcarsBindingSource.DataMember = "tblcars"
        Me.TblcarsBindingSource.DataSource = Me.FleeteaseDataSet
        '
        'TblcarsTableAdapter
        '
        Me.TblcarsTableAdapter.ClearBeforeFill = True
        '
        'CarID
        '
        Me.CarID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CarID.DataPropertyName = "CarID"
        Me.CarID.HeaderText = "CarID"
        Me.CarID.MinimumWidth = 6
        Me.CarID.Name = "CarID"
        Me.CarID.ReadOnly = True
        Me.CarID.Width = 75
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Car Name"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Model"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Color"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "RegNO"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column4.HeaderText = "Available"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 102
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "TotalKm"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column7.HeaderText = "LastMaintenanceDate"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 186
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column8.HeaderText = "LastMaintenanceKilometer"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 218
        '
        'Cars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1332, 725)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Fleetease)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.BtnUsers)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.BtnCustomers)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BtnStats)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Cars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cars"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fleetease, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FleeteaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents BtnAddCustomer As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents Txtmodel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCarname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents Fleetease As PictureBox
    Friend WithEvents LblColor As Label
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents TxtRegNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnStats As Button
    Friend WithEvents BtnCustomers As Button
    Friend WithEvents BtnUsers As Button
    Friend WithEvents TxtLastmaintenancedate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtAvaiable As ComboBox
    Friend WithEvents TxtInitialKm As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FleeteaseDataSet As fleeteaseDataSet
    Friend WithEvents TblcarsBindingSource As BindingSource
    Friend WithEvents TblcarsTableAdapter As fleeteaseDataSetTableAdapters.tblcarsTableAdapter
    Friend WithEvents CarID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homee
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtAdmin = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Dgv1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnStatistics = New System.Windows.Forms.Button()
        Me.BtnCustomers = New System.Windows.Forms.Button()
        Me.BtnUsers = New System.Windows.Forms.Button()
        Me.BtnCars = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.Fleetease = New System.Windows.Forms.PictureBox()
        Me.FleeteaseDataSet = New FLEET_EASE.fleeteaseDataSet()
        Me.TblcarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblcarsTableAdapter = New FLEET_EASE.fleeteaseDataSetTableAdapters.tblcarsTableAdapter()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fleetease, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FleeteaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtAdmin
        '
        Me.TxtAdmin.AutoSize = True
        Me.TxtAdmin.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TxtAdmin.Location = New System.Drawing.Point(84, 60)
        Me.TxtAdmin.Name = "TxtAdmin"
        Me.TxtAdmin.Size = New System.Drawing.Size(86, 27)
        Me.TxtAdmin.TabIndex = 21
        Me.TxtAdmin.Text = "Admin"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Location = New System.Drawing.Point(218, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1114, 684)
        Me.Panel1.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 27)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Rented Cars"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Dgv1)
        Me.Panel9.Location = New System.Drawing.Point(11, 383)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1091, 289)
        Me.Panel9.TabIndex = 1
        '
        'Dgv1
        '
        Me.Dgv1.AllowUserToAddRows = False
        Me.Dgv1.AllowUserToDeleteRows = False
        Me.Dgv1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv1.ColumnHeadersHeight = 40
        Me.Dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column8, Me.DataGridViewTextBoxColumn3, Me.Column9, Me.DataGridViewTextBoxColumn4, Me.Column4, Me.Column6, Me.Column7})
        Me.Dgv1.Location = New System.Drawing.Point(19, 19)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv1.RowHeadersVisible = False
        Me.Dgv1.RowHeadersWidth = 51
        Me.Dgv1.RowTemplate.Height = 24
        Me.Dgv1.Size = New System.Drawing.Size(1053, 250)
        Me.Dgv1.TabIndex = 64
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "CusID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "CustomerName"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "CarID"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "CarName"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "PickupLocation"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "date"
        Me.Column4.HeaderText = "RentDate"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "ReturnDate"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Charges"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 27)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Available Cars"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Dgv)
        Me.Panel8.Location = New System.Drawing.Point(11, 48)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1091, 289)
        Me.Panel8.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 165)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(14, 67)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 265)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(14, 67)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(-1, 359)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(14, 67)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(-1, 448)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(14, 67)
        Me.Panel5.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(-1, 535)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(14, 67)
        Me.Panel6.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(0, 624)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(14, 67)
        Me.Panel7.TabIndex = 5
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox6.Image = Global.FLEET_EASE.My.Resources.Resources.Logout
        Me.PictureBox6.Location = New System.Drawing.Point(24, 639)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(44, 52)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 33
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox5.Image = Global.FLEET_EASE.My.Resources.Resources.Statistics
        Me.PictureBox5.Location = New System.Drawing.Point(24, 550)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(44, 52)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 32
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox4.Image = Global.FLEET_EASE.My.Resources.Resources.Users
        Me.PictureBox4.Location = New System.Drawing.Point(24, 374)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(44, 52)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 31
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = Global.FLEET_EASE.My.Resources.Resources.employees
        Me.PictureBox3.Location = New System.Drawing.Point(24, 448)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(44, 69)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = Global.FLEET_EASE.My.Resources.Resources.Car
        Me.PictureBox2.Location = New System.Drawing.Point(12, 268)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'BtnLogout
        '
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnLogout.Image = Global.FLEET_EASE.My.Resources.Resources.Homee
        Me.BtnLogout.Location = New System.Drawing.Point(60, 639)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(152, 52)
        Me.BtnLogout.TabIndex = 28
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnStatistics
        '
        Me.BtnStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnStatistics.FlatAppearance.BorderSize = 0
        Me.BtnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatistics.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatistics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnStatistics.Image = Global.FLEET_EASE.My.Resources.Resources.Homee
        Me.BtnStatistics.Location = New System.Drawing.Point(60, 559)
        Me.BtnStatistics.Name = "BtnStatistics"
        Me.BtnStatistics.Size = New System.Drawing.Size(152, 52)
        Me.BtnStatistics.TabIndex = 27
        Me.BtnStatistics.Text = "Statistics"
        Me.BtnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnStatistics.UseVisualStyleBackColor = True
        '
        'BtnCustomers
        '
        Me.BtnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCustomers.FlatAppearance.BorderSize = 0
        Me.BtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCustomers.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustomers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnCustomers.Image = Global.FLEET_EASE.My.Resources.Resources.Homee
        Me.BtnCustomers.Location = New System.Drawing.Point(60, 463)
        Me.BtnCustomers.Name = "BtnCustomers"
        Me.BtnCustomers.Size = New System.Drawing.Size(152, 52)
        Me.BtnCustomers.TabIndex = 26
        Me.BtnCustomers.Text = "Customers"
        Me.BtnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnCustomers.UseVisualStyleBackColor = True
        '
        'BtnUsers
        '
        Me.BtnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnUsers.FlatAppearance.BorderSize = 0
        Me.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsers.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnUsers.Image = Global.FLEET_EASE.My.Resources.Resources.Homee
        Me.BtnUsers.Location = New System.Drawing.Point(74, 381)
        Me.BtnUsers.Name = "BtnUsers"
        Me.BtnUsers.Size = New System.Drawing.Size(126, 52)
        Me.BtnUsers.TabIndex = 25
        Me.BtnUsers.Text = "Users"
        Me.BtnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnUsers.UseVisualStyleBackColor = True
        '
        'BtnCars
        '
        Me.BtnCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCars.FlatAppearance.BorderSize = 0
        Me.BtnCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCars.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCars.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnCars.Image = Global.FLEET_EASE.My.Resources.Resources.Homee
        Me.BtnCars.Location = New System.Drawing.Point(74, 292)
        Me.BtnCars.Name = "BtnCars"
        Me.BtnCars.Size = New System.Drawing.Size(126, 52)
        Me.BtnCars.TabIndex = 24
        Me.BtnCars.Text = "Cars"
        Me.BtnCars.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnCars.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.FLEET_EASE.My.Resources.Resources.Homee
        Me.PictureBox1.Location = New System.Drawing.Point(24, 180)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'BtnHome
        '
        Me.BtnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.BtnHome.BackgroundImage = Global.FLEET_EASE.My.Resources.Resources.button1black1
        Me.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnHome.FlatAppearance.BorderSize = 0
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnHome.Location = New System.Drawing.Point(49, 163)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(170, 97)
        Me.BtnHome.TabIndex = 22
        Me.BtnHome.Text = "Home"
        Me.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnHome.UseVisualStyleBackColor = False
        '
        'Fleetease
        '
        Me.Fleetease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Fleetease.Image = Global.FLEET_EASE.My.Resources.Resources.Fleet_Ease_black_removebg_preview
        Me.Fleetease.Location = New System.Drawing.Point(0, 20)
        Me.Fleetease.Name = "Fleetease"
        Me.Fleetease.Size = New System.Drawing.Size(100, 96)
        Me.Fleetease.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Fleetease.TabIndex = 20
        Me.Fleetease.TabStop = False
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
        'Dgv
        '
        Me.Dgv.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv.ColumnHeadersHeight = 40
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.DataGridViewTextBoxColumn5})
        Me.Dgv.Location = New System.Drawing.Point(19, 19)
        Me.Dgv.Name = "Dgv"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.RowHeadersWidth = 51
        Me.Dgv.RowTemplate.Height = 24
        Me.Dgv.Size = New System.Drawing.Size(1053, 250)
        Me.Dgv.TabIndex = 61
        '
        'Column5
        '
        Me.Column5.HeaderText = "#"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
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
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'Homee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1332, 725)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnStatistics)
        Me.Controls.Add(Me.BtnCustomers)
        Me.Controls.Add(Me.BtnUsers)
        Me.Controls.Add(Me.BtnCars)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.TxtAdmin)
        Me.Controls.Add(Me.Fleetease)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Homee"
        Me.Text = "Homee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fleetease, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FleeteaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnStatistics As Button
    Friend WithEvents BtnCustomers As Button
    Friend WithEvents BtnUsers As Button
    Friend WithEvents BtnCars As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnHome As Button
    Friend WithEvents TxtAdmin As Label
    Friend WithEvents Fleetease As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents FleeteaseDataSet As fleeteaseDataSet
    Friend WithEvents TblcarsBindingSource As BindingSource
    Friend WithEvents TblcarsTableAdapter As fleeteaseDataSetTableAdapters.tblcarsTableAdapter
    Friend WithEvents Dgv1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class

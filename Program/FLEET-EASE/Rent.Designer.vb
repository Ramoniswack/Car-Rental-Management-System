<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rent
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
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCusid = New System.Windows.Forms.TextBox()
        Me.TxtReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.TxtRentDate = New System.Windows.Forms.DateTimePicker()
        Me.Txtcusname = New System.Windows.Forms.TextBox()
        Me.TxtRegNum = New System.Windows.Forms.TextBox()
        Me.TxtCharges = New System.Windows.Forms.TextBox()
        Me.TxtPickupfrom = New System.Windows.Forms.TextBox()
        Me.BtnRent = New System.Windows.Forms.Button()
        Me.Fleetease = New System.Windows.Forms.PictureBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.BtnCustomers = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnCheckout = New System.Windows.Forms.Button()
        Me.BtnSettings = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCheckoutOdometer = New System.Windows.Forms.NumericUpDown()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.Fleetease, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCheckoutOdometer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.LblUsername.Location = New System.Drawing.Point(85, 50)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(0, 27)
        Me.LblUsername.TabIndex = 66
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Location = New System.Drawing.Point(219, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1114, 684)
        Me.Panel1.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 27)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Rent"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel8.Controls.Add(Me.TxtCheckoutOdometer)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Controls.Add(Me.TxtCusid)
        Me.Panel8.Controls.Add(Me.TxtReturnDate)
        Me.Panel8.Controls.Add(Me.TxtRentDate)
        Me.Panel8.Controls.Add(Me.Txtcusname)
        Me.Panel8.Controls.Add(Me.TxtRegNum)
        Me.Panel8.Controls.Add(Me.TxtCharges)
        Me.Panel8.Controls.Add(Me.TxtPickupfrom)
        Me.Panel8.Controls.Add(Me.BtnRent)
        Me.Panel8.Location = New System.Drawing.Point(10, 48)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1091, 620)
        Me.Panel8.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(139, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 22)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "RentDate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(139, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 22)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Charges"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(110, 233)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 22)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "PickUp From"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(122, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 22)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "ReturnDate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(75, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 22)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(111, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 22)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(111, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 22)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Reg Number"
        '
        'TxtCusid
        '
        Me.TxtCusid.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCusid.Location = New System.Drawing.Point(251, 114)
        Me.TxtCusid.Name = "TxtCusid"
        Me.TxtCusid.Size = New System.Drawing.Size(722, 36)
        Me.TxtCusid.TabIndex = 76
        '
        'TxtReturnDate
        '
        Me.TxtReturnDate.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReturnDate.Location = New System.Drawing.Point(252, 341)
        Me.TxtReturnDate.Name = "TxtReturnDate"
        Me.TxtReturnDate.Size = New System.Drawing.Size(310, 28)
        Me.TxtReturnDate.TabIndex = 75
        '
        'TxtRentDate
        '
        Me.TxtRentDate.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRentDate.Location = New System.Drawing.Point(252, 286)
        Me.TxtRentDate.Name = "TxtRentDate"
        Me.TxtRentDate.Size = New System.Drawing.Size(309, 28)
        Me.TxtRentDate.TabIndex = 74
        Me.TxtRentDate.Value = New Date(2024, 6, 8, 0, 0, 0, 0)
        '
        'Txtcusname
        '
        Me.Txtcusname.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcusname.Location = New System.Drawing.Point(252, 163)
        Me.Txtcusname.Name = "Txtcusname"
        Me.Txtcusname.Size = New System.Drawing.Size(722, 36)
        Me.Txtcusname.TabIndex = 72
        '
        'TxtRegNum
        '
        Me.TxtRegNum.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegNum.Location = New System.Drawing.Point(251, 58)
        Me.TxtRegNum.Name = "TxtRegNum"
        Me.TxtRegNum.Size = New System.Drawing.Size(722, 36)
        Me.TxtRegNum.TabIndex = 71
        '
        'TxtCharges
        '
        Me.TxtCharges.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCharges.Location = New System.Drawing.Point(252, 388)
        Me.TxtCharges.Name = "TxtCharges"
        Me.TxtCharges.Size = New System.Drawing.Size(123, 36)
        Me.TxtCharges.TabIndex = 70
        '
        'TxtPickupfrom
        '
        Me.TxtPickupfrom.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPickupfrom.Location = New System.Drawing.Point(251, 225)
        Me.TxtPickupfrom.Name = "TxtPickupfrom"
        Me.TxtPickupfrom.Size = New System.Drawing.Size(722, 36)
        Me.TxtPickupfrom.TabIndex = 64
        '
        'BtnRent
        '
        Me.BtnRent.BackColor = System.Drawing.Color.Transparent
        Me.BtnRent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRent.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.BtnRent.Location = New System.Drawing.Point(814, 448)
        Me.BtnRent.Name = "BtnRent"
        Me.BtnRent.Size = New System.Drawing.Size(160, 80)
        Me.BtnRent.TabIndex = 62
        Me.BtnRent.Text = "RENT VEHICLE"
        Me.BtnRent.UseVisualStyleBackColor = False
        '
        'Fleetease
        '
        Me.Fleetease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Fleetease.Image = Global.FLEET_EASE.My.Resources.Resources.Fleet_Ease_black_removebg_preview
        Me.Fleetease.Location = New System.Drawing.Point(1, 10)
        Me.Fleetease.Name = "Fleetease"
        Me.Fleetease.Size = New System.Drawing.Size(100, 96)
        Me.Fleetease.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Fleetease.TabIndex = 65
        Me.Fleetease.TabStop = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(-1, 363)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(10, 63)
        Me.Panel10.TabIndex = 154
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnCancel.Image = Global.FLEET_EASE.My.Resources.Resources.subrent1
        Me.BtnCancel.Location = New System.Drawing.Point(11, 363)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(208, 63)
        Me.BtnCancel.TabIndex = 160
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnHome
        '
        Me.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnHome.FlatAppearance.BorderSize = 0
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnHome.Image = Global.FLEET_EASE.My.Resources.Resources.Subhome
        Me.BtnHome.Location = New System.Drawing.Point(7, 113)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(211, 60)
        Me.BtnHome.TabIndex = 159
        Me.BtnHome.Text = "Home"
        Me.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'BtnCustomers
        '
        Me.BtnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCustomers.FlatAppearance.BorderSize = 0
        Me.BtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCustomers.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustomers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnCustomers.Image = Global.FLEET_EASE.My.Resources.Resources.subcustomers
        Me.BtnCustomers.Location = New System.Drawing.Point(10, 195)
        Me.BtnCustomers.Name = "BtnCustomers"
        Me.BtnCustomers.Size = New System.Drawing.Size(209, 60)
        Me.BtnCustomers.TabIndex = 152
        Me.BtnCustomers.Text = "Customers"
        Me.BtnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCustomers.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(-2, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 63)
        Me.Panel2.TabIndex = 147
        '
        'BtnLogout
        '
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnLogout.Image = Global.FLEET_EASE.My.Resources.Resources.sublogout
        Me.BtnLogout.Location = New System.Drawing.Point(8, 648)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(209, 63)
        Me.BtnLogout.TabIndex = 150
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnCheckout
        '
        Me.BtnCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCheckout.FlatAppearance.BorderSize = 0
        Me.BtnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCheckout.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCheckout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnCheckout.Image = Global.FLEET_EASE.My.Resources.Resources.subcheck
        Me.BtnCheckout.Location = New System.Drawing.Point(8, 449)
        Me.BtnCheckout.Name = "BtnCheckout"
        Me.BtnCheckout.Size = New System.Drawing.Size(209, 63)
        Me.BtnCheckout.TabIndex = 149
        Me.BtnCheckout.Text = "CheckOut"
        Me.BtnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCheckout.UseVisualStyleBackColor = True
        '
        'BtnSettings
        '
        Me.BtnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSettings.FlatAppearance.BorderSize = 0
        Me.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSettings.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnSettings.Image = Global.FLEET_EASE.My.Resources.Resources.Settings1
        Me.BtnSettings.Location = New System.Drawing.Point(8, 551)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(209, 59)
        Me.BtnSettings.TabIndex = 148
        Me.BtnSettings.Text = "Settings"
        Me.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSettings.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(-2, 647)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 63)
        Me.Panel5.TabIndex = 158
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(-2, 549)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 63)
        Me.Panel4.TabIndex = 156
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(-2, 448)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 63)
        Me.Panel3.TabIndex = 157
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(-1, 271)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 63)
        Me.Panel6.TabIndex = 153
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(-1, 192)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(10, 56)
        Me.Panel7.TabIndex = 155
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Button1.Image = Global.FLEET_EASE.My.Resources.Resources.subrent1
        Me.Button1.Location = New System.Drawing.Point(10, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(208, 63)
        Me.Button1.TabIndex = 151
        Me.Button1.Text = "Rent"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(66, 462)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 22)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Check Odometer"
        '
        'TxtCheckoutOdometer
        '
        Me.TxtCheckoutOdometer.Location = New System.Drawing.Point(252, 462)
        Me.TxtCheckoutOdometer.Name = "TxtCheckoutOdometer"
        Me.TxtCheckoutOdometer.Size = New System.Drawing.Size(120, 22)
        Me.TxtCheckoutOdometer.TabIndex = 86
        '
        'Rent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1332, 725)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.BtnCustomers)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnCheckout)
        Me.Controls.Add(Me.BtnSettings)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.Fleetease)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Rent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.Fleetease, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCheckoutOdometer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblUsername As Label
    Friend WithEvents Fleetease As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents BtnRent As Button
    Friend WithEvents TxtPickupfrom As TextBox
    Friend WithEvents Txtcusname As TextBox
    Friend WithEvents TxtRegNum As TextBox
    Friend WithEvents TxtCharges As TextBox
    Friend WithEvents TxtRentDate As DateTimePicker
    Friend WithEvents TxtReturnDate As DateTimePicker
    Friend WithEvents TxtCusid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents BtnCustomers As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnCheckout As Button
    Friend WithEvents BtnSettings As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCheckoutOdometer As NumericUpDown
End Class

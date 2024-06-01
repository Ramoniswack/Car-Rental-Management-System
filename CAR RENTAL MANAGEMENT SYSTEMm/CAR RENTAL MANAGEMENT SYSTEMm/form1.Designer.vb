<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.PanelLanding = New System.Windows.Forms.Panel()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnGetStarted = New System.Windows.Forms.Button()
        Me.TimerLoadLanding = New System.Windows.Forms.Timer(Me.components)
        Me.PanelLanding.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLanding
        '
        Me.PanelLanding.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelLanding.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.CAR_RENTAL_LANDING
        Me.PanelLanding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelLanding.Controls.Add(Me.BtnExit)
        Me.PanelLanding.Controls.Add(Me.BtnGetStarted)
        Me.PanelLanding.Location = New System.Drawing.Point(0, 0)
        Me.PanelLanding.Name = "PanelLanding"
        Me.PanelLanding.Size = New System.Drawing.Size(1025, 577)
        Me.PanelLanding.TabIndex = 0
        '
        'BtnExit
        '
        Me.BtnExit.AllowDrop = True
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.GET_STARTED_BUTTON
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(843, 12)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(169, 74)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnGetStarted
        '
        Me.BtnGetStarted.AllowDrop = True
        Me.BtnGetStarted.BackColor = System.Drawing.Color.Transparent
        Me.BtnGetStarted.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.GET_STARTED_BUTTON
        Me.BtnGetStarted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGetStarted.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGetStarted.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnGetStarted.FlatAppearance.BorderSize = 0
        Me.BtnGetStarted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGetStarted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetStarted.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGetStarted.ForeColor = System.Drawing.Color.White
        Me.BtnGetStarted.Location = New System.Drawing.Point(703, 298)
        Me.BtnGetStarted.Name = "BtnGetStarted"
        Me.BtnGetStarted.Size = New System.Drawing.Size(290, 191)
        Me.BtnGetStarted.TabIndex = 1
        Me.BtnGetStarted.Text = "GET STARTED"
        Me.BtnGetStarted.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.PanelLanding)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelLanding.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLanding As Panel
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnGetStarted As Button
    Friend WithEvents TimerLoadLanding As Timer
End Class

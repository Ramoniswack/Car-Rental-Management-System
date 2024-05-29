<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Landingg
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btngetstarted = New System.Windows.Forms.Button()
        Me.btnExitLanding = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEM1.My.Resources.Resources.CAR_RENTAL_LANDING
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnExitLanding)
        Me.Panel1.Controls.Add(Me.btngetstarted)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(807, 459)
        Me.Panel1.TabIndex = 0
        '
        'btngetstarted
        '
        Me.btngetstarted.AllowDrop = True
        Me.btngetstarted.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btngetstarted.BackColor = System.Drawing.Color.Transparent
        Me.btngetstarted.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEM1.My.Resources.Resources.GET_STARTED_BUTTON
        Me.btngetstarted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btngetstarted.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngetstarted.FlatAppearance.BorderSize = 0
        Me.btngetstarted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btngetstarted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btngetstarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngetstarted.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngetstarted.ForeColor = System.Drawing.Color.Transparent
        Me.btngetstarted.Location = New System.Drawing.Point(448, 197)
        Me.btngetstarted.Margin = New System.Windows.Forms.Padding(3, 2, 0, 2)
        Me.btngetstarted.MinimumSize = New System.Drawing.Size(5, 8)
        Me.btngetstarted.Name = "btngetstarted"
        Me.btngetstarted.Size = New System.Drawing.Size(200, 200)
        Me.btngetstarted.TabIndex = 1
        Me.btngetstarted.Text = "GET STARTED"
        Me.btngetstarted.UseVisualStyleBackColor = False
        '
        'btnExitLanding
        '
        Me.btnExitLanding.AllowDrop = True
        Me.btnExitLanding.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExitLanding.BackColor = System.Drawing.Color.Transparent
        Me.btnExitLanding.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEM1.My.Resources.Resources.GET_STARTED_BUTTON
        Me.btnExitLanding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExitLanding.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExitLanding.FlatAppearance.BorderSize = 0
        Me.btnExitLanding.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExitLanding.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExitLanding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitLanding.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitLanding.ForeColor = System.Drawing.Color.Transparent
        Me.btnExitLanding.Location = New System.Drawing.Point(688, -34)
        Me.btnExitLanding.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExitLanding.Name = "btnExitLanding"
        Me.btnExitLanding.Size = New System.Drawing.Size(101, 150)
        Me.btnExitLanding.TabIndex = 3
        Me.btnExitLanding.Text = "Exit"
        Me.btnExitLanding.UseVisualStyleBackColor = False
        '
        'Landingg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Landingg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Landingg"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btngetstarted As Button
    Friend WithEvents btnExitLanding As Button
End Class

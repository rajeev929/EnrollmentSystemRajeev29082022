<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SystemUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator
        Me.EditUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.FreshmenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.SophomoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.JuniorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.SeniorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.LateEnrolleesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.EnrolledStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.DroppedStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.ALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StudentRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HistoryLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.White
        Me.MenuStrip.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemToolStripMenuItem, Me.SystemUsersToolStripMenuItem, Me.TransactToolStripMenuItem, Me.RecordToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(931, 34)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(86, 30)
        Me.SystemToolStripMenuItem.Text = "System"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 30)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 30)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SystemUsersToolStripMenuItem
        '
        Me.SystemUsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageToolStripMenuItem, Me.ToolStripSeparator13, Me.EditUsersToolStripMenuItem})
        Me.SystemUsersToolStripMenuItem.Name = "SystemUsersToolStripMenuItem"
        Me.SystemUsersToolStripMenuItem.Size = New System.Drawing.Size(137, 30)
        Me.SystemUsersToolStripMenuItem.Text = "System Users"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(202, 30)
        Me.ManageToolStripMenuItem.Text = "Administrator"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(199, 6)
        '
        'EditUsersToolStripMenuItem
        '
        Me.EditUsersToolStripMenuItem.Name = "EditUsersToolStripMenuItem"
        Me.EditUsersToolStripMenuItem.Size = New System.Drawing.Size(202, 30)
        Me.EditUsersToolStripMenuItem.Text = "Committee"
        '
        'TransactToolStripMenuItem
        '
        Me.TransactToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageListToolStripMenuItem, Me.ToolStripSeparator1, Me.FreshmenToolStripMenuItem, Me.ToolStripSeparator4, Me.SophomoreToolStripMenuItem, Me.ToolStripSeparator5, Me.JuniorsToolStripMenuItem, Me.ToolStripSeparator7, Me.SeniorsToolStripMenuItem, Me.ToolStripSeparator8, Me.LateEnrolleesToolStripMenuItem, Me.ToolStripSeparator9, Me.EnrolledStudentsToolStripMenuItem, Me.ToolStripSeparator10, Me.DroppedStudentsToolStripMenuItem, Me.ToolStripSeparator11, Me.ALLToolStripMenuItem})
        Me.TransactToolStripMenuItem.Name = "TransactToolStripMenuItem"
        Me.TransactToolStripMenuItem.Size = New System.Drawing.Size(99, 30)
        Me.TransactToolStripMenuItem.Text = "Students"
        '
        'ManageListToolStripMenuItem
        '
        Me.ManageListToolStripMenuItem.Name = "ManageListToolStripMenuItem"
        Me.ManageListToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.ManageListToolStripMenuItem.ShowShortcutKeys = False
        Me.ManageListToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.ManageListToolStripMenuItem.Text = "Current Enrolled Students"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(288, 6)
        '
        'FreshmenToolStripMenuItem
        '
        Me.FreshmenToolStripMenuItem.Name = "FreshmenToolStripMenuItem"
        Me.FreshmenToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.FreshmenToolStripMenuItem.Text = "Freshmen"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(288, 6)
        '
        'SophomoreToolStripMenuItem
        '
        Me.SophomoreToolStripMenuItem.Name = "SophomoreToolStripMenuItem"
        Me.SophomoreToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.SophomoreToolStripMenuItem.Text = "Sophomore"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(288, 6)
        '
        'JuniorsToolStripMenuItem
        '
        Me.JuniorsToolStripMenuItem.Name = "JuniorsToolStripMenuItem"
        Me.JuniorsToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.JuniorsToolStripMenuItem.Text = "Juniors"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(288, 6)
        '
        'SeniorsToolStripMenuItem
        '
        Me.SeniorsToolStripMenuItem.Name = "SeniorsToolStripMenuItem"
        Me.SeniorsToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.SeniorsToolStripMenuItem.Text = "Seniors"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(288, 6)
        '
        'LateEnrolleesToolStripMenuItem
        '
        Me.LateEnrolleesToolStripMenuItem.Name = "LateEnrolleesToolStripMenuItem"
        Me.LateEnrolleesToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.LateEnrolleesToolStripMenuItem.Text = "Late Enrollees"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(288, 6)
        '
        'EnrolledStudentsToolStripMenuItem
        '
        Me.EnrolledStudentsToolStripMenuItem.Name = "EnrolledStudentsToolStripMenuItem"
        Me.EnrolledStudentsToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.EnrolledStudentsToolStripMenuItem.Text = "Enrolled Students"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(288, 6)
        '
        'DroppedStudentsToolStripMenuItem
        '
        Me.DroppedStudentsToolStripMenuItem.Name = "DroppedStudentsToolStripMenuItem"
        Me.DroppedStudentsToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.DroppedStudentsToolStripMenuItem.Text = "Dropped Students"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(288, 6)
        '
        'ALLToolStripMenuItem
        '
        Me.ALLToolStripMenuItem.Name = "ALLToolStripMenuItem"
        Me.ALLToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.ALLToolStripMenuItem.Text = "All"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionsToolStripMenuItem, Me.ToolStripSeparator6, Me.StudentListToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(89, 30)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(213, 30)
        Me.TransactionsToolStripMenuItem.Text = "Late Enrollees"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(210, 6)
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(213, 30)
        Me.StudentListToolStripMenuItem.Text = "Student Report"
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.White
        Me.ToolStrip.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 34)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(931, 26)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(186, 23)
        Me.ToolStripLabel1.Text = "Today's Date and Time:"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(0, 23)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(178, 23)
        Me.ToolStripLabel3.Text = "00/00/0000 00:00:00"
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.White
        Me.StatusStrip.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 521)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(931, 23)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(46, 18)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'RecordToolStripMenuItem
        '
        Me.RecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentRecordsToolStripMenuItem, Me.HistoryLogToolStripMenuItem})
        Me.RecordToolStripMenuItem.Name = "RecordToolStripMenuItem"
        Me.RecordToolStripMenuItem.Size = New System.Drawing.Size(83, 30)
        Me.RecordToolStripMenuItem.Text = "Record"
        '
        'StudentRecordsToolStripMenuItem
        '
        Me.StudentRecordsToolStripMenuItem.Name = "StudentRecordsToolStripMenuItem"
        Me.StudentRecordsToolStripMenuItem.Size = New System.Drawing.Size(223, 30)
        Me.StudentRecordsToolStripMenuItem.Text = "Student Records"
        '
        'HistoryLogToolStripMenuItem
        '
        Me.HistoryLogToolStripMenuItem.Name = "HistoryLogToolStripMenuItem"
        Me.HistoryLogToolStripMenuItem.Size = New System.Drawing.Size(223, 30)
        Me.HistoryLogToolStripMenuItem.Text = "History Log"
        '
        'mdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(931, 544)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdiMain"
        Me.Text = "Administrsator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents SystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FreshmenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SophomoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JuniorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeniorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ALLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LateEnrolleesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EnrolledStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DroppedStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

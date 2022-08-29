<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommittee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommittee))
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.CommitteeDataSet = New ES.CommitteeDataSet
        Me.CommitteeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommitteeTableAdapter = New ES.CommitteeDataSetTableAdapters.CommitteeTableAdapter
        Me.TableAdapterManager = New ES.CommitteeDataSetTableAdapters.TableAdapterManager
        Me.CommitteeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.CommitteeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CommitteeDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsernameTextBox = New System.Windows.Forms.TextBox
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        UsernameLabel = New System.Windows.Forms.Label
        PasswordLabel = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.CommitteeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommitteeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommitteeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CommitteeBindingNavigator.SuspendLayout()
        CType(Me.CommitteeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(491, 508)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.CommitteeDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(11, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(468, 300)
        Me.Panel2.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(UsernameLabel)
        Me.Panel1.Controls.Add(Me.UsernameTextBox)
        Me.Panel1.Controls.Add(PasswordLabel)
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(11, 379)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 116)
        Me.Panel1.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnNew)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Location = New System.Drawing.Point(11, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(468, 48)
        Me.Panel3.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(99, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(180, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(378, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 30)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(13, 8)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(80, 30)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "Add"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(266, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'CommitteeDataSet
        '
        Me.CommitteeDataSet.DataSetName = "CommitteeDataSet"
        Me.CommitteeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CommitteeBindingSource
        '
        Me.CommitteeBindingSource.DataMember = "Committee"
        Me.CommitteeBindingSource.DataSource = Me.CommitteeDataSet
        '
        'CommitteeTableAdapter
        '
        Me.CommitteeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CommitteeTableAdapter = Me.CommitteeTableAdapter
        Me.TableAdapterManager.UpdateOrder = ES.CommitteeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CommitteeBindingNavigator
        '
        Me.CommitteeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CommitteeBindingNavigator.BindingSource = Me.CommitteeBindingSource
        Me.CommitteeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CommitteeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CommitteeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CommitteeBindingNavigatorSaveItem})
        Me.CommitteeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CommitteeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CommitteeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CommitteeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CommitteeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CommitteeBindingNavigator.Name = "CommitteeBindingNavigator"
        Me.CommitteeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CommitteeBindingNavigator.Size = New System.Drawing.Size(514, 25)
        Me.CommitteeBindingNavigator.TabIndex = 15
        Me.CommitteeBindingNavigator.Text = "BindingNavigator1"
        Me.CommitteeBindingNavigator.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CommitteeBindingNavigatorSaveItem
        '
        Me.CommitteeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CommitteeBindingNavigatorSaveItem.Image = CType(resources.GetObject("CommitteeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CommitteeBindingNavigatorSaveItem.Name = "CommitteeBindingNavigatorSaveItem"
        Me.CommitteeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CommitteeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CommitteeDataGridView
        '
        Me.CommitteeDataGridView.AutoGenerateColumns = False
        Me.CommitteeDataGridView.AutoSizeColumnsMode = Global.ES.My.MySettings.Default.auto1
        Me.CommitteeDataGridView.AutoSizeRowsMode = Global.ES.My.MySettings.Default.row2
        Me.CommitteeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CommitteeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.CommitteeDataGridView.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.ES.My.MySettings.Default, "font4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CommitteeDataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeRowsMode", Global.ES.My.MySettings.Default, "row2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CommitteeDataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeColumnsMode", Global.ES.My.MySettings.Default, "auto1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CommitteeDataGridView.DataSource = Me.CommitteeBindingSource
        Me.CommitteeDataGridView.Font = Global.ES.My.MySettings.Default.font4
        Me.CommitteeDataGridView.Location = New System.Drawing.Point(13, 13)
        Me.CommitteeDataGridView.Name = "CommitteeDataGridView"
        Me.CommitteeDataGridView.ReadOnly = True
        Me.CommitteeDataGridView.Size = New System.Drawing.Size(440, 273)
        Me.CommitteeDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 138
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 130
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(7, 20)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(134, 33)
        UsernameLabel.TabIndex = 2
        UsernameLabel.Text = "Username:"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommitteeBindingSource, "Username", True))
        Me.UsernameTextBox.Enabled = False
        Me.UsernameTextBox.Location = New System.Drawing.Point(147, 17)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(306, 40)
        Me.UsernameTextBox.TabIndex = 3
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(7, 66)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(126, 33)
        PasswordLabel.TabIndex = 4
        PasswordLabel.Text = "Password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommitteeBindingSource, "Password", True))
        Me.PasswordTextBox.Enabled = False
        Me.PasswordTextBox.Location = New System.Drawing.Point(147, 63)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(306, 40)
        Me.PasswordTextBox.TabIndex = 5
        '
        'frmCommittee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(514, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.CommitteeBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmCommittee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Committee Accounts"
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.CommitteeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommitteeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommitteeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CommitteeBindingNavigator.ResumeLayout(False)
        Me.CommitteeBindingNavigator.PerformLayout()
        CType(Me.CommitteeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents CommitteeDataSet As ES.CommitteeDataSet
    Friend WithEvents CommitteeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CommitteeTableAdapter As ES.CommitteeDataSetTableAdapters.CommitteeTableAdapter
    Friend WithEvents TableAdapterManager As ES.CommitteeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CommitteeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CommitteeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CommitteeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
End Class

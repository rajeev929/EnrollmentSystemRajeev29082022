<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentRecord))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.StudentRecordDataGridView = New System.Windows.Forms.DataGridView
        Me.StudentRecordBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.StudentRecordBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.StudentRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentRecordDataSet = New ES.StudentRecordDataSet
        Me.StudentRecordTableAdapter = New ES.StudentRecordDataSetTableAdapters.StudentRecordTableAdapter
        Me.TableAdapterManager = New ES.StudentRecordDataSetTableAdapters.TableAdapterManager
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.StudentRecordDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentRecordBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentRecordBindingNavigator.SuspendLayout()
        CType(Me.StudentRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentRecordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1128, 670)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.StudentRecordDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(6, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 651)
        Me.Panel1.TabIndex = 2
        '
        'StudentRecordDataGridView
        '
        Me.StudentRecordDataGridView.AutoGenerateColumns = False
        Me.StudentRecordDataGridView.AutoSizeColumnsMode = Global.ES.My.MySettings.Default.auto1
        Me.StudentRecordDataGridView.AutoSizeRowsMode = Global.ES.My.MySettings.Default.row2
        Me.StudentRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentRecordDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn15})
        Me.StudentRecordDataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeColumnsMode", Global.ES.My.MySettings.Default, "auto1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.StudentRecordDataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeRowsMode", Global.ES.My.MySettings.Default, "row2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.StudentRecordDataGridView.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.ES.My.MySettings.Default, "font6", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.StudentRecordDataGridView.DataSource = Me.StudentRecordBindingSource
        Me.StudentRecordDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StudentRecordDataGridView.Font = Global.ES.My.MySettings.Default.font6
        Me.StudentRecordDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.StudentRecordDataGridView.Name = "StudentRecordDataGridView"
        Me.StudentRecordDataGridView.Size = New System.Drawing.Size(1116, 651)
        Me.StudentRecordDataGridView.TabIndex = 5
        '
        'StudentRecordBindingNavigator
        '
        Me.StudentRecordBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentRecordBindingNavigator.BindingSource = Me.StudentRecordBindingSource
        Me.StudentRecordBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentRecordBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentRecordBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentRecordBindingNavigatorSaveItem})
        Me.StudentRecordBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentRecordBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentRecordBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentRecordBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentRecordBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentRecordBindingNavigator.Name = "StudentRecordBindingNavigator"
        Me.StudentRecordBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentRecordBindingNavigator.Size = New System.Drawing.Size(1152, 25)
        Me.StudentRecordBindingNavigator.TabIndex = 5
        Me.StudentRecordBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'StudentRecordBindingNavigatorSaveItem
        '
        Me.StudentRecordBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentRecordBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentRecordBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentRecordBindingNavigatorSaveItem.Name = "StudentRecordBindingNavigatorSaveItem"
        Me.StudentRecordBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StudentRecordBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StudentRecordBindingSource
        '
        Me.StudentRecordBindingSource.DataMember = "StudentRecord"
        Me.StudentRecordBindingSource.DataSource = Me.StudentRecordDataSet
        '
        'StudentRecordDataSet
        '
        Me.StudentRecordDataSet.DataSetName = "StudentRecordDataSet"
        Me.StudentRecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentRecordTableAdapter
        '
        Me.StudentRecordTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentRecordTableAdapter = Me.StudentRecordTableAdapter
        Me.TableAdapterManager.UpdateOrder = ES.StudentRecordDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 111
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 114
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MiddleName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MiddleName"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 133
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "BirthDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "BirthDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 108
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 64
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 92
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 98
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "YearLevel"
        Me.DataGridViewTextBoxColumn12.HeaderText = "YearLevel"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 107
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "SchoolYear"
        Me.DataGridViewTextBoxColumn15.HeaderText = "SchoolYear"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 119
        '
        'frmStudentRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1152, 711)
        Me.ControlBox = False
        Me.Controls.Add(Me.StudentRecordBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmStudentRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentRecord"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.StudentRecordDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentRecordBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentRecordBindingNavigator.ResumeLayout(False)
        Me.StudentRecordBindingNavigator.PerformLayout()
        CType(Me.StudentRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentRecordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StudentRecordDataSet As ES.StudentRecordDataSet
    Friend WithEvents StudentRecordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentRecordTableAdapter As ES.StudentRecordDataSetTableAdapters.StudentRecordTableAdapter
    Friend WithEvents TableAdapterManager As ES.StudentRecordDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentRecordBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents StudentRecordBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StudentRecordDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

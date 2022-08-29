<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistLog
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.HistoryLogDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HistoryLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistoryLogDataSet = New ES.HistoryLogDataSet
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnPrev = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.HistoryLogTableAdapter = New ES.HistoryLogDataSetTableAdapters.HistoryLogTableAdapter
        Me.TableAdapterManager = New ES.HistoryLogDataSetTableAdapters.TableAdapterManager
        Me.Panel1.SuspendLayout()
        CType(Me.HistoryLogDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryLogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.HistoryLogDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(7, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1053, 599)
        Me.Panel1.TabIndex = 2
        '
        'HistoryLogDataGridView
        '
        Me.HistoryLogDataGridView.AutoGenerateColumns = False
        Me.HistoryLogDataGridView.AutoSizeColumnsMode = Global.ES.My.MySettings.Default.auto1
        Me.HistoryLogDataGridView.AutoSizeRowsMode = Global.ES.My.MySettings.Default.row2
        Me.HistoryLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistoryLogDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.HistoryLogDataGridView.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.ES.My.MySettings.Default, "font1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.HistoryLogDataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeColumnsMode", Global.ES.My.MySettings.Default, "auto1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.HistoryLogDataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeRowsMode", Global.ES.My.MySettings.Default, "row2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.HistoryLogDataGridView.DataSource = Me.HistoryLogBindingSource
        Me.HistoryLogDataGridView.Font = Global.ES.My.MySettings.Default.font1
        Me.HistoryLogDataGridView.Location = New System.Drawing.Point(8, 14)
        Me.HistoryLogDataGridView.Name = "HistoryLogDataGridView"
        Me.HistoryLogDataGridView.ReadOnly = True
        Me.HistoryLogDataGridView.Size = New System.Drawing.Size(1037, 571)
        Me.HistoryLogDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Time"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 72
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Actions"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Actions"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 93
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "User"
        Me.DataGridViewTextBoxColumn4.HeaderText = "User"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 71
        '
        'HistoryLogBindingSource
        '
        Me.HistoryLogBindingSource.DataMember = "HistoryLog"
        Me.HistoryLogBindingSource.DataSource = Me.HistoryLogDataSet
        '
        'HistoryLogDataSet
        '
        Me.HistoryLogDataSet.DataSetName = "HistoryLogDataSet"
        Me.HistoryLogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.UsernameLabel)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnLast)
        Me.Panel2.Controls.Add(Me.btnNext)
        Me.Panel2.Controls.Add(Me.btnPrev)
        Me.Panel2.Controls.Add(Me.btnFirst)
        Me.Panel2.Location = New System.Drawing.Point(7, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1053, 52)
        Me.Panel2.TabIndex = 3
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(8, 12)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(108, 28)
        Me.UsernameLabel.TabIndex = 5
        Me.UsernameLabel.Text = "Navigate:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(970, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(365, 9)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 34)
        Me.btnLast.TabIndex = 3
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(284, 9)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 34)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(203, 9)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 34)
        Me.btnPrev.TabIndex = 1
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(122, 9)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 34)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1069, 690)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'HistoryLogTableAdapter
        '
        Me.HistoryLogTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HistoryLogTableAdapter = Me.HistoryLogTableAdapter
        Me.TableAdapterManager.UpdateOrder = ES.HistoryLogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmHistLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1094, 712)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmHistLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History Log"
        Me.Panel1.ResumeLayout(False)
        CType(Me.HistoryLogDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryLogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HistoryLogDataSet As ES.HistoryLogDataSet
    Friend WithEvents HistoryLogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HistoryLogTableAdapter As ES.HistoryLogDataSetTableAdapters.HistoryLogTableAdapter
    Friend WithEvents TableAdapterManager As ES.HistoryLogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents HistoryLogDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

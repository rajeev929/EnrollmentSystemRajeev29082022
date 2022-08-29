<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentList
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
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboSearch = New System.Windows.Forms.ComboBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnPrev = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnFilter = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboYearLevel = New System.Windows.Forms.ComboBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.GenderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenderDataSet = New ES.GenderDataSet
        Me.YearLevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YearLevelDataSet = New ES.YearLevelDataSet
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusDataSet = New ES.StatusDataSet
        Me.PrevEnrollmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Year_LevelTableAdapter = New ES.YearLevelDataSetTableAdapters.Year_LevelTableAdapter
        Me.StatusTableAdapter = New ES.StatusDataSetTableAdapters.StatusTableAdapter
        Me.GenderTableAdapter = New ES.GenderDataSetTableAdapters.GenderTableAdapter
        Me.StudentsDataGridView = New System.Windows.Forms.DataGridView
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentDataSet = New ES.StudentDataSet
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.StudentsTableAdapter = New ES.StudentDataSetTableAdapters.StudentsTableAdapter
        Me.TableAdapterManager = New ES.StudentDataSetTableAdapters.TableAdapterManager
        Me.SYDataSet = New ES.SYDataSet
        Me.SYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SYTableAdapter = New ES.SYDataSetTableAdapters.SYTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BirthDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Gender = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.SchoolYear = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Panel3.SuspendLayout()
        CType(Me.GenderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearLevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearLevelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrevEnrollmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.StudentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.cboSearch)
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnNext)
        Me.Panel3.Controls.Add(Me.btnLast)
        Me.Panel3.Controls.Add(Me.btnPrev)
        Me.Panel3.Controls.Add(Me.btnFirst)
        Me.Panel3.Controls.Add(Me.btnRefresh)
        Me.Panel3.Controls.Add(Me.btnFilter)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cboYearLevel)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnEdit)
        Me.Panel3.Controls.Add(Me.btnExit)
        Me.Panel3.Location = New System.Drawing.Point(18, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1185, 83)
        Me.Panel3.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(688, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Search By:"
        '
        'cboSearch
        '
        Me.cboSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Items.AddRange(New Object() {"Student ID", "Lastname", "Firstname", "Middlename"})
        Me.cboSearch.Location = New System.Drawing.Point(770, 11)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(121, 27)
        Me.cboSearch.TabIndex = 14
        Me.cboSearch.Text = "Student ID"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1101, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 30)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(897, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(198, 27)
        Me.txtSearch.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Navigate:"
        '
        'btnNext
        '
        Me.btnNext.AutoSize = True
        Me.btnNext.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(169, 8)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(35, 30)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.AutoSize = True
        Me.btnLast.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(210, 8)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(35, 30)
        Me.btnLast.TabIndex = 9
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.AutoSize = True
        Me.btnPrev.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(128, 8)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(35, 30)
        Me.btnPrev.TabIndex = 8
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.AutoSize = True
        Me.btnFirst.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(87, 8)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(35, 30)
        Me.btnFirst.TabIndex = 7
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(251, 8)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 30)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(209, 44)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 30)
        Me.btnFilter.TabIndex = 5
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Filter By:"
        '
        'cboYearLevel
        '
        Me.cboYearLevel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cboYearLevel.Location = New System.Drawing.Point(82, 47)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(121, 27)
        Me.cboYearLevel.TabIndex = 3
        Me.cboYearLevel.Text = "1st Year"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(449, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(332, 8)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(111, 30)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Allow Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1101, 44)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GenderBindingSource
        '
        Me.GenderBindingSource.DataMember = "Gender"
        Me.GenderBindingSource.DataSource = Me.GenderDataSet
        '
        'GenderDataSet
        '
        Me.GenderDataSet.DataSetName = "GenderDataSet"
        Me.GenderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'YearLevelBindingSource
        '
        Me.YearLevelBindingSource.DataMember = "Year Level"
        Me.YearLevelBindingSource.DataSource = Me.YearLevelDataSet
        '
        'YearLevelDataSet
        '
        Me.YearLevelDataSet.DataSetName = "YearLevelDataSet"
        Me.YearLevelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusBindingSource
        '
        Me.StatusBindingSource.DataMember = "Status"
        Me.StatusBindingSource.DataSource = Me.StatusDataSet
        '
        'StatusDataSet
        '
        Me.StatusDataSet.DataSetName = "StatusDataSet"
        Me.StatusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrevEnrollmentBindingSource
        '
        Me.PrevEnrollmentBindingSource.DataMember = "PrevEnrollment"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1221, 117)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Year_LevelTableAdapter
        '
        Me.Year_LevelTableAdapter.ClearBeforeFill = True
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'GenderTableAdapter
        '
        Me.GenderTableAdapter.ClearBeforeFill = True
        '
        'StudentsDataGridView
        '
        Me.StudentsDataGridView.AutoGenerateColumns = False
        Me.StudentsDataGridView.AutoSizeColumnsMode = Global.ES.My.MySettings.Default.auto1
        Me.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.BirthDate, Me.DataGridViewTextBoxColumn5, Me.Gender, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.SchoolYear, Me.DataGridViewTextBoxColumn11})
        Me.StudentsDataGridView.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.ES.My.MySettings.Default, "font3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.StudentsDataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeColumnsMode", Global.ES.My.MySettings.Default, "auto1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.StudentsDataGridView.DataSource = Me.StudentsBindingSource
        Me.StudentsDataGridView.Font = Global.ES.My.MySettings.Default.font3
        Me.StudentsDataGridView.Location = New System.Drawing.Point(6, 15)
        Me.StudentsDataGridView.Name = "StudentsDataGridView"
        Me.StudentsDataGridView.ReadOnly = True
        Me.StudentsDataGridView.Size = New System.Drawing.Size(1214, 560)
        Me.StudentsDataGridView.TabIndex = 1
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.StudentDataSet
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "StudentDataSet"
        Me.StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StudentsDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1226, 581)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FSubjectsTableAdapter = Nothing
        Me.TableAdapterManager.JSubjectsTableAdapter = Nothing
        Me.TableAdapterManager.SeSubjectsTableAdapter = Nothing
        Me.TableAdapterManager.SSubjectsTableAdapter = Nothing
        Me.TableAdapterManager.StudentsTableAdapter = Me.StudentsTableAdapter
        Me.TableAdapterManager.SubjectGradeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ES.StudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SYDataSet
        '
        Me.SYDataSet.DataSetName = "SYDataSet"
        Me.SYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SYBindingSource
        '
        Me.SYBindingSource.DataMember = "SY"
        Me.SYBindingSource.DataSource = Me.SYDataSet
        '
        'SYTableAdapter
        '
        Me.SYTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "S_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 56
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "L_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "F_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 76
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MiddleName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "M_Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'BirthDate
        '
        Me.BirthDate.DataPropertyName = "BirthDate"
        Me.BirthDate.HeaderText = "Birth_Date"
        Me.BirthDate.Name = "BirthDate"
        Me.BirthDate.ReadOnly = True
        Me.BirthDate.Width = 90
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 52
        '
        'Gender
        '
        Me.Gender.DataPropertyName = "Gender"
        Me.Gender.DataSource = Me.GenderBindingSource
        Me.Gender.DisplayMember = "Gender"
        Me.Gender.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        Me.Gender.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Gender.ValueMember = "GenderID"
        Me.Gender.Width = 72
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 76
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ContactNo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contact_No"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 93
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Guardian"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Guardian"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 83
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "GuardianContactNo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "G_Contact_No"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 107
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "YearLevel"
        Me.DataGridViewTextBoxColumn10.DataSource = Me.YearLevelBindingSource
        Me.DataGridViewTextBoxColumn10.DisplayMember = "YearLevel"
        Me.DataGridViewTextBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn10.HeaderText = "Y_Level"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn10.ValueMember = "YrLvlID"
        Me.DataGridViewTextBoxColumn10.Width = 72
        '
        'SchoolYear
        '
        Me.SchoolYear.DataPropertyName = "SchoolYear"
        Me.SchoolYear.DataSource = Me.SYBindingSource
        Me.SchoolYear.DisplayMember = "SY"
        Me.SchoolYear.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.SchoolYear.HeaderText = "SchoolYear"
        Me.SchoolYear.Name = "SchoolYear"
        Me.SchoolYear.ReadOnly = True
        Me.SchoolYear.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SchoolYear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SchoolYear.ValueMember = "SYID"
        Me.SchoolYear.Width = 91
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn11.DataSource = Me.StatusBindingSource
        Me.DataGridViewTextBoxColumn11.DisplayMember = "Status"
        Me.DataGridViewTextBoxColumn11.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn11.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn11.ValueMember = "StatusID"
        Me.DataGridViewTextBoxColumn11.Width = 66
        '
        'frmStudentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(0, 1500)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1246, 717)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmStudentList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student List"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GenderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearLevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearLevelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrevEnrollmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.StudentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StudentDataSet As ES.StudentDataSet
    Friend WithEvents StudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsTableAdapter As ES.StudentDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents TableAdapterManager As ES.StudentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents YearLevelDataSet As ES.YearLevelDataSet
    Friend WithEvents YearLevelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Year_LevelTableAdapter As ES.YearLevelDataSetTableAdapters.Year_LevelTableAdapter
    Friend WithEvents StatusDataSet As ES.StatusDataSet
    Friend WithEvents StatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StatusTableAdapter As ES.StatusDataSetTableAdapters.StatusTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cboYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GenderDataSet As ES.GenderDataSet
    Friend WithEvents GenderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenderTableAdapter As ES.GenderDataSetTableAdapters.GenderTableAdapter
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents PrevEnrollmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSearch As System.Windows.Forms.ComboBox
    Friend WithEvents SYDataSet As ES.SYDataSet
    Friend WithEvents SYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SYTableAdapter As ES.SYDataSetTableAdapters.SYTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BirthDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gender As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SchoolYear As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class

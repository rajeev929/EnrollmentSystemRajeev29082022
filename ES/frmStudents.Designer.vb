<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudents
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
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MiddleNameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ContactNoLabel As System.Windows.Forms.Label
        Dim GuardianLabel As System.Windows.Forms.Label
        Dim GuardianContactNoLabel As System.Windows.Forms.Label
        Dim YearLevelLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim SchoolYearLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudents))
        Me.StudentDataSet = New ES.StudentDataSet
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsTableAdapter = New ES.StudentDataSetTableAdapters.StudentsTableAdapter
        Me.TableAdapterManager = New ES.StudentDataSetTableAdapters.TableAdapterManager
        Me.SubjectGradeTableAdapter = New ES.StudentDataSetTableAdapters.SubjectGradeTableAdapter
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox
        Me.LastNameTextBox = New System.Windows.Forms.TextBox
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox
        Me.AgeTextBox = New System.Windows.Forms.TextBox
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.ContactNoTextBox = New System.Windows.Forms.TextBox
        Me.GuardianTextBox = New System.Windows.Forms.TextBox
        Me.GuardianContactNoTextBox = New System.Windows.Forms.TextBox
        Me.YearLevelComboBox = New System.Windows.Forms.ComboBox
        Me.YearLevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YearLevelDataSet = New ES.YearLevelDataSet
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusDataSet = New ES.StatusDataSet
        Me.Year_LevelTableAdapter = New ES.YearLevelDataSetTableAdapters.Year_LevelTableAdapter
        Me.StatusTableAdapter = New ES.StatusDataSetTableAdapters.StatusTableAdapter
        Me.SubjectGradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BirthDateTextBox = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.SchoolYearTextBox = New System.Windows.Forms.ComboBox
        Me.SYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SYDataSet = New ES.SYDataSet
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.StatusComboBox = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GenderComboBox = New System.Windows.Forms.ComboBox
        Me.GenderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenderDataSet = New ES.GenderDataSet
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.HistoryLogDataSet = New ES.HistoryLogDataSet
        Me.HistoryLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistoryLogTableAdapter = New ES.HistoryLogDataSetTableAdapters.HistoryLogTableAdapter
        Me.TableAdapterManager1 = New ES.HistoryLogDataSetTableAdapters.TableAdapterManager
        Me.GenderTableAdapter = New ES.GenderDataSetTableAdapters.GenderTableAdapter
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SYTableAdapter = New ES.SYDataSetTableAdapters.SYTableAdapter
        StudentIDLabel = New System.Windows.Forms.Label
        LastNameLabel = New System.Windows.Forms.Label
        FirstNameLabel = New System.Windows.Forms.Label
        MiddleNameLabel = New System.Windows.Forms.Label
        AgeLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        ContactNoLabel = New System.Windows.Forms.Label
        GuardianLabel = New System.Windows.Forms.Label
        GuardianContactNoLabel = New System.Windows.Forms.Label
        YearLevelLabel = New System.Windows.Forms.Label
        StatusLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        GenderLabel = New System.Windows.Forms.Label
        SchoolYearLabel = New System.Windows.Forms.Label
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearLevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearLevelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectGradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.SYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.HistoryLogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(13, 12)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(80, 19)
        StudentIDLabel.TabIndex = 1
        StudentIDLabel.Text = "Student ID:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(14, 141)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(82, 19)
        LastNameLabel.TabIndex = 3
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(141, 141)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(83, 19)
        FirstNameLabel.TabIndex = 5
        FirstNameLabel.Text = "First Name:"
        '
        'MiddleNameLabel
        '
        MiddleNameLabel.AutoSize = True
        MiddleNameLabel.Location = New System.Drawing.Point(268, 141)
        MiddleNameLabel.Name = "MiddleNameLabel"
        MiddleNameLabel.Size = New System.Drawing.Size(100, 19)
        MiddleNameLabel.TabIndex = 7
        MiddleNameLabel.Text = "Middle Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(165, 193)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(38, 19)
        AgeLabel.TabIndex = 9
        AgeLabel.Text = "Age:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(14, 297)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(65, 19)
        AddressLabel.TabIndex = 11
        AddressLabel.Text = "Address:"
        '
        'ContactNoLabel
        '
        ContactNoLabel.AutoSize = True
        ContactNoLabel.Location = New System.Drawing.Point(15, 379)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(85, 19)
        ContactNoLabel.TabIndex = 13
        ContactNoLabel.Text = "Contact No:"
        '
        'GuardianLabel
        '
        GuardianLabel.AutoSize = True
        GuardianLabel.Location = New System.Drawing.Point(12, 434)
        GuardianLabel.Name = "GuardianLabel"
        GuardianLabel.Size = New System.Drawing.Size(120, 19)
        GuardianLabel.TabIndex = 15
        GuardianLabel.Text = "Parent/Guardian:"
        '
        'GuardianContactNoLabel
        '
        GuardianContactNoLabel.AutoSize = True
        GuardianContactNoLabel.Location = New System.Drawing.Point(13, 486)
        GuardianContactNoLabel.Name = "GuardianContactNoLabel"
        GuardianContactNoLabel.Size = New System.Drawing.Size(148, 19)
        GuardianContactNoLabel.TabIndex = 17
        GuardianContactNoLabel.Text = "Guardian Contact No:"
        '
        'YearLevelLabel
        '
        YearLevelLabel.AutoSize = True
        YearLevelLabel.Location = New System.Drawing.Point(14, 64)
        YearLevelLabel.Name = "YearLevelLabel"
        YearLevelLabel.Size = New System.Drawing.Size(79, 19)
        YearLevelLabel.TabIndex = 19
        YearLevelLabel.Text = "Year Level:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(13, 538)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(53, 19)
        StatusLabel.TabIndex = 21
        StatusLabel.Text = "Status:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(13, 193)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(79, 19)
        Label1.TabIndex = 26
        Label1.Text = "Birth Date:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(13, 245)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(60, 19)
        GenderLabel.TabIndex = 30
        GenderLabel.Text = "Gender:"
        '
        'SchoolYearLabel
        '
        SchoolYearLabel.AutoSize = True
        SchoolYearLabel.Location = New System.Drawing.Point(141, 64)
        SchoolYearLabel.Name = "SchoolYearLabel"
        SchoolYearLabel.Size = New System.Drawing.Size(87, 19)
        SchoolYearLabel.TabIndex = 21
        SchoolYearLabel.Text = "School Year:"
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "StudentDataSet"
        Me.StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.StudentDataSet
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
        Me.TableAdapterManager.SubjectGradeTableAdapter = Me.SubjectGradeTableAdapter
        Me.TableAdapterManager.UpdateOrder = ES.StudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SubjectGradeTableAdapter
        '
        Me.SubjectGradeTableAdapter.ClearBeforeFill = True
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "StudentID", True))
        Me.StudentIDTextBox.Location = New System.Drawing.Point(17, 34)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.ReadOnly = True
        Me.StudentIDTextBox.Size = New System.Drawing.Size(121, 27)
        Me.StudentIDTextBox.TabIndex = 0
        Me.StudentIDTextBox.TabStop = False
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "LastName", True))
        Me.LastNameTextBox.Enabled = False
        Me.LastNameTextBox.Location = New System.Drawing.Point(17, 163)
        Me.LastNameTextBox.MaxLength = 20
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(121, 27)
        Me.LastNameTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Enabled = False
        Me.FirstNameTextBox.Location = New System.Drawing.Point(144, 163)
        Me.FirstNameTextBox.MaxLength = 20
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(121, 27)
        Me.FirstNameTextBox.TabIndex = 3
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "MiddleName", True))
        Me.MiddleNameTextBox.Enabled = False
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(271, 163)
        Me.MiddleNameTextBox.MaxLength = 20
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(121, 27)
        Me.MiddleNameTextBox.TabIndex = 4
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Age", True))
        Me.AgeTextBox.Enabled = False
        Me.AgeTextBox.Location = New System.Drawing.Point(169, 215)
        Me.AgeTextBox.MaxLength = 2
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(36, 27)
        Me.AgeTextBox.TabIndex = 6
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Address", True))
        Me.AddressTextBox.Enabled = False
        Me.AddressTextBox.Location = New System.Drawing.Point(18, 319)
        Me.AddressTextBox.MaxLength = 50
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(375, 57)
        Me.AddressTextBox.TabIndex = 8
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "ContactNo", True))
        Me.ContactNoTextBox.Enabled = False
        Me.ContactNoTextBox.Location = New System.Drawing.Point(18, 398)
        Me.ContactNoTextBox.MaxLength = 15
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(206, 27)
        Me.ContactNoTextBox.TabIndex = 9
        '
        'GuardianTextBox
        '
        Me.GuardianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Guardian", True))
        Me.GuardianTextBox.Enabled = False
        Me.GuardianTextBox.Location = New System.Drawing.Point(17, 456)
        Me.GuardianTextBox.MaxLength = 20
        Me.GuardianTextBox.Name = "GuardianTextBox"
        Me.GuardianTextBox.Size = New System.Drawing.Size(385, 27)
        Me.GuardianTextBox.TabIndex = 10
        '
        'GuardianContactNoTextBox
        '
        Me.GuardianContactNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "GuardianContactNo", True))
        Me.GuardianContactNoTextBox.Enabled = False
        Me.GuardianContactNoTextBox.Location = New System.Drawing.Point(17, 508)
        Me.GuardianContactNoTextBox.MaxLength = 15
        Me.GuardianContactNoTextBox.Name = "GuardianContactNoTextBox"
        Me.GuardianContactNoTextBox.Size = New System.Drawing.Size(206, 27)
        Me.GuardianContactNoTextBox.TabIndex = 11
        '
        'YearLevelComboBox
        '
        Me.YearLevelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StudentsBindingSource, "YearLevel", True))
        Me.YearLevelComboBox.DataSource = Me.YearLevelBindingSource
        Me.YearLevelComboBox.DisplayMember = "YearLevel"
        Me.YearLevelComboBox.Enabled = False
        Me.YearLevelComboBox.FormattingEnabled = True
        Me.YearLevelComboBox.Location = New System.Drawing.Point(17, 86)
        Me.YearLevelComboBox.Name = "YearLevelComboBox"
        Me.YearLevelComboBox.Size = New System.Drawing.Size(121, 27)
        Me.YearLevelComboBox.TabIndex = 0
        Me.YearLevelComboBox.ValueMember = "YrLvlID"
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
        'Year_LevelTableAdapter
        '
        Me.Year_LevelTableAdapter.ClearBeforeFill = True
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'SubjectGradeBindingSource
        '
        Me.SubjectGradeBindingSource.DataMember = "Students_SubjectGrade"
        Me.SubjectGradeBindingSource.DataSource = Me.StudentsBindingSource
        '
        'BirthDateTextBox
        '
        Me.BirthDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "BirthDate", True))
        Me.BirthDateTextBox.Enabled = False
        Me.BirthDateTextBox.Location = New System.Drawing.Point(18, 215)
        Me.BirthDateTextBox.Name = "BirthDateTextBox"
        Me.BirthDateTextBox.ReadOnly = True
        Me.BirthDateTextBox.Size = New System.Drawing.Size(128, 27)
        Me.BirthDateTextBox.TabIndex = 25
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(143, 215)
        Me.DateTimePicker1.MaxDate = New Date(2001, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(16, 27)
        Me.DateTimePicker1.TabIndex = 5
        Me.DateTimePicker1.Value = New Date(2001, 12, 31, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(99, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 19)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "*"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(862, 416)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.AutoScrollMinSize = New System.Drawing.Size(0, 600)
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.SchoolYearTextBox)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.StatusComboBox)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(SchoolYearLabel)
        Me.Panel5.Controls.Add(GuardianLabel)
        Me.Panel5.Controls.Add(Me.GuardianTextBox)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(GuardianContactNoLabel)
        Me.Panel5.Controls.Add(Me.GuardianContactNoTextBox)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(StatusLabel)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(StudentIDLabel)
        Me.Panel5.Controls.Add(Me.YearLevelComboBox)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(YearLevelLabel)
        Me.Panel5.Controls.Add(Me.StudentIDTextBox)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(GenderLabel)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.GenderComboBox)
        Me.Panel5.Controls.Add(LastNameLabel)
        Me.Panel5.Controls.Add(Me.AgeTextBox)
        Me.Panel5.Controls.Add(AgeLabel)
        Me.Panel5.Controls.Add(Me.DateTimePicker1)
        Me.Panel5.Controls.Add(Me.MiddleNameTextBox)
        Me.Panel5.Controls.Add(Label1)
        Me.Panel5.Controls.Add(Me.ContactNoTextBox)
        Me.Panel5.Controls.Add(MiddleNameLabel)
        Me.Panel5.Controls.Add(ContactNoLabel)
        Me.Panel5.Controls.Add(Me.BirthDateTextBox)
        Me.Panel5.Controls.Add(Me.AddressTextBox)
        Me.Panel5.Controls.Add(Me.FirstNameTextBox)
        Me.Panel5.Controls.Add(AddressLabel)
        Me.Panel5.Controls.Add(FirstNameLabel)
        Me.Panel5.Controls.Add(Me.LastNameTextBox)
        Me.Panel5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.ForeColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(409, 24)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(443, 381)
        Me.Panel5.TabIndex = 33
        '
        'SchoolYearTextBox
        '
        Me.SchoolYearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StudentsBindingSource, "SchoolYear", True))
        Me.SchoolYearTextBox.DataSource = Me.SYBindingSource
        Me.SchoolYearTextBox.DisplayMember = "SY"
        Me.SchoolYearTextBox.FormattingEnabled = True
        Me.SchoolYearTextBox.Location = New System.Drawing.Point(145, 86)
        Me.SchoolYearTextBox.Name = "SchoolYearTextBox"
        Me.SchoolYearTextBox.Size = New System.Drawing.Size(121, 27)
        Me.SchoolYearTextBox.TabIndex = 44
        Me.SchoolYearTextBox.ValueMember = "SYID"
        '
        'SYBindingSource
        '
        Me.SYBindingSource.DataMember = "SY"
        Me.SYBindingSource.DataSource = Me.SYDataSet
        '
        'SYDataSet
        '
        Me.SYDataSet.DataSetName = "SYDataSet"
        Me.SYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(167, 486)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 19)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(138, 434)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 19)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(374, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 19)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(72, 538)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 19)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(234, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 19)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "*"
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StudentsBindingSource, "Status", True))
        Me.StatusComboBox.DataSource = Me.StatusBindingSource
        Me.StatusComboBox.DisplayMember = "Status"
        Me.StatusComboBox.Enabled = False
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Location = New System.Drawing.Point(16, 560)
        Me.StatusComboBox.MaxLength = 20
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(176, 27)
        Me.StatusComboBox.TabIndex = 12
        Me.StatusComboBox.ValueMember = "StatusID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(106, 379)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 19)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(79, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 19)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(85, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 19)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(207, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 19)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(98, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 19)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(230, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 19)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(102, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "*"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StudentsBindingSource, "Gender", True))
        Me.GenderComboBox.DataSource = Me.GenderBindingSource
        Me.GenderComboBox.DisplayMember = "Gender"
        Me.GenderComboBox.Enabled = False
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Location = New System.Drawing.Point(17, 267)
        Me.GenderComboBox.MaxLength = 6
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(121, 27)
        Me.GenderComboBox.TabIndex = 7
        Me.GenderComboBox.ValueMember = "GenderID"
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(9, 24)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(394, 381)
        Me.Panel4.TabIndex = 32
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 381)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnExit)
        Me.Panel3.Controls.Add(Me.btnNew)
        Me.Panel3.Location = New System.Drawing.Point(9, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(843, 86)
        Me.Panel3.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(13, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(428, 20)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "NOTICE: Fields with asterisks (*) are required to be filled up."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(153, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 31)
        Me.Button1.TabIndex = 14
        Me.Button1.TabStop = False
        Me.Button1.Text = "Admin"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(85, 15)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(62, 31)
        Me.btnSave.TabIndex = 13
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(764, 15)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(62, 31)
        Me.btnExit.TabIndex = 16
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(17, 15)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(62, 31)
        Me.btnNew.TabIndex = 13
        Me.btnNew.TabStop = False
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'HistoryLogDataSet
        '
        Me.HistoryLogDataSet.DataSetName = "HistoryLogDataSet"
        Me.HistoryLogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistoryLogBindingSource
        '
        Me.HistoryLogBindingSource.DataMember = "HistoryLog"
        Me.HistoryLogBindingSource.DataSource = Me.HistoryLogDataSet
        '
        'HistoryLogTableAdapter
        '
        Me.HistoryLogTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.HistoryLogTableAdapter = Me.HistoryLogTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ES.HistoryLogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GenderTableAdapter
        '
        Me.GenderTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(862, 112)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.White
        Me.ToolStrip.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3, Me.ToolStripSeparator1, Me.ToolStripLabel4, Me.ToolStripLabel5})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(902, 26)
        Me.ToolStrip.TabIndex = 35
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(114, 23)
        Me.ToolStripLabel4.Text = "Current User:"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(132, 23)
        Me.ToolStripLabel5.Text = "ToolStripLabel5"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'SYTableAdapter
        '
        Me.SYTableAdapter.ClearBeforeFill = True
        '
        'frmStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(902, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmStudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration Form"
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearLevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearLevelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectGradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.SYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.HistoryLogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentDataSet As ES.StudentDataSet
    Friend WithEvents StudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsTableAdapter As ES.StudentDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents TableAdapterManager As ES.StudentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiddleNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GuardianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GuardianContactNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearLevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents YearLevelDataSet As ES.YearLevelDataSet
    Friend WithEvents YearLevelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Year_LevelTableAdapter As ES.YearLevelDataSetTableAdapters.Year_LevelTableAdapter
    Friend WithEvents StatusDataSet As ES.StatusDataSet
    Friend WithEvents StatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StatusTableAdapter As ES.StatusDataSetTableAdapters.StatusTableAdapter
    Friend WithEvents SubjectGradeTableAdapter As ES.StudentDataSetTableAdapters.SubjectGradeTableAdapter
    Friend WithEvents SubjectGradeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BirthDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents HistoryLogDataSet As ES.HistoryLogDataSet
    Friend WithEvents HistoryLogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HistoryLogTableAdapter As ES.HistoryLogDataSetTableAdapters.HistoryLogTableAdapter
    Friend WithEvents TableAdapterManager1 As ES.HistoryLogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GenderDataSet As ES.GenderDataSet
    Friend WithEvents GenderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenderTableAdapter As ES.GenderDataSetTableAdapters.GenderTableAdapter
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SchoolYearTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents SYDataSet As ES.SYDataSet
    Friend WithEvents SYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SYTableAdapter As ES.SYDataSetTableAdapters.SYTableAdapter
End Class

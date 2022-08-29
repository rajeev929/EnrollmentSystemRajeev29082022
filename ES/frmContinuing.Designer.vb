<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContinuing
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
        Dim AgeLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ContactNoLabel As System.Windows.Forms.Label
        Dim GuardianLabel As System.Windows.Forms.Label
        Dim GuardianContactNoLabel As System.Windows.Forms.Label
        Dim YearLevelLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim BirthDateLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim SchoolYearLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContinuing))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboSearch = New System.Windows.Forms.ComboBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.SectionComboBox = New System.Windows.Forms.ComboBox
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentDataSet = New ES.StudentDataSet
        Me.SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectionDataSet = New ES.SectionDataSet
        Me.SchoolYearComboBox = New System.Windows.Forms.ComboBox
        Me.SYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SYDataSet = New ES.SYDataSet
        Me.AgeTextBox = New System.Windows.Forms.TextBox
        Me.StudentIDLabel1 = New System.Windows.Forms.Label
        Me.LastNameLabel1 = New System.Windows.Forms.Label
        Me.FirstNameLabel1 = New System.Windows.Forms.Label
        Me.MiddleNameLabel1 = New System.Windows.Forms.Label
        Me.AddressLabel1 = New System.Windows.Forms.Label
        Me.ContactNoLabel1 = New System.Windows.Forms.Label
        Me.GuardianLabel1 = New System.Windows.Forms.Label
        Me.GuardianContactNoLabel1 = New System.Windows.Forms.Label
        Me.YearLevelComboBox = New System.Windows.Forms.ComboBox
        Me.YearLevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YearLevelDataSet = New ES.YearLevelDataSet
        Me.StatusComboBox = New System.Windows.Forms.ComboBox
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusDataSet = New ES.StatusDataSet
        Me.BirthDateLabel1 = New System.Windows.Forms.Label
        Me.GenderComboBox = New System.Windows.Forms.ComboBox
        Me.GenderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenderDataSet = New ES.GenderDataSet
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button6 = New System.Windows.Forms.Button
        Me.Grades_Freshmen_DataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.GradingPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradingPeriodDataSet = New ES.GradingPeriodDataSet
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Grades_Freshmen_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Button3 = New System.Windows.Forms.Button
        Me.Grades_Sophomore_DataGridView = New System.Windows.Forms.DataGridView
        Me.Grades_Sophomore_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Button4 = New System.Windows.Forms.Button
        Me.Grades_Juniors_DataGridView = New System.Windows.Forms.DataGridView
        Me.Grades_Juniors_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Button5 = New System.Windows.Forms.Button
        Me.Grades_Seniors_DataGridView = New System.Windows.Forms.DataGridView
        Me.Grades_Seniors_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FSubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JSubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeSubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsTableAdapter = New ES.StudentDataSetTableAdapters.StudentsTableAdapter
        Me.TableAdapterManager = New ES.StudentDataSetTableAdapters.TableAdapterManager
        Me.FSubjectsTableAdapter = New ES.StudentDataSetTableAdapters.FSubjectsTableAdapter
        Me.Grades_Freshmen_TableAdapter = New ES.StudentDataSetTableAdapters.Grades_Freshmen_TableAdapter
        Me.Grades_Juniors_TableAdapter = New ES.StudentDataSetTableAdapters.Grades_Juniors_TableAdapter
        Me.Grades_Seniors_TableAdapter = New ES.StudentDataSetTableAdapters.Grades_Seniors_TableAdapter
        Me.Grades_Sophomore_TableAdapter = New ES.StudentDataSetTableAdapters.Grades_Sophomore_TableAdapter
        Me.JSubjectsTableAdapter = New ES.StudentDataSetTableAdapters.JSubjectsTableAdapter
        Me.SeSubjectsTableAdapter = New ES.StudentDataSetTableAdapters.SeSubjectsTableAdapter
        Me.SSubjectsTableAdapter = New ES.StudentDataSetTableAdapters.SSubjectsTableAdapter
        Me.StudentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.StudentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Year_LevelTableAdapter = New ES.YearLevelDataSetTableAdapters.Year_LevelTableAdapter
        Me.StatusTableAdapter = New ES.StatusDataSetTableAdapters.StatusTableAdapter
        Me.GenderTableAdapter = New ES.GenderDataSetTableAdapters.GenderTableAdapter
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SYTableAdapter = New ES.SYDataSetTableAdapters.SYTableAdapter
        Me.SectionTableAdapter = New ES.SectionDataSetTableAdapters.SectionTableAdapter
        Me.GradingPeriodTableAdapter = New ES.GradingPeriodDataSetTableAdapters.GradingPeriodTableAdapter
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn
        StudentIDLabel = New System.Windows.Forms.Label
        AgeLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        ContactNoLabel = New System.Windows.Forms.Label
        GuardianLabel = New System.Windows.Forms.Label
        GuardianContactNoLabel = New System.Windows.Forms.Label
        YearLevelLabel = New System.Windows.Forms.Label
        StatusLabel = New System.Windows.Forms.Label
        BirthDateLabel = New System.Windows.Forms.Label
        GenderLabel = New System.Windows.Forms.Label
        SchoolYearLabel = New System.Windows.Forms.Label
        SectionLabel = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearLevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearLevelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Grades_Freshmen_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradingPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradingPeriodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grades_Freshmen_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Grades_Sophomore_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grades_Sophomore_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Grades_Juniors_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grades_Juniors_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.Grades_Seniors_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grades_Seniors_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FSubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JSubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeSubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentsBindingNavigator.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StudentIDLabel.Location = New System.Drawing.Point(12, 29)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(99, 23)
        StudentIDLabel.TabIndex = 0
        StudentIDLabel.Text = "Student ID:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(12, 280)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(38, 19)
        AgeLabel.TabIndex = 8
        AgeLabel.Text = "Age:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(12, 307)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(65, 19)
        AddressLabel.TabIndex = 10
        AddressLabel.Text = "Address:"
        '
        'ContactNoLabel
        '
        ContactNoLabel.AutoSize = True
        ContactNoLabel.Location = New System.Drawing.Point(12, 333)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(85, 19)
        ContactNoLabel.TabIndex = 12
        ContactNoLabel.Text = "Contact No:"
        '
        'GuardianLabel
        '
        GuardianLabel.AutoSize = True
        GuardianLabel.Location = New System.Drawing.Point(12, 359)
        GuardianLabel.Name = "GuardianLabel"
        GuardianLabel.Size = New System.Drawing.Size(72, 19)
        GuardianLabel.TabIndex = 14
        GuardianLabel.Text = "Guardian:"
        '
        'GuardianContactNoLabel
        '
        GuardianContactNoLabel.AutoSize = True
        GuardianContactNoLabel.Location = New System.Drawing.Point(12, 385)
        GuardianContactNoLabel.Name = "GuardianContactNoLabel"
        GuardianContactNoLabel.Size = New System.Drawing.Size(148, 19)
        GuardianContactNoLabel.TabIndex = 16
        GuardianContactNoLabel.Text = "Guardian Contact No:"
        '
        'YearLevelLabel
        '
        YearLevelLabel.AutoSize = True
        YearLevelLabel.Location = New System.Drawing.Point(12, 63)
        YearLevelLabel.Name = "YearLevelLabel"
        YearLevelLabel.Size = New System.Drawing.Size(79, 19)
        YearLevelLabel.TabIndex = 18
        YearLevelLabel.Text = "Year Level:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(12, 412)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(53, 19)
        StatusLabel.TabIndex = 20
        StatusLabel.Text = "Status:"
        '
        'BirthDateLabel
        '
        BirthDateLabel.AutoSize = True
        BirthDateLabel.Location = New System.Drawing.Point(12, 224)
        BirthDateLabel.Name = "BirthDateLabel"
        BirthDateLabel.Size = New System.Drawing.Size(79, 19)
        BirthDateLabel.TabIndex = 22
        BirthDateLabel.Text = "Birth Date:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(12, 249)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(60, 19)
        GenderLabel.TabIndex = 24
        GenderLabel.Text = "Gender:"
        '
        'SchoolYearLabel
        '
        SchoolYearLabel.AutoSize = True
        SchoolYearLabel.Location = New System.Drawing.Point(12, 127)
        SchoolYearLabel.Name = "SchoolYearLabel"
        SchoolYearLabel.Size = New System.Drawing.Size(87, 19)
        SchoolYearLabel.TabIndex = 26
        SchoolYearLabel.Text = "School Year:"
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.Location = New System.Drawing.Point(12, 96)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(60, 19)
        SectionLabel.TabIndex = 30
        SectionLabel.Text = "Section:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1188, 87)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cboSearch)
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Location = New System.Drawing.Point(9, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1178, 67)
        Me.Panel3.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(587, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Search By:"
        '
        'cboSearch
        '
        Me.cboSearch.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Items.AddRange(New Object() {"Student ID", "Lastname", "Firstname", "Middlename"})
        Me.cboSearch.Location = New System.Drawing.Point(683, 16)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(165, 31)
        Me.cboSearch.TabIndex = 19
        Me.cboSearch.Text = "Student ID"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(1065, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(93, 31)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.TabStop = False
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(854, 15)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(205, 31)
        Me.txtSearch.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(6, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 31)
        Me.Button1.TabIndex = 14
        Me.Button1.TabStop = False
        Me.Button1.Text = "Admin"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(1087, 17)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
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
        Me.btnNew.Location = New System.Drawing.Point(79, 17)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(214, 31)
        Me.btnNew.TabIndex = 13
        Me.btnNew.TabStop = False
        Me.btnNew.Text = "Register as Continuing"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(11, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1188, 571)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnNew)
        Me.Panel2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(9, 498)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1169, 62)
        Me.Panel2.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(439, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(739, 109)
        Me.Panel1.TabIndex = 34
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(554, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(81, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(187, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT'S GRADE"
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.AutoScrollMinSize = New System.Drawing.Size(0, 400)
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(SectionLabel)
        Me.Panel5.Controls.Add(Me.SectionComboBox)
        Me.Panel5.Controls.Add(Me.SchoolYearComboBox)
        Me.Panel5.Controls.Add(Me.AgeTextBox)
        Me.Panel5.Controls.Add(StudentIDLabel)
        Me.Panel5.Controls.Add(Me.StudentIDLabel1)
        Me.Panel5.Controls.Add(Me.LastNameLabel1)
        Me.Panel5.Controls.Add(Me.FirstNameLabel1)
        Me.Panel5.Controls.Add(Me.MiddleNameLabel1)
        Me.Panel5.Controls.Add(AgeLabel)
        Me.Panel5.Controls.Add(AddressLabel)
        Me.Panel5.Controls.Add(Me.AddressLabel1)
        Me.Panel5.Controls.Add(ContactNoLabel)
        Me.Panel5.Controls.Add(Me.ContactNoLabel1)
        Me.Panel5.Controls.Add(GuardianLabel)
        Me.Panel5.Controls.Add(Me.GuardianLabel1)
        Me.Panel5.Controls.Add(GuardianContactNoLabel)
        Me.Panel5.Controls.Add(Me.GuardianContactNoLabel1)
        Me.Panel5.Controls.Add(YearLevelLabel)
        Me.Panel5.Controls.Add(Me.YearLevelComboBox)
        Me.Panel5.Controls.Add(StatusLabel)
        Me.Panel5.Controls.Add(Me.StatusComboBox)
        Me.Panel5.Controls.Add(BirthDateLabel)
        Me.Panel5.Controls.Add(Me.BirthDateLabel1)
        Me.Panel5.Controls.Add(GenderLabel)
        Me.Panel5.Controls.Add(Me.GenderComboBox)
        Me.Panel5.Controls.Add(SchoolYearLabel)
        Me.Panel5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.ForeColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(9, 24)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(424, 468)
        Me.Panel5.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Label3"
        '
        'SectionComboBox
        '
        Me.SectionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StudentsBindingSource, "Section", True))
        Me.SectionComboBox.DataSource = Me.SectionBindingSource
        Me.SectionComboBox.DisplayMember = "Section"
        Me.SectionComboBox.FormattingEnabled = True
        Me.SectionComboBox.Location = New System.Drawing.Point(166, 93)
        Me.SectionComboBox.Name = "SectionComboBox"
        Me.SectionComboBox.Size = New System.Drawing.Size(121, 27)
        Me.SectionComboBox.TabIndex = 31
        Me.SectionComboBox.ValueMember = "SectionID"
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
        'SectionBindingSource
        '
        Me.SectionBindingSource.DataMember = "Section"
        Me.SectionBindingSource.DataSource = Me.SectionDataSet
        '
        'SectionDataSet
        '
        Me.SectionDataSet.DataSetName = "SectionDataSet"
        Me.SectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SchoolYearComboBox
        '
        Me.SchoolYearComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StudentsBindingSource, "SchoolYear", True))
        Me.SchoolYearComboBox.DataSource = Me.SYBindingSource
        Me.SchoolYearComboBox.DisplayMember = "SY"
        Me.SchoolYearComboBox.FormattingEnabled = True
        Me.SchoolYearComboBox.Location = New System.Drawing.Point(166, 128)
        Me.SchoolYearComboBox.Name = "SchoolYearComboBox"
        Me.SchoolYearComboBox.Size = New System.Drawing.Size(174, 27)
        Me.SchoolYearComboBox.TabIndex = 21
        Me.SchoolYearComboBox.ValueMember = "SYID"
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
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(166, 277)
        Me.AgeTextBox.MaxLength = 2
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(71, 27)
        Me.AgeTextBox.TabIndex = 30
        '
        'StudentIDLabel1
        '
        Me.StudentIDLabel1.AutoSize = True
        Me.StudentIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "StudentID", True))
        Me.StudentIDLabel1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentIDLabel1.Location = New System.Drawing.Point(166, 29)
        Me.StudentIDLabel1.Name = "StudentIDLabel1"
        Me.StudentIDLabel1.Size = New System.Drawing.Size(62, 23)
        Me.StudentIDLabel1.TabIndex = 1
        Me.StudentIDLabel1.Text = "Label1"
        '
        'LastNameLabel1
        '
        Me.LastNameLabel1.AutoSize = True
        Me.LastNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "LastName", True))
        Me.LastNameLabel1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameLabel1.Location = New System.Drawing.Point(318, 174)
        Me.LastNameLabel1.Name = "LastNameLabel1"
        Me.LastNameLabel1.Size = New System.Drawing.Size(62, 23)
        Me.LastNameLabel1.TabIndex = 3
        Me.LastNameLabel1.Text = "Label1"
        '
        'FirstNameLabel1
        '
        Me.FirstNameLabel1.AutoSize = True
        Me.FirstNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "FirstName", True))
        Me.FirstNameLabel1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameLabel1.Location = New System.Drawing.Point(12, 174)
        Me.FirstNameLabel1.Name = "FirstNameLabel1"
        Me.FirstNameLabel1.Size = New System.Drawing.Size(62, 23)
        Me.FirstNameLabel1.TabIndex = 5
        Me.FirstNameLabel1.Text = "Label1"
        '
        'MiddleNameLabel1
        '
        Me.MiddleNameLabel1.AutoSize = True
        Me.MiddleNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "MiddleName", True))
        Me.MiddleNameLabel1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleNameLabel1.Location = New System.Drawing.Point(164, 174)
        Me.MiddleNameLabel1.Name = "MiddleNameLabel1"
        Me.MiddleNameLabel1.Size = New System.Drawing.Size(62, 23)
        Me.MiddleNameLabel1.TabIndex = 7
        Me.MiddleNameLabel1.Text = "Label1"
        '
        'AddressLabel1
        '
        Me.AddressLabel1.AutoSize = True
        Me.AddressLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Address", True))
        Me.AddressLabel1.Location = New System.Drawing.Point(166, 307)
        Me.AddressLabel1.Name = "AddressLabel1"
        Me.AddressLabel1.Size = New System.Drawing.Size(52, 19)
        Me.AddressLabel1.TabIndex = 11
        Me.AddressLabel1.Text = "Label1"
        '
        'ContactNoLabel1
        '
        Me.ContactNoLabel1.AutoSize = True
        Me.ContactNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "ContactNo", True))
        Me.ContactNoLabel1.Location = New System.Drawing.Point(166, 333)
        Me.ContactNoLabel1.Name = "ContactNoLabel1"
        Me.ContactNoLabel1.Size = New System.Drawing.Size(52, 19)
        Me.ContactNoLabel1.TabIndex = 13
        Me.ContactNoLabel1.Text = "Label1"
        '
        'GuardianLabel1
        '
        Me.GuardianLabel1.AutoSize = True
        Me.GuardianLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Guardian", True))
        Me.GuardianLabel1.Location = New System.Drawing.Point(166, 359)
        Me.GuardianLabel1.Name = "GuardianLabel1"
        Me.GuardianLabel1.Size = New System.Drawing.Size(52, 19)
        Me.GuardianLabel1.TabIndex = 15
        Me.GuardianLabel1.Text = "Label1"
        '
        'GuardianContactNoLabel1
        '
        Me.GuardianContactNoLabel1.AutoSize = True
        Me.GuardianContactNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "GuardianContactNo", True))
        Me.GuardianContactNoLabel1.Location = New System.Drawing.Point(166, 385)
        Me.GuardianContactNoLabel1.Name = "GuardianContactNoLabel1"
        Me.GuardianContactNoLabel1.Size = New System.Drawing.Size(52, 19)
        Me.GuardianContactNoLabel1.TabIndex = 17
        Me.GuardianContactNoLabel1.Text = "Label1"
        '
        'YearLevelComboBox
        '
        Me.YearLevelComboBox.BackColor = System.Drawing.Color.White
        Me.YearLevelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StudentsBindingSource, "YearLevel", True))
        Me.YearLevelComboBox.DataSource = Me.YearLevelBindingSource
        Me.YearLevelComboBox.DisplayMember = "YearLevel"
        Me.YearLevelComboBox.FormattingEnabled = True
        Me.YearLevelComboBox.Location = New System.Drawing.Point(166, 60)
        Me.YearLevelComboBox.Name = "YearLevelComboBox"
        Me.YearLevelComboBox.Size = New System.Drawing.Size(121, 27)
        Me.YearLevelComboBox.TabIndex = 19
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
        'StatusComboBox
        '
        Me.StatusComboBox.BackColor = System.Drawing.Color.White
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StudentsBindingSource, "Status", True))
        Me.StatusComboBox.DataSource = Me.StatusBindingSource
        Me.StatusComboBox.DisplayMember = "Status"
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Location = New System.Drawing.Point(166, 409)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(205, 27)
        Me.StatusComboBox.TabIndex = 21
        Me.StatusComboBox.ValueMember = "StatusID"
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
        'BirthDateLabel1
        '
        Me.BirthDateLabel1.AutoSize = True
        Me.BirthDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "BirthDate", True))
        Me.BirthDateLabel1.Location = New System.Drawing.Point(166, 224)
        Me.BirthDateLabel1.Name = "BirthDateLabel1"
        Me.BirthDateLabel1.Size = New System.Drawing.Size(52, 19)
        Me.BirthDateLabel1.TabIndex = 23
        Me.BirthDateLabel1.Text = "Label1"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.BackColor = System.Drawing.Color.White
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StudentsBindingSource, "Gender", True))
        Me.GenderComboBox.DataSource = Me.GenderBindingSource
        Me.GenderComboBox.DisplayMember = "Gender"
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Location = New System.Drawing.Point(166, 246)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(121, 27)
        Me.GenderComboBox.TabIndex = 25
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
        Me.Panel4.Controls.Add(Me.TabControl1)
        Me.Panel4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(439, 139)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(739, 353)
        Me.Panel4.TabIndex = 32
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(739, 353)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Grades_Freshmen_DataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(731, 321)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "1st Year Grade"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(6, 269)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 31)
        Me.Button6.TabIndex = 18
        Me.Button6.TabStop = False
        Me.Button6.Text = "Save Grades"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Grades_Freshmen_DataGridView
        '
        Me.Grades_Freshmen_DataGridView.AutoGenerateColumns = False
        Me.Grades_Freshmen_DataGridView.AutoSizeColumnsMode = Global.ES.My.MySettings.Default.auto1
        Me.Grades_Freshmen_DataGridView.AutoSizeRowsMode = Global.ES.My.MySettings.Default.row2
        Me.Grades_Freshmen_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grades_Freshmen_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.Grades_Freshmen_DataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeColumnsMode", Global.ES.My.MySettings.Default, "auto1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Grades_Freshmen_DataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeRowsMode", Global.ES.My.MySettings.Default, "row2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Grades_Freshmen_DataGridView.DataSource = Me.Grades_Freshmen_BindingSource
        Me.Grades_Freshmen_DataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grades_Freshmen_DataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Grades_Freshmen_DataGridView.Name = "Grades_Freshmen_DataGridView"
        Me.Grades_Freshmen_DataGridView.Size = New System.Drawing.Size(725, 251)
        Me.Grades_Freshmen_DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GradingPeriod"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.GradingPeriodBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "GradingPeriod"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "GradingPeriod"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "GradingPeriodID"
        Me.DataGridViewTextBoxColumn3.Width = 126
        '
        'GradingPeriodBindingSource
        '
        Me.GradingPeriodBindingSource.DataMember = "GradingPeriod"
        Me.GradingPeriodBindingSource.DataSource = Me.GradingPeriodDataSet
        '
        'GradingPeriodDataSet
        '
        Me.GradingPeriodDataSet.DataSetName = "GradingPeriodDataSet"
        Me.GradingPeriodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "English"
        Me.DataGridViewTextBoxColumn4.HeaderText = "English"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 81
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Filipino"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Filipino"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 81
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SocialScience"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SocialScience"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 121
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Math"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Math"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 68
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Makabayan"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Makabayan"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 109
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "MAPEH"
        Me.DataGridViewTextBoxColumn7.HeaderText = "MAPEH"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 82
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "AralPan"
        Me.DataGridViewTextBoxColumn10.HeaderText = "AralPan"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 84
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Values"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Values"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 77
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TLE"
        Me.DataGridViewTextBoxColumn12.HeaderText = "TLE"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 57
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Average"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Average"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 87
        '
        'Grades_Freshmen_BindingSource
        '
        Me.Grades_Freshmen_BindingSource.DataMember = "Students_Grades(Freshmen)"
        Me.Grades_Freshmen_BindingSource.DataSource = Me.StudentsBindingSource
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Grades_Sophomore_DataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(731, 321)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "2nd Year Grade"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(6, 269)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 31)
        Me.Button3.TabIndex = 18
        Me.Button3.TabStop = False
        Me.Button3.Text = "Save Grades"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Grades_Sophomore_DataGridView
        '
        Me.Grades_Sophomore_DataGridView.AutoGenerateColumns = False
        Me.Grades_Sophomore_DataGridView.AutoSizeColumnsMode = Global.ES.My.MySettings.Default.auto1
        Me.Grades_Sophomore_DataGridView.AutoSizeRowsMode = Global.ES.My.MySettings.Default.row2
        Me.Grades_Sophomore_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grades_Sophomore_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.Grades_Sophomore_DataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeColumnsMode", Global.ES.My.MySettings.Default, "auto1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Grades_Sophomore_DataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeRowsMode", Global.ES.My.MySettings.Default, "row2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Grades_Sophomore_DataGridView.DataSource = Me.Grades_Sophomore_BindingSource
        Me.Grades_Sophomore_DataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grades_Sophomore_DataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Grades_Sophomore_DataGridView.Name = "Grades_Sophomore_DataGridView"
        Me.Grades_Sophomore_DataGridView.Size = New System.Drawing.Size(725, 251)
        Me.Grades_Sophomore_DataGridView.TabIndex = 0
        '
        'Grades_Sophomore_BindingSource
        '
        Me.Grades_Sophomore_BindingSource.DataMember = "Students_Grades(Sophomore)"
        Me.Grades_Sophomore_BindingSource.DataSource = Me.StudentsBindingSource
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.Grades_Juniors_DataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(731, 321)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "3rd Year Grade"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(3, 266)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 31)
        Me.Button4.TabIndex = 19
        Me.Button4.TabStop = False
        Me.Button4.Text = "Save Grades"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Grades_Juniors_DataGridView
        '
        Me.Grades_Juniors_DataGridView.AutoGenerateColumns = False
        Me.Grades_Juniors_DataGridView.AutoSizeColumnsMode = Global.ES.My.MySettings.Default.auto1
        Me.Grades_Juniors_DataGridView.AutoSizeRowsMode = Global.ES.My.MySettings.Default.row2
        Me.Grades_Juniors_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grades_Juniors_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35})
        Me.Grades_Juniors_DataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeColumnsMode", Global.ES.My.MySettings.Default, "auto1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Grades_Juniors_DataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeRowsMode", Global.ES.My.MySettings.Default, "row2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Grades_Juniors_DataGridView.DataSource = Me.Grades_Juniors_BindingSource
        Me.Grades_Juniors_DataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grades_Juniors_DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Grades_Juniors_DataGridView.Name = "Grades_Juniors_DataGridView"
        Me.Grades_Juniors_DataGridView.Size = New System.Drawing.Size(731, 257)
        Me.Grades_Juniors_DataGridView.TabIndex = 0
        '
        'Grades_Juniors_BindingSource
        '
        Me.Grades_Juniors_BindingSource.DataMember = "Students_Grades(Juniors)"
        Me.Grades_Juniors_BindingSource.DataSource = Me.StudentsBindingSource
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.Button5)
        Me.TabPage4.Controls.Add(Me.Grades_Seniors_DataGridView)
        Me.TabPage4.Location = New System.Drawing.Point(4, 28)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(731, 321)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "4th Year Grade"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(3, 266)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 31)
        Me.Button5.TabIndex = 19
        Me.Button5.TabStop = False
        Me.Button5.Text = "Save Grades"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Grades_Seniors_DataGridView
        '
        Me.Grades_Seniors_DataGridView.AutoGenerateColumns = False
        Me.Grades_Seniors_DataGridView.AutoSizeColumnsMode = Global.ES.My.MySettings.Default.auto1
        Me.Grades_Seniors_DataGridView.AutoSizeRowsMode = Global.ES.My.MySettings.Default.row2
        Me.Grades_Seniors_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grades_Seniors_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn46})
        Me.Grades_Seniors_DataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeColumnsMode", Global.ES.My.MySettings.Default, "auto1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Grades_Seniors_DataGridView.DataBindings.Add(New System.Windows.Forms.Binding("AutoSizeRowsMode", Global.ES.My.MySettings.Default, "row2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Grades_Seniors_DataGridView.DataSource = Me.Grades_Seniors_BindingSource
        Me.Grades_Seniors_DataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grades_Seniors_DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Grades_Seniors_DataGridView.Name = "Grades_Seniors_DataGridView"
        Me.Grades_Seniors_DataGridView.Size = New System.Drawing.Size(731, 257)
        Me.Grades_Seniors_DataGridView.TabIndex = 0
        '
        'Grades_Seniors_BindingSource
        '
        Me.Grades_Seniors_BindingSource.DataMember = "Students_Grades(Seniors)"
        Me.Grades_Seniors_BindingSource.DataSource = Me.StudentsBindingSource
        '
        'FSubjectsBindingSource
        '
        Me.FSubjectsBindingSource.DataMember = "Students_FSubjects"
        Me.FSubjectsBindingSource.DataSource = Me.StudentsBindingSource
        '
        'SSubjectsBindingSource
        '
        Me.SSubjectsBindingSource.DataMember = "Students_SSubjects"
        Me.SSubjectsBindingSource.DataSource = Me.StudentsBindingSource
        '
        'JSubjectsBindingSource
        '
        Me.JSubjectsBindingSource.DataMember = "Students_JSubjects"
        Me.JSubjectsBindingSource.DataSource = Me.StudentsBindingSource
        '
        'SeSubjectsBindingSource
        '
        Me.SeSubjectsBindingSource.DataMember = "Students_SeSubjects"
        Me.SeSubjectsBindingSource.DataSource = Me.StudentsBindingSource
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FSubjectsTableAdapter = Me.FSubjectsTableAdapter
        Me.TableAdapterManager.Grades_Freshmen_TableAdapter = Me.Grades_Freshmen_TableAdapter
        Me.TableAdapterManager.Grades_Juniors_TableAdapter = Me.Grades_Juniors_TableAdapter
        Me.TableAdapterManager.Grades_Seniors_TableAdapter = Me.Grades_Seniors_TableAdapter
        Me.TableAdapterManager.Grades_Sophomore_TableAdapter = Me.Grades_Sophomore_TableAdapter
        Me.TableAdapterManager.JSubjectsTableAdapter = Me.JSubjectsTableAdapter
        Me.TableAdapterManager.SeSubjectsTableAdapter = Me.SeSubjectsTableAdapter
        Me.TableAdapterManager.SSubjectsTableAdapter = Me.SSubjectsTableAdapter
        Me.TableAdapterManager.StudentsTableAdapter = Me.StudentsTableAdapter
        Me.TableAdapterManager.SubjectGradeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ES.StudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FSubjectsTableAdapter
        '
        Me.FSubjectsTableAdapter.ClearBeforeFill = True
        '
        'Grades_Freshmen_TableAdapter
        '
        Me.Grades_Freshmen_TableAdapter.ClearBeforeFill = True
        '
        'Grades_Juniors_TableAdapter
        '
        Me.Grades_Juniors_TableAdapter.ClearBeforeFill = True
        '
        'Grades_Seniors_TableAdapter
        '
        Me.Grades_Seniors_TableAdapter.ClearBeforeFill = True
        '
        'Grades_Sophomore_TableAdapter
        '
        Me.Grades_Sophomore_TableAdapter.ClearBeforeFill = True
        '
        'JSubjectsTableAdapter
        '
        Me.JSubjectsTableAdapter.ClearBeforeFill = True
        '
        'SeSubjectsTableAdapter
        '
        Me.SeSubjectsTableAdapter.ClearBeforeFill = True
        '
        'SSubjectsTableAdapter
        '
        Me.SSubjectsTableAdapter.ClearBeforeFill = True
        '
        'StudentsBindingNavigator
        '
        Me.StudentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentsBindingNavigator.BindingSource = Me.StudentsBindingSource
        Me.StudentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentsBindingNavigatorSaveItem})
        Me.StudentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentsBindingNavigator.Name = "StudentsBindingNavigator"
        Me.StudentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentsBindingNavigator.Size = New System.Drawing.Size(885, 25)
        Me.StudentsBindingNavigator.TabIndex = 37
        Me.StudentsBindingNavigator.Text = "BindingNavigator1"
        Me.StudentsBindingNavigator.Visible = False
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
        'StudentsBindingNavigatorSaveItem
        '
        Me.StudentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentsBindingNavigatorSaveItem.Name = "StudentsBindingNavigatorSaveItem"
        Me.StudentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StudentsBindingNavigatorSaveItem.Text = "Save Data"
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
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.White
        Me.ToolStrip.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3, Me.ToolStripSeparator1, Me.ToolStripLabel4, Me.ToolStripLabel5})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1209, 26)
        Me.ToolStrip.TabIndex = 38
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
        'SectionTableAdapter
        '
        Me.SectionTableAdapter.ClearBeforeFill = True
        '
        'GradingPeriodTableAdapter
        '
        Me.GradingPeriodTableAdapter.ClearBeforeFill = True
        '
        'Timer2
        '
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "GradingPeriod"
        Me.DataGridViewTextBoxColumn14.DataSource = Me.GradingPeriodBindingSource
        Me.DataGridViewTextBoxColumn14.DisplayMember = "GradingPeriod"
        Me.DataGridViewTextBoxColumn14.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn14.Frozen = True
        Me.DataGridViewTextBoxColumn14.HeaderText = "GradingPeriod"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn14.ValueMember = "GradingPeriodID"
        Me.DataGridViewTextBoxColumn14.Width = 126
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "English"
        Me.DataGridViewTextBoxColumn15.HeaderText = "English"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 81
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Filipino"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Filipino"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 81
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "SocialScience"
        Me.DataGridViewTextBoxColumn17.HeaderText = "SocialScience"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 121
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Math"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Math"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 68
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Makabayan"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Makabayan"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 109
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "MAPEH"
        Me.DataGridViewTextBoxColumn18.HeaderText = "MAPEH"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 82
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "AralPan"
        Me.DataGridViewTextBoxColumn21.HeaderText = "AralPan"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 84
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Values"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Values"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 77
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TLE"
        Me.DataGridViewTextBoxColumn23.HeaderText = "TLE"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 57
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Average"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Average"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 87
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "GradingPeriod"
        Me.DataGridViewTextBoxColumn25.DataSource = Me.GradingPeriodBindingSource
        Me.DataGridViewTextBoxColumn25.DisplayMember = "GradingPeriod"
        Me.DataGridViewTextBoxColumn25.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn25.Frozen = True
        Me.DataGridViewTextBoxColumn25.HeaderText = "GradingPeriod"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn25.ValueMember = "GradingPeriodID"
        Me.DataGridViewTextBoxColumn25.Width = 126
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "English"
        Me.DataGridViewTextBoxColumn26.HeaderText = "English"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 81
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Filipino"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Filipino"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 81
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "SocialScience"
        Me.DataGridViewTextBoxColumn28.HeaderText = "SocialScience"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 121
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Math"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Math"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 68
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Makabayan"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Makabayan"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 109
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "MAPEH"
        Me.DataGridViewTextBoxColumn29.HeaderText = "MAPEH"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 82
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "AralPan"
        Me.DataGridViewTextBoxColumn32.HeaderText = "AralPan"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 84
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Values"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Values"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 77
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "TLE"
        Me.DataGridViewTextBoxColumn34.HeaderText = "TLE"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 57
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "Average"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Average"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Width = 87
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "GradingPeriod"
        Me.DataGridViewTextBoxColumn36.DataSource = Me.GradingPeriodBindingSource
        Me.DataGridViewTextBoxColumn36.DisplayMember = "GradingPeriod"
        Me.DataGridViewTextBoxColumn36.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn36.Frozen = True
        Me.DataGridViewTextBoxColumn36.HeaderText = "GradingPeriod"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn36.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn36.ValueMember = "GradingPeriodID"
        Me.DataGridViewTextBoxColumn36.Width = 126
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "English"
        Me.DataGridViewTextBoxColumn37.HeaderText = "English"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Width = 81
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "Filipino"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Filipino"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.Width = 81
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "SocialScience"
        Me.DataGridViewTextBoxColumn39.HeaderText = "SocialScience"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Width = 121
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "Math"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Math"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.Width = 68
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "Makabayan"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Makabayan"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Width = 109
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "MAPEH"
        Me.DataGridViewTextBoxColumn40.HeaderText = "MAPEH"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.Width = 82
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "AralPan"
        Me.DataGridViewTextBoxColumn43.HeaderText = "AralPan"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.Width = 84
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "Values"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Values"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.Width = 77
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "TLE"
        Me.DataGridViewTextBoxColumn45.HeaderText = "TLE"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.Width = 57
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "CAT"
        Me.DataGridViewTextBoxColumn47.HeaderText = "CAT"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.Width = 59
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "Average"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Average"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        Me.DataGridViewTextBoxColumn46.Width = 87
        '
        'frmContinuing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1209, 692)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.StudentsBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmContinuing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Continuing Student"
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearLevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearLevelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Grades_Freshmen_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradingPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradingPeriodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grades_Freshmen_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Grades_Sophomore_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grades_Sophomore_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Grades_Juniors_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grades_Juniors_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.Grades_Seniors_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grades_Seniors_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FSubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JSubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeSubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentsBindingNavigator.ResumeLayout(False)
        Me.StudentsBindingNavigator.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents StudentDataSet As ES.StudentDataSet
    Friend WithEvents StudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsTableAdapter As ES.StudentDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents TableAdapterManager As ES.StudentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents StudentsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StudentIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents LastNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents FirstNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents MiddleNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents AddressLabel1 As System.Windows.Forms.Label
    Friend WithEvents ContactNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents GuardianLabel1 As System.Windows.Forms.Label
    Friend WithEvents GuardianContactNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents YearLevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BirthDateLabel1 As System.Windows.Forms.Label
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents YearLevelDataSet As ES.YearLevelDataSet
    Friend WithEvents YearLevelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Year_LevelTableAdapter As ES.YearLevelDataSetTableAdapters.Year_LevelTableAdapter
    Friend WithEvents StatusDataSet As ES.StatusDataSet
    Friend WithEvents StatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StatusTableAdapter As ES.StatusDataSetTableAdapters.StatusTableAdapter
    Friend WithEvents GenderDataSet As ES.GenderDataSet
    Friend WithEvents GenderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenderTableAdapter As ES.GenderDataSetTableAdapters.GenderTableAdapter
    Friend WithEvents FSubjectsTableAdapter As ES.StudentDataSetTableAdapters.FSubjectsTableAdapter
    Friend WithEvents FSubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents SSubjectsTableAdapter As ES.StudentDataSetTableAdapters.SSubjectsTableAdapter
    Friend WithEvents SSubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JSubjectsTableAdapter As ES.StudentDataSetTableAdapters.JSubjectsTableAdapter
    Friend WithEvents JSubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeSubjectsTableAdapter As ES.StudentDataSetTableAdapters.SeSubjectsTableAdapter
    Friend WithEvents SeSubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboSearch As System.Windows.Forms.ComboBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SchoolYearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SYDataSet As ES.SYDataSet
    Friend WithEvents SYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SYTableAdapter As ES.SYDataSetTableAdapters.SYTableAdapter
    Friend WithEvents SectionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SectionDataSet As ES.SectionDataSet
    Friend WithEvents SectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SectionTableAdapter As ES.SectionDataSetTableAdapters.SectionTableAdapter
    Friend WithEvents Grades_Freshmen_TableAdapter As ES.StudentDataSetTableAdapters.Grades_Freshmen_TableAdapter
    Friend WithEvents Grades_Freshmen_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Grades_Freshmen_DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GradingPeriodDataSet As ES.GradingPeriodDataSet
    Friend WithEvents GradingPeriodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradingPeriodTableAdapter As ES.GradingPeriodDataSetTableAdapters.GradingPeriodTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grades_Sophomore_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Grades_Sophomore_TableAdapter As ES.StudentDataSetTableAdapters.Grades_Sophomore_TableAdapter
    Friend WithEvents Grades_Sophomore_DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Grades_Juniors_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Grades_Juniors_TableAdapter As ES.StudentDataSetTableAdapters.Grades_Juniors_TableAdapter
    Friend WithEvents Grades_Juniors_DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Grades_Seniors_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Grades_Seniors_TableAdapter As ES.StudentDataSetTableAdapters.Grades_Seniors_TableAdapter
    Friend WithEvents Grades_Seniors_DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

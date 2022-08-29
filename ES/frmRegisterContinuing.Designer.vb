<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterContinuing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegisterContinuing))
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
        Dim BirthDateLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim SchoolYearLabel As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.StudentDataSet = New ES.StudentDataSet
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsTableAdapter = New ES.StudentDataSetTableAdapters.StudentsTableAdapter
        Me.TableAdapterManager = New ES.StudentDataSetTableAdapters.TableAdapterManager
        Me.StudentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.StudentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.StudentIDLabel1 = New System.Windows.Forms.Label
        Me.LastNameLabel1 = New System.Windows.Forms.Label
        Me.FirstNameLabel1 = New System.Windows.Forms.Label
        Me.MiddleNameLabel1 = New System.Windows.Forms.Label
        Me.AgeTextBox = New System.Windows.Forms.TextBox
        Me.AddressLabel1 = New System.Windows.Forms.Label
        Me.ContactNoLabel1 = New System.Windows.Forms.Label
        Me.GuardianLabel1 = New System.Windows.Forms.Label
        Me.GuardianContactNoLabel1 = New System.Windows.Forms.Label
        Me.YearLevelComboBox = New System.Windows.Forms.ComboBox
        Me.StatusComboBox = New System.Windows.Forms.ComboBox
        Me.BirthDateLabel1 = New System.Windows.Forms.Label
        Me.GenderComboBox = New System.Windows.Forms.ComboBox
        Me.SchoolYearTextBox = New System.Windows.Forms.TextBox
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
        BirthDateLabel = New System.Windows.Forms.Label
        GenderLabel = New System.Windows.Forms.Label
        SchoolYearLabel = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(862, 84)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnExit)
        Me.Panel3.Controls.Add(Me.btnNew)
        Me.Panel3.Location = New System.Drawing.Point(9, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(843, 60)
        Me.Panel3.TabIndex = 8
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(11, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(862, 417)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.AutoScrollMinSize = New System.Drawing.Size(0, 600)
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(StudentIDLabel)
        Me.Panel5.Controls.Add(Me.StudentIDLabel1)
        Me.Panel5.Controls.Add(LastNameLabel)
        Me.Panel5.Controls.Add(Me.LastNameLabel1)
        Me.Panel5.Controls.Add(FirstNameLabel)
        Me.Panel5.Controls.Add(Me.FirstNameLabel1)
        Me.Panel5.Controls.Add(MiddleNameLabel)
        Me.Panel5.Controls.Add(Me.MiddleNameLabel1)
        Me.Panel5.Controls.Add(AgeLabel)
        Me.Panel5.Controls.Add(Me.AgeTextBox)
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
        Me.Panel5.Controls.Add(Me.SchoolYearTextBox)
        Me.Panel5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.ForeColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(409, 24)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(443, 381)
        Me.Panel5.TabIndex = 33
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
        Me.TableAdapterManager.SubjectGradeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ES.StudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'StudentsBindingNavigatorSaveItem
        '
        Me.StudentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentsBindingNavigatorSaveItem.Name = "StudentsBindingNavigatorSaveItem"
        Me.StudentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.StudentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(19, 21)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(80, 19)
        StudentIDLabel.TabIndex = 0
        StudentIDLabel.Text = "Student ID:"
        '
        'StudentIDLabel1
        '
        Me.StudentIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "StudentID", True))
        Me.StudentIDLabel1.Location = New System.Drawing.Point(173, 21)
        Me.StudentIDLabel1.Name = "StudentIDLabel1"
        Me.StudentIDLabel1.Size = New System.Drawing.Size(121, 23)
        Me.StudentIDLabel1.TabIndex = 1
        Me.StudentIDLabel1.Text = "Label1"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(19, 44)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(82, 19)
        LastNameLabel.TabIndex = 2
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameLabel1
        '
        Me.LastNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "LastName", True))
        Me.LastNameLabel1.Location = New System.Drawing.Point(173, 44)
        Me.LastNameLabel1.Name = "LastNameLabel1"
        Me.LastNameLabel1.Size = New System.Drawing.Size(121, 23)
        Me.LastNameLabel1.TabIndex = 3
        Me.LastNameLabel1.Text = "Label1"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(19, 67)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(83, 19)
        FirstNameLabel.TabIndex = 4
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameLabel1
        '
        Me.FirstNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "FirstName", True))
        Me.FirstNameLabel1.Location = New System.Drawing.Point(173, 67)
        Me.FirstNameLabel1.Name = "FirstNameLabel1"
        Me.FirstNameLabel1.Size = New System.Drawing.Size(121, 23)
        Me.FirstNameLabel1.TabIndex = 5
        Me.FirstNameLabel1.Text = "Label1"
        '
        'MiddleNameLabel
        '
        MiddleNameLabel.AutoSize = True
        MiddleNameLabel.Location = New System.Drawing.Point(19, 90)
        MiddleNameLabel.Name = "MiddleNameLabel"
        MiddleNameLabel.Size = New System.Drawing.Size(100, 19)
        MiddleNameLabel.TabIndex = 6
        MiddleNameLabel.Text = "Middle Name:"
        '
        'MiddleNameLabel1
        '
        Me.MiddleNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "MiddleName", True))
        Me.MiddleNameLabel1.Location = New System.Drawing.Point(173, 90)
        Me.MiddleNameLabel1.Name = "MiddleNameLabel1"
        Me.MiddleNameLabel1.Size = New System.Drawing.Size(121, 23)
        Me.MiddleNameLabel1.TabIndex = 7
        Me.MiddleNameLabel1.Text = "Label1"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(19, 144)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(38, 19)
        AgeLabel.TabIndex = 8
        AgeLabel.Text = "Age:"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(177, 143)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(61, 27)
        Me.AgeTextBox.TabIndex = 9
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(19, 205)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(65, 19)
        AddressLabel.TabIndex = 10
        AddressLabel.Text = "Address:"
        '
        'AddressLabel1
        '
        Me.AddressLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Address", True))
        Me.AddressLabel1.Location = New System.Drawing.Point(173, 205)
        Me.AddressLabel1.Name = "AddressLabel1"
        Me.AddressLabel1.Size = New System.Drawing.Size(121, 23)
        Me.AddressLabel1.TabIndex = 11
        Me.AddressLabel1.Text = "Label1"
        '
        'ContactNoLabel
        '
        ContactNoLabel.AutoSize = True
        ContactNoLabel.Location = New System.Drawing.Point(19, 228)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(85, 19)
        ContactNoLabel.TabIndex = 12
        ContactNoLabel.Text = "Contact No:"
        '
        'ContactNoLabel1
        '
        Me.ContactNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "ContactNo", True))
        Me.ContactNoLabel1.Location = New System.Drawing.Point(173, 228)
        Me.ContactNoLabel1.Name = "ContactNoLabel1"
        Me.ContactNoLabel1.Size = New System.Drawing.Size(121, 23)
        Me.ContactNoLabel1.TabIndex = 13
        Me.ContactNoLabel1.Text = "Label1"
        '
        'GuardianLabel
        '
        GuardianLabel.AutoSize = True
        GuardianLabel.Location = New System.Drawing.Point(19, 251)
        GuardianLabel.Name = "GuardianLabel"
        GuardianLabel.Size = New System.Drawing.Size(72, 19)
        GuardianLabel.TabIndex = 14
        GuardianLabel.Text = "Guardian:"
        '
        'GuardianLabel1
        '
        Me.GuardianLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Guardian", True))
        Me.GuardianLabel1.Location = New System.Drawing.Point(173, 251)
        Me.GuardianLabel1.Name = "GuardianLabel1"
        Me.GuardianLabel1.Size = New System.Drawing.Size(121, 23)
        Me.GuardianLabel1.TabIndex = 15
        Me.GuardianLabel1.Text = "Label1"
        '
        'GuardianContactNoLabel
        '
        GuardianContactNoLabel.AutoSize = True
        GuardianContactNoLabel.Location = New System.Drawing.Point(19, 274)
        GuardianContactNoLabel.Name = "GuardianContactNoLabel"
        GuardianContactNoLabel.Size = New System.Drawing.Size(148, 19)
        GuardianContactNoLabel.TabIndex = 16
        GuardianContactNoLabel.Text = "Guardian Contact No:"
        '
        'GuardianContactNoLabel1
        '
        Me.GuardianContactNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "GuardianContactNo", True))
        Me.GuardianContactNoLabel1.Location = New System.Drawing.Point(173, 274)
        Me.GuardianContactNoLabel1.Name = "GuardianContactNoLabel1"
        Me.GuardianContactNoLabel1.Size = New System.Drawing.Size(121, 23)
        Me.GuardianContactNoLabel1.TabIndex = 17
        Me.GuardianContactNoLabel1.Text = "Label1"
        '
        'YearLevelLabel
        '
        YearLevelLabel.AutoSize = True
        YearLevelLabel.Location = New System.Drawing.Point(19, 303)
        YearLevelLabel.Name = "YearLevelLabel"
        YearLevelLabel.Size = New System.Drawing.Size(79, 19)
        YearLevelLabel.TabIndex = 18
        YearLevelLabel.Text = "Year Level:"
        '
        'YearLevelComboBox
        '
        Me.YearLevelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "YearLevel", True))
        Me.YearLevelComboBox.FormattingEnabled = True
        Me.YearLevelComboBox.Location = New System.Drawing.Point(173, 300)
        Me.YearLevelComboBox.Name = "YearLevelComboBox"
        Me.YearLevelComboBox.Size = New System.Drawing.Size(121, 27)
        Me.YearLevelComboBox.TabIndex = 19
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(19, 336)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(53, 19)
        StatusLabel.TabIndex = 20
        StatusLabel.Text = "Status:"
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Location = New System.Drawing.Point(173, 333)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(121, 27)
        Me.StatusComboBox.TabIndex = 21
        '
        'BirthDateLabel
        '
        BirthDateLabel.AutoSize = True
        BirthDateLabel.Location = New System.Drawing.Point(19, 119)
        BirthDateLabel.Name = "BirthDateLabel"
        BirthDateLabel.Size = New System.Drawing.Size(79, 19)
        BirthDateLabel.TabIndex = 22
        BirthDateLabel.Text = "Birth Date:"
        '
        'BirthDateLabel1
        '
        Me.BirthDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "BirthDate", True))
        Me.BirthDateLabel1.Location = New System.Drawing.Point(173, 119)
        Me.BirthDateLabel1.Name = "BirthDateLabel1"
        Me.BirthDateLabel1.Size = New System.Drawing.Size(121, 23)
        Me.BirthDateLabel1.TabIndex = 23
        Me.BirthDateLabel1.Text = "Label1"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(19, 175)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(60, 19)
        GenderLabel.TabIndex = 24
        GenderLabel.Text = "Gender:"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Location = New System.Drawing.Point(173, 172)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(121, 27)
        Me.GenderComboBox.TabIndex = 25
        '
        'SchoolYearLabel
        '
        SchoolYearLabel.AutoSize = True
        SchoolYearLabel.Location = New System.Drawing.Point(19, 426)
        SchoolYearLabel.Name = "SchoolYearLabel"
        SchoolYearLabel.Size = New System.Drawing.Size(87, 19)
        SchoolYearLabel.TabIndex = 26
        SchoolYearLabel.Text = "School Year:"
        '
        'SchoolYearTextBox
        '
        Me.SchoolYearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "SchoolYear", True))
        Me.SchoolYearTextBox.Location = New System.Drawing.Point(173, 423)
        Me.SchoolYearTextBox.Name = "SchoolYearTextBox"
        Me.SchoolYearTextBox.Size = New System.Drawing.Size(121, 27)
        Me.SchoolYearTextBox.TabIndex = 27
        '
        'frmRegisterContinuing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(885, 512)
        Me.ControlBox = False
        Me.Controls.Add(Me.StudentsBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRegisterContinuing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Continuing"
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentsBindingNavigator.ResumeLayout(False)
        Me.StudentsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
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
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressLabel1 As System.Windows.Forms.Label
    Friend WithEvents ContactNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents GuardianLabel1 As System.Windows.Forms.Label
    Friend WithEvents GuardianContactNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents YearLevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BirthDateLabel1 As System.Windows.Forms.Label
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SchoolYearTextBox As System.Windows.Forms.TextBox
End Class

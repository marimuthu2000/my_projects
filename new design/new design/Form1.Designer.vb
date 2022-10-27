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
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_file_name = New System.Windows.Forms.Label()
        Me.btn_file_choose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_move = New System.Windows.Forms.Button()
        Me.cmb_folder = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_size = New System.Windows.Forms.ComboBox()
        Me.AlgoMdDbDataSet1 = New new_design.AlgoMdDbDataSet1()
        Me.TblTransHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Trans_HeaderTableAdapter = New new_design.AlgoMdDbDataSet1TableAdapters.Tbl_Trans_HeaderTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.AlgoMdDbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_file_name
        '
        Me.lbl_file_name.AutoSize = True
        Me.lbl_file_name.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_file_name.ForeColor = System.Drawing.Color.White
        Me.lbl_file_name.Location = New System.Drawing.Point(67, 56)
        Me.lbl_file_name.Name = "lbl_file_name"
        Me.lbl_file_name.Size = New System.Drawing.Size(99, 19)
        Me.lbl_file_name.TabIndex = 10
        Me.lbl_file_name.Text = "CHOOSE FILE:"
        '
        'btn_file_choose
        '
        Me.btn_file_choose.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_file_choose.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_file_choose.ForeColor = System.Drawing.Color.White
        Me.btn_file_choose.Location = New System.Drawing.Point(283, 46)
        Me.btn_file_choose.Name = "btn_file_choose"
        Me.btn_file_choose.Size = New System.Drawing.Size(121, 29)
        Me.btn_file_choose.TabIndex = 14
        Me.btn_file_choose.Text = "CHOOSE FILE"
        Me.btn_file_choose.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(67, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 19)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "TRANSACTION TYPE:"
        '
        'Btn_move
        '
        Me.Btn_move.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_move.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_move.ForeColor = System.Drawing.Color.White
        Me.Btn_move.Location = New System.Drawing.Point(283, 207)
        Me.Btn_move.Name = "Btn_move"
        Me.Btn_move.Size = New System.Drawing.Size(121, 26)
        Me.Btn_move.TabIndex = 24
        Me.Btn_move.Text = "CREATE "
        Me.Btn_move.UseVisualStyleBackColor = False
        '
        'cmb_folder
        '
        Me.cmb_folder.BackColor = System.Drawing.Color.White
        Me.cmb_folder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_folder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmb_folder.FormattingEnabled = True
        Me.cmb_folder.Location = New System.Drawing.Point(283, 99)
        Me.cmb_folder.Name = "cmb_folder"
        Me.cmb_folder.Size = New System.Drawing.Size(121, 21)
        Me.cmb_folder.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 19)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "SIZE:"
        '
        'cmb_size
        '
        Me.cmb_size.FormattingEnabled = True
        Me.cmb_size.Location = New System.Drawing.Point(283, 138)
        Me.cmb_size.Name = "cmb_size"
        Me.cmb_size.Size = New System.Drawing.Size(121, 21)
        Me.cmb_size.TabIndex = 29
        '
        'AlgoMdDbDataSet1
        '
        Me.AlgoMdDbDataSet1.DataSetName = "AlgoMdDbDataSet1"
        Me.AlgoMdDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblTransHeaderBindingSource
        '
        Me.TblTransHeaderBindingSource.DataMember = "Tbl_Trans_Header"
        Me.TblTransHeaderBindingSource.DataSource = Me.AlgoMdDbDataSet1
        '
        'Tbl_Trans_HeaderTableAdapter
        '
        Me.Tbl_Trans_HeaderTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(285, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(67, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 19)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "DESIGN NAME:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(283, 171)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 32
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(549, 268)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_size)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_folder)
        Me.Controls.Add(Me.Btn_move)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_file_choose)
        Me.Controls.Add(Me.lbl_file_name)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AlgoMdDbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents lbl_file_name As Label
    Friend WithEvents btn_file_choose As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn_move As Button
    Friend WithEvents cmb_folder As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_size As ComboBox
    Friend WithEvents AlgoMdDbDataSet1 As AlgoMdDbDataSet1
    Friend WithEvents TblTransHeaderBindingSource As BindingSource
    Friend WithEvents Tbl_Trans_HeaderTableAdapter As AlgoMdDbDataSet1TableAdapters.Tbl_Trans_HeaderTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class

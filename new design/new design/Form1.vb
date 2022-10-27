Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Public Sub TRANSACTION_TYPE()
        'Folder load from DB
        Try
            Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-OJC1HEI8\ALGO;Initial Catalog=AlgoMdDb;Persist Security Info=True;User ID=sa;Password=")
            con.Open()
            Dim da As New SqlDataAdapter("
select 0 AS TTH_hdr_id,'--- Choose Type ---' AS TTH_Hdr_Name 
UNION ALL
SELECT TTH_hdr_id,TTH_Hdr_Name from Tbl_Trans_Header
               WHERE TTH_Printing_Enable='Y'
                  GROUP BY TTH_hdr_id,TTH_Hdr_Name", con)
            Dim dt As New DataTable
            da.Fill(dt)
            RemoveHandler cmb_folder.SelectedIndexChanged, AddressOf cmb_folder_SelectedIndexChanged
            cmb_folder.DataSource = dt
            cmb_folder.DisplayMember = "TTH_Hdr_Name"
            cmb_folder.ValueMember = "TTH_hdr_id"
            cmb_folder.SelectedIndex = 0
            con.Close()
            AddHandler cmb_folder.SelectedIndexChanged, AddressOf cmb_folder_SelectedIndexChanged
            Call cmb_folder_SelectedIndexChanged(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Public Sub SIZE_TYPE()
        'Load data from DB based on cmb_folder selection
        Try
            Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-OJC1HEI8\ALGO;Initial Catalog=AlgoMdDb;Persist Security Info=True;User ID=sa;Password=Alg0@2017")
            If cmb_folder.Text.ToString.Length > 0 Then
                con.Open()
                Dim da As SqlDataAdapter = New SqlDataAdapter("
SELECT '--- Choose Size ---' AS TPC_Print_Size
union all
SELECT DISTINCT TPC_Print_Size 
                   from Tbl_Printer_Config_Dtl WHERE TPC_HDR_ID=" & cmb_folder.SelectedValue.ToString & "
                     AND TPC_Active = 'Y'", con)
                Dim dt As DataSet = New DataSet()
                da.Fill(dt)
                cmb_size.DataSource = dt.Tables(0)
                cmb_size.DisplayMember = "TPC_Print_Size"
                cmb_size.ValueMember = "TPC_Print_Size"
                cmb_size.SelectedIndex = 0
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Public Sub btn_file_choose_Click(sender As Object, e As EventArgs) Handles btn_file_choose.Click
        'CHOOSING SPECIFIC FILE & GETTING CHOOSEN FILE PATH 
        Try
            OpenFileDialog.Filter = "RDLC Files|*.RDLC"
            Dim openResult As DialogResult = Me.OpenFileDialog.ShowDialog()
            If openResult = Windows.Forms.DialogResult.Cancel Then Exit Sub
            Dim filechoose As String = Path.GetFileName(OpenFileDialog.FileName)
            Label3.Text = Path.GetDirectoryName(OpenFileDialog.FileName) & "\" & filechoose
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Public Sub Btn_move_Click(sender As Object, e As EventArgs) Handles Btn_move.Click

        Try
            If Label3.Text = "" Then
                MessageBox.Show("choose file")
            ElseIf cmb_folder.Text = "--- Choose Type ---" Then
                MessageBox.Show("Select Transaction Type")
            ElseIf cmb_size.Text = "--- Choose Size ---" Then
                MessageBox.Show("Select Size Type")
            Else
                'CUSTOM FOLDER CREATE
                Dim CPD As String = "Custom Print Design\"
                If Directory.Exists(CPD) Then
                Else
                    Directory.CreateDirectory(CPD)
                End If
                'TRANSACTION CREATE USING COMBOBOX
                If Directory.Exists(CPD & "\" & cmb_folder.Text) Then
                Else
                    Directory.CreateDirectory(CPD & "\" & cmb_folder.Text)
                End If
                'SIZE CREATE USING COMBOBOX
                If Directory.Exists(CPD & "\" & cmb_folder.Text & "\" & cmb_size.Text) Then
                Else
                    Directory.CreateDirectory(CPD & "\" & cmb_folder.Text & "\" & cmb_size.Text)
                End If
                Dim FPOP As String 'Folder Path Of Selected Program
                FPOP = My.Application.Info.DirectoryPath
                'To location
                Dim tolocation As String = FPOP & "\" & CPD + cmb_folder.Text & "\" & cmb_size.Text
                tolocation = FPOP & "\" & CPD + cmb_folder.Text & "\" & cmb_size.Text
                'File choose
                Dim filechoose As String = Path.GetFileName(OpenFileDialog.FileName)
                'TRANSACTION TYPE SELECTED VALUE
                Dim TV As String = "" & cmb_folder.SelectedValue
                'SQL CONNECTION 
                Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-OJC1HEI8\ALGO;Initial Catalog=AlgoMdDb;Persist Security Info=True;User ID=sa;Password=Alg0@2017")
                Dim cmd As New SqlCommand
                con.Open()
                cmd.Connection = con
                cmd = New SqlCommand("If Not Exists(select * from [Tbl_Printer_Config_Dtl] where [TPC_HDR_ID]=  " & TV & "
                And [TPC_Print_Profile]=  '" & filechoose & "'  And [TPC_Print_Size] =  '" & cmb_size.Text & "' )
                Begin
                INSERT INTO [dbo].[Tbl_Printer_Config_Dtl]
                           ([TPC_HDR_ID]
                           ,[TPC_Print_Size]
                           ,[TPC_Print_Profile]
                           ,[TPC_Print_Profile_disp]
                           ,[TPC_Terms_Condition]
                           ,[TPC_No_of_Copy]
                		   ,[TPC_DesignType])
                     VALUES
                           ( " & TV & "
                		  , '" & cmb_size.Text & "'
                          , '" & filechoose & "'
                           , '" & TextBox1.Text & "'
                           ,''
                           ,1
                		   ,'Customized')
                End", con)
                cmd.ExecuteNonQuery()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                'FILE MOVE
                Dim DNOCF As String = Path.GetDirectoryName(OpenFileDialog.FileName) 'Directory Name Of Choosen File
                If System.IO.File.Exists(tolocation & "\" & filechoose) Then
                Else
                    File.Move(DNOCF & "\" & filechoose, tolocation & "\" & filechoose)
                End If
                MessageBox.Show("updated")
                cmb_folder.SelectedIndex = 0
                Label3.Text = ""
                TextBox1.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub cmb_folder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_folder.SelectedIndexChanged
        SIZE_TYPE()
    End Sub
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TRANSACTION_TYPE()
    End Sub
End Class

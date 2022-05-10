Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlConnection
Imports System.Data
Public Partial Class rank
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	Dim con As New MySqlConnection
	
	
	Sub RankLoad(sender As Object, e As EventArgs)
		con = New mySqlConnection("Server=db4free.net,3306;Database=letradadostenata;User Id=letradadostenata;Password=dR86K3QUXuw!#Q6;old guids=true;")
		for i As Integer = 0 To 5
		Try

			
			Dim tdad As New MySqlDataAdapter("SELECT * FROM pontos",con)
			Dim bli As New BindingSource
			Dim dat As new DataTable
			
			con.Open
			tdad.Fill(dat)
			bli.DataSource = dat
			dataGridView1.DataSource = bli
			tdad.Update(dat)
			con.close
			DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Descending)
			 Exit for
		Catch
			If i = 5 Then
				MsgBox("não foi possivel conectar ao servidor")
			End If
		End Try
		next
	End Sub
	
	Sub Timer1Tick(sender As Object, e As EventArgs)
	Me.Text = " " & Me.Text
		If Me.Text.Length >  100 Then
			Me.Text = Me.Text.Replace(" ","")
		End If		
	End Sub
	
	
	Sub Label6Click(sender As Object, e As EventArgs)
		home.show
		Me.close
	End Sub
	
	Sub Timer2Tick(sender As Object, e As EventArgs)
		
	
	End Sub
	
	Sub DataGridView1ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
		DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Descending)
	End Sub
End Class


Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlConnection
Public Partial Class pontos
	Public Sub New()
		Me.InitializeComponent()
	
	End Sub
	
	Dim con As MySqlConnection
	
	
	Sub PontosLoad(sender As Object, e As EventArgs)
		
		label4.Text = pf
		con = New mySqlConnection("Server=localhost,3306;Database=me;User Id=me;Password=123;")
		
	End Sub
	
	
	Dim p_select As Integer = 0
	Sub PontosKeyDown(sender As Object, e As KeyEventArgs)
		Select e.KeyCode
		    Case Keys.Left
		    	If p_select > 0 Then
		    		p_select -= 1
		    	Else 
		    		p_select = 2
				End If
		    Case Keys.Right
			If p_select < 2 Then
		    		p_select += 1
		    	Else 
		    		p_select = 0
		    	End If	
		    Case Keys.Back
		    	Select p_select
		    	    Case 0
		    			label1.Text = ""
		    	    Case 1
		    	    	label2.Text = ""
		    	    Case 2
		    			label3.Text = ""
		    	End Select
		    	If p_select > 0 Then
		    		p_select -= 1
		    	End If
		    	
		End Select
	End Sub
	
	Sub Timer1Tick(sender As Object, e As EventArgs)
		
				label1.BackColor = Color.Gray	
				label2.BackColor = Color.Gray	
				label3.BackColor = Color.Gray	
		Select p_select
				
	Case 0
		label1.BackColor = Color.DarkGray
	Case 1
		label2.BackColor = Color.DarkGray
    Case 2
		label3.BackColor = Color.DarkGray
		End Select	
		
	End Sub
	Dim mandar As Boolean = false
	Sub Label5Click(sender As Object, e As EventArgs)
		nome_enviar = label1.Text & label2.Text & label3.Text
		If nome_enviar.Length = 3 And mandar = false then
			for i As Integer = 0 To 3
			Try
			
			Dim t As String = "INSERT INTO pontos (nome, pontos, minutos) VALUES ('" & nome_enviar & "','" & pontos_enviar & "','" & minutos_enviar &"' )"
			Dim sqcom As New MySqlCommand()
			sqcom.CommandText = t
			sqcom.Connection = con
			con.Open
			sqcom.ExecuteNonQuery()
			con.close
			
			mandar = True
			
			Exit for
		Catch 
			If i = 3 Then
				MsgBox("Não foi possivel mandar sua pontuação")
				
			End If
		End Try
		next
		Else
			End if
	End Sub
	
	
	Sub PontosKeyPress(sender As Object, e As KeyPressEventArgs)
		
		Dim c As Char = e.KeyChar
		
		If Not char.IsLetterOrDigit(c) Then
			e.Handled = False
		Else 
			
			Select p_select
				  Case 0
		    			label1.Text = UCase(c)
		    	    Case 1
		    	    	label2.Text = UCase(c)
		    	    Case 2
		    			label3.Text = UCase(c)
			End Select
		
			If p_select = 2 Then
				p_select = 0
			Else
				p_select += 1 
			End If
				End if
	End Sub
	
	Sub Timer2Tick(sender As Object, e As EventArgs)
			Me.Text = " " & Me.Text
		If Me.Text.Length >  100 Then
			Me.Text = Me.Text.Replace(" ","")
		End If
		If mandar = True Then
			rank.show
			Me.hide
		End If
	End Sub
	
	Sub Label6Click(sender As Object, e As EventArgs)
	Application.Exit
	End Sub
End Class

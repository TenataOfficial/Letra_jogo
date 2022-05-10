
Public Partial Class instruções
	Public Sub New()
	
		Me.InitializeComponent()
		
	
	End Sub
	Dim t_m As Integer = 0
	Sub Timer1Tick(sender As Object, e As EventArgs)
		
		Me.Text = " " & Me.Text
		
		If Me.Text.Length >  130 Then
			Me.Text = Me.Text.Replace(" ","")
			If t_m = 100 Then
				Me.Text = "torre de alexandria (wuttbgppqzro,294)"
			Else If t_m > 100 Then
				Me.Text = "instruções"
				t_m = 0
			End If
			t_m += 1
		End If	
	End Sub
	
	Sub Label6Click(sender As Object, e As EventArgs)
		home.show
Me.close		
	End Sub
	
	Sub Label11Click(sender As Object, e As EventArgs)
		If panel1.Visible =  False Then
			panel2.Visible = False 
			panel1.Visible = True
		Else
			panel1.Visible = False 
			panel2.Visible = True
		End If
	End Sub
	
	Sub InstruçõesLoad(sender As Object, e As EventArgs)
		panel2.Visible = False
	End Sub
	
	Sub Label12Click(sender As Object, e As EventArgs)
		If panel1.Visible =  False Then
			panel2.Visible = False 
			panel1.Visible = True
		Else
			panel1.Visible = False 
			panel2.Visible = True
		End If
	End Sub
	
	Sub InstruçõesKeyDown(sender As Object, e As KeyEventArgs)
		Select e.KeyCode
			Case Keys.Left
				If panel1.Visible =  False Then
			panel2.Visible = False 
			panel1.Visible = True
		Else
			panel1.Visible = False 
			panel2.Visible = True
		End If
			Case Keys.Right
				If panel1.Visible =  False Then
			panel2.Visible = False 
			panel1.Visible = True
		Else
			panel1.Visible = False 
			panel2.Visible = True
		End If
		End Select 
	End Sub
End Class

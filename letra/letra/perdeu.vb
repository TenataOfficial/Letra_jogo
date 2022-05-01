
Public Partial Class perdeu
	Public Sub New()
	
		Me.InitializeComponent()
		
	End Sub
	
	
	Sub Timer1Tick(sender As Object, e As EventArgs)
Me.Text = " " & Me.Text
		If Me.Text.Length >  100 Then
			Me.Text = Me.Text.Replace("  ","")
		End If			
	End Sub
	
	Sub Label6Click(sender As Object, e As EventArgs)
		Application.Restart
	End Sub
	
	Sub Label1Click(sender As Object, e As EventArgs)
		Application.Exit
	End Sub
	
	Sub PerdeuLoad(sender As Object, e As EventArgs)
	label2.Text = "Sua palavra era" & vbNewLine & pf.ToUpper
	End Sub
	
	
End Class

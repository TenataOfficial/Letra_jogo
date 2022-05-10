
Public Partial Class home
	Public Sub New()
		
		Me.InitializeComponent()
		
	End Sub
	
	Dim i As Integer = 0
	Dim i2 As Integer = 1
	Dim i3 As Integer = 4
	Dim b As Boolean = True
	Dim b2 As Boolean = True
	Dim b3 As Boolean = True
	Sub Timer1Tick(sender As Object, e As EventArgs)
		
		If b = True Then
			If i = 0 Then
				b = False
				If label3.Top <= 0 - label3.Height Then
					label3.Top = 79
					label4.Top = 79
					label5.Top = 79
					label6.Top = 79
					label7.Top = 79
				End If
			Else
				i -= 1
			End If
			
		Else 
			If i = 10 Then
				b = True
			Else 
				i += 1
			End If
		End If
		
		If b2 = True Then
			If i2 = 0 Then
				b2 = False
			Else
				i2 -= 1
			End If
			
		Else 
			If i2 = 10 Then
				b2 = True
			Else 
				i2 += 1
			End If
		End If
		
		If b3 = True Then
			If i3 = 0 Then
				b3 = False
			Else
				i3 -= 1
			End If
			
		Else 
			If i3 = 10 Then
				b3 = True
			Else 
				i3 += 1
			End If
		End If
		
			If i <= 5 Then
				label5.Top -=1
				
			Else
				label5.Top +=1
			
			End If
			If i2 <= 5 Then
				
				label6.Top -=1
				label4.Top -=1
			Else
				label6.Top +=1
				label4.Top +=1
			End If
			If i3 <= 5 Then
				label7.Top -=1
				label3.Top -=1
			Else
				label7.Top +=1
				label3.Top +=1
			End If
			
			
			
	End Sub
	
	
	Sub Label1Click(sender As Object, e As EventArgs)
		MainForm.show
		Me.Close
	End Sub
	
	Sub HomeLoad(sender As Object, e As EventArgs)

	End Sub
	
	Sub Label2Click(sender As Object, e As EventArgs)
		rank.show
		Me.Hide
	End Sub
	
	Sub Label31Click(sender As Object, e As EventArgs)
Application.Exit		
	End Sub
	
	Sub Label8Click(sender As Object, e As EventArgs)
		Me.Hide
		instruções.show
	End Sub
	
	Dim x As New Random
	Sub Label6Click(sender As Object, e As EventArgs)
		label6.BackColor = Color.FromArgb(x.Next(0,255),x.Next(0,255),x.Next(0,255))
	End Sub
	
	Sub Label7Click(sender As Object, e As EventArgs)
		label7.BackColor = Color.FromArgb(x.Next(0,255),x.Next(0,255),x.Next(0,255))
	End Sub
	
	Sub Label5Click(sender As Object, e As EventArgs)
		label5.BackColor = Color.FromArgb(x.Next(0,255),x.Next(0,255),x.Next(0,255))
	End Sub
	
	Sub Label4Click(sender As Object, e As EventArgs)
		label4.BackColor = Color.FromArgb(x.Next(0,255),x.Next(0,255),x.Next(0,255))
	End Sub
	
	Sub Label3Click(sender As Object, e As EventArgs)
		label3.BackColor = Color.FromArgb(x.Next(0,255),x.Next(0,255),x.Next(0,255))
	End Sub
End Class

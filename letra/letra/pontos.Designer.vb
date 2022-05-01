'
' Created by SharpDevelop.
' User: Tenataz
' Date: 30/04/2022
' Time: 18:34
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class pontos
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.label5 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout
		'
		'label3
		'
		Me.label3.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label3.Location = New System.Drawing.Point(109, 135)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(20, 22)
		Me.label3.TabIndex = 3
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label2
		'
		Me.label2.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label2.Location = New System.Drawing.Point(83, 135)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(20, 22)
		Me.label2.TabIndex = 2
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label1.Location = New System.Drawing.Point(57, 135)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(20, 22)
		Me.label1.TabIndex = 1
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(41, 17)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(106, 95)
		Me.label4.TabIndex = 4
		Me.label4.Text = "label4"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'timer1
		'
		Me.timer1.Enabled = true
		Me.timer1.Interval = 1
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'label5
		'
		Me.label5.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label5.Location = New System.Drawing.Point(57, 186)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(72, 22)
		Me.label5.TabIndex = 6
		Me.label5.Text = "Registar"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label5.Click, AddressOf Me.Label5Click
		'
		'label6
		'
		Me.label6.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label6.Location = New System.Drawing.Point(57, 217)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(72, 22)
		Me.label6.TabIndex = 7
		Me.label6.Text = "Sair"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label6.Click, AddressOf Me.Label6Click
		'
		'timer2
		'
		Me.timer2.Enabled = true
		Me.timer2.Interval = 50
		AddHandler Me.timer2.Tick, AddressOf Me.Timer2Tick
		'
		'pontos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(172, 254)
		Me.ControlBox = false
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "pontos"
		Me.ShowIcon = false
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "letra"
		AddHandler Load, AddressOf Me.PontosLoad
		AddHandler KeyDown, AddressOf Me.PontosKeyDown
		AddHandler KeyPress, AddressOf Me.PontosKeyPress
		Me.ResumeLayout(false)
	End Sub
	Private timer2 As System.Windows.Forms.Timer
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private timer1 As System.Windows.Forms.Timer
	Private label4 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
End Class

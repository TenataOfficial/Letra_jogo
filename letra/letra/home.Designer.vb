'
' Created by SharpDevelop.
' User: CEEP
' Date: 02/05/2022
' Time: 12:09
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class home
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
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.label31 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'timer1
		'
		Me.timer1.Enabled = true
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'label31
		'
		Me.label31.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label31.Location = New System.Drawing.Point(119, 211)
		Me.label31.Name = "label31"
		Me.label31.Size = New System.Drawing.Size(47, 20)
		Me.label31.TabIndex = 9
		Me.label31.Text = "Sair"
		Me.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label31.Click, AddressOf Me.Label31Click
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label1.Location = New System.Drawing.Point(108, 120)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(72, 20)
		Me.label1.TabIndex = 10
		Me.label1.Text = "Começar"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label1.Click, AddressOf Me.Label1Click
		'
		'label2
		'
		Me.label2.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label2.Location = New System.Drawing.Point(119, 179)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(47, 20)
		Me.label2.TabIndex = 11
		Me.label2.Text = "Rank"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label2.Click, AddressOf Me.Label2Click
		'
		'label5
		'
		Me.label5.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label5.Location = New System.Drawing.Point(135, 79)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(20, 22)
		Me.label5.TabIndex = 15
		Me.label5.Text = "T"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label5.Click, AddressOf Me.Label5Click
		'
		'label4
		'
		Me.label4.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label4.Location = New System.Drawing.Point(161, 79)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(20, 22)
		Me.label4.TabIndex = 16
		Me.label4.Text = "R"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label4.Click, AddressOf Me.Label4Click
		'
		'label3
		'
		Me.label3.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label3.Location = New System.Drawing.Point(187, 79)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(20, 22)
		Me.label3.TabIndex = 14
		Me.label3.Text = "A"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label3.Click, AddressOf Me.Label3Click
		'
		'label6
		'
		Me.label6.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label6.Location = New System.Drawing.Point(83, 79)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(20, 22)
		Me.label6.TabIndex = 12
		Me.label6.Text = "L"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label6.Click, AddressOf Me.Label6Click
		'
		'label7
		'
		Me.label7.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label7.Location = New System.Drawing.Point(109, 79)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(20, 22)
		Me.label7.TabIndex = 13
		Me.label7.Text = "E"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label7.Click, AddressOf Me.Label7Click
		'
		'label8
		'
		Me.label8.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label8.Location = New System.Drawing.Point(113, 149)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(62, 20)
		Me.label8.TabIndex = 17
		Me.label8.Text = "instruções"
		Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label8.Click, AddressOf Me.Label8Click
		'
		'home
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 261)
		Me.ControlBox = false
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.label31)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "home"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "LETRA"
		AddHandler Load, AddressOf Me.HomeLoad
		Me.ResumeLayout(false)
	End Sub
	Private label8 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private label31 As System.Windows.Forms.Label
	Private timer1 As System.Windows.Forms.Timer
End Class

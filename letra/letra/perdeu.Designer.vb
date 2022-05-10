'
' Created by SharpDevelop.
' User: Tenataz
' Date: 01/05/2022
' Time: 17:57
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class perdeu
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(perdeu))
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.label1 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'timer1
		'
		Me.timer1.Enabled = true
		Me.timer1.Interval = 50
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label1.Location = New System.Drawing.Point(105, 216)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(72, 22)
		Me.label1.TabIndex = 11
		Me.label1.Text = "Sair"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label1.Click, AddressOf Me.Label1Click
		'
		'label6
		'
		Me.label6.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label6.Location = New System.Drawing.Point(105, 179)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(72, 22)
		Me.label6.TabIndex = 10
		Me.label6.Text = "Voltar ao jogo"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label6.Click, AddressOf Me.Label6Click
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(89, 9)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 81)
		Me.label2.TabIndex = 12
		Me.label2.Text = "label2"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pictureBox1
		'
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(90, 78)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(99, 87)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox1.TabIndex = 13
		Me.pictureBox1.TabStop = false
		'
		'perdeu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 262)
		Me.ControlBox = false
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.label6)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "perdeu"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Você PERDEU"
		AddHandler Load, AddressOf Me.PerdeuLoad
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private label2 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private timer1 As System.Windows.Forms.Timer
End Class

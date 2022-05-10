'
' Created by SharpDevelop.
' User: CEEP
' Date: 04/05/2022
' Time: 16:14
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class instruções
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(instruções))
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.pictureBox2 = New System.Windows.Forms.PictureBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.label10 = New System.Windows.Forms.Label()
		Me.label9 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.pictureBox5 = New System.Windows.Forms.PictureBox()
		Me.pictureBox3 = New System.Windows.Forms.PictureBox()
		Me.pictureBox4 = New System.Windows.Forms.PictureBox()
		Me.label11 = New System.Windows.Forms.Label()
		Me.label12 = New System.Windows.Forms.Label()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		CType(Me.pictureBox5,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'timer1
		'
		Me.timer1.Enabled = true
		Me.timer1.Interval = 50
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'pictureBox1
		'
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(0, 2)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(198, 180)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox1.TabIndex = 0
		Me.pictureBox1.TabStop = false
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(183, 24)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(253, 30)
		Me.label1.TabIndex = 1
		Me.label1.Text = "LETRA COM FUNDO AMARELO - TEM A LETRA NA PALAVRA MAS NÃO NAQUELA POSIÇÃO"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(183, 64)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(253, 30)
		Me.label2.TabIndex = 2
		Me.label2.Text = "LETRA COM FUNDO PRETO - NÃO TEM A LETRA NA PALAVRA"
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(183, 105)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(253, 30)
		Me.label3.TabIndex = 3
		Me.label3.Text = "LETRA COM FUNDO VERDE - TEM A LETRA NA PALAVRA  NAQUELA POSIÇÃO"
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(183, 145)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(253, 30)
		Me.label4.TabIndex = 4
		Me.label4.Text = "SE A PALAVRA ESTIVER CORRETA TODOS ESPAÇOS FICARAM VERDES"
		'
		'pictureBox2
		'
		Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"),System.Drawing.Image)
		Me.pictureBox2.Location = New System.Drawing.Point(37, 192)
		Me.pictureBox2.Name = "pictureBox2"
		Me.pictureBox2.Size = New System.Drawing.Size(110, 27)
		Me.pictureBox2.TabIndex = 5
		Me.pictureBox2.TabStop = false
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(153, 188)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(283, 41)
		Me.label5.TabIndex = 6
		Me.label5.Text = "TERMINE NO MENOR TEMPO E CONSIGA MAIOR PONTUAÇÃO,  O NUMERO DE TENTATIVAS TAMBEM "& _ 
		"INFLUENCIA NO RESULTADO DOS PONTOS"
		'
		'label6
		'
		Me.label6.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label6.Location = New System.Drawing.Point(342, 322)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(72, 22)
		Me.label6.TabIndex = 9
		Me.label6.Text = "Voltar ao jogo"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label6.Click, AddressOf Me.Label6Click
		'
		'panel1
		'
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Controls.Add(Me.label5)
		Me.panel1.Controls.Add(Me.pictureBox2)
		Me.panel1.Controls.Add(Me.label2)
		Me.panel1.Controls.Add(Me.label4)
		Me.panel1.Controls.Add(Me.label3)
		Me.panel1.Controls.Add(Me.pictureBox1)
		Me.panel1.Location = New System.Drawing.Point(5, 22)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(426, 281)
		Me.panel1.TabIndex = 10
		'
		'panel2
		'
		Me.panel2.Controls.Add(Me.label10)
		Me.panel2.Controls.Add(Me.label9)
		Me.panel2.Controls.Add(Me.label8)
		Me.panel2.Controls.Add(Me.label7)
		Me.panel2.Controls.Add(Me.pictureBox5)
		Me.panel2.Controls.Add(Me.pictureBox3)
		Me.panel2.Controls.Add(Me.pictureBox4)
		Me.panel2.Location = New System.Drawing.Point(5, 12)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(423, 307)
		Me.panel2.TabIndex = 11
		'
		'label10
		'
		Me.label10.Location = New System.Drawing.Point(23, 211)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(388, 47)
		Me.label10.TabIndex = 6
		Me.label10.Text = "SOMENTE TEXTO É ACEITO NO JOGO MAS ESSA REGRA NÃO SE APLICA QUANDO ESTIVER REGIST"& _ 
		"RANDO SEU NOME NO RANK ^-^"
		'
		'label9
		'
		Me.label9.Location = New System.Drawing.Point(144, 155)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(253, 30)
		Me.label9.TabIndex = 5
		Me.label9.Text = "APAGA OS DADOS DA CELULA"
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(144, 95)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(253, 30)
		Me.label8.TabIndex = 4
		Me.label8.Text = "ENTER PARA CONFIRMAR O ENVIO DA RESPOSTA"
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(144, 34)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(253, 30)
		Me.label7.TabIndex = 3
		Me.label7.Text = "MOVA AS CASAS COM AS SETAS DO TECLADO"
		'
		'pictureBox5
		'
		Me.pictureBox5.Image = CType(resources.GetObject("pictureBox5.Image"),System.Drawing.Image)
		Me.pictureBox5.Location = New System.Drawing.Point(34, 86)
		Me.pictureBox5.Name = "pictureBox5"
		Me.pictureBox5.Size = New System.Drawing.Size(104, 55)
		Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox5.TabIndex = 2
		Me.pictureBox5.TabStop = false
		'
		'pictureBox3
		'
		Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"),System.Drawing.Image)
		Me.pictureBox3.Location = New System.Drawing.Point(23, 10)
		Me.pictureBox3.Name = "pictureBox3"
		Me.pictureBox3.Size = New System.Drawing.Size(151, 70)
		Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox3.TabIndex = 0
		Me.pictureBox3.TabStop = false
		'
		'pictureBox4
		'
		Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"),System.Drawing.Image)
		Me.pictureBox4.Location = New System.Drawing.Point(32, 128)
		Me.pictureBox4.Name = "pictureBox4"
		Me.pictureBox4.Size = New System.Drawing.Size(115, 92)
		Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox4.TabIndex = 1
		Me.pictureBox4.TabStop = false
		'
		'label11
		'
		Me.label11.BackColor = System.Drawing.Color.Yellow
		Me.label11.Location = New System.Drawing.Point(-2, 151)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(17, 12)
		Me.label11.TabIndex = 12
		Me.label11.Text = "<"
		AddHandler Me.label11.Click, AddressOf Me.Label11Click
		'
		'label12
		'
		Me.label12.BackColor = System.Drawing.Color.Yellow
		Me.label12.Location = New System.Drawing.Point(423, 151)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(17, 12)
		Me.label12.TabIndex = 13
		Me.label12.Text = ">"
		AddHandler Me.label12.Click, AddressOf Me.Label12Click
		'
		'instruções
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(438, 353)
		Me.ControlBox = false
		Me.Controls.Add(Me.label12)
		Me.Controls.Add(Me.label11)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "instruções"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "instruções"
		AddHandler Load, AddressOf Me.InstruçõesLoad
		AddHandler KeyDown, AddressOf Me.InstruçõesKeyDown
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel1.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		CType(Me.pictureBox5,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox3,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox4,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private label12 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private pictureBox4 As System.Windows.Forms.PictureBox
	Private pictureBox3 As System.Windows.Forms.PictureBox
	Private pictureBox5 As System.Windows.Forms.PictureBox
	Private label7 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private label10 As System.Windows.Forms.Label
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private pictureBox2 As System.Windows.Forms.PictureBox
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private timer1 As System.Windows.Forms.Timer
End Class

'
' Created by SharpDevelop.
' User: Tenataz
' Date: 01/05/2022
' Time: 08:13
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class rank
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
		Me.label6 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'timer1
		'
		Me.timer1.Enabled = true
		Me.timer1.Interval = 50
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'label6
		'
		Me.label6.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label6.Location = New System.Drawing.Point(124, 253)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(72, 22)
		Me.label6.TabIndex = 8
		Me.label6.Text = "Voltar ao jogo"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label6.Click, AddressOf Me.Label6Click
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label1.Location = New System.Drawing.Point(243, 253)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(72, 22)
		Me.label1.TabIndex = 9
		Me.label1.Text = "Sair"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label1.Click, AddressOf Me.Label1Click
		'
		'timer2
		'
		Me.timer2.Enabled = true
		Me.timer2.Interval = 1000
		AddHandler Me.timer2.Tick, AddressOf Me.Timer2Tick
		'
		'dataGridView1
		'
		Me.dataGridView1.AllowUserToAddRows = false
		Me.dataGridView1.AllowUserToDeleteRows = false
		Me.dataGridView1.AllowUserToResizeColumns = false
		Me.dataGridView1.AllowUserToResizeRows = false
		Me.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
		Me.dataGridView1.Location = New System.Drawing.Point(3, 0)
		Me.dataGridView1.MultiSelect = false
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.ReadOnly = true
		Me.dataGridView1.RowHeadersVisible = false
		Me.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dataGridView1.ShowCellToolTips = false
		Me.dataGridView1.ShowEditingIcon = false
		Me.dataGridView1.ShowRowErrors = false
		Me.dataGridView1.Size = New System.Drawing.Size(322, 250)
		Me.dataGridView1.StandardTab = true
		Me.dataGridView1.TabIndex = 0
		AddHandler Me.dataGridView1.ColumnHeaderMouseClick, AddressOf Me.DataGridView1ColumnHeaderMouseClick
		'
		'rank
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
		Me.ClientSize = New System.Drawing.Size(327, 279)
		Me.ControlBox = false
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.dataGridView1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "rank"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "rank"
		AddHandler Load, AddressOf Me.RankLoad
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private timer2 As System.Windows.Forms.Timer
	Private label1 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private timer1 As System.Windows.Forms.Timer
End Class

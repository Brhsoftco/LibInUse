'
' Created by SharpDevelop.
' User: Internet
' Date: 8/11/2018
' Time: 5:27 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
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
        Me.picBackdrop = New System.Windows.Forms.PictureBox()
        Me.btnUnlock = New System.Windows.Forms.Button()
        Me.lblLockedTL = New System.Windows.Forms.Label()
        Me.lblLockedTR = New System.Windows.Forms.Label()
        Me.lblLockedBR = New System.Windows.Forms.Label()
        Me.lblLockedBL = New System.Windows.Forms.Label()
        CType(Me.picBackdrop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBackdrop
        '
        Me.picBackdrop.BackColor = System.Drawing.Color.Black
        Me.picBackdrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBackdrop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBackdrop.Location = New System.Drawing.Point(0, 0)
        Me.picBackdrop.Margin = New System.Windows.Forms.Padding(2)
        Me.picBackdrop.Name = "picBackdrop"
        Me.picBackdrop.Size = New System.Drawing.Size(1280, 720)
        Me.picBackdrop.TabIndex = 0
        Me.picBackdrop.TabStop = False
        '
        'btnUnlock
        '
        Me.btnUnlock.Location = New System.Drawing.Point(525, 20)
        Me.btnUnlock.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(154, 29)
        Me.btnUnlock.TabIndex = 1
        Me.btnUnlock.Text = "UNLOCK"
        Me.btnUnlock.UseVisualStyleBackColor = True
        '
        'lblLockedTL
        '
        Me.lblLockedTL.AutoSize = True
        Me.lblLockedTL.BackColor = System.Drawing.Color.Black
        Me.lblLockedTL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLockedTL.ForeColor = System.Drawing.Color.White
        Me.lblLockedTL.Location = New System.Drawing.Point(20, 20)
        Me.lblLockedTL.Name = "lblLockedTL"
        Me.lblLockedTL.Size = New System.Drawing.Size(111, 29)
        Me.lblLockedTL.TabIndex = 2
        Me.lblLockedTL.Text = "LOCKED"
        '
        'lblLockedTR
        '
        Me.lblLockedTR.AutoSize = True
        Me.lblLockedTR.BackColor = System.Drawing.Color.Black
        Me.lblLockedTR.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLockedTR.ForeColor = System.Drawing.Color.White
        Me.lblLockedTR.Location = New System.Drawing.Point(1149, 20)
        Me.lblLockedTR.Name = "lblLockedTR"
        Me.lblLockedTR.Size = New System.Drawing.Size(111, 29)
        Me.lblLockedTR.TabIndex = 3
        Me.lblLockedTR.Text = "LOCKED"
        '
        'lblLockedBR
        '
        Me.lblLockedBR.AutoSize = True
        Me.lblLockedBR.BackColor = System.Drawing.Color.Black
        Me.lblLockedBR.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLockedBR.ForeColor = System.Drawing.Color.White
        Me.lblLockedBR.Location = New System.Drawing.Point(1149, 671)
        Me.lblLockedBR.Name = "lblLockedBR"
        Me.lblLockedBR.Size = New System.Drawing.Size(111, 29)
        Me.lblLockedBR.TabIndex = 4
        Me.lblLockedBR.Text = "LOCKED"
        '
        'lblLockedBL
        '
        Me.lblLockedBL.AutoSize = True
        Me.lblLockedBL.BackColor = System.Drawing.Color.Black
        Me.lblLockedBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLockedBL.ForeColor = System.Drawing.Color.White
        Me.lblLockedBL.Location = New System.Drawing.Point(20, 671)
        Me.lblLockedBL.Name = "lblLockedBL"
        Me.lblLockedBL.Size = New System.Drawing.Size(111, 29)
        Me.lblLockedBL.TabIndex = 5
        Me.lblLockedBL.Text = "LOCKED"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.lblLockedBL)
        Me.Controls.Add(Me.lblLockedBR)
        Me.Controls.Add(Me.lblLockedTR)
        Me.Controls.Add(Me.lblLockedTL)
        Me.Controls.Add(Me.btnUnlock)
        Me.Controls.Add(Me.picBackdrop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computer in Use"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picBackdrop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnUnlock As System.Windows.Forms.Button
	Private picBackdrop As System.Windows.Forms.PictureBox
    Friend WithEvents lblLockedTL As Label
    Friend WithEvents lblLockedTR As Label
    Friend WithEvents lblLockedBR As Label
    Friend WithEvents lblLockedBL As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbLoop = New System.Windows.Forms.ListBox()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.lblJP = New System.Windows.Forms.Label()
        Me.btnEraser = New System.Windows.Forms.Button()
        Me.txtTeks = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbLoop
        '
        Me.lbLoop.FormattingEnabled = True
        Me.lbLoop.Location = New System.Drawing.Point(43, 104)
        Me.lbLoop.Name = "lbLoop"
        Me.lbLoop.Size = New System.Drawing.Size(308, 251)
        Me.lbLoop.TabIndex = 0
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(61, 398)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 23)
        Me.btnProses.TabIndex = 1
        Me.btnProses.Text = "&Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'btnOut
        '
        Me.btnOut.Location = New System.Drawing.Point(258, 398)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(75, 23)
        Me.btnOut.TabIndex = 2
        Me.btnOut.Text = "&Keluar"
        Me.btnOut.UseVisualStyleBackColor = True
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(50, 25)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(73, 13)
        Me.lblInput.TabIndex = 3
        Me.lblInput.Text = "Inputkan Text"
        '
        'lblJP
        '
        Me.lblJP.AutoSize = True
        Me.lblJP.Location = New System.Drawing.Point(50, 63)
        Me.lblJP.Name = "lblJP"
        Me.lblJP.Size = New System.Drawing.Size(97, 13)
        Me.lblJP.TabIndex = 4
        Me.lblJP.Text = "Jumlah Perulangan"
        '
        'btnEraser
        '
        Me.btnEraser.Location = New System.Drawing.Point(161, 398)
        Me.btnEraser.Name = "btnEraser"
        Me.btnEraser.Size = New System.Drawing.Size(75, 23)
        Me.btnEraser.TabIndex = 5
        Me.btnEraser.Text = "&Hapus"
        Me.btnEraser.UseVisualStyleBackColor = True
        '
        'txtTeks
        '
        Me.txtTeks.Location = New System.Drawing.Point(181, 23)
        Me.txtTeks.Name = "txtTeks"
        Me.txtTeks.Size = New System.Drawing.Size(163, 20)
        Me.txtTeks.TabIndex = 6
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(181, 56)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(163, 20)
        Me.txtJumlah.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 450)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtTeks)
        Me.Controls.Add(Me.btnEraser)
        Me.Controls.Add(Me.lblJP)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.btnOut)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.lbLoop)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbLoop As ListBox
    Friend WithEvents btnProses As Button
    Friend WithEvents btnOut As Button
    Friend WithEvents lblInput As Label
    Friend WithEvents lblJP As Label
    Friend WithEvents btnEraser As Button
    Friend WithEvents txtTeks As TextBox
    Friend WithEvents txtJumlah As TextBox
End Class

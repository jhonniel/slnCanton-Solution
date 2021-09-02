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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstUseful = New System.Windows.Forms.ListBox()
        Me.txtAsset = New System.Windows.Forms.TextBox()
        Me.txtSalvage = New System.Windows.Forms.TextBox()
        Me.btnDisplayDep = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar()
        Me.lblDoubleD = New System.Windows.Forms.TextBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.lblSum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asset cost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salvage value:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Useful life:"
        '
        'lstUseful
        '
        Me.lstUseful.FormattingEnabled = True
        Me.lstUseful.Location = New System.Drawing.Point(231, 34)
        Me.lstUseful.Name = "lstUseful"
        Me.lstUseful.Size = New System.Drawing.Size(53, 56)
        Me.lstUseful.TabIndex = 3
        '
        'txtAsset
        '
        Me.txtAsset.Location = New System.Drawing.Point(55, 34)
        Me.txtAsset.Name = "txtAsset"
        Me.txtAsset.Size = New System.Drawing.Size(71, 20)
        Me.txtAsset.TabIndex = 4
        '
        'txtSalvage
        '
        Me.txtSalvage.Location = New System.Drawing.Point(145, 34)
        Me.txtSalvage.Name = "txtSalvage"
        Me.txtSalvage.Size = New System.Drawing.Size(75, 20)
        Me.txtSalvage.TabIndex = 5
        '
        'btnDisplayDep
        '
        Me.btnDisplayDep.Location = New System.Drawing.Point(55, 107)
        Me.btnDisplayDep.Name = "btnDisplayDep"
        Me.btnDisplayDep.Size = New System.Drawing.Size(165, 23)
        Me.btnDisplayDep.TabIndex = 6
        Me.btnDisplayDep.Text = "Display Depreciation Schedules"
        Me.btnDisplayDep.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(226, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VScrollBar2)
        Me.GroupBox1.Controls.Add(Me.lblDoubleD)
        Me.GroupBox1.Controls.Add(Me.VScrollBar1)
        Me.GroupBox1.Controls.Add(Me.lblSum)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 195)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'VScrollBar2
        '
        Me.VScrollBar2.Location = New System.Drawing.Point(146, 46)
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(17, 117)
        Me.VScrollBar2.TabIndex = 18
        '
        'lblDoubleD
        '
        Me.lblDoubleD.Location = New System.Drawing.Point(21, 46)
        Me.lblDoubleD.Multiline = True
        Me.lblDoubleD.Name = "lblDoubleD"
        Me.lblDoubleD.Size = New System.Drawing.Size(122, 117)
        Me.lblDoubleD.TabIndex = 17
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(305, 46)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 117)
        Me.VScrollBar1.TabIndex = 16
        '
        'lblSum
        '
        Me.lblSum.Location = New System.Drawing.Point(184, 46)
        Me.lblSum.Multiline = True
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(118, 117)
        Me.lblSum.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(181, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Sum-of-the-years's digits"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Double-declining balance:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 359)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnDisplayDep)
        Me.Controls.Add(Me.txtSalvage)
        Me.Controls.Add(Me.txtAsset)
        Me.Controls.Add(Me.lstUseful)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Canton Manufacturing Company"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstUseful As ListBox
    Friend WithEvents txtAsset As TextBox
    Friend WithEvents txtSalvage As TextBox
    Friend WithEvents btnDisplayDep As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSum As TextBox
    Friend WithEvents VScrollBar2 As VScrollBar
    Friend WithEvents lblDoubleD As TextBox
    Friend WithEvents VScrollBar1 As VScrollBar
End Class

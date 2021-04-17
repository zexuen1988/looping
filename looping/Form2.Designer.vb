<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.BtnClick = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.LstAnswer = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BtnClick
        '
        Me.BtnClick.Location = New System.Drawing.Point(291, 225)
        Me.BtnClick.Name = "BtnClick"
        Me.BtnClick.Size = New System.Drawing.Size(75, 23)
        Me.BtnClick.TabIndex = 0
        Me.BtnClick.Text = "Click"
        Me.BtnClick.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(291, 142)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Label1"
        '
        'LstAnswer
        '
        Me.LstAnswer.FormattingEnabled = True
        Me.LstAnswer.ItemHeight = 16
        Me.LstAnswer.Location = New System.Drawing.Point(490, 110)
        Me.LstAnswer.Name = "LstAnswer"
        Me.LstAnswer.Size = New System.Drawing.Size(203, 180)
        Me.LstAnswer.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LstAnswer)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.BtnClick)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClick As Button
    Friend WithEvents lblName As Label
    Friend WithEvents LstAnswer As ListBox
End Class

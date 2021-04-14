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
        Me.BtnEnter = New System.Windows.Forms.Button()
        Me.LstAnswer = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BtnEnter
        '
        Me.BtnEnter.Location = New System.Drawing.Point(281, 296)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(123, 42)
        Me.BtnEnter.TabIndex = 2
        Me.BtnEnter.Text = "Enter"
        Me.BtnEnter.UseVisualStyleBackColor = True
        '
        'LstAnswer
        '
        Me.LstAnswer.FormattingEnabled = True
        Me.LstAnswer.ItemHeight = 16
        Me.LstAnswer.Location = New System.Drawing.Point(240, 31)
        Me.LstAnswer.Name = "LstAnswer"
        Me.LstAnswer.Size = New System.Drawing.Size(212, 228)
        Me.LstAnswer.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LstAnswer)
        Me.Controls.Add(Me.BtnEnter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnEnter As Button
    Friend WithEvents LstAnswer As ListBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipCalculator
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
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Tiptextbox = New System.Windows.Forms.TextBox()
        Me.Tiptotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'totalTextBox
        '
        Me.totalTextBox.Location = New System.Drawing.Point(202, 183)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.totalTextBox.TabIndex = 0
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(12, 12)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 23)
        Me.calcButton.TabIndex = 1
        Me.calcButton.Text = "Check"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(199, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bill Total"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(78, 261)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(47, 20)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "5%"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(78, 287)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(54, 20)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "10%"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(78, 313)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(54, 20)
        Me.RadioButton3.TabIndex = 6
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "20%"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Tiptextbox
        '
        Me.Tiptextbox.Location = New System.Drawing.Point(381, 183)
        Me.Tiptextbox.Name = "Tiptextbox"
        Me.Tiptextbox.Size = New System.Drawing.Size(100, 22)
        Me.Tiptextbox.TabIndex = 7
        '
        'Tiptotal
        '
        Me.Tiptotal.AutoSize = True
        Me.Tiptotal.Location = New System.Drawing.Point(381, 161)
        Me.Tiptotal.Name = "Tiptotal"
        Me.Tiptotal.Size = New System.Drawing.Size(58, 16)
        Me.Tiptotal.TabIndex = 8
        Me.Tiptotal.Text = "TipTotal"
        '
        'TipCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Tiptotal)
        Me.Controls.Add(Me.Tiptextbox)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.totalTextBox)
        Me.Name = "TipCalculator"
        Me.Text = "TipCalculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents totalTextBox As TextBox
    Friend WithEvents calcButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Tiptextbox As TextBox
    Friend WithEvents Tiptotal As Label
End Class

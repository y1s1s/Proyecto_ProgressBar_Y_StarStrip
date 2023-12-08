<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ProgressBar1 = New ProgressBar()
        CheckedListBox1 = New CheckedListBox()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        ProgressBar1.Location = New Point(253, 242)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(236, 23)
        ProgressBar1.TabIndex = 0
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"Eres Programador?", "Eres Alcoholico?", "Eres Drogadicto?", "Eres calvo (o te estas quedando)?"})
        CheckedListBox1.Location = New Point(253, 115)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(236, 94)
        CheckedListBox1.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CheckedListBox1)
        Controls.Add(ProgressBar1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Timer1 As Timer
End Class

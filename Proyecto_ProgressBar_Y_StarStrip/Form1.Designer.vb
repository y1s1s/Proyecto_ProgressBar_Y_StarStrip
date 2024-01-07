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
        Timer1 = New Timer(components)
        bt_ejemplo = New Button()
        bt_reset = New Button()
        Label1 = New Label()
        bt_statusStrip = New Button()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        ProgressBar1.Location = New Point(12, 185)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(776, 23)
        ProgressBar1.TabIndex = 0
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' bt_ejemplo
        ' 
        bt_ejemplo.Location = New Point(266, 214)
        bt_ejemplo.Name = "bt_ejemplo"
        bt_ejemplo.Size = New Size(122, 23)
        bt_ejemplo.TabIndex = 3
        bt_ejemplo.Text = "Ejemplo"
        bt_ejemplo.UseVisualStyleBackColor = True
        ' 
        ' bt_reset
        ' 
        bt_reset.Location = New Point(394, 214)
        bt_reset.Name = "bt_reset"
        bt_reset.Size = New Size(122, 23)
        bt_reset.TabIndex = 4
        bt_reset.Text = "Reiniciar"
        bt_reset.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(12, 158)
        Label1.Name = "Label1"
        Label1.Size = New Size(776, 23)
        Label1.TabIndex = 5
        Label1.Text = "Label1"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' bt_statusStrip
        ' 
        bt_statusStrip.Location = New Point(347, 352)
        bt_statusStrip.Name = "bt_statusStrip"
        bt_statusStrip.Size = New Size(75, 23)
        bt_statusStrip.TabIndex = 6
        bt_statusStrip.Text = "StatusStrip"
        bt_statusStrip.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(bt_statusStrip)
        Controls.Add(Label1)
        Controls.Add(bt_reset)
        Controls.Add(bt_ejemplo)
        Controls.Add(ProgressBar1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bt_ejemplo As Button
    Friend WithEvents bt_reset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_statusStrip As Button
End Class

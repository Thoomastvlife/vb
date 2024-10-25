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
        btn01 = New Button()
        btn02 = New Button()
        btn03 = New Button()
        btn04 = New Button()
        btn05 = New Button()
        btn_print = New Button()
        txt01 = New TextBox()
        txt03 = New TextBox()
        txt05 = New TextBox()
        txt04 = New TextBox()
        txt02 = New TextBox()
        pd = New Printing.PrintDocument()
        SuspendLayout()
        ' 
        ' btn01
        ' 
        btn01.Location = New Point(12, 57)
        btn01.Name = "btn01"
        btn01.Size = New Size(75, 23)
        btn01.TabIndex = 0
        btn01.Text = "第一題"
        btn01.UseVisualStyleBackColor = True
        ' 
        ' btn02
        ' 
        btn02.Location = New Point(302, 57)
        btn02.Name = "btn02"
        btn02.Size = New Size(75, 23)
        btn02.TabIndex = 1
        btn02.Text = "第二題"
        btn02.UseVisualStyleBackColor = True
        ' 
        ' btn03
        ' 
        btn03.Location = New Point(542, 57)
        btn03.Name = "btn03"
        btn03.Size = New Size(75, 23)
        btn03.TabIndex = 2
        btn03.Text = "第三題"
        btn03.UseVisualStyleBackColor = True
        ' 
        ' btn04
        ' 
        btn04.Location = New Point(760, 57)
        btn04.Name = "btn04"
        btn04.Size = New Size(75, 23)
        btn04.TabIndex = 3
        btn04.Text = "第四題"
        btn04.UseVisualStyleBackColor = True
        ' 
        ' btn05
        ' 
        btn05.Location = New Point(1004, 57)
        btn05.Name = "btn05"
        btn05.Size = New Size(75, 23)
        btn05.TabIndex = 4
        btn05.Text = "第五題"
        btn05.UseVisualStyleBackColor = True
        ' 
        ' btn_print
        ' 
        btn_print.Location = New Point(1149, 12)
        btn_print.Name = "btn_print"
        btn_print.Size = New Size(75, 23)
        btn_print.TabIndex = 5
        btn_print.Text = "列印答案"
        btn_print.UseVisualStyleBackColor = True
        ' 
        ' txt01
        ' 
        txt01.Location = New Point(12, 104)
        txt01.Multiline = True
        txt01.Name = "txt01"
        txt01.Size = New Size(272, 320)
        txt01.TabIndex = 6
        ' 
        ' txt03
        ' 
        txt03.Location = New Point(542, 104)
        txt03.Multiline = True
        txt03.Name = "txt03"
        txt03.Size = New Size(212, 320)
        txt03.TabIndex = 7
        ' 
        ' txt05
        ' 
        txt05.Location = New Point(1004, 104)
        txt05.Multiline = True
        txt05.Name = "txt05"
        txt05.Size = New Size(244, 320)
        txt05.TabIndex = 10
        ' 
        ' txt04
        ' 
        txt04.Location = New Point(760, 104)
        txt04.Multiline = True
        txt04.Name = "txt04"
        txt04.Size = New Size(226, 320)
        txt04.TabIndex = 11
        ' 
        ' txt02
        ' 
        txt02.Location = New Point(302, 104)
        txt02.Multiline = True
        txt02.Name = "txt02"
        txt02.Size = New Size(217, 320)
        txt02.TabIndex = 12
        ' 
        ' pd
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1255, 633)
        Controls.Add(txt02)
        Controls.Add(txt04)
        Controls.Add(txt05)
        Controls.Add(txt03)
        Controls.Add(txt01)
        Controls.Add(btn_print)
        Controls.Add(btn05)
        Controls.Add(btn04)
        Controls.Add(btn03)
        Controls.Add(btn02)
        Controls.Add(btn01)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn01 As Button
    Friend WithEvents btn02 As Button
    Friend WithEvents btn03 As Button
    Friend WithEvents btn04 As Button
    Friend WithEvents btn05 As Button
    Friend WithEvents btn_print As Button
    Friend WithEvents txt01 As TextBox
    Friend WithEvents txt03 As TextBox
    Friend WithEvents txt05 As TextBox
    Friend WithEvents txt04 As TextBox
    Friend WithEvents txt02 As TextBox
    Friend WithEvents pd As Printing.PrintDocument

End Class

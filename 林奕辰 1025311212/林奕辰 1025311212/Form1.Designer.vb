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
        btn_01 = New Button()
        btn_02 = New Button()
        btn_03 = New Button()
        btn_05 = New Button()
        btn_04 = New Button()
        btn_print = New Button()
        pd = New Printing.PrintDocument()
        txt_01 = New TextBox()
        txt_02 = New TextBox()
        txt_03 = New TextBox()
        txt_04 = New TextBox()
        txt_05 = New TextBox()
        SuspendLayout()
        ' 
        ' btn_01
        ' 
        btn_01.Location = New Point(33, 82)
        btn_01.Name = "btn_01"
        btn_01.Size = New Size(111, 47)
        btn_01.TabIndex = 0
        btn_01.Text = "第一題"
        btn_01.UseVisualStyleBackColor = True
        ' 
        ' btn_02
        ' 
        btn_02.Location = New Point(279, 82)
        btn_02.Name = "btn_02"
        btn_02.Size = New Size(102, 47)
        btn_02.TabIndex = 1
        btn_02.Text = "第二題"
        btn_02.UseVisualStyleBackColor = True
        ' 
        ' btn_03
        ' 
        btn_03.Location = New Point(523, 82)
        btn_03.Name = "btn_03"
        btn_03.Size = New Size(129, 47)
        btn_03.TabIndex = 2
        btn_03.Text = "第三題"
        btn_03.UseVisualStyleBackColor = True
        ' 
        ' btn_05
        ' 
        btn_05.Location = New Point(1003, 82)
        btn_05.Name = "btn_05"
        btn_05.Size = New Size(113, 47)
        btn_05.TabIndex = 3
        btn_05.Text = "第五題"
        btn_05.UseVisualStyleBackColor = True
        ' 
        ' btn_04
        ' 
        btn_04.Location = New Point(799, 82)
        btn_04.Name = "btn_04"
        btn_04.Size = New Size(116, 47)
        btn_04.TabIndex = 4
        btn_04.Text = "第四題"
        btn_04.UseVisualStyleBackColor = True
        ' 
        ' btn_print
        ' 
        btn_print.Location = New Point(1107, 12)
        btn_print.Name = "btn_print"
        btn_print.Size = New Size(131, 52)
        btn_print.TabIndex = 5
        btn_print.Text = "列印答案"
        btn_print.UseVisualStyleBackColor = True
        ' 
        ' pd
        ' 
        ' 
        ' txt_01
        ' 
        txt_01.Location = New Point(23, 167)
        txt_01.Multiline = True
        txt_01.Name = "txt_01"
        txt_01.Size = New Size(238, 293)
        txt_01.TabIndex = 6
        ' 
        ' txt_02
        ' 
        txt_02.Location = New Point(279, 167)
        txt_02.Multiline = True
        txt_02.Name = "txt_02"
        txt_02.Size = New Size(238, 293)
        txt_02.TabIndex = 7
        ' 
        ' txt_03
        ' 
        txt_03.Location = New Point(523, 167)
        txt_03.Multiline = True
        txt_03.Name = "txt_03"
        txt_03.Size = New Size(270, 258)
        txt_03.TabIndex = 8
        ' 
        ' txt_04
        ' 
        txt_04.Location = New Point(799, 167)
        txt_04.Multiline = True
        txt_04.Name = "txt_04"
        txt_04.Size = New Size(198, 293)
        txt_04.TabIndex = 9
        ' 
        ' txt_05
        ' 
        txt_05.Location = New Point(1003, 167)
        txt_05.Multiline = True
        txt_05.Name = "txt_05"
        txt_05.Size = New Size(315, 258)
        txt_05.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1341, 592)
        Controls.Add(txt_05)
        Controls.Add(txt_04)
        Controls.Add(txt_03)
        Controls.Add(txt_02)
        Controls.Add(txt_01)
        Controls.Add(btn_print)
        Controls.Add(btn_04)
        Controls.Add(btn_05)
        Controls.Add(btn_03)
        Controls.Add(btn_02)
        Controls.Add(btn_01)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_01 As Button
    Friend WithEvents btn_02 As Button
    Friend WithEvents btn_03 As Button
    Friend WithEvents btn_05 As Button
    Friend WithEvents btn_04 As Button
    Friend WithEvents btn_print As Button
    Friend WithEvents pd As Printing.PrintDocument
    Friend WithEvents txt_01 As TextBox
    Friend WithEvents txt_02 As TextBox
    Friend WithEvents txt_03 As TextBox
    Friend WithEvents txt_04 As TextBox
    Friend WithEvents txt_05 As TextBox

End Class

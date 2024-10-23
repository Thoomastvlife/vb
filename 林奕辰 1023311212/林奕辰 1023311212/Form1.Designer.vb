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
        btn_pd = New Button()
        pd = New Printing.PrintDocument()
        btn_01 = New Button()
        btn_02 = New Button()
        btn_03 = New Button()
        txt_01 = New TextBox()
        txt_02 = New TextBox()
        txt_03 = New TextBox()
        SuspendLayout()
        ' 
        ' btn_pd
        ' 
        btn_pd.Location = New Point(627, 29)
        btn_pd.Name = "btn_pd"
        btn_pd.Size = New Size(107, 41)
        btn_pd.TabIndex = 0
        btn_pd.Text = "列印答案"
        btn_pd.UseVisualStyleBackColor = True
        ' 
        ' pd
        ' 
        ' 
        ' btn_01
        ' 
        btn_01.Location = New Point(31, 47)
        btn_01.Name = "btn_01"
        btn_01.Size = New Size(75, 23)
        btn_01.TabIndex = 1
        btn_01.Text = "第一題"
        btn_01.UseVisualStyleBackColor = True
        ' 
        ' btn_02
        ' 
        btn_02.Location = New Point(320, 38)
        btn_02.Name = "btn_02"
        btn_02.Size = New Size(75, 23)
        btn_02.TabIndex = 2
        btn_02.Text = "第二題"
        btn_02.UseVisualStyleBackColor = True
        ' 
        ' btn_03
        ' 
        btn_03.Location = New Point(535, 96)
        btn_03.Name = "btn_03"
        btn_03.Size = New Size(75, 23)
        btn_03.TabIndex = 3
        btn_03.Text = "第三題"
        btn_03.UseVisualStyleBackColor = True
        ' 
        ' txt_01
        ' 
        txt_01.Location = New Point(31, 147)
        txt_01.Multiline = True
        txt_01.Name = "txt_01"
        txt_01.Size = New Size(283, 250)
        txt_01.TabIndex = 4
        ' 
        ' txt_02
        ' 
        txt_02.Location = New Point(320, 97)
        txt_02.Multiline = True
        txt_02.Name = "txt_02"
        txt_02.Size = New Size(209, 303)
        txt_02.TabIndex = 5
        ' 
        ' txt_03
        ' 
        txt_03.Location = New Point(535, 144)
        txt_03.Multiline = True
        txt_03.Name = "txt_03"
        txt_03.Size = New Size(253, 253)
        txt_03.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txt_03)
        Controls.Add(txt_02)
        Controls.Add(txt_01)
        Controls.Add(btn_03)
        Controls.Add(btn_02)
        Controls.Add(btn_01)
        Controls.Add(btn_pd)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_pd As Button
    Friend WithEvents pd As Printing.PrintDocument
    Friend WithEvents btn_01 As Button
    Friend WithEvents btn_02 As Button
    Friend WithEvents btn_03 As Button
    Friend WithEvents txt_01 As TextBox
    Friend WithEvents txt_02 As TextBox
    Friend WithEvents txt_03 As TextBox

End Class

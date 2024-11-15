﻿Public Class Form1

    '*******************************
    '* 11900-1060301 Program Start * 
    '*******************************

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "c:\test\1060301.t03", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
        m1 = m0
        Do
            m2 = m1 \ 10
            m3 = m1 Mod 10
            m4 = m4 & m3
            If m2 = 0 Then
                Exit Do
            Else
                m1 = m2
            End If
        Loop While True
        If m4 = m0 Then
            TextBox1.Text = "第一題結果 : " & m0 & " is a palindrome."
        Else
            TextBox1.Text = "第一題結果 : " & m0 & " is not a palindrome."

        End If
    End Sub

    '*******************************
    '* 11900-1060302 Program Start * 
    '*******************************

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "c:\test\1060302.t03", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
        Dim i = 1
        Do
            Dim j = 1
            Do
                m1 = m1 & j
                j = j + 1

            Loop While j <= i
            m1 = m1 & vbCrLf
            i = i + 1
        Loop While i <= m0
        TextBox2.Text = "第二題結果 : " & vbCrLf & vbCrLf & m1


    End Sub

    '*******************************
    '* 11900-1060303 Program Start * 
    '*******************************

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "c:\test\1060303.t03", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
        Dim i = 1
        Do
            If m0 Mod i = 0 Then m1 = m1 + 1
            i = i + 1

        Loop While i <= m0

        If m1 = 2 Then
            TextBox3.Text = "第三題結果 : " & m0 & " is a prime number."
        Else
            TextBox3.Text = "第三題結果 : " & m0 & " is not a prime number."

        End If
    End Sub

    '*******************************
    '* 11900-1060304 Program Start * 
    '*******************************

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim h(3), w(3), bmi(3), sbmi
        FileOpen(1, "c:\test\1060304.t03", OpenMode.Input)
        Dim i = 1
        Do
            Input(1, h(i)) : Input(1, w(i))
            bmi(i) = w(i) / (h(i) / 100) ^ 2
            i = i + 1
        Loop While i <= 3
        FileClose(1)
        sbmi = bmi(1)

        i = 1
        Do
            If bmi(i) < sbmi Then sbmi = bmi(i)
            i = i + 1

        Loop While i <= 3
        Dim sbmi45 As Integer = sbmi
        If sbmi45 <= 25 And sbmi45 >= 20 Then
            TextBox4.Text = "第四題結果 : 最小BMI值" & sbmi45 & "正常"
        Else
            TextBox4.Text = "第四題結果 : 最小BMI值" & sbmi45 & "不正常"

        End If
    End Sub

    '*******************************
    '* 11900-1060305 Program Start * 
    '*******************************

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim a(2, 2), b(2, 2), c(2, 2)

        FileOpen(1, "c:\test\1060305.t03", OpenMode.Input)
        Input(1, a(1, 1)) : Input(1, a(1, 2))
        Input(1, a(2, 1)) : Input(1, a(2, 2))
        Input(1, b(1, 1)) : Input(1, b(1, 2))
        Input(1, b(2, 1)) : Input(1, b(2, 2))
        FileClose(1)
        Dim i = 1
        Do
            Dim j = 1
            Do
                c(i, j) = a(i, j) + b(i, j)
                j = j + 1
            Loop While j <= 2
            i = i + 1

        Loop While i <= 2
        Dim ans As String
        ans &= "[" & c(1, 1) & vbTab & c(1, 2) & "]" & vbCrLf
        ans &= "[" & c(2, 1) & vbTab & c(2, 2) & "]" & vbCrLf
        TextBox5.Text = "第五題結果 : " & vbCrLf & ans
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        pd.Print()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd.PrintPage
        Dim ans As String
        ans &= "姓名 : [林奕辰]    術科測試編號 : [1115311212]" & vbCrLf
        ans &= "座號 : [12]         日期 : [2024/11/15]" & vbCrLf & vbCrLf
        ans &= TextBox1.Text & vbCrLf & vbCrLf
        ans &= TextBox2.Text & vbCrLf & vbCrLf
        ans &= TextBox3.Text & vbCrLf & vbCrLf
        ans &= TextBox4.Text & vbCrLf & vbCrLf
        ans &= TextBox5.Text & vbCrLf & vbCrLf
        e.Graphics.DrawString(ans, Font, Brushes.Black, 100, 100)
    End Sub
End Class

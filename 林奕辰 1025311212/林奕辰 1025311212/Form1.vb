Public Class Form1

    '*****************************
    '* 1990-1060301 Program Start *
    '*****************************

    Private Sub btn_01_Click(sender As Object, e As EventArgs) Handles btn_01.Click
        Dim m0, m1, m2, m3, m4

        FileOpen(1, "c:\test\1060301.sm", OpenMode.Input)
        Input(1, m0)
        FileClose(1)

        m1 = m0
        For i = 1 To 10
            m2 = m1 \ 10
            m3 = m1 Mod 10
            m4 = m4 & m3
            If m2 = 0 Then
                Exit For
            End If
            m1 = m2

        Next
        If m4 = m0 Then
            txt_01.Text = "第一題結果 : " & m0 & "is a palindrome."
        Else
            txt_01.Text = "第一題結果 : " & m0 & "is not a palindrome."
        End If
    End Sub

    '*****************************
    '* 1990-1060302 Program Start *
    '*****************************

    Private Sub btn_02_Click(sender As Object, e As EventArgs) Handles btn_02.Click
        Dim m0, m1, m2, m3, m4

        FileOpen(1, "c:\test\1060302.sm", OpenMode.Input)
        Input(1, m0)
        FileClose(1)

        For i = 1 To m0
            For j = 1 To i
                m1 = m1 & j
            Next
            m1 = m1 & vbCrLf
        Next
        txt_02.Text = "第二題結果 : " & vbCrLf & vbCrLf & m1

    End Sub

    '*****************************
    '* 1990-1060303 Program Start *
    '*****************************

    Private Sub btn_03_Click(sender As Object, e As EventArgs) Handles btn_03.Click
        Dim m0, m1, m2, m3, m4

        FileOpen(1, "c:\test\1060303.sm", OpenMode.Input)
        Input(1, m0)
        FileClose(1)

        For i = 1 To m0
            If m0 Mod i = 0 Then m1 = m1 + 1

        Next
        If m1 = 2 Then
            txt_03.Text = "第三題結果 : " & m0 & "is a prime number."
        Else
            txt_03.Text = "第三題結果 : " & m0 & "is not a prime number."
        End If
    End Sub

    '*****************************
    '* 1990-1060304 Program Start *
    '*****************************

    Private Sub btn_04_Click(sender As Object, e As EventArgs) Handles btn_04.Click
        Dim h(3), w(3), bmi(3), sbmi

        FileOpen(1, "c:\test\1060304.sm", OpenMode.Input)


        For i = 1 To 3
            Input(1, h(i))
            Input(1, w(i))
            bmi(i) = w(i) / (h(i) / 100) ^ 2

        Next
        FileClose(1)
        sbmi = bmi(1)
        For i = 1 To 3
            If bmi(i) < sbmi Then sbmi = bmi(i)
        Next
        Dim sbmi45 As Integer = sbmi
        If sbmi45 <= 25 And sbmi45 >= 20 Then
            txt_04.Text = "第四題結果 : 最小BMI值" & sbmi45 & "正常"
        Else
            txt_04.Text = "第四題結果 : 最小BMI值" & sbmi45 & "不正常"

        End If
    End Sub

    '*****************************
    '* 1990-1060305 Program Start *
    '*****************************

    Private Sub btn_05_Click(sender As Object, e As EventArgs) Handles btn_05.Click
        Dim a(2, 2), b(2, 2), c(2, 2)

        FileOpen(1, "c:\test\1060305.sm", OpenMode.Input)
        Input(1, a(1, 1)) : Input(1, a(1, 2))
        Input(1, a(2, 1)) : Input(1, a(2, 2))
        Input(1, b(1, 1)) : Input(1, b(1, 2))
        Input(1, b(2, 1)) : Input(1, b(2, 2))

        FileClose(1)
        For i = 1 To 2
            For j = 1 To 2
                c(i, j) = a(i, j) + b(i, j)

            Next
        Next
        Dim ans As String
        ans &= "[" & c(1, 1) & vbTab & c(1, 2) & "]" & vbCrLf
        ans &= "[" & c(2, 1) & vbTab & c(2, 2) & "]" & vbCrLf
        txt_05.Text = "第五題結果 :" & vbCrLf & ans
    End Sub


    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        pd.Print()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd.PrintPage
        Dim ans As String
        ans &= "姓名 : [林奕辰]    術科測試編號 : [1025311212]" & vbCrLf
        ans &= "座號 : [12]         日期 : [2024/10/25]" & vbCrLf & vbCrLf
        ans &= txt_01.Text & vbCrLf & vbCrLf
        ans &= txt_02.Text & vbCrLf & vbCrLf
        ans &= txt_03.Text & vbCrLf & vbCrLf
        ans &= txt_04.Text & vbCrLf & vbCrLf
        ans &= txt_05.Text & vbCrLf & vbCrLf
        e.Graphics.DrawString(ans, Font, Brushes.Black, 100, 100)
    End Sub
End Class

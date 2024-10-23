Imports System.Net.Security
Imports System.Numerics

Public Class Form1

    '*****************************
    '* 11900-1060301 Program Start *
    '*****************************

    Private Sub btn_01_Click(sender As Object, e As EventArgs) Handles btn_01.Click
        Dim m0, m1, m2, m3, m4

        FileOpen(1, "C:\test\1060301.sm", OpenMode.Input)
        Input(1, m0)
        FileClose()

        m1 = m0

        For i = 1 To 10
            m2 = m1 \ 10
            m3 = m1 Mod 10
            m4 = m4 & m3
            If m2 = 0 Then
                Exit For
            Else
                m1 = m2
            End If
        Next

        If m4 = m0 Then
            txt_01.Text = "第一題結果 : " & m0 & "is a palindrome."
        Else
            txt_01.Text = "第一題結果 : " & m0 & "is not a palindrome."
        End If

    End Sub

    '*****************************
    '* 11900-1060302 Program Start *
    '*****************************

    Private Sub btn_02_Click(sender As Object, e As EventArgs) Handles btn_02.Click

        Dim m0, m1, m2, m3, m4

        FileOpen(1, "C:\test\1060302.sm", OpenMode.Input)
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
    '* 11900-1060303 Program Start *
    '*****************************

    Private Sub btn_03_Click(sender As Object, e As EventArgs) Handles btn_03.Click

        Dim m0, m1, m2, m3, m4

        FileOpen(1, "C:\test\1060303.sm", OpenMode.Input)
        Input(1, m0)
        FileClose(1)

        For i = 1 To m0
            If m0 Mod i = 0 Then m1 = m1 + 1
        Next

        If m1 = 2 Then
            txt_03.Text = "第一題結果 : " & m0 & "is a prime number."
        Else
            txt_03.Text = "第一題結果 : " & m0 & "is not a prime number"
        End If
    End Sub

    Private Sub btn_pd_Click(sender As Object, e As EventArgs) Handles btn_pd.Click
        pd.Print()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd.PrintPage
        Dim ans As String
        Dim vn = vbCrLf
        ans &= "姓名[林奕辰]       術科測試編號[1023311212]" & vn
        ans &= "座號[12]              日期[2024/10/23]" & vn & vn
        ans &= txt_01.Text & vn & vn
        ans &= txt_02.Text & vn & vn
        ans &= txt_03.Text & vn & vn

        e.Graphics.DrawString(ans, Font, Brushes.Black, 100, 100)


    End Sub
End Class

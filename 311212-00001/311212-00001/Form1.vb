Imports System.Net.Security

Public Class Form1

    '*****************************
    '* 11200-1020301 Progam Start *
    '*****************************

    Private Sub btn01_Click(sender As Object, e As EventArgs) Handles btn01.Click
        Dim m0, m1, m2, m3, m4

        FileOpen(1, "c:\test\1020301.sm", OpenMode.Input)
        Input(1, m0)
        FileClose(1)

    End Sub

    '*****************************
    '* 11200-1020302 Progam Start *
    '*****************************
    Private Sub btn02_Click(sender As Object, e As EventArgs) Handles btn02.Click
        Dim m0, m1, m2, m3, m4

        FileOpen(1, "c:\test\1020302.sm", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
    End Sub
    '*****************************
    '* 11200-1020303 Progam Start *
    '*****************************
    Private Sub btn03_Click(sender As Object, e As EventArgs) Handles btn03.Click
        Dim m0, m1, m2

        FileOpen(1, "c:\test\1020303.sm", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
        For i = 1 To m0
            If m0 Mod i = 0 Then m1 = m1 + 1
        Next
        If m1 = 2 Then
            txt03.Text = "結果:" & m0 & "is a prime number."
        Else

        End If
    End Sub
    '*****************************
    '* 11200-1020304 Progam Start *
    '*****************************
    Private Sub btn04_Click(sender As Object, e As EventArgs) Handles btn04.Click
        Dim m0, m1, m2, m3, m4

        FileOpen(1, "c:\test\1020301.sm", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
    End Sub
    '*****************************
    '* 11200-1020305 Progam Start *
    '*****************************
    Private Sub btn05_Click(sender As Object, e As EventArgs) Handles btn05.Click

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        pd.Print()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd.PrintPage

    End Sub
End Class

Public Class Form1
    Imports System.Net.Security

    Public Class Form1

        '*****************************
        '* 11200-1020301 Progam Start *
        '*****************************

        Private Sub btn_01_Click(sender As Object, e As EventArgs) Handles btn_01.Click
            Dim m0, m1, m2, m3, m4

            FileOpen(1, "c:\test\1060301.sm", OpenMode.Input)
            Input(1, m0)
            FileClose(1)


        '*****************************
        '* 1990-1060302 Program Start *
        '*****************************

        Private Sub btn_02_Click(sender As Object, e As EventArgs) Handles btn_02.Click
            Dim m0, m1, m2, m3, m4

            FileOpen(1, "c:\test\1060302.sm", OpenMode.Input)
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

End Class

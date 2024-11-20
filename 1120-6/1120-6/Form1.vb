Public Class Form1
    Dim rno, ec, d(100, 4)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call rdata()
        For i = 1 To rno
            If ec = "" Then Call sp1(i)
            If ec = "" Then Call sp2(i)
            If ec = "" Then Call sp3(i)
            d(i, 4) = ec
        Next
        Call wdata()
    End Sub

    Sub rdata()
        FileOpen(1, "c:\test\1060306.sm", OpenMode.Input)
        rno = 0
        Do While Not EOF(1)
            rno = rno + 1
            For j = 1 To 3
                Input(1, d(rno, j))
            Next
        Loop
        FileClose(1)
    End Sub

    Sub sp1(i)

    End Sub
    Sub sp2(i)

    End Sub

    Sub sp3(i)

    End Sub
    Sub wdata()

    End Sub

End Class

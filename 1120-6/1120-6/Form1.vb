﻿Public Class Form1
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
        Dim idno = d(i, 1)
        If Not idno Like "[A-Z]#########" Then ec = "FORMAT ERROR"


    End Sub
    Sub sp2(i)
        Dim sex_mf = d(i, 3)
        Dim sex_12 = Mid(d(i, 1), 2, 1)
        Dim msex = sex_12 & sex_mf
        If msex <> "1M" And msex <> "2F" Then ec = "SEX CODE ERROR"


    End Sub

    Sub sp3(i)
        Dim s26 = "ABCDEFGHJKLMNPQRSTUVXYWZIO"
        Dim L1 = Mid(d(i, 1), 1, 1)
        Dim m1 = InStr(s26, L1) + 9
        Dim x1 = m1 \ 10
        Dim x2 = m1 Mod 10
        Dim y = x1 + 9 * x2

        Dim a(9)
        For j = 2 To 10
            a(j - 1) = Mid(d(i, 1), j, 1)

        Next

        'y = y = 8 * a(1) + 7 * a(2) + 6 * a(3) + 5 * a(4) + 4 * (5) + 3 * (6) + 2 * a(7) + a(8)

        For j = 1 To 8
            y = y + a(9 - j) * j
        Next
        y = y + a(9)
        If y Mod 10 <> 0 Then ec = "CHECK SUM ERROR"

    End Sub
    Sub wdata()
        Dim dt As New DataTable
        dt.Columns.Add("ID_NO")
        dt.Columns.Add("NAME")
        dt.Columns.Add("SEX")
        dt.Columns.Add("ERROR")
        For i = 1 To rno
            Dim dr As DataRow = dt.NewRow
            dr(0) = d(i, 1)
            dr(1) = d(i, 2)
            dr(2) = d(i, 3)
            dr(3) = d(i, 4)
            dt.Rows.Add(dr)
        Next
        dgv.DataSource = dt
        dgv.Sort(dgv.Columns(0), 0)
        dgv.Columns(2).Width = 50
        dgv.Columns(3).Width = 150


    End Sub

End Class

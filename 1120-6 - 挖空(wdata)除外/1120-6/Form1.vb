Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub rdata()

    End Sub

    Sub sp1(i)

    End Sub
    Sub sp2(i)

    End Sub

    Sub sp3(i)

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

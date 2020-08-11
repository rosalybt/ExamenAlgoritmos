Public Class Form1

    Dim ObjExamen As New ClaseExamen2
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        ObjExamen.Funcion(txt_xi, txt_ed, txt_a, txt_b, txt_c, txt_exp1, txt_exp2)
    End Sub
End Class

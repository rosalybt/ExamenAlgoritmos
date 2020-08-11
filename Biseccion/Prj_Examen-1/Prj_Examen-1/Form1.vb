Public Class Form1

    Dim ObjExamen As New Clase_examen1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        ObjExamen.Funcion(txt_xi, txt_xd, txt_ed, txt_num1, txt_num2, txt_num3)
    End Sub
End Class

Public Class Clase_examen1
    Public xi, xd, xm, ed, vaxm As Decimal
    Public a, b, c, ancho, alto As Integer
    Dim x1, x2, y, y2 As Integer
    Public Sub Funcion(txt_xi As TextBox, txt_xd As TextBox, txt_ed As TextBox, num1 As TextBox, num2 As TextBox, num3 As TextBox)

        xi = Convert.ToDecimal(txt_xi.Text)
        xd = Convert.ToDecimal(txt_xd.Text)
        ed = Convert.ToDecimal(txt_ed.Text)

        If (Evaluar_Funcion(xi, a, b, c) * Evaluar_Funcion(xd, a, b, c)) < 0 Then

            Do
                xm = (xi + xd) / 2.0
                vaxm = Math.Abs(Evaluar_Funcion(xm, a, b, c))

                If (vaxm <= ed) Then
                    MessageBox.Show("La Raiz es  " & xm.ToString & "  +-  " & vaxm.ToString)

                Else
                    If (Evaluar_Funcion(xi, a, b, c) * Evaluar_Funcion(xm, a, b, c)) < 0 Then
                        xd = xm
                    Else
                        xi = xm
                    End If

                End If

            Loop While vaxm > ed

        Else
            MessageBox.Show("NO HAY RAIZ EN EL INTERVALO DADO")

        End If

    End Sub


    Public Function Evaluar_Funcion(x As Double, a As Double, b As Double, c As Double) As Double
        Dim y As Double
        y = (a * Math.Pow(x, 2)) + b * x + c
        Return y
    End Function


End Class

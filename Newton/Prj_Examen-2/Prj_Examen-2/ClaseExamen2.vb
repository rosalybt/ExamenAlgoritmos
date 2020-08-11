Public Class ClaseExamen2
    Public xi, ed, xip, vaxip, fx, fpx As Decimal
    Public a, b, c, exp1, exp2, ancho, alto As Decimal
    Public Sub Funcion(txt_xi As TextBox, txt_ed As TextBox, txt_a As TextBox, txt_b As TextBox, txt_c As TextBox, txt_exp1 As TextBox, txt_exp2 As TextBox)

        xi = Convert.ToDecimal(txt_xi.Text)
        ed = Convert.ToDecimal(txt_ed.Text)
        a = txt_a.Text
        b = txt_b.Text
        c = txt_c.Text
        exp1 = txt_exp1.Text
        exp2 = txt_exp2.Text
        Dim cont As Integer = 0
        Do
            cont = cont + 1
            fx = Evaluar_Funcion(xi, a, b, c, exp1, exp2)
            fpx = Evaluar_Derivada(xi, exp1, exp2, a, b)
            If fpx = 0 Then

                MessageBox.Show("EL METODO FALLA")

                Exit Do
            End If

            xip = xi - (fx / fpx)
            vaxip = Math.Abs(Evaluar_Funcion(xip, a, b, c, exp1, exp2))
            If vaxip <= ed Then

                MessageBox.Show("La Raiz es  " & xip.ToString & "  +-  " & vaxip.ToString)

            Else
                xi = xip
            End If

            If cont = 50 Then
                MessageBox.Show("NO EXISTE RAIZ ")
                Exit Do
            End If

        Loop While vaxip > ed

    End Sub
    Public Function Evaluar_Funcion(x_ As Double, a As Double, b As Double, c As Double, exp1 As Double, exp2 As Double) As Double
        Dim y As Double
        y = ((a * Math.Pow(x_, exp1)) + (b * Math.Pow(x_, exp2) + c))
        Return y
    End Function
    Public Function Evaluar_Derivada(x As Double, exp1 As Double, exp2 As Double, a As Double, b As Double) As Double
        Dim y, base1, exponente1, base2, exponente2 As Double
        exponente2 = exp2 - 1
        exponente1 = exp1 - 1
        base1 = a * exp1
        base2 = b * exp2
        If (exponente1 >= 0) Then
            y = (base1 * Math.Pow(x, 1)) + (base2 * Math.Pow(x, exponente2))

        End If

        If (exponente2 >= 0) Then
            y = (base1 * Math.Pow(x, exponente1)) + (base2 * Math.Pow(x, 1))
        End If

        Return y
    End Function
End Class

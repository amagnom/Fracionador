Public Class frmDivisibilidade

    Private Function IsDivididoPor(Numero As Long, DivNumero As Long) As Boolean

        If DivNumero <> 0 Then
            Return Numero Mod DivNumero = 0
        End If

        Return False

    End Function

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        lstResultado.Items.Clear()
        If Len(txtNumero.Text) > 5 Then
            lstResultado.Items.Add(" numero de entrada muito grande. ")
            Return
        End If
        Dim numero As Integer = Convert.ToInt32(txtNumero.Text)

        Dim valor(100) As Boolean

        For x = 1 To 100
            valor(x) = IsDivididoPor(numero, x)
        Next

        If valor.Any(Function(x) x.Equals(False)) Then
            lstResultado.Items.Add(numero & " é divisível por: ")
        End If

        For y = 1 To 20
            If valor(y) Then
                lstResultado.Items.Add(y)
            End If
        Next
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            If (Asc(e.KeyChar) = 8) Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub lblTexto_Click(sender As Object, e As EventArgs) Handles lblTexto.Click

    End Sub
End Class

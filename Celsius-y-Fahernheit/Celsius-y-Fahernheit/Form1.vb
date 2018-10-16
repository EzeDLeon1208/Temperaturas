Public Class Form1
    Private Sub CelsBtn_Click(sender As Object, e As EventArgs) Handles CelsBtn.Click
        Dim Cels As Double, Fah As Double

        If IsNumeric(FahrTxt.Text) = True Then
            Fah = Convert.ToDouble(FahrTxt.Text)
            If CDbl(FahrTxt.Text) >= -1000 And CDbl(FahrTxt.Text) <= 1000 Then
                Cels = ((Fah - 32) * (5 / 9))
                CelsResp.Text = (Cels).ToString

            Else
                MessageBox.Show("error, ingrese nuevamente")
                FahrTxt.Clear()
            End If
        Else
            MessageBox.Show("Error, debe ingresar numeros")
            FahrTxt.Clear()
        End If
    End Sub

    Private Sub FahrBtn_Click(sender As Object, e As EventArgs) Handles FahrBtn.Click
        Dim Fahren As Double, Ce As Double
        If IsNumeric(CelsTxt.Text) = True Then
            Ce = Convert.ToDouble(CelsTxt.Text)
            If CDbl(CelsTxt.Text) >= -1000 And CDbl(CelsTxt.Text) <= 1000 Then
                Fahren = (Ce * (9 / 5) + 32)
                FahrResp.Text = (Fahren).ToString
            Else
                MessageBox.Show("ingrese un numero")
                CelsTxt.Clear()
            End If
        Else
            MessageBox.Show("Error, debe ingresar numeros")
            CelsTxt.Clear()
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        FahrTxt.Clear()
        CelsTxt.Clear()
        FahrResp.Text = ""
        CelsResp.Text = ""
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Desea salir del programa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class

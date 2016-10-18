Imports VIA


Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mathlib As New VIA.DNP1MathLib
        TextBox3.Text = mathlib.Add( Integer.Parse(TextBox1.Text),Integer.Parse(TextBox2.Text))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim mathlib As New VIA.DNP1MathLib
        TextBox3.Text = mathlib.Sub(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text))

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim mathlib As New VIA.DNP1MathLib
        TextBox3.Text = mathlib.Mul(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text))

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim mathlib As New VIA.DNP1MathLib
        Try
            TextBox3.Text = mathlib.Div(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text))
        Catch ex As Exception
            MessageBox.Show(ex.Message)



        End Try
    End Sub
End Class

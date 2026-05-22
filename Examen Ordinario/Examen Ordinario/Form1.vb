Public Class Form1
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim contador As Integer = TextBox2.Text
        contador += 1
        TextBox2.Text = contador.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim precio As Decimal = precio1.Text
        Dim cantidad As Integer = TextBox2.Text
        Dim subtotal As Decimal = precio * cantidad
        Label7.Text = subtotal.ToString

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim contador As Integer = TextBox2.Text
        contador -= 1
        TextBox2.Text = contador.ToString
        If TextBox2.Text = -1 Then
            TextBox2.Text = 0
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim precio As Decimal = precio1.Text
        Dim cantidad As Integer = TextBox2.Text
        Dim num1 = Val(Label7.Text)
        Dim num2 = Val(Label8.Text)
        Dim subtotal As Decimal = num1 + num2
        Label9.Text = subtotal.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim precio As Decimal = precio1.Text
        Dim cantidad As Integer = TextBox2.Text
        Dim subtotal As Decimal = precio * cantidad * 0.16
        Label8.Text = subtotal.ToString
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class

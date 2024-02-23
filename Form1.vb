Public Class Form1

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' This code will only allow numeric characters in the text box
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        If Not Char.IsDigit(e.KeyChar) Then
            'ignore the keypress by setting Handled to True If not a digit,
            e.Handled = True

            MessageBox.Show("Only numeric values are allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



End Class

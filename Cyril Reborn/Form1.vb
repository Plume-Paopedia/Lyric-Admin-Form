Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        TextBox2.UseSystemPasswordChar = True 'Pour masquer le texte dans la zone de texte
        TextBox2.PasswordChar = "*" 'Définir un caractère de masquage personnalisé

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs)
        TextBox2.UseSystemPasswordChar = True 'Pour masquer le texte dans la zone de texte
        TextBox2.PasswordChar = "*" 'Définir un caractère de masquage personnalisé
    End Sub
End Class

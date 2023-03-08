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

    Private Sub TextBox2_TextChanged_2(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.UseSystemPasswordChar = True 'Pour masquer le texte dans la zone de texte
        TextBox2.PasswordChar = "*" 'Définir un caractère de masquage personnalisé
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide() ' Masquer la fenêtre actuelle

        System.Threading.Thread.Sleep(300000) ' Attendre 5 minutes (300000 millisecondes)

        Dim frm As New Form1 ' Instancier un nouveau formulaire Form1
        frm.Show() ' Afficher le nouveau formulaire

        frm.TextBox1.Text = TextBox2.Text ' Copier le texte de TextBox2 dans la TextBox1 du nouveau formulaire
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class

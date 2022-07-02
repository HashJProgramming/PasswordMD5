Public Class Form1
    Dim count As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        strResult = Nothing
        a = 1
        strResult = TextBox1.Text
        hasher = TextBox5.Text
        Hash()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If TextBox4.Text = TextBox1.Text Then
                count = 0
                TextBox3.Text = Nothing
                Timer1.Stop()
                MessageBox.Show("Done!")
            Else
                TextBox3.Text = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(TextBox4.Text))
                TextBox4.Text = TextBox3.Text
                count = count + 1
                Label2.Text = count

            End If
        Catch ex As Exception

        End Try
    End Sub

End Class

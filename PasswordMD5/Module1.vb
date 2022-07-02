Module Module1
    Public a As Integer = 1
    Public hasher As Integer
    Public strResult As String

    Sub Hash()
        Try
            While a <= hasher
                strResult = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(strResult))
                a = a + 1
            End While

            Form1.TextBox2.Text = strResult
            Form1.Label4.Text = Form1.TextBox2.Text.Length

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
End Module

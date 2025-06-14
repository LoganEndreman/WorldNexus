Public Class Card
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Card_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function ToCardData() As CardData
        Return New CardData With {
            .Title = TextBox1.Text,
            .Description = RichTextBox1.Text,
            .Deck = DropDownButton1.Text
        }
    End Function

    Public Sub FromCardData(data As CardData)
        TextBox1.Text = data.Title
        RichTextBox1.Text = data.Description
        DropDownButton1.Text = data.Deck
    End Sub

End Class

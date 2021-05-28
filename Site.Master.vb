Public Class SiteMaster
    Inherits MasterPage
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2, n3, n4, n5 As Single
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)
        n3 = Val(TextBox3.Text)
        n4 = Val(TextBox4.Text)
        n5 = (n1 + n2) * (n3 + n4)

        Textbox5.Text = Str(n5)

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n1, n2, n3, n4, n5 As Single
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)
        n3 = Val(TextBox3.Text)
        n4 = Val(TextBox4.Text)
        n5 = (n1 + n2) / (n3 + n4)

        Textbox5.Text = Str(n5)

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n1, n2, n3, n4, n5 As Single
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)
        n3 = Val(TextBox3.Text)
        n4 = Val(TextBox4.Text)
        n5 = (n1 + n2) + (n3 + n4)

        Textbox5.Text = Str(n5)

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim n1, n2, n3, n4, n5 As Single
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)
        n3 = Val(TextBox3.Text)
        n4 = Val(TextBox4.Text)
        n5 = (n1 + n2) - (n3 + n4)

        Textbox5.Text = Str(n5)

    End Sub
End Class

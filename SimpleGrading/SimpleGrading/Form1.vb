Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(100, 0, 0, 0)

        Calculate.FlatStyle = FlatStyle.Flat
        Calculate.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub Calculate_Click_1(sender As Object, e As EventArgs) Handles Calculate.Click
        If IsNumeric(TextBox1.Text) = False Or
       IsNothing(TextBox1.Text) = True Then

            MessageBox.Show("Please enter a numeric value ")

            TextBox1.Focus()

        ElseIf IsNumeric(TextBox2.Text) = False Or
        IsNothing(TextBox2.Text) = True Then

            MessageBox.Show("Please enter a numeric value ")

            TextBox2.Focus()

        ElseIf IsNumeric(TextBox3.Text) = False Or
        IsNothing(TextBox3.Text) = True Then

            MessageBox.Show("Please enter a numeric value")

            TextBox3.Focus()

        Else

            Label1.Text = ((TextBox1.Text * 0.3) + (TextBox2.Text * 0.3) + (TextBox3.Text * 0.4))

            If Val(Label1.Text) >= 75 Then

                Label2.Text = "Passed"

            Else

                Label2.Text = "Failed"

            End If

        End If
    End Sub
End Class


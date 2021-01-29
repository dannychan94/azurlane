Imports System.ComponentModel

Public Class Form1
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyUp

        Dim cpf = Val(TextBox1.Text)
        Dim cps = Val(TextBox2.Text)
        Dim epcu = Val(TextBox3.Text)

        Label4.Text = cpf * epcu * cps

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.KeyUp

        Dim meta = Val(TextBox5.Text)
        Dim pact = Val(TextBox6.Text)
        Dim tew = Val(Label4.Text)

        Label5.Text = Math.Round((meta - (meta * pact / 100)) / tew, 0, MidpointRounding.AwayFromZero)
        Label3.Text = TextBox6.Text + "%"

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.KeyUp

        Dim meta = Val(TextBox5.Text)
        Dim pact = Val(TextBox6.Text)
        Dim tew = Val(Label4.Text)

        Label5.Text = Math.Round((meta - (meta * pact / 100)) / tew, 0, MidpointRounding.AwayFromZero)
        Label3.Text = TextBox6.Text + "%"
        ProgressBar1.Value = Val(TextBox6.Text)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Form2.Show()
        'Form2.Visible = False

        TextBox1.Text = My.Settings.cantporflota
        TextBox2.Text = My.Settings.combporstage
        TextBox3.Text = My.Settings.exppromedio
        TextBox5.Text = My.Settings.meta
        TextBox6.Text = My.Settings.poractual

        Dim cpf = Val(TextBox1.Text)
        Dim cps = Val(TextBox2.Text)
        Dim epcu = Val(TextBox3.Text)

        Label4.Text = cpf * epcu * cps

        Dim meta = Val(TextBox5.Text)
        Dim pact = Val(TextBox6.Text)
        Dim tew = Val(Label4.Text)

        Label5.Text = Math.Round((meta - (meta * pact / 100)) / tew, 0, MidpointRounding.AwayFromZero)

        Label3.Text = TextBox6.Text + "%"
        ProgressBar1.Value = Val(TextBox6.Text)

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.cantporflota = TextBox1.Text
        My.Settings.combporstage = TextBox2.Text
        My.Settings.exppromedio = TextBox3.Text
        My.Settings.meta = TextBox5.Text
        My.Settings.poractual = TextBox6.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        Form2.Show()
        Me.Visible = False
    End Sub
End Class

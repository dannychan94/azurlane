Imports System.ComponentModel

Public Class Form2
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

    Public Sub calcevento()

        Dim flota1 = Val(TextBox1.Text)
        Dim sp1 = Val(TextBox3.Text)
        Dim sp2 = Val(TextBox4.Text)
        Dim sp3 = Val(TextBox5.Text)
        Dim sp4 = Val(TextBox6.Text)
        Dim sp5 = Val(TextBox7.Text)
        Dim bat1 = Val(TextBox8.Text)
        Dim bat2 = Val(TextBox9.Text)
        Dim bat3 = Val(TextBox10.Text)
        Dim bat4 = Val(TextBox11.Text)
        Dim bat5 = Val(TextBox12.Text)
        Dim act = Val(TextBox14.Text)
        Dim obj = Val(TextBox13.Text)

        Label20.Text = (flota1 * bat1) + 10
        Label21.Text = (flota1 * bat2) + 10
        Label22.Text = (flota1 * bat3) + 10
        Label23.Text = (flota1 * bat4) + 10
        Label24.Text = (flota1 * bat5) + 10


        Label40.Text = obj - act

        Dim metac = Val(Label40.Text)

        Label30.Text = Math.Round(metac / sp1, 0, MidpointRounding.AwayFromZero) &
            " / " &
            Math.Round(metac / sp1, 0, MidpointRounding.AwayFromZero) * Val(Label20.Text)

        Label31.Text = Math.Round(metac / sp2, 0, MidpointRounding.AwayFromZero) &
            " / " &
            Math.Round(metac / sp2, 0, MidpointRounding.AwayFromZero) * Val(Label21.Text)

        Label32.Text = Math.Round(metac / sp3, 0, MidpointRounding.AwayFromZero) &
            " / " &
            Math.Round(metac / sp3, 0, MidpointRounding.AwayFromZero) * Val(Label22.Text)

        Label33.Text = Math.Round(metac / sp4, 0, MidpointRounding.AwayFromZero) &
            " / " &
            Math.Round(metac / sp4, 0, MidpointRounding.AwayFromZero) * Val(Label23.Text)

        Label34.Text = Math.Round(metac / sp5, 0, MidpointRounding.AwayFromZero) &
            " / " &
            Math.Round(metac / sp5, 0, MidpointRounding.AwayFromZero) * Val(Label24.Text)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load

        Label1.Parent = PictureBox1
        Label1.Location = New Point(Label1.Location.X - PictureBox1.Location.X, Label1.Location.Y - PictureBox1.Location.Y)


        Form1.Show()
        Form1.Visible = False

        TextBox1.Text = My.Settings.flota1
        TextBox3.Text = My.Settings.sp1
        TextBox4.Text = My.Settings.sp2
        TextBox5.Text = My.Settings.sp3
        TextBox6.Text = My.Settings.sp4
        TextBox7.Text = My.Settings.sp5
        TextBox8.Text = My.Settings.bt1
        TextBox9.Text = My.Settings.bt2
        TextBox10.Text = My.Settings.bt3
        TextBox11.Text = My.Settings.bt4
        TextBox12.Text = My.Settings.bt5
        TextBox13.Text = My.Settings.obj
        TextBox14.Text = My.Settings.actual

        calcevento()

    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.flota1 = TextBox1.Text
        My.Settings.sp1 = TextBox3.Text
        My.Settings.sp2 = TextBox4.Text
        My.Settings.sp3 = TextBox5.Text
        My.Settings.sp4 = TextBox6.Text
        My.Settings.sp5 = TextBox7.Text
        My.Settings.bt1 = TextBox8.Text
        My.Settings.bt2 = TextBox9.Text
        My.Settings.bt3 = TextBox10.Text
        My.Settings.bt4 = TextBox11.Text
        My.Settings.bt5 = TextBox12.Text
        My.Settings.obj = TextBox13.Text
        My.Settings.actual = TextBox14.Text

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        calcevento()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        Form4.Show()
        Me.Hide()
    End Sub
End Class
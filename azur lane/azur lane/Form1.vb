Imports System.ComponentModel

Public Class Form1
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public CantidadPerFlota As Integer
    Public CombatesPerStage As Integer
    Public ExpPerEachOne As Integer
    Public Meta As Integer
    Public PercAct As Integer

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Form2.Show()
        'Form2.Visible = False

        TextBox1.Text = My.Settings.cantporflota
        TextBox2.Text = My.Settings.combporstage
        TextBox3.Text = My.Settings.exppromedio
        TextBox5.Text = My.Settings.meta
        TextBox6.Text = My.Settings.poractual

        CantidadPerFlota = Val(TextBox1.Text)
        CombatesPerStage = Val(TextBox2.Text)
        ExpPerEachOne = Val(TextBox3.Text)

        Label4.Text = CantidadPerFlota * ExpPerEachOne * CombatesPerStage

        Meta = Val(TextBox5.Text)
        PercAct = Val(TextBox6.Text)

        Label5.Text = Math.Round((Meta - (Meta * PercAct / 100)) / Val(Label4.Text), 0, MidpointRounding.AwayFromZero)

        Label3.Text = TextBox6.Text + "%"
        ThunderProgressBar1.Value = PercAct


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

    Private Sub NightButton1_Click(sender As Object, e As EventArgs) Handles NightButton1.Click

        CantidadPerFlota = Val(TextBox1.Text)
        CombatesPerStage = Val(TextBox2.Text)
        ExpPerEachOne = Val(TextBox3.Text)

        Label4.Text = CantidadPerFlota * ExpPerEachOne * CombatesPerStage

        Meta = Val(TextBox5.Text)
        PercAct = Val(TextBox6.Text)

        Label5.Text = Math.Round((Meta - (Meta * PercAct / 100)) / Val(Label4.Text), 0, MidpointRounding.AwayFromZero)

        Label3.Text = TextBox6.Text + "%"

        ThunderProgressBar1.Value = PercAct
    End Sub
End Class

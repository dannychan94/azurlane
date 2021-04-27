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

    Public Sub prbutton(pr As String)
        Select Case pr
            Case "pr1"
                PictureBox12.BackgroundImage = My.Resources.pr2
                Label1.Text = "pr2"

                PictureBox6.BackgroundImage = My.Resources.gra_seattle
                PictureBox7.BackgroundImage = My.Resources.gra_georgia
                PictureBox8.BackgroundImage = My.Resources.gra_kitakase
                PictureBox9.BackgroundImage = My.Resources.gra_azuma
                PictureBox10.BackgroundImage = My.Resources.gra_frederich
                PictureBox11.BackgroundImage = My.Resources.gra_gascogne

                PictureBox14.Hide()
                PictureBox16.Hide()
                PictureBox17.Show()

            Case "pr2"
                PictureBox12.BackgroundImage = My.Resources.pr3
                Label1.Text = "pr3"

                PictureBox6.BackgroundImage = My.Resources.gra_cheshire
                PictureBox7.BackgroundImage = My.Resources.gra_drake
                PictureBox8.BackgroundImage = My.Resources.gra_mainz
                PictureBox9.BackgroundImage = My.Resources.gra_odin
                PictureBox10.BackgroundImage = My.Resources.gra_champagne
                PictureBox11.Hide()

                PictureBox14.Hide()
                PictureBox16.Show()
                PictureBox17.Hide()

            Case "pr3"
                PictureBox12.BackgroundImage = My.Resources.pr1
                Label1.Text = "pr1"

                PictureBox11.Show()

                PictureBox6.BackgroundImage = My.Resources.gra_saint
                PictureBox7.BackgroundImage = My.Resources.gra_roon
                PictureBox8.BackgroundImage = My.Resources.gra_neptune
                PictureBox9.BackgroundImage = My.Resources.gra_monarch
                PictureBox10.BackgroundImage = My.Resources.gra_ibuki
                PictureBox11.BackgroundImage = My.Resources.gra_izumo

                PictureBox14.Show()
                PictureBox16.Hide()
                PictureBox17.Hide()

            Case Else
                Exit Select
        End Select

    End Sub

    Public Sub parents()

        With Label2
            .Parent = PictureBox15
            .Location = New Point(Label2.Location.X - PictureBox15.Location.X, Label2.Location.Y - PictureBox15.Location.Y)
        End With

        With Label3
            .Parent = PictureBox15
            .Location = New Point(Label3.Location.X - PictureBox15.Location.X, Label3.Location.Y - PictureBox15.Location.Y)
        End With

        With Label6
            .Parent = PictureBox3
            .Location = New Point(Label6.Location.X - PictureBox3.Location.X, Label6.Location.Y - PictureBox3.Location.Y)
        End With

        With Label7
            .Parent = PictureBox3
            .Location = New Point(Label7.Location.X - PictureBox3.Location.X, Label7.Location.Y - PictureBox3.Location.Y)
        End With

        With Label8
            .Parent = PictureBox3
            .Location = New Point(Label8.Location.X - PictureBox3.Location.X, Label8.Location.Y - PictureBox3.Location.Y)
        End With

        With Label9
            .Parent = PictureBox3
            .Location = New Point(Label9.Location.X - PictureBox3.Location.X, Label9.Location.Y - PictureBox3.Location.Y)
        End With

        With Label10
            .Parent = PictureBox3
            .Location = New Point(Label10.Location.X - PictureBox3.Location.X, Label10.Location.Y - PictureBox3.Location.Y)
        End With

        With Label11
            .Parent = PictureBox3
            .Location = New Point(Label11.Location.X - PictureBox3.Location.X, Label11.Location.Y - PictureBox3.Location.Y)
        End With

        With Label13
            .Parent = PictureBox3
            .Location = New Point(Label13.Location.X - PictureBox3.Location.X, Label13.Location.Y - PictureBox3.Location.Y)
        End With

        With PictureBox6
            .Parent = PictureBox5
            .Location = New Point(PictureBox6.Location.X - PictureBox5.Location.X, PictureBox6.Location.Y - PictureBox5.Location.Y)
        End With

        With PictureBox7
            .Parent = PictureBox5
            .Location = New Point(PictureBox7.Location.X - PictureBox5.Location.X, PictureBox7.Location.Y - PictureBox5.Location.Y)
        End With

        With PictureBox8
            .Parent = PictureBox5
            .Location = New Point(PictureBox8.Location.X - PictureBox5.Location.X, PictureBox8.Location.Y - PictureBox5.Location.Y)
        End With

        With PictureBox9
            .Parent = PictureBox5
            .Location = New Point(PictureBox9.Location.X - PictureBox5.Location.X, PictureBox9.Location.Y - PictureBox5.Location.Y)
        End With

        With PictureBox10
            .Parent = PictureBox5
            .Location = New Point(PictureBox10.Location.X - PictureBox5.Location.X, PictureBox10.Location.Y - PictureBox5.Location.Y)
        End With

        With PictureBox11
            .Parent = PictureBox5
            .Location = New Point(PictureBox11.Location.X - PictureBox5.Location.X, PictureBox11.Location.Y - PictureBox5.Location.Y)
        End With

        With PictureBox12
            .Parent = PictureBox5
            .Location = New Point(PictureBox12.Location.X - PictureBox5.Location.X, PictureBox12.Location.Y - PictureBox5.Location.Y)
        End With

        With PictureBox13
            .Parent = PictureBox5
            .Location = New Point(PictureBox13.Location.X - PictureBox5.Location.X, PictureBox13.Location.Y - PictureBox5.Location.Y)
        End With

        With PictureBox14
            .Parent = PictureBox5
            .Location = New Point(PictureBox14.Location.X - PictureBox5.Location.X, PictureBox14.Location.Y - PictureBox5.Location.Y)
        End With

        With PictureBox16
            .Parent = PictureBox5
            .Location = New Point(PictureBox16.Location.X - PictureBox5.Location.X, PictureBox16.Location.Y - PictureBox5.Location.Y)
        End With

        With PictureBox17
            .Parent = PictureBox5
            .Location = New Point(PictureBox17.Location.X - PictureBox5.Location.X, PictureBox17.Location.Y - PictureBox5.Location.Y)
        End With

        With PictureBox18
            .Parent = PictureBox19
            .Location = New Point(PictureBox18.Location.X - PictureBox19.Location.X, PictureBox18.Location.Y - PictureBox19.Location.Y)
        End With

        With Label4
            .Parent = PictureBox19
            .Location = New Point(Label4.Location.X - PictureBox19.Location.X, Label4.Location.Y - PictureBox19.Location.Y)
        End With

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = My.Settings.pr
        TextBox1.Text = My.Settings.cantporflota
        TextBox2.Text = My.Settings.combporstage
        TextBox3.Text = My.Settings.exppromedio
        TextBox5.Text = My.Settings.meta
        TextBox6.Text = My.Settings.poractual
        Me.BackgroundImage = My.Resources.ResourceManager.GetObject(My.Settings.waifu)
        Label3.Text = My.Settings.catwaifu
        Label2.Text = My.Settings.waifu
        Label12.Text = My.Settings.waifu


        CantidadPerFlota = Val(TextBox1.Text)
        CombatesPerStage = Val(TextBox2.Text)
        ExpPerEachOne = Val(TextBox3.Text)

        Dim suma = CantidadPerFlota * ExpPerEachOne * CombatesPerStage

        Label9.Text = $"Experiencia ganada: {suma}"

        Meta = Val(TextBox5.Text)
        PercAct = Val(TextBox6.Text)

        Label13.Text = $"Repetir {Math.Round((Meta - (Meta * PercAct / 100)) / Val(suma), 0, MidpointRounding.AwayFromZero)} veces"

        parents()


        Select Case My.Settings.pr
            Case "pr1"
                prbutton("pr3")
            Case "pr2"
                prbutton("pr1")
            Case "pr3"
                prbutton("pr2")

        End Select



    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.cantporflota = TextBox1.Text
        My.Settings.combporstage = TextBox2.Text
        My.Settings.exppromedio = TextBox3.Text
        My.Settings.meta = TextBox5.Text
        My.Settings.poractual = TextBox6.Text
        My.Settings.pr = Label1.Text.ToString
        My.Settings.catwaifu = Label3.Text
        My.Settings.waifu = Label12.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        CantidadPerFlota = Val(TextBox1.Text)
        CombatesPerStage = Val(TextBox2.Text)
        ExpPerEachOne = Val(TextBox3.Text)

        Dim suma = CantidadPerFlota * ExpPerEachOne * CombatesPerStage

        Label9.Text = $"Experiencia ganada: {suma}"

        Meta = Val(TextBox5.Text)
        PercAct = Val(TextBox6.Text)

        Label13.Text = $"Repetir {Math.Round((Meta - (Meta * PercAct / 100)) / Val(suma), 0, MidpointRounding.AwayFromZero)} veces"

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

        prbutton(Label1.Text)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        Select Case Label1.Text
            Case "pr1"
                Me.BackgroundImage = My.Resources.Saint_Louis

                Label12.Text = "Saint_Louis"
                Label2.Text = "Saint Louis"
                Label3.Text = "CA"
            Case "pr2"
                Me.BackgroundImage = My.Resources.Seattle

                Label12.Text = "Seattle"
                Label2.Text = "Seattle"
                Label3.Text = "CL"
            Case "pr3"
                Me.BackgroundImage = My.Resources.Cheshire

                Label12.Text = "Cheshire"
                Label2.Text = "Cheshire"
                Label3.Text = "CA"
        End Select


    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

        Select Case Label1.Text
            Case "pr1"
                Me.BackgroundImage = My.Resources.Roon

                Label12.Text = "Roon"
                Label2.Text = "Roon"
                Label3.Text = "CA"
            Case "pr2"
                Me.BackgroundImage = My.Resources.Georgia

                Label12.Text = "Georgia"
                Label2.Text = "Georgia"
                Label3.Text = "BB"
            Case "pr3"
                Me.BackgroundImage = My.Resources.Drake

                Label12.Text = "Drake"
                Label2.Text = "Drake"
                Label3.Text = "CA"
        End Select


    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

        Select Case Label1.Text
            Case "pr1"
                Me.BackgroundImage = My.Resources.Neptune

                Label12.Text = "Neptune"
                Label2.Text = "Neptune"
                Label3.Text = "CL"

            Case "pr2"
                Me.BackgroundImage = My.Resources.Kitakaze

                Label12.Text = "Kitakaze"
                Label2.Text = "Kitakaze"
                Label3.Text = "DD"

            Case "pr3"
                Me.BackgroundImage = My.Resources.Mainz

                Label12.Text = "Mainz"
                Label2.Text = "Mainz"
                Label3.Text = "CL"

        End Select


    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        Select Label1.Text
            Case "pr1"
                Me.BackgroundImage = My.Resources.Monarch

                Label12.Text = "Monarch"
                Label2.Text = "Monarch"
                Label3.Text = "BB"

            Case "pr2"
                Me.BackgroundImage = My.Resources.Azuma

                Label12.Text = "Azuma"
                Label2.Text = "Azuma"
                Label3.Text = "CB"

            Case "pr3"
                Me.BackgroundImage = My.Resources.Odin

                Label12.Text = "Odin"
                Label2.Text = "Odin"
                Label3.Text = "BC"

        End Select


    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

        Select Case Label1.Text
            Case "pr1"
                Me.BackgroundImage = My.Resources.Ibuki

                Label12.Text = "Ibuki"
                Label2.Text = "Ibuki"
                Label3.Text = "CA"

            Case "pr2"
                Me.BackgroundImage = My.Resources.Friedrich

                Label12.Text = "Friedrich"
                Label2.Text = "Friedrih der GroBe"
                Label3.Text = "BB"

            Case "pr3"
                Me.BackgroundImage = My.Resources.Champagne

                Label12.Text = "Champagne"
                Label2.Text = "Champagne"
                Label3.Text = "BB"

        End Select


    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

        Select Case Label1.Text
            Case "pr1"
                Me.BackgroundImage = My.Resources.Izumo

                Label12.Text = "Izumo"
                Label2.Text = "Izumo"
                Label3.Text = "BB"

            Case "pr2"
                Me.BackgroundImage = My.Resources.Gascogne

                Label12.Text = "Gascogne"
                Label2.Text = "Gascogne"
                Label3.Text = "BB"

        End Select

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Select Case Panel1.Visible
            Case True
                Panel1.Hide()
                Panel2.Hide()
                PictureBox2.Hide()
                Panel3.Hide()
                Panel4.Hide()
            Case Else
                Panel1.Show()
                Panel2.Show()
                PictureBox2.Show()
                Panel3.Show()
                Panel4.Show()
        End Select
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Form4.Show()
        Me.Visible = False
    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class
Imports System.ComponentModel

Public Class Form1
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public CantidadPerFlota As Integer
    Public CombatesPerStage As Integer
    Public ExpPerEachOne As Integer
    Public Meta As Integer
    Public PercAct As Integer

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp

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
            Case "pr2"
                PictureBox12.BackgroundImage = My.Resources.pr3
                Label1.Text = "pr3"

                PictureBox6.BackgroundImage = My.Resources.gra_cheshire
                PictureBox7.BackgroundImage = My.Resources.gra_drake
                PictureBox8.BackgroundImage = My.Resources.gra_mainz
                PictureBox9.BackgroundImage = My.Resources.gra_odin
                PictureBox10.BackgroundImage = My.Resources.gra_champagne
                PictureBox11.Hide()
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
            Case Else
                Exit Select
        End Select

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = My.Settings.pr
        TextBox1.Text = My.Settings.cantporflota
        TextBox2.Text = My.Settings.combporstage
        TextBox3.Text = My.Settings.exppromedio
        TextBox5.Text = My.Settings.meta
        TextBox6.Text = My.Settings.poractual
        PictureBox1.BackgroundImage = My.Resources.ResourceManager.GetObject(My.Settings.waifu)
        Label3.Text = My.Settings.catwaifu
        Label2.Text = My.Settings.waifu
        Label12.Text = My.Settings.waifu

        PictureBox1.Size = New Size(My.Settings.pic1sizew, My.Settings.pic1sizeh)

        PictureBox1.Location = New Point(My.Settings.pic1locx, My.Settings.pic1locy)

        CantidadPerFlota = Val(TextBox1.Text)
        CombatesPerStage = Val(TextBox2.Text)
        ExpPerEachOne = Val(TextBox3.Text)

        Dim suma = CantidadPerFlota * ExpPerEachOne * CombatesPerStage

        Label9.Text = $"Experiencia ganada: {suma}"

        Meta = Val(TextBox5.Text)
        PercAct = Val(TextBox6.Text)

        Label13.Text = $"Repetir {Math.Round((Meta - (Meta * PercAct / 100)) / Val(suma), 0, MidpointRounding.AwayFromZero)} veces"


        With TransparentPictureBox1
            .Image = My.Resources.ban
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With

        With TransparentPictureBox2
            .Image = My.Resources.ver
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With

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
        My.Settings.pic1sizew = PictureBox1.Size.Width
        My.Settings.pic1sizeh = PictureBox1.Size.Height
        My.Settings.pic1locx = PictureBox1.Location.X
        My.Settings.pic1locy = PictureBox1.Location.Y

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        Form4.Show()
        Me.Visible = False
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

    Private Sub TransparentPictureBox2_Click(sender As Object, e As EventArgs) Handles TransparentPictureBox2.Click
        Select Case Panel1.Visible
            Case True
                Panel1.Hide()
                Label2.Hide()
                Label3.Hide()
                TransparentPictureBox1.Hide()
                PictureBox2.Hide()
                PictureBox5.Hide()
                PictureBox6.Hide()
                PictureBox7.Hide()
                PictureBox8.Hide()
                PictureBox9.Hide()
                PictureBox10.Hide()
                PictureBox11.Hide()
                PictureBox12.Hide()
                PictureBox13.Hide()
            Case Else
                Label2.Show()
                Label3.Show()
                TransparentPictureBox1.Show()
                Panel1.Show()
                PictureBox2.Show()
                PictureBox5.Show()
                PictureBox6.Show()
                PictureBox7.Show()
                PictureBox8.Show()
                PictureBox9.Show()
                PictureBox10.Show()
                PictureBox11.Show()
                PictureBox12.Show()
                PictureBox13.Show()
        End Select
    End Sub



    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

        prbutton(Label1.Text)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        Select Case Label1.Text
            Case "pr1"
                PictureBox1.BackgroundImage = My.Resources.Saint_Louis
                PictureBox1.Location = New Point(-66, -168)
                PictureBox1.Size = New Size(1014, 924)

                Label12.Text = "Saint_Louis"
                Label2.Text = "Saint Louis"
                Label3.Text = "CA"
            Case "pr2"
                PictureBox1.BackgroundImage = My.Resources.Seattle
                PictureBox1.Location = New Point(-33, 90)
                PictureBox1.Size = New Size(930, 612)

                Label12.Text = "Seattle"
                Label2.Text = "Seattle"
                Label3.Text = "CL"
            Case "pr3"
                PictureBox1.BackgroundImage = My.Resources.Cheshire
                PictureBox1.Location = New Point(6, 4)
                PictureBox1.Size = New Size(977, 723)

                Label12.Text = "Cheshire"
                Label2.Text = "Cheshire"
                Label3.Text = "CA"
        End Select

        TransparentPictureBox1.Refresh()
        TransparentPictureBox2.Refresh()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

        Select Case Label1.Text
            Case "pr1"
                PictureBox1.BackgroundImage = My.Resources.Roon
                PictureBox1.Location = New Point(13, -49)
                PictureBox1.Size = New Size(929, 818)

                Label12.Text = "Roon"
                Label2.Text = "Roon"
                Label3.Text = "CA"
            Case "pr2"
                PictureBox1.BackgroundImage = My.Resources.Georgia
                PictureBox1.Location = New Point(0, 43)
                PictureBox1.Size = New Size(930, 671)

                Label12.Text = "Georgia"
                Label2.Text = "Georgia"
                Label3.Text = "BB"
            Case "pr3"
                PictureBox1.BackgroundImage = My.Resources.Drake
                PictureBox1.Location = New Point(-48, -17)
                PictureBox1.Size = New Size(1020, 790)

                Label12.Text = "Drake"
                Label2.Text = "Drake"
                Label3.Text = "CA"
        End Select

        TransparentPictureBox1.Refresh()
        TransparentPictureBox2.Refresh()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

        Select Case Label1.Text
            Case "pr1"
                PictureBox1.BackgroundImage = My.Resources.Neptune
                PictureBox1.Location = New Point(58, 66)
                PictureBox1.Size = New Size(775, 679)

                Label12.Text = "Neptune"
                Label2.Text = "Neptune"
                Label3.Text = "CL"
            Case "pr2"
                PictureBox1.BackgroundImage = My.Resources.Kitakaze
                PictureBox1.Location = New Point(-8, 3)
                PictureBox1.Size = New Size(820, 610)

                Label12.Text = "Kitakaze"
                Label2.Text = "Kitakaze"
                Label3.Text = "DD"
            Case "pr3"
                PictureBox1.BackgroundImage = My.Resources.Mainz
                PictureBox1.Location = New Point(-105, -227)
                PictureBox1.Size = New Size(1155, 1005)

                Label12.Text = "Mainz"
                Label2.Text = "Mainz"
                Label3.Text = "CL"
        End Select

        TransparentPictureBox1.Refresh()
        TransparentPictureBox2.Refresh()

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        Select Label1.Text
            Case "pr1"
                PictureBox1.BackgroundImage = My.Resources.Monarch
                PictureBox1.Location = New Point(-37, -69)
                PictureBox1.Size = New Size(943, 821)

                Label12.Text = "Monarch"
                Label2.Text = "Monarch"
                Label3.Text = "BB"
            Case "pr2"
                PictureBox1.BackgroundImage = My.Resources.Azuma
                PictureBox1.Location = New Point(12, 43)
                PictureBox1.Size = New Size(936, 642)

                Label12.Text = "Azuma"
                Label2.Text = "Azuma"
                Label3.Text = "CB"
            Case "pr3"
                PictureBox1.BackgroundImage = My.Resources.Odin
                PictureBox1.Location = New Point(-71, -162)
                PictureBox1.Size = New Size(1090, 969)

                Label12.Text = "Odin"
                Label2.Text = "Odin"
                Label3.Text = "BC"
        End Select

        TransparentPictureBox1.Refresh()
        TransparentPictureBox2.Refresh()

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

        Select Case Label1.Text
            Case "pr1"
                PictureBox1.BackgroundImage = My.Resources.Ibuki
                PictureBox1.Location = New Point(-63, 67)
                PictureBox1.Size = New Size(1031, 821)

                Label12.Text = "Ibuki"
                Label2.Text = "Ibuki"
                Label3.Text = "CA"
            Case "pr2"

                PictureBox1.BackgroundImage = My.Resources.Friedrich
                PictureBox1.Location = New Point(-116, -92)
                PictureBox1.Size = New Size(1154, 852)

                Label12.Text = "Friedrich"
                Label2.Text = "Friedrih der GroBe"
                Label3.Text = "BB"
            Case "pr3"
                PictureBox1.BackgroundImage = My.Resources.Champagne
                PictureBox1.Location = New Point(-347, -210)
                PictureBox1.Size = New Size(1672, 1091)

                Label12.Text = "Champagne"
                Label2.Text = "Champagne"
                Label3.Text = "BB"
        End Select

        TransparentPictureBox1.Refresh()
        TransparentPictureBox2.Refresh()

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

        Select Case Label1.Text
            Case "pr1"
                PictureBox1.BackgroundImage = My.Resources.Izumo
                PictureBox1.Location = New Point(-166, -58)
                PictureBox1.Size = New Size(1479, 861)

                Label12.Text = "Izumo"
                Label2.Text = "Izumo"
                Label3.Text = "BB"
            Case "pr2"
                PictureBox1.BackgroundImage = My.Resources.Gascogne
                PictureBox1.Location = New Point(-103, -112)
                PictureBox1.Size = New Size(1154, 852)

                Label12.Text = "Gascogne"
                Label2.Text = "Gascogne"
                Label3.Text = "BB"
        End Select

        TransparentPictureBox1.Refresh()
        TransparentPictureBox2.Refresh()

    End Sub
End Class
Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim frm As New Agregar()
        frm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Panel1.Visible = True
        Label1.Visible = True

        Dim testo As New texto()
        Dim iami As New Imagen()
        testo.obtenerdatos()
        iami.obtenerdatos()

        Label3.Text = testo.mostrarpregunta()
        Label4.Text = testo.mostrarrespeusta()

        Try

            PictureBox1.Image = Image.FromFile(iami.CargarImagen())

        Catch ex As Exception

        End Try






    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        Label1.Visible = False

        Label4.Visible = False

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Panel1.Visible = False
        Label1.Visible = False




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Label4.Visible = True
        PictureBox1.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Panel1.Visible = True
        Label1.Visible = True
        Label4.Visible = False

        Dim testo As New texto()
        Dim iami As New Imagen()
        testo.obtenerdatos()
        iami.obtenerdatos()

        Label3.Text = testo.mostrarpregunta()
        Label4.Text = testo.mostrarrespeusta()



        Try

            PictureBox1.Image = Image.FromFile(iami.CargarImagen())
        Catch ex As Exception

        End Try


    End Sub
End Class

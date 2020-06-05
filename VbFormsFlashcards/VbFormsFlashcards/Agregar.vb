Imports System.IO

Public Class Agregar
    Private Sub Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button2.Visible = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then

            Button2.Visible = True
            PictureBox1.Visible = True
        Else
            Button2.Visible = False
            PictureBox1.Visible = False
        End If


    End Sub


    Dim lugar As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim open As New OpenFileDialog()
        open.Filter = "Image Files(*.jpg)|*.jpg"

        If open.ShowDialog() = DialogResult.OK Then

            PictureBox1.Image = New Bitmap(open.FileName)
            lugar = open.FileName

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton2.Checked = True Then

            Dim ruta As String = "C:\Users\oscar\Desktop\Imagen\"
            Dim rutaynombre As String = ruta & TextBox1.Text & ".jpg"
            Dim img As New FlashCardsArchivosImagen(lugar, rutaynombre)

            Dim grd As New FlashCardsArchivos()
            grd.GuardarTexto("C:\Users\oscar\Desktop\Puntaje\", TextBox1.Text, TextBox2.Text)

        Else
            Dim grd As New FlashCardsArchivos()
            grd.GuardarTexto("C:\Users\oscar\Desktop\Puntaje\", TextBox1.Text, TextBox2.Text)

        End If


    End Sub
End Class
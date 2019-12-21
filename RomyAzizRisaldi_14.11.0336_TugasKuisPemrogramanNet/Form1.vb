'@author : Romy Aziz Risaldi 14.11.0336'
'Jangan Asal Copas,Modif dikit dong :D'
'DEBUG1 : isi dari Subroutine new() dipindahkan ke form1load biar secara default tampilan combobox dan label pada minuman tidak tampil ketika launch app pertama kali beserta komponen seperti textbox2
'DEBUG2 : Sesuaikan nama label dan combobox sesuai logika program'
'DEBUG3 : pada form1load isikan komponen textbox2 yg berisi minuman dengan nilai 0 agar secara default ketika tidak memilih minuman isinya textboxnya 0 dan agar program bisa berjalan. 
Public Class Form1
    Public hrgmakanan, hrgminuman As Integer

    Private Sub cbbox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbox2.SelectedIndexChanged

        Select Case cbbox2.Text
            Case “Es Jeruk”
                Label2.Text = “Rp. 3000”
                hrgminuman = 3000
            Case “Jus Alpukat”
                Label2.Text = “Rp. 7000”
                hrgminuman = 7000
            Case “Teh Manis”
                Label2.Text = “Rp. 4000”
                hrgminuman = 4000
        End Select

    End Sub

    Private Sub cbbox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbox1.SelectedIndexChanged
        Select Case cbbox1.Text
            Case “Nasi Uduk”
                Label1.Text = “Rp. 3500”
                hrgmakanan = 3500
            Case “Bakso”
                Label1.Text = “Rp. 6000”
                hrgmakanan = 6000
            Case “Mie Ayam”
                Label1.Text = “Rp. 7000”
                hrgmakanan = 7000
        End Select

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Enabled = False Then
            cbbox2.Visible = False
            TextBox2.Visible = False
            TextBox2.Text = 0

        End If
        If CheckBox1.Enabled = True Then
            cbbox2.Visible = True
            Label2.Visible = True
            TextBox2.Visible = True
        End If
        If CheckBox1.Checked = False Then
            cbbox2.Visible = False
            TextBox2.Visible = False
            TextBox2.Text = 0
            Label2.Visible = False
        End If

        If CheckBox1.Checked = True Then
            cbbox2.Visible = True
            Label2.Visible = True
            TextBox2.Visible = True


        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This call is required by the designer. InitializeComponent()'
        cbbox2.Visible = False
        ' Add any initialization after the InitializeComponent() call'
        Label2.Visible = False
        TextBox2.Visible = False
        TextBox2.Text = 0

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnjumlah.Click
        Dim porsimkn, porsimnm, jumlah As Integer

        porsimkn = TextBox1.Text
        porsimnm = TextBox2.Text
        jumlah = (hrgmakanan * porsimkn) + (hrgminuman * porsimnm)
        txtboxjumlah.Text = “Rp. ” & jumlah.ToString

    End Sub




End Class

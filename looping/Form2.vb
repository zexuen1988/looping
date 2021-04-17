Public Class Form2
    Private Sub BtnClick_Click(sender As Object, e As EventArgs) Handles BtnClick.Click
        Dim strKelas(5, 2) As String
        strKelas(0, 0) = "DDT1A"
        strKelas(0, 1) = "DDT1B"
        strKelas(0, 2) = "DDT2A"
        strKelas(1, 0) = "DDT2B"
        strKelas(1, 1) = "DDT2C"
        strKelas(1, 2) = "DDT2D"
        strKelas(2, 0) = "DDT3A"
        strKelas(2, 1) = "DDT3B"
        strKelas(2, 2) = "DDT3C"
        strKelas(3, 0) = "DDT3D"
        strKelas(3, 1) = "DDT4A"
        strKelas(3, 2) = "DDT4B"
        strKelas(4, 0) = "DDT4C"
        strKelas(4, 1) = "DDT4D"
        strKelas(4, 2) = "DDT5A"
        strKelas(5, 0) = "DDT5B"
        strKelas(5, 1) = "DDT5C"
        strKelas(5, 2) = "DDT5D"
        For x = 0 To 5
            For y = 0 To 2
                LstAnswer.Items.Add(strKelas(x, y))
            Next
        Next
    End Sub
End Class
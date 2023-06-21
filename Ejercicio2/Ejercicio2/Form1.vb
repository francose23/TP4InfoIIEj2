Public Class Form
    Dim Matriz(5, 4), NroFila, Mat(5, 4), SumaFilai, SumaTotal, May As Integer
    Private Function SumaFila(ByRef Mat(,) As Integer, ByVal NroFila As Integer)
        Dim Sumar, Suma As Integer
        For i = 1 To 4
            Sumar = Sumar + Mat(NroFila, i)
        Next
        Suma = Sumar
        Return Suma
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For a = 1 To 4
            dgMostrar.Columns.Add("", "")
            dgMostrar.Columns(a - 1).Width = 40
        Next
        dgMostrar.Rows.Add(5)
        For a = 1 To 4
            dgIngresar.Columns.Add("", "")
            dgIngresar.Columns(a - 1).Width = 40
        Next
        dgIngresar.Rows.Add(5)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        For Fila = 1 To 5
            For Columna = 1 To 4
                Matriz(Fila, Columna) = dgIngresar.Item(Columna - 1, Fila - 1).Value
            Next
        Next

        For Fila = 1 To 5
            For Columna = 1 To 4
                dgMostrar.Item(Columna - 1, Fila - 1).Value = Matriz(Fila, Columna)
            Next
        Next
        For i = 2 To 5
            SumaFilai = SumaFila(Matriz, i)
            SumaTotal = SumaTotal + SumaFilai
            lstSalida.Items.Add("La suma de la fila " & i & " es: " & SumaFilai)
        Next
        lstSalida.Items.Add("La suma total de las filas 2, 3, 4 y 5 es: " & SumaTotal)
        For Fila = 1 To 5
            For Columna = 2 To 4
                If Matriz(Fila, Columna) > May Then
                    May = Matriz(Fila, Columna)
                End If
            Next
        Next
        lstSalida.Items.Add("El mayor número de las últimas tres columnas es: " & May)
    End Sub

    Private Sub lstSalida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSalida.SelectedIndexChanged

    End Sub

    Private Sub dgIngresar_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgIngresar.CellContentClick

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class

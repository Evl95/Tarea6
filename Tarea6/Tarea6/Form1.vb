Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'PRIMERO VAMOS A CONFIGURAR LOS NUMEROS A Y B.
    'Crearemos las 4 funciones primero (Disminuir A, Disminuir B, Aumentar A, Aumentar B)

    'Disminuir A:
    Function DisminuirA(TextoA As String) As String
        Dim numero As Integer = Int32.Parse(TextoA)
        Dim newtext As String
        numero = numero - 1
        newtext = numero.ToString
        Return newtext
    End Function

    'Disminuir B:
    Function DisminuirB(TextoB As String) As String
        Dim numero As Integer = Int32.Parse(TextoB)
        Dim newtext As String
        numero = numero - 1
        newtext = numero.ToString
        Return newtext
    End Function

    'Aumentar A:
    Function AumentarA(TextoA As String) As String
        Dim numero As Integer = Int32.Parse(TextoA)
        Dim newtext As String
        numero = numero + 1
        newtext = numero.ToString
        Return newtext
    End Function

    'Disminuir B:
    Function AumentarB(TextoB As String) As String
        Dim numero As Integer = Int32.Parse(TextoB)
        Dim newtext As String
        numero = numero + 1
        newtext = numero.ToString
        Return newtext
    End Function

    'Una vez tenemos todas las funciones ya solo las llamamos en sus botones correspondientes

    'Procedemos a crear las funciones aritmeticas
    Function SumaA(numA As Integer, numB As Integer) As Integer
        Dim ResultadoSuma As Integer
        ResultadoSuma = numA + numB
        Return ResultadoSuma
    End Function

    Function RestaA(numA As Integer, numB As Integer) As Integer
        Dim ResultadoResta As Integer
        ResultadoResta = numA - numB
        Return ResultadoResta
    End Function

    Function MultA(numA As Integer, numB As Integer) As Integer
        Dim ResultadoMult As Integer
        ResultadoMult = numA * numB
        Return ResultadoMult
    End Function

    Function DivA(numA As Integer, numB As Integer) As Integer
        Dim ResultadoDiv As Integer
        ResultadoDiv = numA / numB
        Return ResultadoDiv
    End Function


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnBAum.Click
        Dim numEntrante As String = lblB.Text
        numEntrante = AumentarB(numEntrante)
        lblB.Text = numEntrante
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnClean.Click

    End Sub

    Private Sub BtnResta_Click(sender As Object, e As EventArgs) Handles BtnResta.Click
        Dim txtA = lblA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lblB.Text
        Dim numB = Int32.Parse(txtB)

        Dim RespResta = RestaA(numA, numB)
        TextoImp.Text = "El resultado de la resta es: " + RespResta.ToString
    End Sub

    Private Sub BtnMult_Click(sender As Object, e As EventArgs) Handles BtnMult.Click
        Dim txtA = lblA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lblB.Text
        Dim numB = Int32.Parse(txtB)

        Dim RespMult = MultA(numA, numB)
        TextoImp.Text = "El resultado de la multiplicación es: " + RespMult.ToString
    End Sub

    Private Sub BtnDiv_Click(sender As Object, e As EventArgs) Handles BtnDiv.Click
        Dim txtA = lblA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lblB.Text
        Dim numB = Int32.Parse(txtB)

        Dim RespDivision = DivA(numA, numB)
        TextoImp.Text = "El resultado de la división es: " + RespDivision.ToString
    End Sub

    Private Sub BtnBDis_Click(sender As Object, e As EventArgs) Handles BtnBDis.Click
        Dim numEntrante As String = lblB.Text
        numEntrante = DisminuirB(numEntrante)
        lblB.Text = numEntrante
    End Sub

    Private Sub BtnADis_Click(sender As Object, e As EventArgs) Handles BtnADis.Click
        Dim numEntrante As String = lblA.Text
        numEntrante = DisminuirA(numEntrante)
        lblA.Text = numEntrante
    End Sub

    Private Sub BtnAAum_Click(sender As Object, e As EventArgs) Handles BtnAAum.Click
        Dim numEntrante As String = lblA.Text
        numEntrante = AumentarA(numEntrante)
        lblA.Text = numEntrante
    End Sub

    Private Sub BtnSuma_Click(sender As Object, e As EventArgs) Handles BtnSuma.Click
        Dim txtA = lblA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lblB.Text
        Dim numB = Int32.Parse(txtB)

        Dim RespSuma = SumaA(numA, numB)
        TextoImp.Text = "El resultado de la suma es: " + RespSuma.ToString
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class

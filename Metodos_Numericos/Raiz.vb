Public Class Raiz
    'Complementa la funcion del modulo de datos para validar el contenido de los datos que se ingresan a un textbox
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        NumerosyDecimal(TextBox1, e)
    End Sub
    Private Sub UserForm_QueryClose(CloseMode As Integer)
        If CloseMode = 0 Then
            MetodosNumericos.Show()
            Me.Close()
        End If
    End Sub
    ' Al hacer clic en el boton de calcular
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Si dan clic y no hay valores en TextBox1 entonces manda un mensaje de error 
        If TextBox1.Text = "" Then
            MsgBox("Error: Ingresa un Número por favor", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If TextBox1.Text = "0" Then
            MsgBox("Introduce un valor diferente de cero o voy a explotar", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'Inicio del procedimiento
        'Primero limpiamos el listbox
        Resultado.Items.Clear()

        'Declaramos una variable Raiz que es el valor que obtenemos del textbox ingresado por el usuario
        Dim Ans As Double
    ' Asignamos el valor del textbox convertido a la variable raiz 
        Ans = Double.Parse(TextBox1.Text)
        'Raiz Será el resultado de la ecuacion 
        'Dim Raiz As Double
        'Variable de almacen dos
        'Dim Raiz2 As Double
        ' n será el contador
        Dim n As Integer
    ' r será 0.5
    Dim r As Double
        r = 0.5
        Do While n <= Ans ' Mientras que el valor de la ecuacion sea mayor o igual al contador
            n = n + 1 ' El contador empieza en cero y va sumando 
            Ans = r * (Ans + (2 / Ans)) ' La ecuacion
            Resultado.Items.Add("Vuelta " & n & " = " & Ans) ' Muestra resultado en un listbox
        Loop
        TextBox1.Text = vbEmpty ' limpia el texbox 1

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
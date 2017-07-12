' Importación de librerías, usamos lo necesario para la conexión con Oracle y Excel

Imports System.Data.OracleClient
Imports WindowForm = System.Windows.Forms
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office

' Toda la aplicación está contenida en un formulario, el Form1

Public Class Form1

    ' la variable global registro apunta al registro del excel que contiene el informe que estamos mostrando en pantalla

    Dim registro As Integer = 2

    ' utilizamos las componentes de excel aplicación, colección de libros, libro y hoja de trabajo

    Dim xlsApp As Application = Nothing
    Dim xlsWorkBooks As Workbooks = Nothing
    Dim xlsWb As Workbook = Nothing
    Dim xlsWsT As Worksheet = Nothing

    'Definimos también un rango a nivel global para gestionar grupos de registros del Excel

    Dim rango As Range = Nothing

    ' La conexión se establece como una cadena, con el servidor, usuario y contraseña

    Dim conexion As String = "server = TFG; User Id = TFG; Password = TFG;"

    'Este procedimiento abre el excel con las consultas, pero no activa su visibilidad

    Sub AbrirExcel()

        xlsApp = New Application
        'xlsApp.Visible = True
        xlsWorkBooks = xlsApp.Workbooks
        xlsWb = xlsWorkBooks.Open("C:\Users\Public\Documents\Inventario de procesos TFG.xlsx")
        xlsWsT = xlsWb.Worksheets("H1")
        xlsWsT.Activate()

    End Sub

    ' Este procedimiento muestra una consulta del excel por pantalla

    Sub MostrarRegistro()

        ' los datos se muestran en cajas de texto TextBox

        Me.TextBoxProceso.Text = xlsWsT.Range("A" & registro).Value
        Me.TextBoxSQL.Text = xlsWsT.Range("B" & registro).Value
        Me.TextBoxInstrucciones.Text = xlsWsT.Range("C" & registro).Value

        Me.TextBoxTotal.Text = xlsApp.WorksheetFunction.Subtotal(3, xlsWsT.Range("A2:A1000"))
        Me.TextBoxRegistro.Text = registro - 1

        If (xlsApp.WorksheetFunction.Subtotal(3, xlsWsT.Range("A2:A1000"))) = 0 Then
            registro = 0
            Me.TextBoxRegistro.Text = 0
        End If

    End Sub

    ' Este procedimiento ejecuta un informe

    Sub Ejecutar()

        Dim consulta As String = TextBoxSQL.Text.Replace(";", " ")

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim cn As New OracleConnection(conexion)
        Dim da As New OracleDataAdapter(consulta, cn)

        Try

            Dim ds As New DataSet
            da.Fill(ds, "customers")
            Me.DataGridView1.DataSource = ds.Tables("customers")
        Catch ex As Exception
            MsgBox("Error de Query")
        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Arrow

    End Sub

    ' con el botón de avance se controla la navegación por consultas

    Private Sub ButtonAvance_Click(sender As Object, e As EventArgs) Handles ButtonAvance.Click
        If registro <= xlsApp.WorksheetFunction.Subtotal(3, xlsWsT.Range("A2:A1000")) Then
            registro = registro + 1
            Call MostrarRegistro()
            Me.DataGridView1.DataSource = Nothing
            Me.DataGridView1.Refresh()

            Me.DataGridView2.ClearSelection()
            Me.DataGridView2.Rows(registro - 2).Selected = True

        Else
            MsgBox("Ultimo Informe")
        End If

    End Sub

    ' con el botón atrás se controla la navegación por consultas

    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click
        If registro > 2 Then
            registro = registro - 1
            Call MostrarRegistro()
            Me.DataGridView1.DataSource = Nothing
            Me.DataGridView1.Refresh()

            Me.DataGridView2.ClearSelection()
            Me.DataGridView2.Rows(registro - 2).Selected = True

        Else
            MsgBox("Primer Informe")
        End If

    End Sub

    Private Sub ButtonEjecutar_Click(sender As Object, e As EventArgs) Handles ButtonEjecutar.Click
        Call Ejecutar()
    End Sub

    ' guardamos los datos en el fichero excel y actualizamos el control datagridview con los datos guardados

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click

        Call GuardarExcel()
        Call CargaPT()
        Me.DataGridView2.Rows(registro - 2).Selected = True

    End Sub

    ' almacenamos los datos modificados por el usuario en las cajas de texto, en el fichero excel

    Private Sub GuardarExcel()

        xlsWsT.Range("A" & registro).Value = Me.TextBoxProceso.Text.TrimEnd()
        xlsWsT.Range("B" & registro).Value = Me.TextBoxSQL.Text.TrimEnd()
        xlsWsT.Range("C" & registro).Value = Me.TextBoxInstrucciones.Text.TrimEnd()

        xlsWb.Unprotect()
        xlsWb.Save()

    End Sub

    'cierra el excel y luego el formulario

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        xlsWb.Close(False)
        xlsApp.Quit()
        Me.Close()
    End Sub

    'elimina un registro del excel y salva el fichero excel además de volver a cargar los datos para que no muestren
    'información eliminada

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        xlsWsT.Rows(registro).Delete()
        xlsWb.Unprotect()
        xlsWb.Save()
        Call CargaPT()
        registro = 2
        Call MostrarRegistro()

    End Sub

    'inserta un nuevo registro para un nuevo informe definido por el usuario

    Private Sub Insertar_Click(sender As Object, e As EventArgs) Handles Insertar.Click

        xlsWsT.Rows(registro + 1).Insert()
        registro = registro + 1

        xlsWsT.Range("A" & registro).Value = "XX"
        xlsWsT.Range("B" & registro).Value = "XX"
        xlsWsT.Range("C" & registro).Value = "XX"

        xlsWb.Unprotect()
        xlsWb.Save()
        Call CargaPT()
        Call MostrarRegistro()

    End Sub

    'carga en un control datagridview todas las consultas del usuario

    Private Sub CargaPT()

        'primero limpiamos el datagridview

        Me.DataGridView2.Rows.Clear()
        Me.DataGridView2.Columns.Clear()
        Me.DataGridView2.Refresh()


        ' contamos el numero de consultas y ajustamos el encabezado y ancho

        Dim longitud As Integer = xlsApp.WorksheetFunction.Subtotal(3, xlsWsT.Range("A2:A1000"))
        DataGridView2.Columns.Add("PC", "INFORMES")
        DataGridView2.Columns("PC").MinimumWidth = 100

        'añadimos las consultas

        For i As Integer = 0 To longitud - 1

            DataGridView2.Rows.Add()
            DataGridView2.Rows(i).Cells(0).Value = (xlsWsT.Range("A" & (i + 2)).Value)
        Next

        'ajustamos las columnas y filas

        DataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        DataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)


    End Sub

    'este procedimiento exporta a excel el resultado de la consulta

    Private Sub ButtonExcel_Click(sender As Object, e As EventArgs) Handles ButtonExcel.Click


        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets(1)

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        For i = 0 To DataGridView1.RowCount - 1
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next

        Try

            xlWorkSheet.SaveAs("C:\Users\Public\Documents\" & TextBoxProceso.Text & ".xlsx")

            ' mostramos por pantalla el fichero guardado y la ruta
            MsgBox("Exportado a C:\Users\Public\Documents\" & TextBoxProceso.Text & ".xlsx")
            xlWorkBook.Close()
            xlApp.Quit()

            'liberamos recursos de memoria

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

        Catch

        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Arrow

    End Sub

    'procedimiento para liberar recursos de memoria

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    'cada vez que hacemos click en un registro del grid, mostramos sus datos por pantalla

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.Refresh()
        registro = Me.DataGridView2.CurrentRow.Index + 2
        Call MostrarRegistro()


    End Sub

    ' con la siguiente función borramos una tabla de Oracle

    Private Sub BorrarTabla(tabla As String)

        Dim comando As String = "DROP TABLE " & tabla

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim cn As New OracleConnection(conexion)

        Try

            Dim oc As New OracleCommand(comando, cn)
            oc.Connection.Open()
            oc.CommandType = CommandType.Text
            oc.ExecuteNonQuery()
            MsgBox("Borrada información anterior, procediendo a la creación de la nueva tabla....")
        Catch
            MsgBox("No hay ninguna información previa, procediendo a la creación de la nueva tabla.....")
        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Arrow

    End Sub

    'procedimiento para segmentar clientes, con el código SQL incrustado'

    Private Sub ButtonSegmentar_Click(sender As Object, e As EventArgs) Handles ButtonSegmentar.Click

        Call BorrarTabla("CLIENTES_SEGMENTADOS")

        Dim comando As String = "CREATE TABLE CLIENTES_SEGMENTADOS AS 
                                 (
                                 SELECT CLI3.*, 
                                 CASE WHEN CLI3.SCORE_TOTAL > 
                                      (SELECT UMBRAL_INFERIOR FROM NIVELES_DE_RIESGO WHERE NIVEL = 'BLOQUEAR') 
                                      THEN 'BLOQUEAR'
                                 WHEN CLI3.SCORE_TOTAL > 
                                      (SELECT UMBRAL_INFERIOR FROM NIVELES_DE_RIESGO WHERE NIVEL = 'ALTO') AND
                                      CLI3.SCORE_TOTAL <= 
                                      (SELECT UMBRAL_SUPERIOR FROM NIVELES_DE_RIESGO WHERE NIVEL = 'ALTO')
                                      THEN 'ALTO'
                                 WHEN CLI3.SCORE_TOTAL > 
                                      (SELECT UMBRAL_INFERIOR FROM NIVELES_DE_RIESGO WHERE NIVEL = 'MEDIO') AND
                                      CLI3.SCORE_TOTAL <= 
                                      (SELECT UMBRAL_SUPERIOR FROM NIVELES_DE_RIESGO WHERE NIVEL = 'MEDIO')
                                      THEN 'MEDIO'
                                 ELSE 'BAJO' END AS NIVEL FROM
                                   (
                                   SELECT CLI2.*, (CLI2.PESO_LISTA + CLI2.PESO_PAIS_NACIMIENTO + 
                                   CLI2.PESO_PAIS_RESIDENCIA + CLI2.PESO_PAIS_NACIONALIDAD + 
                                   CLI2.PESO_ACTIVIDAD_ECONOMICA + CLI2.PESO_CANAL_DE_CONTRATACION) AS SCORE_TOTAL
                                   FROM
                                        (
                                        SELECT CLI.ID_CLIENTE, CLI.NOMBRE, CLI.APELLIDO1, CLI.APELLIDO2,
                                        FAC.CLASIFICACION,
                                        CASE FAC.CLASIFICACION 
                                            WHEN 'TERRORISTA' THEN (SELECT PESO FROM PESOS_COLISION_LISTA WHERE COLISION = 'TERRORISTA')
                                            WHEN 'NARCOTRAFICANTE' THEN (SELECT PESO FROM PESOS_COLISION_LISTA WHERE COLISION = 'NARCOTRAFICANTE')
                                            WHEN 'CONTRABANDISTA' THEN (SELECT PESO FROM PESOS_COLISION_LISTA WHERE COLISION = 'CONTRABANDISTA')
                                            WHEN 'PEP' THEN (SELECT PESO FROM PESOS_COLISION_LISTA WHERE COLISION = 'PEP')
                                            WHEN 'SANCIONADO' THEN (SELECT PESO FROM PESOS_COLISION_LISTA WHERE COLISION = 'SANCIONADO')
                                            WHEN 'PARIENTE PEP' THEN (SELECT PESO FROM PESOS_COLISION_LISTA WHERE COLISION = 'PARIENTE PEP')
                                            ELSE 0 END AS PESO_LISTA,
                                        CLI.PAIS_NACIMIENTO, PN.PESO AS PESO_PAIS_NACIMIENTO,
                                        CLI.PAIS_RESIDENCIA, PR.PESO AS PESO_PAIS_RESIDENCIA,
                                        CLI.PAIS_NACIONALIDAD, PNA.PESO AS PESO_PAIS_NACIONALIDAD,
                                        CLI.ACTIVIDAD_ECONOMICA, AE.PESO AS PESO_ACTIVIDAD_ECONOMICA,
                                        CLI.CANAL_DE_CONTRATACION, CA.PESO AS PESO_CANAL_DE_CONTRATACION
                                        FROM CLIENTES CLI 
                                        LEFT JOIN FACTIVA FAC ON CLI.NOMBRE = FAC.NOMBRE AND CLI.APELLIDO1 = FAC.APELLIDO1 AND CLI.APELLIDO2 = FAC.APELLIDO2
                                        LEFT JOIN PAIS_NACIMIENTO PN ON CLI.PAIS_NACIMIENTO = PN.PAIS
                                        LEFT JOIN PAIS_RESIDENCIA PR ON CLI.PAIS_RESIDENCIA = PR.PAIS
                                        LEFT JOIN PAIS_NACIONALIDAD PNA ON CLI.PAIS_NACIONALIDAD = PNA.PAIS
                                        LEFT JOIN ACTIVIDAD_ECONOMICA AE ON CLI.ACTIVIDAD_ECONOMICA = AE.ACTIVIDAD_ECONOMICA
                                        LEFT JOIN CANAL_DE_CONTRATACION CA ON CLI.CANAL_DE_CONTRATACION = CA.CANAL
                                        ) CLI2
                                    ORDER BY SCORE_TOTAL DESC
                                    ) CLI3
                                 )"

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim cn As New OracleConnection(conexion)

        Try

            Dim oc As New OracleCommand(comando, cn)
            oc.Connection.Open()
            oc.CommandType = CommandType.Text
            oc.ExecuteNonQuery()
            MsgBox("Clientes segmentados correctamente")

            Call MostrarTabla("CLIENTES_SEGMENTADOS")

        Catch
            MsgBox("Error en el proceso de segmentación")

        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Arrow


    End Sub

    'función para mostrar tabla

    Private Sub MostrarTabla(tabla As String)

        Dim consulta As String = "Select * from " & tabla

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim cn As New OracleConnection(conexion)
        Dim da As New OracleDataAdapter(consulta, cn)

        Try

            Dim ds As New DataSet
            da.Fill(ds, "customers")
            Me.DataGridView1.DataSource = ds.Tables("customers")
        Catch ex As Exception
            MsgBox("Error de Query")
        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Arrow

    End Sub

    'botón para generar las alertas por ingresos, con el código SQL incrustado

    Private Sub ButtonAlIngresos_Click(sender As Object, e As EventArgs) Handles ButtonAlIngresos.Click

        Call BorrarTabla("ALERTAS_INGRESOS")

        Dim comando As String = "CREATE TABLE ALERTAS_INGRESOS AS 
                                (
                                SELECT A.*, CLI.NOMBRE, CLI.APELLIDO1, CLI.APELLIDO2
                                FROM
                                (SELECT FECHA, ID_CLIENTE, SUM(CANTIDAD) AS TOTAL_INGRESADO_DIA 
                                FROM INGRESOS_CAJA
                                GROUP BY FECHA, ID_CLIENTE
                                HAVING SUM(CANTIDAD) > 3000
                                ) A
                                LEFT JOIN CLIENTES CLI
                                ON A.ID_CLIENTE = CLI.ID_CLIENTE
                                )"

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        ' creación de la conexión a Oracle

        Dim cn As New OracleConnection(conexion)

        Try

            Dim oc As New OracleCommand(comando, cn)
            oc.Connection.Open()
            oc.CommandType = CommandType.Text
            oc.ExecuteNonQuery()
            MsgBox("Alertas generadas correctamente")

            'llamamos a mostrar tabla para ver los resultados

            Call MostrarTabla("ALERTAS_INGRESOS")

        Catch
            MsgBox("Error en el proceso de generación de alertas")

        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Arrow


    End Sub

    ' botón para las alertas por transferencias nacionales emitidas, con el código SQL incrustado

    Private Sub ButtonTNE_Click(sender As Object, e As EventArgs) Handles ButtonTNE.Click
        Call BorrarTabla("ALERTAS_TNE")

        Dim comando As String = "CREATE TABLE ALERTAS_TNE AS 
                                 (
                                 SELECT TNE.*, FAC.CLASIFICACION AS CLASIFICACION_BENEFICIARIO
                                 FROM TRANSF_NAC_EMI TNE
                                 LEFT JOIN FACTIVA FAC
                                 ON TNE.NOMBRE_DESTINATARIO = FAC.NOMBRE AND
                                 TNE.APELLIDO1_DESTINATARIO = FAC.APELLIDO1 AND
                                 TNE.APELLIDO2_DESTINATARIO = FAC.APELLIDO2
                                 WHERE CLASIFICACION IN ('TERRORISTA', 'NARCOTRAFICANTE', 'CONTRABANDISTA')
                                 )"

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim cn As New OracleConnection(conexion)

        Try

            Dim oc As New OracleCommand(comando, cn)
            oc.Connection.Open()
            oc.CommandType = CommandType.Text
            oc.ExecuteNonQuery()
            MsgBox("Alertas generadas correctamente")

            Call MostrarTabla("ALERTAS_TNE")

        Catch
            MsgBox("Error en el proceso de generación de alertas")

        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    ' botón para las alertas por transferencias nacionales recibidas, con el código SQL incrustado

    Private Sub ButtonTNR_Click(sender As Object, e As EventArgs) Handles ButtonTNR.Click
        Call BorrarTabla("ALERTAS_TNR")

        Dim comando As String = "CREATE TABLE ALERTAS_TNR AS 
                                 (
                                 SELECT TNR.*, FAC.CLASIFICACION AS CLASIFICACION_EMISOR
                                 FROM TRANSF_NAC_REC TNR
                                 LEFT JOIN FACTIVA FAC
                                 ON TNR.NOMBRE_EMISOR = FAC.NOMBRE AND
                                 TNR.APELLIDO1_EMISOR = FAC.APELLIDO1 AND
                                 TNR.APELLIDO2_EMISOR = FAC.APELLIDO2
                                 WHERE CLASIFICACION IN ('TERRORISTA', 'NARCOTRAFICANTE', 'CONTRABANDISTA')
                                 )"

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim cn As New OracleConnection(conexion)

        Try

            Dim oc As New OracleCommand(comando, cn)
            oc.Connection.Open()
            oc.CommandType = CommandType.Text
            oc.ExecuteNonQuery()
            MsgBox("Alertas generadas correctamente")

            Call MostrarTabla("ALERTAS_TNR")

        Catch
            MsgBox("Error en el proceso de generación de alertas")

        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    ' botón para las alertas por transferencias internacionales emitidas, con el código SQL incrustado

    Private Sub ButtonTIE_Click(sender As Object, e As EventArgs) Handles ButtonTIE.Click
        Call BorrarTabla("ALERTAS_TIE")

        Dim comando As String = "CREATE TABLE ALERTAS_TIE AS 
                                 (
                                 SELECT TIE.*, FAC.CLASIFICACION AS CLASIFICACION_DESTINATARIO
                                 FROM TRANSF_INT_EMI TIE
                                 LEFT JOIN FACTIVA FAC
                                 ON TIE.NOMBRE_DESTINATARIO = FAC.NOMBRE AND
                                 TIE.APELLIDO1_DESTINATARIO = FAC.APELLIDO1 AND
                                 TIE.APELLIDO2_DESTINATARIO = FAC.APELLIDO2
                                 WHERE FAC.CLASIFICACION IN ('TERRORISTA', 'NARCOTRAFICANTE', 'CONTRABANDISTA')
                                 OR TIE.PAIS_DESTINATARIO IN (SELECT * FROM PARAISOS_FISCALES)
                                 )"

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim cn As New OracleConnection(conexion)

        Try

            Dim oc As New OracleCommand(comando, cn)
            oc.Connection.Open()
            oc.CommandType = CommandType.Text
            oc.ExecuteNonQuery()
            MsgBox("Alertas generadas correctamente")

            Call MostrarTabla("ALERTAS_TIE")

        Catch
            MsgBox("Error en el proceso de generación de alertas")

        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    ' botón para las alertas por transferencias nacionales recibidas, con el código SQL incrustado

    Private Sub ButtonTIR_Click(sender As Object, e As EventArgs) Handles ButtonTIR.Click
        Call BorrarTabla("ALERTAS_TIR")

        Dim comando As String = "CREATE TABLE ALERTAS_TIR AS 
                                 (
                                 SELECT TIR.*, FAC.CLASIFICACION AS CLASIFICACION_EMISOR
                                 FROM TRANSF_INT_REC TIR
                                 LEFT JOIN FACTIVA FAC
                                 ON TIR.NOMBRE_EMISOR = FAC.NOMBRE AND
                                 TIR.APELLIDO1_EMISOR = FAC.APELLIDO1 AND
                                 TIR.APELLIDO2_EMISOR = FAC.APELLIDO2
                                 WHERE FAC.CLASIFICACION IN ('TERRORISTA', 'NARCOTRAFICANTE', 'CONTRABANDISTA')
                                 OR TIR.PAIS_EMISOR IN (SELECT * FROM PARAISOS_FISCALES)
                                 )"

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim cn As New OracleConnection(conexion)

        Try

            Dim oc As New OracleCommand(comando, cn)
            oc.Connection.Open()
            oc.CommandType = CommandType.Text
            oc.ExecuteNonQuery()
            MsgBox("Alertas generadas correctamente")

            Call MostrarTabla("ALERTAS_TIR")

        Catch
            MsgBox("Error en el proceso de generación de alertas")

        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    ' botón para las alertas por operativa de los PEP, con el código SQL incrustado

    Private Sub ButtonPEP_Click(sender As Object, e As EventArgs) Handles ButtonPEP.Click
        Call BorrarTabla("ALERTAS_PEP")

        Dim comando As String = "CREATE TABLE ALERTAS_PEP AS 
                                 (
                                 SELECT TNR.FECHA, CUS.NOMBRE, CUS.APELLIDO1, CUS.APELLIDO2, FAC.CLASIFICACION AS CLASIFICACION_RECEPTOR, TNR.CANTIDAD, 'NACIONAL' AS PAIS_EMISOR 
                                 FROM TRANSF_NAC_REC TNR, CLIENTES CUS, FACTIVA FAC
                                 WHERE TNR.ID_CLIENTE = CUS.ID_CLIENTE
                                 AND CUS.NOMBRE = FAC.NOMBRE
                                 AND CUS.APELLIDO1 = FAC.APELLIDO1
                                 AND CUS.APELLIDO2 = FAC.APELLIDO2
                                 AND FAC.CLASIFICACION IN ('PEP', 'PARIENTE PEP')
                                 AND TNR.CANTIDAD > 10000
                                 UNION
                                 SELECT TIR.FECHA, CUS.NOMBRE, CUS.APELLIDO1, CUS.APELLIDO2, FAC.CLASIFICACION AS CLASIFICACION_RECEPTOR, TIR.CANTIDAD, TIR.PAIS_EMISOR AS PAIS_EMISOR
                                 FROM TRANSF_INT_REC TIR, CLIENTES CUS, FACTIVA FAC
                                 WHERE TIR.ID_CLIENTE = CUS.ID_CLIENTE
                                 AND CUS.NOMBRE = FAC.NOMBRE
                                 AND CUS.APELLIDO1 = FAC.APELLIDO1
                                 AND CUS.APELLIDO2 = FAC.APELLIDO2
                                 AND FAC.CLASIFICACION IN ('PEP', 'PARIENTE PEP')
                                 AND TIR.CANTIDAD > 10000
                                 )"

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim cn As New OracleConnection(conexion)

        Try

            Dim oc As New OracleCommand(comando, cn)
            oc.Connection.Open()
            oc.CommandType = CommandType.Text
            oc.ExecuteNonQuery()
            MsgBox("Alertas generadas correctamente")

            Call MostrarTabla("ALERTAS_PEP")

        Catch
            MsgBox("Error en el proceso de generación de alertas")

        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    ' Carga del formulario inicial

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        ' abrimos el excel con las consultas
        Call AbrirExcel()
        ' ampliamos la pantalla
        Me.WindowState = FormWindowState.Maximized
        ' cargamos las consultas
        Call CargaPT()
        'mostramos la primera
        Call MostrarRegistro()
        Me.Cursor = System.Windows.Forms.Cursors.Arrow

    End Sub


End Class

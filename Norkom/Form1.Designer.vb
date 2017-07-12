<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxSQL = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxRegistro = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonAvance = New System.Windows.Forms.Button()
        Me.ButtonAtras = New System.Windows.Forms.Button()
        Me.ButtonEjecutar = New System.Windows.Forms.Button()
        Me.Ax_DocSiteControl1 = New AxMicrosoft.Office.Interop.Outlook.Ax_DocSiteControl()
        Me.Ax_RecipientControl1 = New AxMicrosoft.Office.Interop.Outlook.Ax_RecipientControl()
        Me.Insertar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ButtonExcel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxInstrucciones = New System.Windows.Forms.TextBox()
        Me.TextBoxProceso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonSegmentar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonTNE = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonAlIngresos = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonTIR = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonTNR = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonTIE = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonPEP = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ax_DocSiteControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ax_RecipientControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(534, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(781, 414)
        Me.DataGridView1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(846, 496)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "PERSONALIZAR INFORME"
        '
        'TextBoxSQL
        '
        Me.TextBoxSQL.Location = New System.Drawing.Point(534, 512)
        Me.TextBoxSQL.Multiline = True
        Me.TextBoxSQL.Name = "TextBoxSQL"
        Me.TextBoxSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxSQL.Size = New System.Drawing.Size(780, 44)
        Me.TextBoxSQL.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(282, 518)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Registro"
        '
        'TextBoxRegistro
        '
        Me.TextBoxRegistro.Location = New System.Drawing.Point(334, 515)
        Me.TextBoxRegistro.Name = "TextBoxRegistro"
        Me.TextBoxRegistro.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxRegistro.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(384, 518)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Total"
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(421, 515)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxTotal.TabIndex = 28
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Image = Global.Norkom.My.Resources.Resources.Salir1
        Me.ButtonSalir.Location = New System.Drawing.Point(1266, 11)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(48, 47)
        Me.ButtonSalir.TabIndex = 22
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Image = Global.Norkom.My.Resources.Resources.save22
        Me.ButtonGuardar.Location = New System.Drawing.Point(1212, 12)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(48, 47)
        Me.ButtonGuardar.TabIndex = 21
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'ButtonAvance
        '
        Me.ButtonAvance.Image = Global.Norkom.My.Resources.Resources.blue_avance_pq1
        Me.ButtonAvance.Location = New System.Drawing.Point(178, 485)
        Me.ButtonAvance.Name = "ButtonAvance"
        Me.ButtonAvance.Size = New System.Drawing.Size(44, 45)
        Me.ButtonAvance.TabIndex = 17
        Me.ButtonAvance.UseVisualStyleBackColor = True
        '
        'ButtonAtras
        '
        Me.ButtonAtras.Image = Global.Norkom.My.Resources.Resources.blue_atras_pq1
        Me.ButtonAtras.Location = New System.Drawing.Point(128, 485)
        Me.ButtonAtras.Name = "ButtonAtras"
        Me.ButtonAtras.Size = New System.Drawing.Size(44, 45)
        Me.ButtonAtras.TabIndex = 16
        Me.ButtonAtras.UseVisualStyleBackColor = True
        '
        'ButtonEjecutar
        '
        Me.ButtonEjecutar.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonEjecutar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEjecutar.Image = Global.Norkom.My.Resources.Resources.blue_play_pq1
        Me.ButtonEjecutar.Location = New System.Drawing.Point(22, 485)
        Me.ButtonEjecutar.Name = "ButtonEjecutar"
        Me.ButtonEjecutar.Size = New System.Drawing.Size(45, 46)
        Me.ButtonEjecutar.TabIndex = 1
        Me.ButtonEjecutar.UseVisualStyleBackColor = True
        '
        'Ax_DocSiteControl1
        '
        Me.Ax_DocSiteControl1.Enabled = True
        Me.Ax_DocSiteControl1.Location = New System.Drawing.Point(0, 0)
        Me.Ax_DocSiteControl1.Name = "Ax_DocSiteControl1"
        Me.Ax_DocSiteControl1.TabIndex = 0
        '
        'Ax_RecipientControl1
        '
        Me.Ax_RecipientControl1.Enabled = True
        Me.Ax_RecipientControl1.Location = New System.Drawing.Point(0, 0)
        Me.Ax_RecipientControl1.Name = "Ax_RecipientControl1"
        Me.Ax_RecipientControl1.TabIndex = 0
        '
        'Insertar
        '
        Me.Insertar.Image = Global.Norkom.My.Resources.Resources.insert
        Me.Insertar.Location = New System.Drawing.Point(1102, 11)
        Me.Insertar.Name = "Insertar"
        Me.Insertar.Size = New System.Drawing.Size(49, 47)
        Me.Insertar.TabIndex = 41
        Me.Insertar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Image = Global.Norkom.My.Resources.Resources.borrar
        Me.Eliminar.Location = New System.Drawing.Point(1157, 12)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(49, 47)
        Me.Eliminar.TabIndex = 42
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.ColumnHeadersVisible = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DataGridView2.Location = New System.Drawing.Point(12, 65)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 10
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(502, 414)
        Me.DataGridView2.TabIndex = 44
        '
        'ButtonExcel
        '
        Me.ButtonExcel.Image = Global.Norkom.My.Resources.Resources.excel1
        Me.ButtonExcel.Location = New System.Drawing.Point(1047, 12)
        Me.ButtonExcel.Name = "ButtonExcel"
        Me.ButtonExcel.Size = New System.Drawing.Size(49, 46)
        Me.ButtonExcel.TabIndex = 45
        Me.ButtonExcel.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 546)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "INFORME"
        '
        'TextBoxInstrucciones
        '
        Me.TextBoxInstrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInstrucciones.Location = New System.Drawing.Point(12, 612)
        Me.TextBoxInstrucciones.Multiline = True
        Me.TextBoxInstrucciones.Name = "TextBoxInstrucciones"
        Me.TextBoxInstrucciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxInstrucciones.Size = New System.Drawing.Size(502, 72)
        Me.TextBoxInstrucciones.TabIndex = 48
        '
        'TextBoxProceso
        '
        Me.TextBoxProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProceso.Location = New System.Drawing.Point(12, 562)
        Me.TextBoxProceso.Multiline = True
        Me.TextBoxProceso.Name = "TextBoxProceso"
        Me.TextBoxProceso.Size = New System.Drawing.Size(502, 27)
        Me.TextBoxProceso.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 592)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "DESCRIPCION DEL INFORME"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(140, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 18)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "VISUALIZAR INFORMES"
        '
        'ButtonSegmentar
        '
        Me.ButtonSegmentar.Image = CType(resources.GetObject("ButtonSegmentar.Image"), System.Drawing.Image)
        Me.ButtonSegmentar.Location = New System.Drawing.Point(589, 584)
        Me.ButtonSegmentar.Name = "ButtonSegmentar"
        Me.ButtonSegmentar.Size = New System.Drawing.Size(77, 63)
        Me.ButtonSegmentar.TabIndex = 53
        Me.ButtonSegmentar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(586, 653)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 36)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Segmentar Cartera de Clientes"
        '
        'ButtonTNE
        '
        Me.ButtonTNE.Image = CType(resources.GetObject("ButtonTNE.Image"), System.Drawing.Image)
        Me.ButtonTNE.Location = New System.Drawing.Point(9, 22)
        Me.ButtonTNE.Name = "ButtonTNE"
        Me.ButtonTNE.Size = New System.Drawing.Size(77, 63)
        Me.ButtonTNE.TabIndex = 55
        Me.ButtonTNE.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(686, 653)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 36)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Alertas Ingresos en efectivo"
        '
        'ButtonAlIngresos
        '
        Me.ButtonAlIngresos.Image = CType(resources.GetObject("ButtonAlIngresos.Image"), System.Drawing.Image)
        Me.ButtonAlIngresos.Location = New System.Drawing.Point(689, 584)
        Me.ButtonAlIngresos.Name = "ButtonAlIngresos"
        Me.ButtonAlIngresos.Size = New System.Drawing.Size(77, 63)
        Me.ButtonAlIngresos.TabIndex = 57
        Me.ButtonAlIngresos.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(294, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 26)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Internacionales Recibidas"
        '
        'ButtonTIR
        '
        Me.ButtonTIR.Image = CType(resources.GetObject("ButtonTIR.Image"), System.Drawing.Image)
        Me.ButtonTIR.Location = New System.Drawing.Point(297, 22)
        Me.ButtonTIR.Name = "ButtonTIR"
        Me.ButtonTIR.Size = New System.Drawing.Size(77, 63)
        Me.ButtonTIR.TabIndex = 59
        Me.ButtonTIR.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(102, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 26)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Nacionales Recibidas"
        '
        'ButtonTNR
        '
        Me.ButtonTNR.Image = CType(resources.GetObject("ButtonTNR.Image"), System.Drawing.Image)
        Me.ButtonTNR.Location = New System.Drawing.Point(101, 22)
        Me.ButtonTNR.Name = "ButtonTNR"
        Me.ButtonTNR.Size = New System.Drawing.Size(77, 63)
        Me.ButtonTNR.TabIndex = 61
        Me.ButtonTNR.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 26)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Nacionales Emitidas"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(199, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 26)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Internacionales Emitidas"
        '
        'ButtonTIE
        '
        Me.ButtonTIE.Image = CType(resources.GetObject("ButtonTIE.Image"), System.Drawing.Image)
        Me.ButtonTIE.Location = New System.Drawing.Point(202, 22)
        Me.ButtonTIE.Name = "ButtonTIE"
        Me.ButtonTIE.Size = New System.Drawing.Size(77, 63)
        Me.ButtonTIE.TabIndex = 64
        Me.ButtonTIE.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ButtonPEP)
        Me.GroupBox1.Controls.Add(Me.ButtonTIE)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ButtonTNR)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ButtonTIR)
        Me.GroupBox1.Controls.Add(Me.ButtonTNE)
        Me.GroupBox1.Location = New System.Drawing.Point(784, 562)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 127)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alertas Transferencias"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(388, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 18)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Recibidas PEPs"
        '
        'ButtonPEP
        '
        Me.ButtonPEP.Image = CType(resources.GetObject("ButtonPEP.Image"), System.Drawing.Image)
        Me.ButtonPEP.Location = New System.Drawing.Point(391, 22)
        Me.ButtonPEP.Name = "ButtonPEP"
        Me.ButtonPEP.Size = New System.Drawing.Size(77, 63)
        Me.ButtonPEP.TabIndex = 67
        Me.ButtonPEP.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1326, 694)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonAlIngresos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonSegmentar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxProceso)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxInstrucciones)
        Me.Controls.Add(Me.ButtonExcel)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Insertar)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBoxRegistro)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.ButtonAvance)
        Me.Controls.Add(Me.ButtonAtras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxSQL)
        Me.Controls.Add(Me.ButtonEjecutar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Aplicación de Prevención de Blanqueo de Capitales y financiación del terrorismo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ax_DocSiteControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ax_RecipientControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxSQL As TextBox
    Friend WithEvents ButtonAtras As Button
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxRegistro As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents ButtonEjecutar As Button
    Friend WithEvents ButtonAvance As Button
    Private WithEvents Ax_DocSiteControl1 As AxMicrosoft.Office.Interop.Outlook.Ax_DocSiteControl
    Private WithEvents Ax_RecipientControl1 As AxMicrosoft.Office.Interop.Outlook.Ax_RecipientControl
    Friend WithEvents Insertar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ButtonExcel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxInstrucciones As TextBox
    Friend WithEvents TextBoxProceso As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonSegmentar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonTNE As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonAlIngresos As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonTIR As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonTNR As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ButtonTIE As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonPEP As Button
End Class

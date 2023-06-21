<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgIngresar = New System.Windows.Forms.DataGridView()
        Me.lstSalida = New System.Windows.Forms.ListBox()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.dgMostrar = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgIngresar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgIngresar
        '
        Me.dgIngresar.AllowUserToAddRows = False
        Me.dgIngresar.AllowUserToDeleteRows = False
        Me.dgIngresar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgIngresar.ColumnHeadersVisible = False
        Me.dgIngresar.Location = New System.Drawing.Point(37, 51)
        Me.dgIngresar.Name = "dgIngresar"
        Me.dgIngresar.RowHeadersVisible = False
        Me.dgIngresar.Size = New System.Drawing.Size(163, 113)
        Me.dgIngresar.TabIndex = 0
        '
        'lstSalida
        '
        Me.lstSalida.FormattingEnabled = True
        Me.lstSalida.Location = New System.Drawing.Point(37, 193)
        Me.lstSalida.Name = "lstSalida"
        Me.lstSalida.Size = New System.Drawing.Size(412, 160)
        Me.lstSalida.TabIndex = 2
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(197, 359)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(89, 35)
        Me.btnEjecutar.TabIndex = 3
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'dgMostrar
        '
        Me.dgMostrar.AllowUserToAddRows = False
        Me.dgMostrar.AllowUserToDeleteRows = False
        Me.dgMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMostrar.ColumnHeadersVisible = False
        Me.dgMostrar.Location = New System.Drawing.Point(286, 51)
        Me.dgMostrar.Name = "dgMostrar"
        Me.dgMostrar.RowHeadersVisible = False
        Me.dgMostrar.Size = New System.Drawing.Size(163, 113)
        Me.dgMostrar.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ingrese matriz:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Matriz ingresada:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Resultados: "
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 474)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgMostrar)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.lstSalida)
        Me.Controls.Add(Me.dgIngresar)
        Me.Name = "Form"
        Me.Text = "Form1"
        CType(Me.dgIngresar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgIngresar As System.Windows.Forms.DataGridView
    Friend WithEvents lstSalida As System.Windows.Forms.ListBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents dgMostrar As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class

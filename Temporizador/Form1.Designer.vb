<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.LblReloj = New System.Windows.Forms.Label()
        Me.GbxCronometro = New System.Windows.Forms.GroupBox()
        Me.GrxNumeros = New System.Windows.Forms.GroupBox()
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.NudSegundos = New System.Windows.Forms.NumericUpDown()
        Me.NudMinutos = New System.Windows.Forms.NumericUpDown()
        Me.NudHoras = New System.Windows.Forms.NumericUpDown()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GbxCronometro.SuspendLayout()
        Me.GrxNumeros.SuspendLayout()
        CType(Me.NudSegundos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudMinutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblReloj
        '
        Me.LblReloj.AutoSize = True
        Me.LblReloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReloj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblReloj.Location = New System.Drawing.Point(166, 31)
        Me.LblReloj.Name = "LblReloj"
        Me.LblReloj.Size = New System.Drawing.Size(425, 108)
        Me.LblReloj.TabIndex = 0
        Me.LblReloj.Text = "00:00:00"
        '
        'GbxCronometro
        '
        Me.GbxCronometro.Controls.Add(Me.LblReloj)
        Me.GbxCronometro.Location = New System.Drawing.Point(62, 13)
        Me.GbxCronometro.Name = "GbxCronometro"
        Me.GbxCronometro.Size = New System.Drawing.Size(686, 163)
        Me.GbxCronometro.TabIndex = 1
        Me.GbxCronometro.TabStop = False
        '
        'GrxNumeros
        '
        Me.GrxNumeros.Controls.Add(Me.Label3)
        Me.GrxNumeros.Controls.Add(Me.Label2)
        Me.GrxNumeros.Controls.Add(Me.Label1)
        Me.GrxNumeros.Controls.Add(Me.BtnIniciar)
        Me.GrxNumeros.Controls.Add(Me.NudSegundos)
        Me.GrxNumeros.Controls.Add(Me.NudMinutos)
        Me.GrxNumeros.Controls.Add(Me.NudHoras)
        Me.GrxNumeros.Location = New System.Drawing.Point(62, 268)
        Me.GrxNumeros.Name = "GrxNumeros"
        Me.GrxNumeros.Size = New System.Drawing.Size(686, 223)
        Me.GrxNumeros.TabIndex = 2
        Me.GrxNumeros.TabStop = False
        '
        'BtnIniciar
        '
        Me.BtnIniciar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnIniciar.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnIniciar.Location = New System.Drawing.Point(84, 130)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(526, 67)
        Me.BtnIniciar.TabIndex = 1
        Me.BtnIniciar.Text = "Iniciar"
        Me.BtnIniciar.UseVisualStyleBackColor = False
        '
        'NudSegundos
        '
        Me.NudSegundos.BackColor = System.Drawing.SystemColors.Control
        Me.NudSegundos.Font = New System.Drawing.Font("Ubuntu", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudSegundos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NudSegundos.Location = New System.Drawing.Point(452, 19)
        Me.NudSegundos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NudSegundos.Name = "NudSegundos"
        Me.NudSegundos.Size = New System.Drawing.Size(96, 81)
        Me.NudSegundos.TabIndex = 0
        '
        'NudMinutos
        '
        Me.NudMinutos.BackColor = System.Drawing.SystemColors.Control
        Me.NudMinutos.Font = New System.Drawing.Font("Ubuntu", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudMinutos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NudMinutos.Location = New System.Drawing.Point(262, 19)
        Me.NudMinutos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NudMinutos.Name = "NudMinutos"
        Me.NudMinutos.Size = New System.Drawing.Size(96, 81)
        Me.NudMinutos.TabIndex = 0
        '
        'NudHoras
        '
        Me.NudHoras.BackColor = System.Drawing.SystemColors.Control
        Me.NudHoras.Font = New System.Drawing.Font("Ubuntu", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudHoras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NudHoras.Location = New System.Drawing.Point(84, 19)
        Me.NudHoras.Name = "NudHoras"
        Me.NudHoras.Size = New System.Drawing.Size(96, 81)
        Me.NudHoras.TabIndex = 0
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(62, 190)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(686, 59)
        Me.ProgressBar.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "hs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(382, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "min"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(572, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "seg"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 519)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.GrxNumeros)
        Me.Controls.Add(Me.GbxCronometro)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temporizador"
        Me.GbxCronometro.ResumeLayout(False)
        Me.GbxCronometro.PerformLayout()
        Me.GrxNumeros.ResumeLayout(False)
        Me.GrxNumeros.PerformLayout()
        CType(Me.NudSegundos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudMinutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblReloj As Label
    Friend WithEvents GbxCronometro As GroupBox
    Friend WithEvents GrxNumeros As GroupBox
    Friend WithEvents BtnIniciar As Button
    Friend WithEvents NudSegundos As NumericUpDown
    Friend WithEvents NudMinutos As NumericUpDown
    Friend WithEvents NudHoras As NumericUpDown
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

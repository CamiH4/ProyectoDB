<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPersona
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdPersonaLabel As System.Windows.Forms.Label
        Dim PrimerApellidoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim PrimerNombreLabel As System.Windows.Forms.Label
        Dim FechaNacLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim IdCiudadLabel As System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.DBPrueba26DataSet = New RegistroPersonas.DBPrueba26DataSet()
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonaTableAdapter = New RegistroPersonas.DBPrueba26DataSetTableAdapters.PersonaTableAdapter()
        Me.TableAdapterManager = New RegistroPersonas.DBPrueba26DataSetTableAdapters.TableAdapterManager()
        Me.IdPersonaTextBox = New System.Windows.Forms.TextBox()
        Me.PrimerApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.PrimerNombreTextBox = New System.Windows.Forms.TextBox()
        Me.SegundoNombreTextBox = New System.Windows.Forms.TextBox()
        Me.SegundoApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaNacDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        IdPersonaLabel = New System.Windows.Forms.Label()
        PrimerApellidoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        PrimerNombreLabel = New System.Windows.Forms.Label()
        FechaNacLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        IdCiudadLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DBPrueba26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdPersonaLabel
        '
        IdPersonaLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        IdPersonaLabel.AutoSize = True
        IdPersonaLabel.Location = New System.Drawing.Point(332, 84)
        IdPersonaLabel.Name = "IdPersonaLabel"
        IdPersonaLabel.Size = New System.Drawing.Size(21, 13)
        IdPersonaLabel.TabIndex = 5
        IdPersonaLabel.Text = "ID:"
        '
        'PrimerApellidoLabel
        '
        PrimerApellidoLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        PrimerApellidoLabel.AutoSize = True
        PrimerApellidoLabel.Location = New System.Drawing.Point(460, 164)
        PrimerApellidoLabel.Name = "PrimerApellidoLabel"
        PrimerApellidoLabel.Size = New System.Drawing.Size(52, 13)
        PrimerApellidoLabel.TabIndex = 6
        PrimerApellidoLabel.Text = "Apellidos:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(460, 290)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 7
        TelefonoLabel.Text = "Teléfono:"
        '
        'PrimerNombreLabel
        '
        PrimerNombreLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        PrimerNombreLabel.AutoSize = True
        PrimerNombreLabel.Location = New System.Drawing.Point(78, 164)
        PrimerNombreLabel.Name = "PrimerNombreLabel"
        PrimerNombreLabel.Size = New System.Drawing.Size(52, 13)
        PrimerNombreLabel.TabIndex = 8
        PrimerNombreLabel.Text = "Nombres:"
        '
        'FechaNacLabel
        '
        FechaNacLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        FechaNacLabel.AutoSize = True
        FechaNacLabel.Location = New System.Drawing.Point(67, 233)
        FechaNacLabel.Name = "FechaNacLabel"
        FechaNacLabel.Size = New System.Drawing.Size(63, 13)
        FechaNacLabel.TabIndex = 13
        FechaNacLabel.Text = "Nacimiento:"
        '
        'EmailLabel
        '
        EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(95, 290)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "Email:"
        '
        'DireccionLabel
        '
        DireccionLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(75, 351)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 17
        DireccionLabel.Text = "Dirección:"
        '
        'SexoLabel
        '
        SexoLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(478, 233)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(34, 13)
        SexoLabel.TabIndex = 20
        SexoLabel.Text = "Sexo:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Orange
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.BtnGuardar, Me.BtnEditar, Me.BtnEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(790, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNuevo.Image = Global.RegistroPersonas.My.Resources.Resources.add_file
        Me.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(23, 22)
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnGuardar.Image = Global.RegistroPersonas.My.Resources.Resources.verify
        Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(23, 22)
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnEditar
        '
        Me.BtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEditar.Image = Global.RegistroPersonas.My.Resources.Resources.edit
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(23, 22)
        Me.BtnEditar.Text = "Editar"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEliminar.Image = Global.RegistroPersonas.My.Resources.Resources.trash
        Me.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(23, 22)
        Me.BtnEliminar.Text = "Eliminar"
        '
        'DBPrueba26DataSet
        '
        Me.DBPrueba26DataSet.DataSetName = "DBPrueba26DataSet"
        Me.DBPrueba26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonaBindingSource
        '
        Me.PersonaBindingSource.DataMember = "Persona"
        Me.PersonaBindingSource.DataSource = Me.DBPrueba26DataSet
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CiudadTableAdapter = Nothing
        Me.TableAdapterManager.PersonaTableAdapter = Me.PersonaTableAdapter
        Me.TableAdapterManager.UpdateOrder = RegistroPersonas.DBPrueba26DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdPersonaTextBox
        '
        Me.IdPersonaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IdPersonaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "idPersona", True))
        Me.IdPersonaTextBox.Location = New System.Drawing.Point(359, 81)
        Me.IdPersonaTextBox.Name = "IdPersonaTextBox"
        Me.IdPersonaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdPersonaTextBox.TabIndex = 6
        '
        'PrimerApellidoTextBox
        '
        Me.PrimerApellidoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PrimerApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "primerApellido", True))
        Me.PrimerApellidoTextBox.Location = New System.Drawing.Point(518, 161)
        Me.PrimerApellidoTextBox.Name = "PrimerApellidoTextBox"
        Me.PrimerApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrimerApellidoTextBox.TabIndex = 7
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(518, 287)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 8
        '
        'PrimerNombreTextBox
        '
        Me.PrimerNombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PrimerNombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "primerNombre", True))
        Me.PrimerNombreTextBox.Location = New System.Drawing.Point(136, 161)
        Me.PrimerNombreTextBox.Name = "PrimerNombreTextBox"
        Me.PrimerNombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrimerNombreTextBox.TabIndex = 9
        '
        'SegundoNombreTextBox
        '
        Me.SegundoNombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SegundoNombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "segundoNombre", True))
        Me.SegundoNombreTextBox.Location = New System.Drawing.Point(242, 161)
        Me.SegundoNombreTextBox.Name = "SegundoNombreTextBox"
        Me.SegundoNombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SegundoNombreTextBox.TabIndex = 10
        '
        'SegundoApellidoTextBox
        '
        Me.SegundoApellidoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SegundoApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "segundoApellido", True))
        Me.SegundoApellidoTextBox.Location = New System.Drawing.Point(624, 161)
        Me.SegundoApellidoTextBox.Name = "SegundoApellidoTextBox"
        Me.SegundoApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SegundoApellidoTextBox.TabIndex = 12
        '
        'FechaNacDateTimePicker
        '
        Me.FechaNacDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FechaNacDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PersonaBindingSource, "fechaNac", True))
        Me.FechaNacDateTimePicker.Location = New System.Drawing.Point(136, 227)
        Me.FechaNacDateTimePicker.Name = "FechaNacDateTimePicker"
        Me.FechaNacDateTimePicker.Size = New System.Drawing.Size(206, 20)
        Me.FechaNacDateTimePicker.TabIndex = 14
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(136, 287)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 16
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(136, 348)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 18
        '
        'CmbSexo
        '
        Me.CmbSexo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Location = New System.Drawing.Point(518, 230)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(121, 21)
        Me.CmbSexo.TabIndex = 21
        '
        'IdCiudadLabel
        '
        IdCiudadLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        IdCiudadLabel.AutoSize = True
        IdCiudadLabel.Location = New System.Drawing.Point(471, 351)
        IdCiudadLabel.Name = "IdCiudadLabel"
        IdCiudadLabel.Size = New System.Drawing.Size(43, 13)
        IdCiudadLabel.TabIndex = 21
        IdCiudadLabel.Text = "Ciudad:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(518, 348)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 22
        '
        'FrmPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(IdCiudadLabel)
        Me.Controls.Add(Me.CmbSexo)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(FechaNacLabel)
        Me.Controls.Add(Me.FechaNacDateTimePicker)
        Me.Controls.Add(Me.SegundoApellidoTextBox)
        Me.Controls.Add(Me.SegundoNombreTextBox)
        Me.Controls.Add(PrimerNombreLabel)
        Me.Controls.Add(Me.PrimerNombreTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(PrimerApellidoLabel)
        Me.Controls.Add(Me.PrimerApellidoTextBox)
        Me.Controls.Add(IdPersonaLabel)
        Me.Controls.Add(Me.IdPersonaTextBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmPersonas"
        Me.Text = "FrmPersonas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DBPrueba26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BtnEliminar As ToolStripButton
    Friend WithEvents DBPrueba26DataSet As DBPrueba26DataSet
    Friend WithEvents PersonaBindingSource As BindingSource
    Friend WithEvents PersonaTableAdapter As DBPrueba26DataSetTableAdapters.PersonaTableAdapter
    Friend WithEvents TableAdapterManager As DBPrueba26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdPersonaTextBox As TextBox
    Friend WithEvents PrimerApellidoTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents PrimerNombreTextBox As TextBox
    Friend WithEvents SegundoNombreTextBox As TextBox
    Friend WithEvents SegundoApellidoTextBox As TextBox
    Friend WithEvents FechaNacDateTimePicker As DateTimePicker
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
End Class

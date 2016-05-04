<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcrearproducto
    Inherits DevComponents.DotNetBar.Metro.MetroAppForm

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
        Me.MetroShell1 = New DevComponents.DotNetBar.Metro.MetroShell()
        Me.MetroTabPanel1 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.MetroTabPanel3 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.MetroTabItem1 = New DevComponents.DotNetBar.Metro.MetroTabItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.StyleManager2 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.txtprecio = New DevComponents.Editors.DoubleInput()
        Me.ckestado = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbimpuesto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbmarca = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbclasificacion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtcodigosap = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.txtreorden = New DevComponents.Editors.DoubleInput()
        Me.txtcantidadmaxima = New DevComponents.Editors.DoubleInput()
        Me.txtcantidadminima = New DevComponents.Editors.DoubleInput()
        Me.txtconsumopromedio = New DevComponents.Editors.DoubleInput()
        Me.txtsemanasenmano = New DevComponents.Editors.DoubleInput()
        Me.txttiemporeabastecimiento = New DevComponents.Editors.DoubleInput()
        Me.costopromedio = New DevComponents.Editors.DoubleInput()
        Me.txtuxcaja = New DevComponents.Editors.DoubleInput()
        Me.txtexistencia = New DevComponents.Editors.DoubleInput()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.MetroShell1.SuspendLayout()
        Me.MetroTabPanel1.SuspendLayout()
        Me.MetroTabPanel3.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        CType(Me.txtprecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.txtreorden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcantidadmaxima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcantidadminima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtconsumopromedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsemanasenmano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttiemporeabastecimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.costopromedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuxcaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtexistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroShell1
        '
        Me.MetroShell1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroShell1.CaptionVisible = True
        Me.MetroShell1.Controls.Add(Me.MetroTabPanel1)
        Me.MetroShell1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroShell1.ForeColor = System.Drawing.Color.Black
        Me.MetroShell1.HelpButtonText = Nothing
        Me.MetroShell1.HelpButtonVisible = False
        Me.MetroShell1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MetroTabItem1})
        Me.MetroShell1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.MetroShell1.Location = New System.Drawing.Point(1, 1)
        Me.MetroShell1.Name = "MetroShell1"
        Me.MetroShell1.SettingsButtonVisible = False
        Me.MetroShell1.Size = New System.Drawing.Size(651, 122)
        Me.MetroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.MetroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.MetroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.MetroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.MetroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.MetroShell1.SystemText.QatDialogAddButton = "&Add >>"
        Me.MetroShell1.SystemText.QatDialogCancelButton = "Cancel"
        Me.MetroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.MetroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.MetroShell1.SystemText.QatDialogOkButton = "OK"
        Me.MetroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.MetroShell1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.MetroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.MetroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.MetroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.MetroShell1.TabIndex = 0
        Me.MetroShell1.TabStripFont = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroShell1.Text = "MetroShell1"
        '
        'MetroTabPanel1
        '
        Me.MetroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MetroTabPanel1.Controls.Add(Me.MetroTabPanel3)
        Me.MetroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel1.Location = New System.Drawing.Point(0, 51)
        Me.MetroTabPanel1.Name = "MetroTabPanel1"
        Me.MetroTabPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel1.Size = New System.Drawing.Size(651, 71)
        '
        '
        '
        Me.MetroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTabPanel1.TabIndex = 1
        '
        'MetroTabPanel3
        '
        Me.MetroTabPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MetroTabPanel3.Controls.Add(Me.btncerrar)
        Me.MetroTabPanel3.Controls.Add(Me.btnimprimir)
        Me.MetroTabPanel3.Controls.Add(Me.btnlimpiar)
        Me.MetroTabPanel3.Controls.Add(Me.btnguardar)
        Me.MetroTabPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel3.Location = New System.Drawing.Point(3, 0)
        Me.MetroTabPanel3.Name = "MetroTabPanel3"
        Me.MetroTabPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel3.Size = New System.Drawing.Size(645, 68)
        '
        '
        '
        Me.MetroTabPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTabPanel3.TabIndex = 3
        '
        'MetroTabItem1
        '
        Me.MetroTabItem1.Checked = True
        Me.MetroTabItem1.Name = "MetroTabItem1"
        Me.MetroTabItem1.Panel = Me.MetroTabPanel1
        Me.MetroTabItem1.Text = "&Operaciones"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.Color.White
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'MetroStatusBar1
        '
        Me.MetroStatusBar1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroStatusBar1.ContainerControlProcessDialogKey = True
        Me.MetroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroStatusBar1.DragDropSupport = True
        Me.MetroStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroStatusBar1.ForeColor = System.Drawing.Color.Black
        Me.MetroStatusBar1.Location = New System.Drawing.Point(1, 413)
        Me.MetroStatusBar1.Name = "MetroStatusBar1"
        Me.MetroStatusBar1.Size = New System.Drawing.Size(651, 22)
        Me.MetroStatusBar1.TabIndex = 1
        Me.MetroStatusBar1.Text = "MetroStatusBar1"
        '
        'StyleManager2
        '
        Me.StyleManager2.ManagerColorTint = System.Drawing.Color.White
        Me.StyleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager2.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.BackColor = System.Drawing.Color.White
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperTabControl1.Location = New System.Drawing.Point(17, 129)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(621, 278)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 3
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2})
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.txtprecio)
        Me.SuperTabControlPanel1.Controls.Add(Me.ckestado)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label7)
        Me.SuperTabControlPanel1.Controls.Add(Me.cmbimpuesto)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label6)
        Me.SuperTabControlPanel1.Controls.Add(Me.cmbmarca)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label5)
        Me.SuperTabControlPanel1.Controls.Add(Me.cmbclasificacion)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label4)
        Me.SuperTabControlPanel1.Controls.Add(Me.txtdescripcion)
        Me.SuperTabControlPanel1.Controls.Add(Me.txtcodigosap)
        Me.SuperTabControlPanel1.Controls.Add(Me.txtcodigo)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label3)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label2)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label1)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 27)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(621, 251)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtprecio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtprecio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtprecio.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtprecio.DisplayFormat = "###,###,###.##"
        Me.txtprecio.ForeColor = System.Drawing.Color.Black
        Me.txtprecio.Increment = 1.0R
        Me.txtprecio.Location = New System.Drawing.Point(21, 173)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(185, 22)
        Me.txtprecio.TabIndex = 31
        '
        'ckestado
        '
        Me.ckestado.AutoSize = True
        Me.ckestado.BackColor = System.Drawing.Color.White
        Me.ckestado.ForeColor = System.Drawing.Color.Black
        Me.ckestado.Location = New System.Drawing.Point(387, 171)
        Me.ckestado.Name = "ckestado"
        Me.ckestado.Size = New System.Drawing.Size(80, 17)
        Me.ckestado.TabIndex = 30
        Me.ckestado.Text = "Habilitado"
        Me.ckestado.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(18, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Precio"
        '
        'cmbimpuesto
        '
        Me.cmbimpuesto.BackColor = System.Drawing.Color.White
        Me.cmbimpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbimpuesto.ForeColor = System.Drawing.Color.Black
        Me.cmbimpuesto.FormattingEnabled = True
        Me.cmbimpuesto.Location = New System.Drawing.Point(387, 126)
        Me.cmbimpuesto.Name = "cmbimpuesto"
        Me.cmbimpuesto.Size = New System.Drawing.Size(187, 21)
        Me.cmbimpuesto.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(384, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Impuesto"
        '
        'cmbmarca
        '
        Me.cmbmarca.BackColor = System.Drawing.Color.White
        Me.cmbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmarca.ForeColor = System.Drawing.Color.Black
        Me.cmbmarca.FormattingEnabled = True
        Me.cmbmarca.Location = New System.Drawing.Point(387, 85)
        Me.cmbmarca.Name = "cmbmarca"
        Me.cmbmarca.Size = New System.Drawing.Size(187, 21)
        Me.cmbmarca.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(18, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Subclasificacion"
        '
        'cmbclasificacion
        '
        Me.cmbclasificacion.BackColor = System.Drawing.Color.White
        Me.cmbclasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbclasificacion.ForeColor = System.Drawing.Color.Black
        Me.cmbclasificacion.FormattingEnabled = True
        Me.cmbclasificacion.Location = New System.Drawing.Point(21, 130)
        Me.cmbclasificacion.Name = "cmbclasificacion"
        Me.cmbclasificacion.Size = New System.Drawing.Size(187, 21)
        Me.cmbclasificacion.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(384, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Clasificacion"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.Color.White
        Me.txtdescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtdescripcion.Location = New System.Drawing.Point(21, 85)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(293, 22)
        Me.txtdescripcion.TabIndex = 21
        '
        'txtcodigosap
        '
        Me.txtcodigosap.BackColor = System.Drawing.Color.White
        Me.txtcodigosap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigosap.ForeColor = System.Drawing.Color.Black
        Me.txtcodigosap.Location = New System.Drawing.Point(387, 43)
        Me.txtcodigosap.Name = "txtcodigosap"
        Me.txtcodigosap.Size = New System.Drawing.Size(187, 22)
        Me.txtcodigosap.TabIndex = 19
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.White
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.ForeColor = System.Drawing.Color.Black
        Me.txtcodigo.Location = New System.Drawing.Point(21, 43)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(187, 22)
        Me.txtcodigo.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(18, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(384, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Codigo SAP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Codigo de Barra"
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Datos Generales"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.txtreorden)
        Me.SuperTabControlPanel2.Controls.Add(Me.txtcantidadmaxima)
        Me.SuperTabControlPanel2.Controls.Add(Me.txtcantidadminima)
        Me.SuperTabControlPanel2.Controls.Add(Me.txtconsumopromedio)
        Me.SuperTabControlPanel2.Controls.Add(Me.txtsemanasenmano)
        Me.SuperTabControlPanel2.Controls.Add(Me.txttiemporeabastecimiento)
        Me.SuperTabControlPanel2.Controls.Add(Me.costopromedio)
        Me.SuperTabControlPanel2.Controls.Add(Me.txtuxcaja)
        Me.SuperTabControlPanel2.Controls.Add(Me.txtexistencia)
        Me.SuperTabControlPanel2.Controls.Add(Me.Label17)
        Me.SuperTabControlPanel2.Controls.Add(Me.Label16)
        Me.SuperTabControlPanel2.Controls.Add(Me.Label15)
        Me.SuperTabControlPanel2.Controls.Add(Me.Label14)
        Me.SuperTabControlPanel2.Controls.Add(Me.Label13)
        Me.SuperTabControlPanel2.Controls.Add(Me.Label12)
        Me.SuperTabControlPanel2.Controls.Add(Me.Label11)
        Me.SuperTabControlPanel2.Controls.Add(Me.Label10)
        Me.SuperTabControlPanel2.Controls.Add(Me.Label9)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 27)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(621, 251)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'txtreorden
        '
        Me.txtreorden.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtreorden.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtreorden.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtreorden.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtreorden.DisplayFormat = "###,###,###.##"
        Me.txtreorden.ForeColor = System.Drawing.Color.Black
        Me.txtreorden.Increment = 1.0R
        Me.txtreorden.Location = New System.Drawing.Point(29, 219)
        Me.txtreorden.Name = "txtreorden"
        Me.txtreorden.Size = New System.Drawing.Size(185, 22)
        Me.txtreorden.TabIndex = 36
        '
        'txtcantidadmaxima
        '
        Me.txtcantidadmaxima.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtcantidadmaxima.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtcantidadmaxima.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcantidadmaxima.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtcantidadmaxima.DisplayFormat = "###,###,###.##"
        Me.txtcantidadmaxima.ForeColor = System.Drawing.Color.Black
        Me.txtcantidadmaxima.Increment = 1.0R
        Me.txtcantidadmaxima.Location = New System.Drawing.Point(416, 178)
        Me.txtcantidadmaxima.Name = "txtcantidadmaxima"
        Me.txtcantidadmaxima.Size = New System.Drawing.Size(185, 22)
        Me.txtcantidadmaxima.TabIndex = 35
        '
        'txtcantidadminima
        '
        Me.txtcantidadminima.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtcantidadminima.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtcantidadminima.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcantidadminima.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtcantidadminima.DisplayFormat = "###,###,###.##"
        Me.txtcantidadminima.ForeColor = System.Drawing.Color.Black
        Me.txtcantidadminima.Increment = 1.0R
        Me.txtcantidadminima.Location = New System.Drawing.Point(28, 178)
        Me.txtcantidadminima.Name = "txtcantidadminima"
        Me.txtcantidadminima.Size = New System.Drawing.Size(185, 22)
        Me.txtcantidadminima.TabIndex = 34
        '
        'txtconsumopromedio
        '
        Me.txtconsumopromedio.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtconsumopromedio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtconsumopromedio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtconsumopromedio.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtconsumopromedio.DisplayFormat = "###,###,###.##"
        Me.txtconsumopromedio.ForeColor = System.Drawing.Color.Black
        Me.txtconsumopromedio.Increment = 1.0R
        Me.txtconsumopromedio.Location = New System.Drawing.Point(416, 136)
        Me.txtconsumopromedio.Name = "txtconsumopromedio"
        Me.txtconsumopromedio.Size = New System.Drawing.Size(185, 22)
        Me.txtconsumopromedio.TabIndex = 33
        '
        'txtsemanasenmano
        '
        Me.txtsemanasenmano.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtsemanasenmano.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtsemanasenmano.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtsemanasenmano.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtsemanasenmano.DisplayFormat = "###,###,###.##"
        Me.txtsemanasenmano.ForeColor = System.Drawing.Color.Black
        Me.txtsemanasenmano.Increment = 1.0R
        Me.txtsemanasenmano.Location = New System.Drawing.Point(28, 136)
        Me.txtsemanasenmano.Name = "txtsemanasenmano"
        Me.txtsemanasenmano.Size = New System.Drawing.Size(185, 22)
        Me.txtsemanasenmano.TabIndex = 32
        '
        'txttiemporeabastecimiento
        '
        Me.txttiemporeabastecimiento.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txttiemporeabastecimiento.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txttiemporeabastecimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txttiemporeabastecimiento.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txttiemporeabastecimiento.DisplayFormat = "###,###,###.##"
        Me.txttiemporeabastecimiento.ForeColor = System.Drawing.Color.Black
        Me.txttiemporeabastecimiento.Increment = 1.0R
        Me.txttiemporeabastecimiento.Location = New System.Drawing.Point(416, 94)
        Me.txttiemporeabastecimiento.Name = "txttiemporeabastecimiento"
        Me.txttiemporeabastecimiento.Size = New System.Drawing.Size(185, 22)
        Me.txttiemporeabastecimiento.TabIndex = 31
        '
        'costopromedio
        '
        Me.costopromedio.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.costopromedio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.costopromedio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.costopromedio.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.costopromedio.DisplayFormat = "###,###,###.##"
        Me.costopromedio.ForeColor = System.Drawing.Color.Black
        Me.costopromedio.Increment = 1.0R
        Me.costopromedio.Location = New System.Drawing.Point(28, 93)
        Me.costopromedio.Name = "costopromedio"
        Me.costopromedio.Size = New System.Drawing.Size(185, 22)
        Me.costopromedio.TabIndex = 30
        '
        'txtuxcaja
        '
        Me.txtuxcaja.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtuxcaja.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtuxcaja.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtuxcaja.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtuxcaja.DisplayFormat = "###,###,###.##"
        Me.txtuxcaja.ForeColor = System.Drawing.Color.Black
        Me.txtuxcaja.Increment = 1.0R
        Me.txtuxcaja.Location = New System.Drawing.Point(416, 50)
        Me.txtuxcaja.Name = "txtuxcaja"
        Me.txtuxcaja.Size = New System.Drawing.Size(185, 22)
        Me.txtuxcaja.TabIndex = 29
        '
        'txtexistencia
        '
        Me.txtexistencia.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtexistencia.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtexistencia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtexistencia.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtexistencia.DisplayFormat = "###,###,###.##"
        Me.txtexistencia.ForeColor = System.Drawing.Color.Black
        Me.txtexistencia.Increment = 1.0R
        Me.txtexistencia.Location = New System.Drawing.Point(28, 50)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(185, 22)
        Me.txtexistencia.TabIndex = 28
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(26, 203)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Punto Reorden"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(413, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Cantidad Maxima"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(26, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Cantidad Minima"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(413, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Consumo Promedio "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(26, 119)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Semanas en mano"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(413, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Tiempo Reabastecimiento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(26, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Costo Promedio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(413, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Unidades por paquete"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(26, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Existencia"
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Datos Almacen"
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.Color.White
        Me.btncerrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.ForeColor = System.Drawing.Color.Black
        Me.btncerrar.Image = Global.IPOSOFT.My.Resources.Resources.window_close
        Me.btncerrar.Location = New System.Drawing.Point(267, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(88, 65)
        Me.btncerrar.TabIndex = 5
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'btnimprimir
        '
        Me.btnimprimir.BackColor = System.Drawing.Color.White
        Me.btnimprimir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnimprimir.FlatAppearance.BorderSize = 0
        Me.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimprimir.ForeColor = System.Drawing.Color.Black
        Me.btnimprimir.Image = Global.IPOSOFT.My.Resources.Resources.printer
        Me.btnimprimir.Location = New System.Drawing.Point(179, 0)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(88, 65)
        Me.btnimprimir.TabIndex = 4
        Me.btnimprimir.Text = "Imprimir"
        Me.btnimprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnimprimir.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.Color.White
        Me.btnlimpiar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnlimpiar.FlatAppearance.BorderSize = 0
        Me.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpiar.ForeColor = System.Drawing.Color.Black
        Me.btnlimpiar.Image = Global.IPOSOFT.My.Resources.Resources.eraser
        Me.btnlimpiar.Location = New System.Drawing.Point(91, 0)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(88, 65)
        Me.btnlimpiar.TabIndex = 3
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.White
        Me.btnguardar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Image = Global.IPOSOFT.My.Resources.Resources.content_save__1_
        Me.btnguardar.Location = New System.Drawing.Point(3, 0)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(88, 65)
        Me.btnguardar.TabIndex = 2
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'frmcrearproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 436)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.Controls.Add(Me.MetroStatusBar1)
        Me.Controls.Add(Me.MetroShell1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmcrearproducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Producto"
        Me.MetroShell1.ResumeLayout(False)
        Me.MetroShell1.PerformLayout()
        Me.MetroTabPanel1.ResumeLayout(False)
        Me.MetroTabPanel3.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel1.PerformLayout()
        CType(Me.txtprecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.SuperTabControlPanel2.PerformLayout()
        CType(Me.txtreorden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcantidadmaxima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcantidadminima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtconsumopromedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsemanasenmano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttiemporeabastecimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.costopromedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuxcaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtexistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroShell1 As DevComponents.DotNetBar.Metro.MetroShell
    Friend WithEvents MetroTabPanel1 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents MetroTabItem1 As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents MetroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroTabPanel3 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents btncerrar As Button
    Friend WithEvents btnimprimir As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents StyleManager2 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents ckestado As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbimpuesto As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbmarca As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbclasificacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtcodigosap As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtprecio As DevComponents.Editors.DoubleInput
    Friend WithEvents txtreorden As DevComponents.Editors.DoubleInput
    Friend WithEvents txtcantidadmaxima As DevComponents.Editors.DoubleInput
    Friend WithEvents txtcantidadminima As DevComponents.Editors.DoubleInput
    Friend WithEvents txtconsumopromedio As DevComponents.Editors.DoubleInput
    Friend WithEvents txtsemanasenmano As DevComponents.Editors.DoubleInput
    Friend WithEvents txttiemporeabastecimiento As DevComponents.Editors.DoubleInput
    Friend WithEvents costopromedio As DevComponents.Editors.DoubleInput
    Friend WithEvents txtuxcaja As DevComponents.Editors.DoubleInput
    Friend WithEvents txtexistencia As DevComponents.Editors.DoubleInput
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmeditarcompra
    Inherits DevComponents.DotNetBar.Metro.MetroAppForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroShell1 = New DevComponents.DotNetBar.Metro.MetroShell()
        Me.MetroTabPanel1 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.MetroTabPanel3 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.MetroTabItem1 = New DevComponents.DotNetBar.Metro.MetroTabItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.dtvencimiento = New System.Windows.Forms.DateTimePicker()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.txtdocumento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lbltotal = New DevComponents.DotNetBar.LabelX()
        Me.lblimpuesto = New DevComponents.DotNetBar.LabelX()
        Me.lblsubtotal = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX5 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtnombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtcodigoproveedor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dgarticulos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtid = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnbuscarcliente = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.MetroShell1.SuspendLayout()
        Me.MetroTabPanel1.SuspendLayout()
        Me.MetroTabPanel3.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dgarticulos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroShell1.Size = New System.Drawing.Size(1060, 111)
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
        Me.MetroTabPanel1.Size = New System.Drawing.Size(1060, 60)
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
        Me.MetroTabPanel3.Controls.Add(Me.Button2)
        Me.MetroTabPanel3.Controls.Add(Me.btncerrar)
        Me.MetroTabPanel3.Controls.Add(Me.Button1)
        Me.MetroTabPanel3.Controls.Add(Me.btnbuscarcliente)
        Me.MetroTabPanel3.Controls.Add(Me.btnlimpiar)
        Me.MetroTabPanel3.Controls.Add(Me.btnguardar)
        Me.MetroTabPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel3.Location = New System.Drawing.Point(3, 0)
        Me.MetroTabPanel3.Name = "MetroTabPanel3"
        Me.MetroTabPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel3.Size = New System.Drawing.Size(1054, 57)
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
        Me.MetroTabPanel3.TabIndex = 7
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
        Me.MetroStatusBar1.Location = New System.Drawing.Point(1, 666)
        Me.MetroStatusBar1.Name = "MetroStatusBar1"
        Me.MetroStatusBar1.Size = New System.Drawing.Size(1060, 22)
        Me.MetroStatusBar1.TabIndex = 1
        Me.MetroStatusBar1.Text = "MetroStatusBar1"
        '
        'dtvencimiento
        '
        Me.dtvencimiento.BackColor = System.Drawing.Color.White
        Me.dtvencimiento.ForeColor = System.Drawing.Color.Black
        Me.dtvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtvencimiento.Location = New System.Drawing.Point(394, 171)
        Me.dtvencimiento.Name = "dtvencimiento"
        Me.dtvencimiento.Size = New System.Drawing.Size(117, 22)
        Me.dtvencimiento.TabIndex = 39
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.ForeColor = System.Drawing.Color.Black
        Me.LabelX13.Location = New System.Drawing.Point(25, 142)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(117, 23)
        Me.LabelX13.TabIndex = 38
        Me.LabelX13.Text = "# Documento"
        '
        'txtdocumento
        '
        Me.txtdocumento.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtdocumento.Border.Class = "TextBoxBorder"
        Me.txtdocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdocumento.DisabledBackColor = System.Drawing.Color.White
        Me.txtdocumento.ForeColor = System.Drawing.Color.Black
        Me.txtdocumento.Location = New System.Drawing.Point(25, 171)
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.PreventEnterBeep = True
        Me.txtdocumento.Size = New System.Drawing.Size(117, 22)
        Me.txtdocumento.TabIndex = 37
        '
        'dtfecha
        '
        Me.dtfecha.BackColor = System.Drawing.Color.White
        Me.dtfecha.ForeColor = System.Drawing.Color.Black
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(148, 171)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(117, 22)
        Me.dtfecha.TabIndex = 36
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.lbltotal)
        Me.GroupPanel1.Controls.Add(Me.lblimpuesto)
        Me.GroupPanel1.Controls.Add(Me.lblsubtotal)
        Me.GroupPanel1.Controls.Add(Me.LabelX9)
        Me.GroupPanel1.Controls.Add(Me.LabelX8)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(25, 548)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1015, 100)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 35
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbltotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbltotal.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.FontBold = True
        Me.lbltotal.ForeColor = System.Drawing.Color.Black
        Me.lbltotal.Location = New System.Drawing.Point(702, 32)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(278, 59)
        Me.lbltotal.TabIndex = 10
        Me.lbltotal.Text = "0.00"
        Me.lbltotal.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lbltotal.TextLineAlignment = System.Drawing.StringAlignment.Far
        '
        'lblimpuesto
        '
        Me.lblimpuesto.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblimpuesto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblimpuesto.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblimpuesto.FontBold = True
        Me.lblimpuesto.ForeColor = System.Drawing.Color.Black
        Me.lblimpuesto.Location = New System.Drawing.Point(316, 33)
        Me.lblimpuesto.Name = "lblimpuesto"
        Me.lblimpuesto.Size = New System.Drawing.Size(278, 59)
        Me.lblimpuesto.TabIndex = 9
        Me.lblimpuesto.Text = "0.00"
        Me.lblimpuesto.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblimpuesto.TextLineAlignment = System.Drawing.StringAlignment.Far
        '
        'lblsubtotal
        '
        Me.lblsubtotal.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblsubtotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblsubtotal.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.FontBold = True
        Me.lblsubtotal.ForeColor = System.Drawing.Color.Black
        Me.lblsubtotal.Location = New System.Drawing.Point(-3, 32)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(278, 59)
        Me.lblsubtotal.TabIndex = 8
        Me.lblsubtotal.Text = "0.00"
        Me.lblsubtotal.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblsubtotal.TextLineAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(944, 0)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(36, 23)
        Me.LabelX9.TabIndex = 7
        Me.LabelX9.Text = "Total"
        Me.LabelX9.TextLineAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(548, 4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(46, 23)
        Me.LabelX8.TabIndex = 6
        Me.LabelX8.Text = "Impuesto"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(228, 4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(47, 23)
        Me.LabelX7.TabIndex = 5
        Me.LabelX7.Text = "Subtotal"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(394, 142)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(117, 23)
        Me.LabelX6.TabIndex = 34
        Me.LabelX6.Text = "Fecha Vencimiento"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(271, 142)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(117, 23)
        Me.LabelX5.TabIndex = 33
        Me.LabelX5.Text = "Dias Credito"
        '
        'TextBoxX5
        '
        Me.TextBoxX5.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX5.Border.Class = "TextBoxBorder"
        Me.TextBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX5.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX5.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX5.Location = New System.Drawing.Point(271, 171)
        Me.TextBoxX5.Name = "TextBoxX5"
        Me.TextBoxX5.PreventEnterBeep = True
        Me.TextBoxX5.Size = New System.Drawing.Size(117, 22)
        Me.TextBoxX5.TabIndex = 32
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(148, 142)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(117, 23)
        Me.LabelX3.TabIndex = 31
        Me.LabelX3.Text = "Fecha"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(148, 191)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(117, 23)
        Me.LabelX2.TabIndex = 30
        Me.LabelX2.Text = "Proveedor"
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtnombre.Border.Class = "TextBoxBorder"
        Me.txtnombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnombre.DisabledBackColor = System.Drawing.Color.White
        Me.txtnombre.ForeColor = System.Drawing.Color.Black
        Me.txtnombre.Location = New System.Drawing.Point(148, 220)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.PreventEnterBeep = True
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(388, 22)
        Me.txtnombre.TabIndex = 29
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(25, 191)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(117, 23)
        Me.LabelX1.TabIndex = 28
        Me.LabelX1.Text = "Codigo Proveedor"
        '
        'txtcodigoproveedor
        '
        Me.txtcodigoproveedor.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtcodigoproveedor.Border.Class = "TextBoxBorder"
        Me.txtcodigoproveedor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcodigoproveedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtcodigoproveedor.ForeColor = System.Drawing.Color.Black
        Me.txtcodigoproveedor.Location = New System.Drawing.Point(25, 220)
        Me.txtcodigoproveedor.Name = "txtcodigoproveedor"
        Me.txtcodigoproveedor.PreventEnterBeep = True
        Me.txtcodigoproveedor.ReadOnly = True
        Me.txtcodigoproveedor.Size = New System.Drawing.Size(117, 22)
        Me.txtcodigoproveedor.TabIndex = 27
        '
        'dgarticulos
        '
        Me.dgarticulos.AllowUserToAddRows = False
        Me.dgarticulos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgarticulos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgarticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgarticulos.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgarticulos.EnableHeadersVisualStyles = False
        Me.dgarticulos.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgarticulos.Location = New System.Drawing.Point(25, 250)
        Me.dgarticulos.Name = "dgarticulos"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgarticulos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgarticulos.Size = New System.Drawing.Size(1015, 292)
        Me.dgarticulos.TabIndex = 26
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.HeaderText = "Articulo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 320
        '
        'Column3
        '
        '
        '
        '
        Me.Column3.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.Increment = 1.0R
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column4
        '
        Me.Column4.HeaderText = "Precio"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Subtotal"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Impuesto"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "id"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(923, 106)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(117, 23)
        Me.LabelX4.TabIndex = 41
        Me.LabelX4.Text = "ID"
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtid.Border.Class = "TextBoxBorder"
        Me.txtid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtid.DisabledBackColor = System.Drawing.Color.White
        Me.txtid.ForeColor = System.Drawing.Color.Black
        Me.txtid.Location = New System.Drawing.Point(923, 135)
        Me.txtid.Name = "txtid"
        Me.txtid.PreventEnterBeep = True
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(117, 22)
        Me.txtid.TabIndex = 40
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.IPOSOFT.My.Resources.Resources.window_close
        Me.Button2.Location = New System.Drawing.Point(443, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 54)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cerrar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.Color.White
        Me.btncerrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.ForeColor = System.Drawing.Color.Black
        Me.btncerrar.Image = Global.IPOSOFT.My.Resources.Resources.cloud_upload
        Me.btncerrar.Location = New System.Drawing.Point(355, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(88, 54)
        Me.btncerrar.TabIndex = 8
        Me.btncerrar.Text = "Cargar"
        Me.btncerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.IPOSOFT.My.Resources.Resources.magnify
        Me.Button1.Location = New System.Drawing.Point(267, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 54)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Productos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnbuscarcliente
        '
        Me.btnbuscarcliente.BackColor = System.Drawing.Color.White
        Me.btnbuscarcliente.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnbuscarcliente.FlatAppearance.BorderSize = 0
        Me.btnbuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarcliente.ForeColor = System.Drawing.Color.Black
        Me.btnbuscarcliente.Image = Global.IPOSOFT.My.Resources.Resources.account_search
        Me.btnbuscarcliente.Location = New System.Drawing.Point(179, 0)
        Me.btnbuscarcliente.Name = "btnbuscarcliente"
        Me.btnbuscarcliente.Size = New System.Drawing.Size(88, 54)
        Me.btnbuscarcliente.TabIndex = 6
        Me.btnbuscarcliente.Text = "Proveedor"
        Me.btnbuscarcliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbuscarcliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnbuscarcliente.UseVisualStyleBackColor = False
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
        Me.btnlimpiar.Size = New System.Drawing.Size(88, 54)
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
        Me.btnguardar.Image = Global.IPOSOFT.My.Resources.Resources.refresh
        Me.btnguardar.Location = New System.Drawing.Point(3, 0)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(88, 54)
        Me.btnguardar.TabIndex = 2
        Me.btnguardar.Text = "Actualizar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'frmeditarcompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 689)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.dtvencimiento)
        Me.Controls.Add(Me.LabelX13)
        Me.Controls.Add(Me.txtdocumento)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.TextBoxX5)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtcodigoproveedor)
        Me.Controls.Add(Me.dgarticulos)
        Me.Controls.Add(Me.MetroStatusBar1)
        Me.Controls.Add(Me.MetroShell1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmeditarcompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar  compra"
        Me.MetroShell1.ResumeLayout(False)
        Me.MetroShell1.PerformLayout()
        Me.MetroTabPanel1.ResumeLayout(False)
        Me.MetroTabPanel3.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.dgarticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroShell1 As DevComponents.DotNetBar.Metro.MetroShell
    Friend WithEvents MetroTabPanel1 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents MetroTabItem1 As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents MetroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroTabPanel3 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents btncerrar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnbuscarcliente As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents dtvencimiento As DateTimePicker
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtdocumento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lbltotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblimpuesto As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblsubtotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtnombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtcodigoproveedor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dgarticulos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtid As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class

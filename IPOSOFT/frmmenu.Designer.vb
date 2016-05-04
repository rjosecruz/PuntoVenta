<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenu))
        Me.MetroShell1 = New DevComponents.DotNetBar.Metro.MetroShell()
        Me.MetroTabPanel1 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnproductos = New System.Windows.Forms.Button()
        Me.MetroTabPanel4 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.MetroTabPanel2 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MetroTabPanel3 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.MetroAppButton1 = New DevComponents.DotNetBar.Metro.MetroAppButton()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.MetroTabItem2 = New DevComponents.DotNetBar.Metro.MetroTabItem()
        Me.MetroTabItem1 = New DevComponents.DotNetBar.Metro.MetroTabItem()
        Me.MetroTabItem3 = New DevComponents.DotNetBar.Metro.MetroTabItem()
        Me.MetroTabItem4 = New DevComponents.DotNetBar.Metro.MetroTabItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton2 = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton3 = New System.Windows.Forms.RibbonButton()
        Me.RibbonColorChooser1 = New System.Windows.Forms.RibbonColorChooser()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.MetroShell1.SuspendLayout()
        Me.MetroTabPanel1.SuspendLayout()
        Me.MetroTabPanel4.SuspendLayout()
        Me.MetroTabPanel2.SuspendLayout()
        Me.MetroTabPanel3.SuspendLayout()
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
        Me.MetroShell1.Controls.Add(Me.MetroTabPanel4)
        Me.MetroShell1.Controls.Add(Me.MetroTabPanel2)
        Me.MetroShell1.Controls.Add(Me.MetroTabPanel3)
        Me.MetroShell1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroShell1.ForeColor = System.Drawing.Color.Black
        Me.MetroShell1.HelpButtonText = Nothing
        Me.MetroShell1.HelpButtonVisible = False
        Me.MetroShell1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MetroAppButton1, Me.MetroTabItem2, Me.MetroTabItem1, Me.MetroTabItem3, Me.MetroTabItem4})
        Me.MetroShell1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.MetroShell1.Location = New System.Drawing.Point(1, 1)
        Me.MetroShell1.Name = "MetroShell1"
        Me.MetroShell1.SettingsButtonVisible = False
        Me.MetroShell1.Size = New System.Drawing.Size(750, 104)
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
        Me.MetroTabPanel1.Controls.Add(Me.Button11)
        Me.MetroTabPanel1.Controls.Add(Me.Button7)
        Me.MetroTabPanel1.Controls.Add(Me.Button4)
        Me.MetroTabPanel1.Controls.Add(Me.Button3)
        Me.MetroTabPanel1.Controls.Add(Me.Button2)
        Me.MetroTabPanel1.Controls.Add(Me.Button1)
        Me.MetroTabPanel1.Controls.Add(Me.btnproductos)
        Me.MetroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel1.Location = New System.Drawing.Point(0, 51)
        Me.MetroTabPanel1.Name = "MetroTabPanel1"
        Me.MetroTabPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel1.Size = New System.Drawing.Size(750, 53)
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
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Image = Global.IPOSOFT.My.Resources.Resources.cart_outline
        Me.Button7.Location = New System.Drawing.Point(468, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(93, 50)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Compras"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.IPOSOFT.My.Resources.Resources.star_outline
        Me.Button4.Location = New System.Drawing.Point(375, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 50)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Metas"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.IPOSOFT.My.Resources.Resources.store
        Me.Button3.Location = New System.Drawing.Point(282, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 50)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Almacenes"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.IPOSOFT.My.Resources.Resources.cart_plus
        Me.Button2.Location = New System.Drawing.Point(189, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Clasificacion"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.IPOSOFT.My.Resources.Resources.cart_plus
        Me.Button1.Location = New System.Drawing.Point(96, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Marcas"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnproductos
        '
        Me.btnproductos.BackColor = System.Drawing.Color.White
        Me.btnproductos.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnproductos.FlatAppearance.BorderSize = 0
        Me.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproductos.ForeColor = System.Drawing.Color.Black
        Me.btnproductos.Image = Global.IPOSOFT.My.Resources.Resources.food_variant
        Me.btnproductos.Location = New System.Drawing.Point(3, 0)
        Me.btnproductos.Name = "btnproductos"
        Me.btnproductos.Size = New System.Drawing.Size(93, 50)
        Me.btnproductos.TabIndex = 0
        Me.btnproductos.Text = "Productos"
        Me.btnproductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnproductos.UseVisualStyleBackColor = False
        '
        'MetroTabPanel4
        '
        Me.MetroTabPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MetroTabPanel4.Controls.Add(Me.Button10)
        Me.MetroTabPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel4.Location = New System.Drawing.Point(0, 51)
        Me.MetroTabPanel4.Name = "MetroTabPanel4"
        Me.MetroTabPanel4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel4.Size = New System.Drawing.Size(651, 53)
        '
        '
        '
        Me.MetroTabPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTabPanel4.TabIndex = 4
        Me.MetroTabPanel4.Visible = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Image = Global.IPOSOFT.My.Resources.Resources.account_multiple
        Me.Button10.Location = New System.Drawing.Point(3, 0)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(93, 50)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "Proveedores"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button10.UseVisualStyleBackColor = False
        '
        'MetroTabPanel2
        '
        Me.MetroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MetroTabPanel2.Controls.Add(Me.Button8)
        Me.MetroTabPanel2.Controls.Add(Me.Button6)
        Me.MetroTabPanel2.Controls.Add(Me.Button5)
        Me.MetroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabPanel2.Name = "MetroTabPanel2"
        Me.MetroTabPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel2.Size = New System.Drawing.Size(651, 104)
        '
        '
        '
        Me.MetroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTabPanel2.TabIndex = 2
        Me.MetroTabPanel2.Visible = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Image = Global.IPOSOFT.My.Resources.Resources.google_maps
        Me.Button8.Location = New System.Drawing.Point(189, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(93, 101)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "Zonas"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Image = Global.IPOSOFT.My.Resources.Resources.account_multiple
        Me.Button6.Location = New System.Drawing.Point(96, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(93, 101)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Vendedores"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Image = Global.IPOSOFT.My.Resources.Resources.cash_multiple
        Me.Button5.Location = New System.Drawing.Point(3, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 101)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Impuestos"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'MetroTabPanel3
        '
        Me.MetroTabPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MetroTabPanel3.Controls.Add(Me.Button9)
        Me.MetroTabPanel3.Controls.Add(Me.btnclientes)
        Me.MetroTabPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel3.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabPanel3.Name = "MetroTabPanel3"
        Me.MetroTabPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel3.Size = New System.Drawing.Size(651, 104)
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
        Me.MetroTabPanel3.Visible = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Image = Global.IPOSOFT.My.Resources.Resources.account_multiple
        Me.Button9.Location = New System.Drawing.Point(96, 0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(93, 101)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "Reporte Venciemiento"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button9.UseVisualStyleBackColor = False
        '
        'btnclientes
        '
        Me.btnclientes.BackColor = System.Drawing.Color.White
        Me.btnclientes.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnclientes.FlatAppearance.BorderSize = 0
        Me.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclientes.ForeColor = System.Drawing.Color.Black
        Me.btnclientes.Image = Global.IPOSOFT.My.Resources.Resources.account_multiple
        Me.btnclientes.Location = New System.Drawing.Point(3, 0)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(93, 101)
        Me.btnclientes.TabIndex = 1
        Me.btnclientes.Text = "Clientes"
        Me.btnclientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnclientes.UseVisualStyleBackColor = False
        '
        'MetroAppButton1
        '
        Me.MetroAppButton1.AutoExpandOnClick = True
        Me.MetroAppButton1.CanCustomize = False
        Me.MetroAppButton1.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.MetroAppButton1.ImagePaddingHorizontal = 0
        Me.MetroAppButton1.ImagePaddingVertical = 0
        Me.MetroAppButton1.Name = "MetroAppButton1"
        Me.MetroAppButton1.ShowSubItems = False
        Me.MetroAppButton1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem2, Me.ButtonItem3})
        Me.MetroAppButton1.Text = "&Opciones"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Seguridad"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "Base de datos"
        '
        'MetroTabItem2
        '
        Me.MetroTabItem2.Name = "MetroTabItem2"
        Me.MetroTabItem2.Panel = Me.MetroTabPanel2
        Me.MetroTabItem2.Text = "&Configuracion"
        '
        'MetroTabItem1
        '
        Me.MetroTabItem1.Checked = True
        Me.MetroTabItem1.Name = "MetroTabItem1"
        Me.MetroTabItem1.Panel = Me.MetroTabPanel1
        Me.MetroTabItem1.Text = "&Inventario"
        '
        'MetroTabItem3
        '
        Me.MetroTabItem3.Name = "MetroTabItem3"
        Me.MetroTabItem3.Panel = Me.MetroTabPanel3
        Me.MetroTabItem3.Text = "Cuentas por cobrar"
        '
        'MetroTabItem4
        '
        Me.MetroTabItem4.Name = "MetroTabItem4"
        Me.MetroTabItem4.Panel = Me.MetroTabPanel4
        Me.MetroTabItem4.Text = "Cuentas por pagar"
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
        Me.MetroStatusBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1})
        Me.MetroStatusBar1.Location = New System.Drawing.Point(1, 413)
        Me.MetroStatusBar1.Name = "MetroStatusBar1"
        Me.MetroStatusBar1.Size = New System.Drawing.Size(750, 22)
        Me.MetroStatusBar1.TabIndex = 1
        Me.MetroStatusBar1.Text = "MetroStatusBar1"
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "READY"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "ButtonItem1"
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins)
        Me.DotNetBarManager1.BottomDockSite = Me.DockSite4
        Me.DotNetBarManager1.EnableFullSizeDock = False
        Me.DotNetBarManager1.LeftDockSite = Me.DockSite1
        Me.DotNetBarManager1.ParentForm = Me
        Me.DotNetBarManager1.RightDockSite = Me.DockSite2
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.DotNetBarManager1.ToolbarBottomDockSite = Me.DockSite8
        Me.DotNetBarManager1.ToolbarLeftDockSite = Me.DockSite5
        Me.DotNetBarManager1.ToolbarRightDockSite = Me.DockSite6
        Me.DotNetBarManager1.ToolbarTopDockSite = Me.DockSite7
        Me.DotNetBarManager1.TopDockSite = Me.DockSite3
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.BackColor = System.Drawing.Color.White
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite4.ForeColor = System.Drawing.Color.Black
        Me.DockSite4.Location = New System.Drawing.Point(1, 435)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(750, 0)
        Me.DockSite4.TabIndex = 6
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.BackColor = System.Drawing.Color.White
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.ForeColor = System.Drawing.Color.Black
        Me.DockSite1.Location = New System.Drawing.Point(1, 105)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 308)
        Me.DockSite1.TabIndex = 3
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.BackColor = System.Drawing.Color.White
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.ForeColor = System.Drawing.Color.Black
        Me.DockSite2.Location = New System.Drawing.Point(751, 105)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 308)
        Me.DockSite2.TabIndex = 4
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.BackColor = System.Drawing.Color.White
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.ForeColor = System.Drawing.Color.Black
        Me.DockSite8.Location = New System.Drawing.Point(1, 435)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(750, 0)
        Me.DockSite8.TabIndex = 10
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.BackColor = System.Drawing.Color.White
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.ForeColor = System.Drawing.Color.Black
        Me.DockSite5.Location = New System.Drawing.Point(1, 1)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 434)
        Me.DockSite5.TabIndex = 7
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.BackColor = System.Drawing.Color.White
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.ForeColor = System.Drawing.Color.Black
        Me.DockSite6.Location = New System.Drawing.Point(751, 1)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 434)
        Me.DockSite6.TabIndex = 8
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.BackColor = System.Drawing.Color.White
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.ForeColor = System.Drawing.Color.Black
        Me.DockSite7.Location = New System.Drawing.Point(1, 1)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(750, 0)
        Me.DockSite7.TabIndex = 9
        Me.DockSite7.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.BackColor = System.Drawing.Color.White
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.ForeColor = System.Drawing.Color.Black
        Me.DockSite3.Location = New System.Drawing.Point(1, 1)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(750, 0)
        Me.DockSite3.TabIndex = 5
        Me.DockSite3.TabStop = False
        '
        'RibbonButton1
        '
        Me.RibbonButton1.AltKey = Nothing
        Me.RibbonButton1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.RibbonButton1.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.RibbonButton1.Tag = Nothing
        Me.RibbonButton1.Text = Nothing
        Me.RibbonButton1.ToolTip = Nothing
        Me.RibbonButton1.ToolTipImage = Nothing
        Me.RibbonButton1.ToolTipTitle = Nothing
        '
        'RibbonButton2
        '
        Me.RibbonButton2.AltKey = Nothing
        Me.RibbonButton2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.RibbonButton2.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.RibbonButton2.Image = CType(resources.GetObject("RibbonButton2.Image"), System.Drawing.Image)
        Me.RibbonButton2.SmallImage = CType(resources.GetObject("RibbonButton2.SmallImage"), System.Drawing.Image)
        Me.RibbonButton2.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.RibbonButton2.Tag = Nothing
        Me.RibbonButton2.Text = Nothing
        Me.RibbonButton2.ToolTip = Nothing
        Me.RibbonButton2.ToolTipImage = Nothing
        Me.RibbonButton2.ToolTipTitle = Nothing
        '
        'RibbonButton3
        '
        Me.RibbonButton3.AltKey = Nothing
        Me.RibbonButton3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.RibbonButton3.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.RibbonButton3.Image = CType(resources.GetObject("RibbonButton3.Image"), System.Drawing.Image)
        Me.RibbonButton3.SmallImage = CType(resources.GetObject("RibbonButton3.SmallImage"), System.Drawing.Image)
        Me.RibbonButton3.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.RibbonButton3.Tag = Nothing
        Me.RibbonButton3.Text = Nothing
        Me.RibbonButton3.ToolTip = Nothing
        Me.RibbonButton3.ToolTipImage = Nothing
        Me.RibbonButton3.ToolTipTitle = Nothing
        '
        'RibbonColorChooser1
        '
        Me.RibbonColorChooser1.AltKey = Nothing
        Me.RibbonColorChooser1.Color = System.Drawing.Color.Transparent
        Me.RibbonColorChooser1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.RibbonColorChooser1.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.RibbonColorChooser1.Image = CType(resources.GetObject("RibbonColorChooser1.Image"), System.Drawing.Image)
        Me.RibbonColorChooser1.SmallImage = CType(resources.GetObject("RibbonColorChooser1.SmallImage"), System.Drawing.Image)
        Me.RibbonColorChooser1.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.RibbonColorChooser1.Tag = Nothing
        Me.RibbonColorChooser1.Text = Nothing
        Me.RibbonColorChooser1.ToolTip = Nothing
        Me.RibbonColorChooser1.ToolTipImage = Nothing
        Me.RibbonColorChooser1.ToolTipTitle = Nothing
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Image = Global.IPOSOFT.My.Resources.Resources.cart_plus
        Me.Button11.Location = New System.Drawing.Point(561, 0)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(93, 50)
        Me.Button11.TabIndex = 6
        Me.Button11.Text = "Ventas"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button11.UseVisualStyleBackColor = False
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 436)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.MetroStatusBar1)
        Me.Controls.Add(Me.MetroShell1)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "frmmenu"
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MetroShell1.ResumeLayout(False)
        Me.MetroShell1.PerformLayout()
        Me.MetroTabPanel1.ResumeLayout(False)
        Me.MetroTabPanel4.ResumeLayout(False)
        Me.MetroTabPanel2.ResumeLayout(False)
        Me.MetroTabPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroShell1 As DevComponents.DotNetBar.Metro.MetroShell
    Friend WithEvents MetroTabPanel1 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents MetroTabPanel2 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents MetroAppButton1 As DevComponents.DotNetBar.Metro.MetroAppButton
    Friend WithEvents MetroTabItem1 As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents MetroTabItem2 As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents MetroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnproductos As Button
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents RibbonButton1 As RibbonButton
    Friend WithEvents RibbonButton2 As RibbonButton
    Friend WithEvents RibbonButton3 As RibbonButton
    Friend WithEvents RibbonColorChooser1 As RibbonColorChooser
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents MetroTabPanel3 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents btnclientes As Button
    Friend WithEvents MetroTabItem3 As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents Button9 As Button
    Friend WithEvents MetroTabPanel4 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents Button10 As Button
    Friend WithEvents MetroTabItem4 As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents Button11 As Button
End Class

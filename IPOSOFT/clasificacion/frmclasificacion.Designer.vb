<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmclasificacion
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
        Me.MetroShell1 = New DevComponents.DotNetBar.Metro.MetroShell()
        Me.MetroTabPanel1 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.MetroTabPanel3 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnconsultar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btncrear = New System.Windows.Forms.Button()
        Me.MetroTabItem1 = New DevComponents.DotNetBar.Metro.MetroTabItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.txtfiltrar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvclasificacion = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroShell1.SuspendLayout()
        Me.MetroTabPanel1.SuspendLayout()
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
        Me.MetroShell1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroShell1.ForeColor = System.Drawing.Color.Black
        Me.MetroShell1.HelpButtonText = Nothing
        Me.MetroShell1.HelpButtonVisible = False
        Me.MetroShell1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MetroTabItem1})
        Me.MetroShell1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.MetroShell1.Location = New System.Drawing.Point(1, 1)
        Me.MetroShell1.Name = "MetroShell1"
        Me.MetroShell1.SettingsButtonVisible = False
        Me.MetroShell1.Size = New System.Drawing.Size(651, 118)
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
        Me.MetroTabPanel1.Size = New System.Drawing.Size(651, 67)
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
        Me.MetroTabPanel3.Controls.Add(Me.btnactualizar)
        Me.MetroTabPanel3.Controls.Add(Me.btneliminar)
        Me.MetroTabPanel3.Controls.Add(Me.btnconsultar)
        Me.MetroTabPanel3.Controls.Add(Me.btneditar)
        Me.MetroTabPanel3.Controls.Add(Me.btncrear)
        Me.MetroTabPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel3.Location = New System.Drawing.Point(3, 0)
        Me.MetroTabPanel3.Name = "MetroTabPanel3"
        Me.MetroTabPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel3.Size = New System.Drawing.Size(645, 64)
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
        Me.MetroTabPanel3.TabIndex = 4
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.Color.White
        Me.btncerrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.ForeColor = System.Drawing.Color.Black
        Me.btncerrar.Image = Global.IPOSOFT.My.Resources.Resources.window_close
        Me.btncerrar.Location = New System.Drawing.Point(468, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(93, 61)
        Me.btncerrar.TabIndex = 7
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'btnactualizar
        '
        Me.btnactualizar.BackColor = System.Drawing.Color.White
        Me.btnactualizar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnactualizar.FlatAppearance.BorderSize = 0
        Me.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactualizar.ForeColor = System.Drawing.Color.Black
        Me.btnactualizar.Image = Global.IPOSOFT.My.Resources.Resources.refresh
        Me.btnactualizar.Location = New System.Drawing.Point(375, 0)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(93, 61)
        Me.btnactualizar.TabIndex = 6
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.White
        Me.btneliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.ForeColor = System.Drawing.Color.Black
        Me.btneliminar.Image = Global.IPOSOFT.My.Resources.Resources.delete
        Me.btneliminar.Location = New System.Drawing.Point(282, 0)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(93, 61)
        Me.btneliminar.TabIndex = 4
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'btnconsultar
        '
        Me.btnconsultar.BackColor = System.Drawing.Color.White
        Me.btnconsultar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnconsultar.FlatAppearance.BorderSize = 0
        Me.btnconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconsultar.ForeColor = System.Drawing.Color.Black
        Me.btnconsultar.Image = Global.IPOSOFT.My.Resources.Resources.file_find
        Me.btnconsultar.Location = New System.Drawing.Point(189, 0)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.Size = New System.Drawing.Size(93, 61)
        Me.btnconsultar.TabIndex = 3
        Me.btnconsultar.Text = "Consultar"
        Me.btnconsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnconsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnconsultar.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.White
        Me.btneditar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btneditar.FlatAppearance.BorderSize = 0
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar.ForeColor = System.Drawing.Color.Black
        Me.btneditar.Image = Global.IPOSOFT.My.Resources.Resources.tooltip_edit
        Me.btneditar.Location = New System.Drawing.Point(96, 0)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(93, 61)
        Me.btneditar.TabIndex = 2
        Me.btneditar.Text = "Editar"
        Me.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'btncrear
        '
        Me.btncrear.BackColor = System.Drawing.Color.White
        Me.btncrear.Dock = System.Windows.Forms.DockStyle.Left
        Me.btncrear.FlatAppearance.BorderSize = 0
        Me.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncrear.ForeColor = System.Drawing.Color.Black
        Me.btncrear.Image = Global.IPOSOFT.My.Resources.Resources.plus
        Me.btncrear.Location = New System.Drawing.Point(3, 0)
        Me.btncrear.Name = "btncrear"
        Me.btncrear.Size = New System.Drawing.Size(93, 61)
        Me.btncrear.TabIndex = 1
        Me.btncrear.Text = "Nuevo"
        Me.btncrear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btncrear.UseVisualStyleBackColor = False
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
        'txtfiltrar
        '
        Me.txtfiltrar.BackColor = System.Drawing.Color.White
        Me.txtfiltrar.ForeColor = System.Drawing.Color.Black
        Me.txtfiltrar.Location = New System.Drawing.Point(77, 135)
        Me.txtfiltrar.Name = "txtfiltrar"
        Me.txtfiltrar.Size = New System.Drawing.Size(395, 22)
        Me.txtfiltrar.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Buscar"
        '
        'lvclasificacion
        '
        Me.lvclasificacion.BackColor = System.Drawing.Color.White
        Me.lvclasificacion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvclasificacion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvclasificacion.ForeColor = System.Drawing.Color.Black
        Me.lvclasificacion.FullRowSelect = True
        Me.lvclasificacion.GridLines = True
        Me.lvclasificacion.Location = New System.Drawing.Point(25, 173)
        Me.lvclasificacion.Name = "lvclasificacion"
        Me.lvclasificacion.Size = New System.Drawing.Size(602, 215)
        Me.lvclasificacion.TabIndex = 5
        Me.lvclasificacion.UseCompatibleStateImageBehavior = False
        Me.lvclasificacion.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Clasificacion"
        Me.ColumnHeader2.Width = 320
        '
        'frmclasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 436)
        Me.Controls.Add(Me.txtfiltrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvclasificacion)
        Me.Controls.Add(Me.MetroStatusBar1)
        Me.Controls.Add(Me.MetroShell1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmclasificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificación"
        Me.MetroShell1.ResumeLayout(False)
        Me.MetroShell1.PerformLayout()
        Me.MetroTabPanel1.ResumeLayout(False)
        Me.MetroTabPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroShell1 As DevComponents.DotNetBar.Metro.MetroShell
    Friend WithEvents MetroTabPanel1 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents MetroTabItem1 As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents MetroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroTabPanel3 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents btncerrar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnconsultar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btncrear As Button
    Friend WithEvents txtfiltrar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lvclasificacion As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconsultarcategoria
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MetroTabItem1 = New DevComponents.DotNetBar.Metro.MetroTabItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.ckestado = New System.Windows.Forms.CheckBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtclasificacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.MetroShell1.Size = New System.Drawing.Size(398, 119)
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
        Me.MetroTabPanel1.Size = New System.Drawing.Size(398, 68)
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
        Me.MetroTabPanel3.Controls.Add(Me.Button1)
        Me.MetroTabPanel3.Controls.Add(Me.Button2)
        Me.MetroTabPanel3.Controls.Add(Me.Button3)
        Me.MetroTabPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel3.Location = New System.Drawing.Point(3, 0)
        Me.MetroTabPanel3.Name = "MetroTabPanel3"
        Me.MetroTabPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel3.Size = New System.Drawing.Size(392, 65)
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
        Me.MetroTabPanel3.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.IPOSOFT.My.Resources.Resources.window_close
        Me.Button1.Location = New System.Drawing.Point(179, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 62)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cerrar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.IPOSOFT.My.Resources.Resources.eraser
        Me.Button2.Location = New System.Drawing.Point(91, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 62)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Limpiar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.IPOSOFT.My.Resources.Resources.refresh
        Me.Button3.Location = New System.Drawing.Point(3, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 62)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Actualizar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.MetroStatusBar1.Location = New System.Drawing.Point(1, 304)
        Me.MetroStatusBar1.Name = "MetroStatusBar1"
        Me.MetroStatusBar1.Size = New System.Drawing.Size(398, 22)
        Me.MetroStatusBar1.TabIndex = 1
        Me.MetroStatusBar1.Text = "MetroStatusBar1"
        '
        'ckestado
        '
        Me.ckestado.AutoSize = True
        Me.ckestado.BackColor = System.Drawing.Color.White
        Me.ckestado.Enabled = False
        Me.ckestado.ForeColor = System.Drawing.Color.Black
        Me.ckestado.Location = New System.Drawing.Point(43, 242)
        Me.ckestado.Name = "ckestado"
        Me.ckestado.Size = New System.Drawing.Size(80, 17)
        Me.ckestado.TabIndex = 20
        Me.ckestado.Text = "Habilitado"
        Me.ckestado.UseVisualStyleBackColor = False
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.White
        Me.txtid.ForeColor = System.Drawing.Color.Black
        Me.txtid.Location = New System.Drawing.Point(43, 158)
        Me.txtid.MaxLength = 255
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(131, 22)
        Me.txtid.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(40, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Id"
        '
        'txtclasificacion
        '
        Me.txtclasificacion.BackColor = System.Drawing.Color.White
        Me.txtclasificacion.ForeColor = System.Drawing.Color.Black
        Me.txtclasificacion.Location = New System.Drawing.Point(43, 205)
        Me.txtclasificacion.MaxLength = 255
        Me.txtclasificacion.Name = "txtclasificacion"
        Me.txtclasificacion.ReadOnly = True
        Me.txtclasificacion.Size = New System.Drawing.Size(326, 22)
        Me.txtclasificacion.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(40, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Clasificacion"
        '
        'frmconsultarcategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 327)
        Me.ControlBox = True
        Me.Controls.Add(Me.ckestado)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtclasificacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MetroStatusBar1)
        Me.Controls.Add(Me.MetroShell1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmconsultarcategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Categoria"
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ckestado As CheckBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtclasificacion As TextBox
    Friend WithEvents Label1 As Label
End Class

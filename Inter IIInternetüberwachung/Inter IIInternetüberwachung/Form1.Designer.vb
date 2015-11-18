<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lb_ownrouter = New LightButton.LightButton()
        Me.lb_inter_ii = New LightButton.LightButton()
        Me.lbl_own = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_login = New LightButton.LightButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lb_zdv = New LightButton.LightButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lb_hbf = New LightButton.LightButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cb_interfaces = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.lbl_ping_own = New System.Windows.Forms.Label()
        Me.lbl_ping_inter = New System.Windows.Forms.Label()
        Me.lbl_ping_login = New System.Windows.Forms.Label()
        Me.lbl_ping_zdv = New System.Windows.Forms.Label()
        Me.lbl_ping_internet = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lbl_ping_hbf = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lb_internet = New LightButton.LightButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.line_own_inter = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.line_inter_login = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.line_login_zdv = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.line_zdv_hbf = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.line_hbf_internet = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_ownrouter
        '
        Me.lb_ownrouter.BackColor = System.Drawing.Color.Transparent
        Me.lb_ownrouter.BackgroundImage = CType(resources.GetObject("lb_ownrouter.BackgroundImage"), System.Drawing.Image)
        Me.lb_ownrouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lb_ownrouter.Caption = "Eigener Router"
        Me.lb_ownrouter.LightState = LightButton.LightButton.Light.Red
        Me.lb_ownrouter.Location = New System.Drawing.Point(12, 12)
        Me.lb_ownrouter.Name = "lb_ownrouter"
        Me.lb_ownrouter.Size = New System.Drawing.Size(140, 140)
        Me.lb_ownrouter.TabIndex = 0
        '
        'lb_inter_ii
        '
        Me.lb_inter_ii.BackColor = System.Drawing.Color.Transparent
        Me.lb_inter_ii.BackgroundImage = CType(resources.GetObject("lb_inter_ii.BackgroundImage"), System.Drawing.Image)
        Me.lb_inter_ii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lb_inter_ii.Caption = "Inter II"
        Me.lb_inter_ii.LightState = LightButton.LightButton.Light.Red
        Me.lb_inter_ii.Location = New System.Drawing.Point(242, 12)
        Me.lb_inter_ii.Name = "lb_inter_ii"
        Me.lb_inter_ii.Size = New System.Drawing.Size(140, 140)
        Me.lb_inter_ii.TabIndex = 1
        '
        'lbl_own
        '
        Me.lbl_own.AutoSize = True
        Me.lbl_own.Location = New System.Drawing.Point(47, 155)
        Me.lbl_own.Name = "lbl_own"
        Me.lbl_own.Size = New System.Drawing.Size(64, 13)
        Me.lbl_own.TabIndex = 2
        Me.lbl_own.Text = "192.168.0.1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "134.93.79.254"
        '
        'lb_login
        '
        Me.lb_login.BackColor = System.Drawing.Color.Transparent
        Me.lb_login.BackgroundImage = CType(resources.GetObject("lb_login.BackgroundImage"), System.Drawing.Image)
        Me.lb_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lb_login.Caption = "Loginseite"
        Me.lb_login.LightState = LightButton.LightButton.Light.Red
        Me.lb_login.Location = New System.Drawing.Point(472, 12)
        Me.lb_login.Name = "lb_login"
        Me.lb_login.Size = New System.Drawing.Size(140, 140)
        Me.lb_login.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(505, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "134.93.48.86"
        '
        'lb_zdv
        '
        Me.lb_zdv.BackColor = System.Drawing.Color.Transparent
        Me.lb_zdv.BackgroundImage = CType(resources.GetObject("lb_zdv.BackgroundImage"), System.Drawing.Image)
        Me.lb_zdv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lb_zdv.Caption = "ZDV-Gateway"
        Me.lb_zdv.LightState = LightButton.LightButton.Light.Red
        Me.lb_zdv.Location = New System.Drawing.Point(702, 12)
        Me.lb_zdv.Name = "lb_zdv"
        Me.lb_zdv.Size = New System.Drawing.Size(140, 140)
        Me.lb_zdv.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(736, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "134.93.254.5"
        '
        'lb_hbf
        '
        Me.lb_hbf.BackColor = System.Drawing.Color.Transparent
        Me.lb_hbf.BackgroundImage = CType(resources.GetObject("lb_hbf.BackgroundImage"), System.Drawing.Image)
        Me.lb_hbf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lb_hbf.Caption = "Hauptbahnhof"
        Me.lb_hbf.LightState = LightButton.LightButton.Light.Red
        Me.lb_hbf.Location = New System.Drawing.Point(932, 12)
        Me.lb_hbf.Name = "lb_hbf"
        Me.lb_hbf.Size = New System.Drawing.Size(140, 140)
        Me.lb_hbf.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(961, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "217.198.240.65"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cb_interfaces, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.ToolStripComboBox1, Me.ToolStripSeparator2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 176)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1306, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(105, 22)
        Me.ToolStripLabel1.Text = "Netzwerkinterface:"
        '
        'cb_interfaces
        '
        Me.cb_interfaces.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_interfaces.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_interfaces.Name = "cb_interfaces"
        Me.cb_interfaces.Size = New System.Drawing.Size(400, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripLabel2.Text = "Wohnheim:"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ToolStripComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ToolStripComboBox1.DropDownWidth = 121
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Gonsenheim", "Hechtsheim", "Inter 2", "K3", "Münchfeld", "Oberstadt", "Wallstrasse", "Weisenau"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Enabled = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(95, 22)
        Me.ToolStripButton1.Text = "Aktualisieren"
        '
        'lbl_ping_own
        '
        Me.lbl_ping_own.AutoSize = True
        Me.lbl_ping_own.Location = New System.Drawing.Point(113, 11)
        Me.lbl_ping_own.Name = "lbl_ping_own"
        Me.lbl_ping_own.Size = New System.Drawing.Size(16, 13)
        Me.lbl_ping_own.TabIndex = 12
        Me.lbl_ping_own.Text = "..."
        '
        'lbl_ping_inter
        '
        Me.lbl_ping_inter.AutoSize = True
        Me.lbl_ping_inter.Location = New System.Drawing.Point(343, 11)
        Me.lbl_ping_inter.Name = "lbl_ping_inter"
        Me.lbl_ping_inter.Size = New System.Drawing.Size(16, 13)
        Me.lbl_ping_inter.TabIndex = 13
        Me.lbl_ping_inter.Text = "..."
        '
        'lbl_ping_login
        '
        Me.lbl_ping_login.AutoSize = True
        Me.lbl_ping_login.Location = New System.Drawing.Point(573, 11)
        Me.lbl_ping_login.Name = "lbl_ping_login"
        Me.lbl_ping_login.Size = New System.Drawing.Size(16, 13)
        Me.lbl_ping_login.TabIndex = 14
        Me.lbl_ping_login.Text = "..."
        '
        'lbl_ping_zdv
        '
        Me.lbl_ping_zdv.AutoSize = True
        Me.lbl_ping_zdv.Location = New System.Drawing.Point(803, 11)
        Me.lbl_ping_zdv.Name = "lbl_ping_zdv"
        Me.lbl_ping_zdv.Size = New System.Drawing.Size(16, 13)
        Me.lbl_ping_zdv.TabIndex = 15
        Me.lbl_ping_zdv.Text = "..."
        '
        'lbl_ping_internet
        '
        Me.lbl_ping_internet.AutoSize = True
        Me.lbl_ping_internet.Location = New System.Drawing.Point(1263, 11)
        Me.lbl_ping_internet.Name = "lbl_ping_internet"
        Me.lbl_ping_internet.Size = New System.Drawing.Size(16, 13)
        Me.lbl_ping_internet.TabIndex = 16
        Me.lbl_ping_internet.Text = "..."
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'lbl_ping_hbf
        '
        Me.lbl_ping_hbf.AutoSize = True
        Me.lbl_ping_hbf.Location = New System.Drawing.Point(1033, 11)
        Me.lbl_ping_hbf.Name = "lbl_ping_hbf"
        Me.lbl_ping_hbf.Size = New System.Drawing.Size(16, 13)
        Me.lbl_ping_hbf.TabIndex = 19
        Me.lbl_ping_hbf.Text = "..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1212, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "8.8.8.8"
        '
        'lb_internet
        '
        Me.lb_internet.BackColor = System.Drawing.Color.Transparent
        Me.lb_internet.BackgroundImage = CType(resources.GetObject("lb_internet.BackgroundImage"), System.Drawing.Image)
        Me.lb_internet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lb_internet.Caption = "Google"
        Me.lb_internet.LightState = LightButton.LightButton.Light.Red
        Me.lb_internet.Location = New System.Drawing.Point(1162, 12)
        Me.lb_internet.Name = "lb_internet"
        Me.lb_internet.Size = New System.Drawing.Size(140, 140)
        Me.lb_internet.TabIndex = 17
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.line_hbf_internet, Me.line_zdv_hbf, Me.line_login_zdv, Me.line_inter_login, Me.line_own_inter})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1306, 201)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'line_own_inter
        '
        Me.line_own_inter.BorderColor = System.Drawing.Color.Red
        Me.line_own_inter.BorderWidth = 2
        Me.line_own_inter.Name = "line_own_inter"
        Me.line_own_inter.X1 = 134
        Me.line_own_inter.X2 = 263
        Me.line_own_inter.Y1 = 84
        Me.line_own_inter.Y2 = 84
        '
        'line_inter_login
        '
        Me.line_inter_login.BorderColor = System.Drawing.Color.Red
        Me.line_inter_login.BorderWidth = 2
        Me.line_inter_login.Name = "line_inter_login"
        Me.line_inter_login.X1 = 359
        Me.line_inter_login.X2 = 488
        Me.line_inter_login.Y1 = 84
        Me.line_inter_login.Y2 = 84
        '
        'line_login_zdv
        '
        Me.line_login_zdv.BorderColor = System.Drawing.Color.Red
        Me.line_login_zdv.BorderWidth = 2
        Me.line_login_zdv.Name = "line_login_zdv"
        Me.line_login_zdv.X1 = 590
        Me.line_login_zdv.X2 = 719
        Me.line_login_zdv.Y1 = 84
        Me.line_login_zdv.Y2 = 84
        '
        'line_zdv_hbf
        '
        Me.line_zdv_hbf.BorderColor = System.Drawing.Color.Red
        Me.line_zdv_hbf.BorderWidth = 2
        Me.line_zdv_hbf.Name = "line_zdv_hbf"
        Me.line_zdv_hbf.X1 = 820
        Me.line_zdv_hbf.X2 = 949
        Me.line_zdv_hbf.Y1 = 84
        Me.line_zdv_hbf.Y2 = 84
        '
        'line_hbf_internet
        '
        Me.line_hbf_internet.BorderColor = System.Drawing.Color.Red
        Me.line_hbf_internet.BorderWidth = 2
        Me.line_hbf_internet.Name = "line_hbf_internet"
        Me.line_hbf_internet.X1 = 1053
        Me.line_hbf_internet.X2 = 1182
        Me.line_hbf_internet.Y1 = 84
        Me.line_hbf_internet.Y2 = 84
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1306, 201)
        Me.Controls.Add(Me.lbl_ping_hbf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_ping_internet)
        Me.Controls.Add(Me.lbl_ping_zdv)
        Me.Controls.Add(Me.lbl_ping_login)
        Me.Controls.Add(Me.lbl_ping_inter)
        Me.Controls.Add(Me.lbl_ping_own)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_own)
        Me.Controls.Add(Me.lb_ownrouter)
        Me.Controls.Add(Me.lb_login)
        Me.Controls.Add(Me.lb_inter_ii)
        Me.Controls.Add(Me.lb_hbf)
        Me.Controls.Add(Me.lb_zdv)
        Me.Controls.Add(Me.lb_internet)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Netzwerküberwachung"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_ownrouter As LightButton.LightButton
    Friend WithEvents lb_inter_ii As LightButton.LightButton
    Friend WithEvents lbl_own As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_login As LightButton.LightButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lb_zdv As LightButton.LightButton
    Friend WithEvents Label4 As Label
    Friend WithEvents lb_hbf As LightButton.LightButton
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cb_interfaces As ToolStripComboBox
    Friend WithEvents lbl_ping_own As Label
    Friend WithEvents lbl_ping_inter As Label
    Friend WithEvents lbl_ping_login As Label
    Friend WithEvents lbl_ping_zdv As Label
    Friend WithEvents lbl_ping_internet As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Public WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbl_ping_hbf As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lb_internet As LightButton.LightButton
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents line_hbf_internet As PowerPacks.LineShape
    Friend WithEvents line_zdv_hbf As PowerPacks.LineShape
    Friend WithEvents line_login_zdv As PowerPacks.LineShape
    Friend WithEvents line_inter_login As PowerPacks.LineShape
    Friend WithEvents line_own_inter As PowerPacks.LineShape
End Class

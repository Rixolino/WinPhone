<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IE
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(4, 68)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(327, 441)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://www.google.com", System.UriKind.Absolute)
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Location = New System.Drawing.Point(1, 510)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(345, 47)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(243, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Home"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WinPhone.My.Resources.Resources.refresh
        Me.PictureBox4.Location = New System.Drawing.Point(288, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WinPhone.My.Resources.Resources.next12
        Me.PictureBox3.Location = New System.Drawing.Point(196, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(41, 41)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WinPhone.My.Resources.Resources.back1
        Me.PictureBox2.Location = New System.Drawing.Point(4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"www.google.com", "www.facebook.com", "www.youtube.com", "www.betawiki.net"})
        Me.ComboBox1.Location = New System.Drawing.Point(53, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(142, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.PictureBox6)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(1, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(654, 37)
        Me.Panel3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(101, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Internet Explorer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Label5"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.WinPhone.My.Resources.Resources.network
        Me.PictureBox6.Location = New System.Drawing.Point(251, 7)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(34, 30)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 7
        Me.PictureBox6.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(291, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(43, 16)
        Me.Panel4.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "100%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(135, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label4"
        '
        'Timer1
        '
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(-21, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(357, 37)
        Me.Panel5.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(143, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 26)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Microsoft"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(1, 565)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(342, 37)
        Me.Panel1.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.Image = Global.WinPhone.My.Resources.Resources.Back
        Me.Button3.Location = New System.Drawing.Point(33, -2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 36)
        Me.Button3.TabIndex = 8
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WinPhone.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(140, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Image = Global.WinPhone.My.Resources.Resources.search1
        Me.Button4.Location = New System.Drawing.Point(262, -2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 36)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = True
        '
        'IE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 598)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "IE"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Phone X - Use your keyboard for typing "
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
End Class

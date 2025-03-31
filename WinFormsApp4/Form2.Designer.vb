<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

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
        Panel2 = New Panel()
        pnloneway = New Panel()
        Panel3 = New Panel()
        Label7 = New Label()
        Label1 = New Label()
        ListBox1 = New ListBox()
        Label2 = New Label()
        MonthCalendar1 = New MonthCalendar()
        TextBox1 = New TextBox()
        Button3 = New Button()
        Label3 = New Label()
        btnoneway = New Button()
        btnround = New Button()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button4 = New Button()
        ListBox3 = New ListBox()
        Label8 = New Label()
        Label9 = New Label()
        Panel1 = New Panel()
        MonthCalendar3 = New MonthCalendar()
        Label10 = New Label()
        TextBox3 = New TextBox()
        Button5 = New Button()
        pnloneway.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources._483714944_640446962074246_1644431219488145765_n
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Location = New Point(177, 1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(624, 451)
        Panel2.TabIndex = 1
        ' 
        ' pnloneway
        ' 
        pnloneway.BackColor = Color.LavenderBlush
        pnloneway.Controls.Add(Panel3)
        pnloneway.Controls.Add(Label1)
        pnloneway.Controls.Add(ListBox1)
        pnloneway.Controls.Add(Label2)
        pnloneway.Controls.Add(MonthCalendar1)
        pnloneway.Controls.Add(TextBox1)
        pnloneway.Controls.Add(Button3)
        pnloneway.Controls.Add(Label3)
        pnloneway.Location = New Point(187, 11)
        pnloneway.Name = "pnloneway"
        pnloneway.Size = New Size(611, 437)
        pnloneway.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightPink
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(18, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(565, 423)
        Panel3.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Sylfaen", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(3, 111)
        Label7.Name = "Label7"
        Label7.Size = New Size(513, 201)
        Label7.TabIndex = 0
        Label7.Text = "Lomilo Airline at your service!   Please proceed on choosing a ticket" & vbCrLf
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(27, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 20)
        Label1.TabIndex = 1
        Label1.Text = "Destinations and Prices"
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = SystemColors.ScrollBar
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"Boracay Island.....................P2,476", "Palawan................................P1,701", "Cebu.....................................P1,735", "El Nido..................................P6,907", "Coron....................................P3,494"})
        ListBox1.Location = New Point(27, 77)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(191, 94)
        ListBox1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold)
        Label2.Location = New Point(343, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 20)
        Label2.TabIndex = 3
        Label2.Text = "Choose A Date"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.BackColor = SystemColors.ScrollBar
        MonthCalendar1.ForeColor = SystemColors.InfoText
        MonthCalendar1.Location = New Point(290, 77)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 2
        MonthCalendar1.TitleBackColor = Color.Red
        MonthCalendar1.TrailingForeColor = SystemColors.ButtonShadow
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ScrollBar
        TextBox1.Location = New Point(27, 282)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(191, 117)
        TextBox1.TabIndex = 4
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Plum
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(331, 325)
        Button3.Name = "Button3"
        Button3.Size = New Size(162, 53)
        Button3.TabIndex = 6
        Button3.Text = "Click to confirm your reservation"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(27, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(195, 67)
        Label3.TabIndex = 5
        Label3.Text = "Enter your chosen destination as well as your preferred date:"
        ' 
        ' btnoneway
        ' 
        btnoneway.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnoneway.Location = New Point(22, 226)
        btnoneway.Name = "btnoneway"
        btnoneway.Size = New Size(149, 33)
        btnoneway.TabIndex = 0
        btnoneway.Text = "One way ticket"
        btnoneway.UseVisualStyleBackColor = True
        ' 
        ' btnround
        ' 
        btnround.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnround.Location = New Point(20, 313)
        btnround.Name = "btnround"
        btnround.Size = New Size(161, 34)
        btnround.TabIndex = 1
        btnround.Text = "Round-trip Ticket"
        btnround.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.air_removebg_preview__1_
        PictureBox1.Location = New Point(47, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 88)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.Location = New Point(58, 154)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 27)
        Button1.TabIndex = 4
        Button1.Text = "Menu"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button4.Location = New Point(58, 377)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 33)
        Button4.TabIndex = 5
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' ListBox3
        ' 
        ListBox3.BackColor = SystemColors.ScrollBar
        ListBox3.FormattingEnabled = True
        ListBox3.ItemHeight = 15
        ListBox3.Items.AddRange(New Object() {"Boracay Island.....................P2,876", "Palawan................................P2,413", "Cebu.....................................P2,785", "El Nido..................................P8,298", "Coron....................................P5,434"})
        ListBox3.Location = New Point(250, 102)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(191, 94)
        ListBox3.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(256, 69)
        Label8.Name = "Label8"
        Label8.Size = New Size(185, 20)
        Label8.TabIndex = 7
        Label8.Text = "Destinations and Prices"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold)
        Label9.Location = New Point(589, 40)
        Label9.Name = "Label9"
        Label9.Size = New Size(121, 20)
        Label9.TabIndex = 8
        Label9.Text = "Choose A Date"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Pink
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnround)
        Panel1.Controls.Add(btnoneway)
        Panel1.Controls.Add(pnloneway)
        Panel1.Controls.Add(MonthCalendar3)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(ListBox3)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Button5)
        Panel1.Location = New Point(-10, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(181, 451)
        Panel1.TabIndex = 0
        ' 
        ' MonthCalendar3
        ' 
        MonthCalendar3.BackColor = SystemColors.ScrollBar
        MonthCalendar3.ForeColor = SystemColors.InfoText
        MonthCalendar3.Location = New Point(538, 69)
        MonthCalendar3.Name = "MonthCalendar3"
        MonthCalendar3.TabIndex = 9
        MonthCalendar3.TitleBackColor = Color.Red
        MonthCalendar3.TrailingForeColor = SystemColors.ButtonShadow
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(250, 233)
        Label10.Name = "Label10"
        Label10.Size = New Size(195, 67)
        Label10.TabIndex = 10
        Label10.Text = "Enter your chosen destination as well as your preferred date:"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ScrollBar
        TextBox3.Location = New Point(256, 303)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(191, 117)
        TextBox3.TabIndex = 11
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Plum
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(603, 357)
        Button5.Name = "Button5"
        Button5.Size = New Size(162, 53)
        Button5.TabIndex = 12
        Button5.Text = "Click to confirm your reservation"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "Form2"
        Text = "Form2"
        pnloneway.ResumeLayout(False)
        pnloneway.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnloneway As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnoneway As Button
    Friend WithEvents btnround As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonthCalendar3 As MonthCalendar
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button5 As Button
End Class

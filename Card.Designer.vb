<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Card
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        RichTextBox1 = New RichTextBox()
        TextBox4 = New TextBox()
        DropDownButton1 = New DevExpress.XtraEditors.DropDownButton()
        PopupMenu1 = New DevExpress.XtraBars.PopupMenu(components)
        BarManager1 = New DevExpress.XtraBars.BarManager(components)
        barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        BarListItem1 = New DevExpress.XtraBars.BarListItem()
        BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        CType(PopupMenu1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BarManager1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(131, 13)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(209, 20)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(13, 13)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(112, 20)
        TextBox2.TabIndex = 1
        TextBox2.Text = "Title"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(13, 39)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(112, 20)
        TextBox3.TabIndex = 3
        TextBox3.Text = "Description"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(131, 39)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(209, 89)
        RichTextBox1.TabIndex = 4
        RichTextBox1.Text = ""
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(13, 130)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(112, 20)
        TextBox4.TabIndex = 5
        TextBox4.Text = "Deck"
        ' 
        ' DropDownButton1
        ' 
        DropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show
        DropDownButton1.Location = New Point(131, 130)
        DropDownButton1.Name = "DropDownButton1"
        DropDownButton1.Size = New Size(209, 20)
        DropDownButton1.TabIndex = 6
        DropDownButton1.Text = "DropDownButton1"
        ' 
        ' PopupMenu1
        ' 
        PopupMenu1.Manager = BarManager1
        PopupMenu1.Name = "PopupMenu1"
        ' 
        ' BarManager1
        ' 
        BarManager1.DockControls.Add(barDockControlTop)
        BarManager1.DockControls.Add(barDockControlBottom)
        BarManager1.DockControls.Add(barDockControlLeft)
        BarManager1.DockControls.Add(barDockControlRight)
        BarManager1.Form = Me
        BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {BarListItem1, BarButtonItem1})
        BarManager1.MaxItemId = 2
        ' 
        ' barDockControlTop
        ' 
        barDockControlTop.CausesValidation = False
        barDockControlTop.Dock = DockStyle.Top
        barDockControlTop.Location = New Point(0, 0)
        barDockControlTop.Manager = BarManager1
        barDockControlTop.Size = New Size(1223, 0)
        ' 
        ' barDockControlBottom
        ' 
        barDockControlBottom.CausesValidation = False
        barDockControlBottom.Dock = DockStyle.Bottom
        barDockControlBottom.Location = New Point(0, 226)
        barDockControlBottom.Manager = BarManager1
        barDockControlBottom.Size = New Size(1223, 0)
        ' 
        ' barDockControlLeft
        ' 
        barDockControlLeft.CausesValidation = False
        barDockControlLeft.Dock = DockStyle.Left
        barDockControlLeft.Location = New Point(0, 0)
        barDockControlLeft.Manager = BarManager1
        barDockControlLeft.Size = New Size(0, 226)
        ' 
        ' barDockControlRight
        ' 
        barDockControlRight.CausesValidation = False
        barDockControlRight.Dock = DockStyle.Right
        barDockControlRight.Location = New Point(1223, 0)
        barDockControlRight.Manager = BarManager1
        barDockControlRight.Size = New Size(0, 226)
        ' 
        ' BarListItem1
        ' 
        BarListItem1.Caption = "BarListItem1"
        BarListItem1.Id = 0
        BarListItem1.Name = "BarListItem1"
        ' 
        ' BarButtonItem1
        ' 
        BarButtonItem1.Caption = "BarButtonItem1"
        BarButtonItem1.Id = 1
        BarButtonItem1.Name = "BarButtonItem1"
        ' 
        ' Card
        ' 
        AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DropDownButton1)
        Controls.Add(TextBox4)
        Controls.Add(RichTextBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(barDockControlLeft)
        Controls.Add(barDockControlRight)
        Controls.Add(barDockControlBottom)
        Controls.Add(barDockControlTop)
        Name = "Card"
        Size = New Size(1223, 226)
        CType(PopupMenu1, ComponentModel.ISupportInitialize).EndInit()
        CType(BarManager1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DropDownButton1 As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarListItem1 As DevExpress.XtraBars.BarListItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Public WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu

End Class

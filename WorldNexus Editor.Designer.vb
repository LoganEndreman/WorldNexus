Partial Public Class WorldNexusEditor
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorldNexusEditor))
        ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        BackstageViewControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
        BackstageViewButtonItem2 = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
        BackstageViewButtonItem1 = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
        SkinDropDownButtonItem1 = New DevExpress.XtraBars.SkinDropDownButtonItem()
        BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        RibbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(components)
        StackPanel1 = New DevExpress.Utils.Layout.StackPanel()
        BarManager1 = New DevExpress.XtraBars.BarManager(components)
        barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        BarListItem1 = New DevExpress.XtraBars.BarListItem()
        BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        CType(ribbonControl1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BackstageViewControl1, ComponentModel.ISupportInitialize).BeginInit()
        CType(StackPanel1, ComponentModel.ISupportInitialize).BeginInit()
        StackPanel1.SuspendLayout()
        CType(BarManager1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ribbonControl1
        ' 
        ribbonControl1.ApplicationButtonDropDownControl = BackstageViewControl1
        ribbonControl1.ExpandCollapseItem.Id = 0
        ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {ribbonControl1.ExpandCollapseItem, SkinDropDownButtonItem1, BarButtonItem1, BarButtonItem2, BarButtonItem3, BarButtonItem4})
        ribbonControl1.Location = New Point(0, 0)
        ribbonControl1.MaxItemId = 8
        ribbonControl1.Name = "ribbonControl1"
        ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {RibbonPageCategory1})
        ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {ribbonPage1})
        ribbonControl1.QuickToolbarItemLinks.Add(SkinDropDownButtonItem1)
        ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        ribbonControl1.Size = New Size(1167, 145)
        ' 
        ' BackstageViewControl1
        ' 
        BackstageViewControl1.Items.Add(BackstageViewButtonItem2)
        BackstageViewControl1.Items.Add(BackstageViewButtonItem1)
        BackstageViewControl1.Location = New Point(318, 12)
        BackstageViewControl1.Name = "BackstageViewControl1"
        BackstageViewControl1.OwnerControl = ribbonControl1
        BackstageViewControl1.Size = New Size(480, 258)
        BackstageViewControl1.TabIndex = 1
        ' 
        ' BackstageViewButtonItem2
        ' 
        BackstageViewButtonItem2.Caption = "Open"
        BackstageViewButtonItem2.ImageOptions.ItemNormal.SvgImage = CType(resources.GetObject("BackstageViewButtonItem2.ImageOptions.ItemNormal.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        BackstageViewButtonItem2.Name = "BackstageViewButtonItem2"
        ' 
        ' BackstageViewButtonItem1
        ' 
        BackstageViewButtonItem1.Caption = "Save"
        BackstageViewButtonItem1.ImageOptions.ItemNormal.SvgImage = CType(resources.GetObject("BackstageViewButtonItem1.ImageOptions.ItemNormal.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        BackstageViewButtonItem1.Name = "BackstageViewButtonItem1"
        ' 
        ' SkinDropDownButtonItem1
        ' 
        SkinDropDownButtonItem1.ActAsDropDown = True
        SkinDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        SkinDropDownButtonItem1.Hint = "Don't want it to look like Win7?"
        SkinDropDownButtonItem1.Id = 2
        SkinDropDownButtonItem1.Name = "SkinDropDownButtonItem1"
        SkinDropDownButtonItem1.RememberLastCommand = True
        ' 
        ' BarButtonItem1
        ' 
        BarButtonItem1.Caption = "Create a Card"
        BarButtonItem1.Hint = "This creates a card."
        BarButtonItem1.Id = 1
        BarButtonItem1.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        BarButtonItem1.Name = "BarButtonItem1"
        ' 
        ' BarButtonItem2
        ' 
        BarButtonItem2.Caption = "Remove Card"
        BarButtonItem2.Enabled = False
        BarButtonItem2.Id = 3
        BarButtonItem2.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        BarButtonItem2.Name = "BarButtonItem2"
        ' 
        ' BarButtonItem3
        ' 
        BarButtonItem3.Caption = "Create a Deck"
        BarButtonItem3.Id = 6
        BarButtonItem3.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        BarButtonItem3.Name = "BarButtonItem3"
        ' 
        ' BarButtonItem4
        ' 
        BarButtonItem4.Caption = "Remove a Deck"
        BarButtonItem4.Enabled = False
        BarButtonItem4.Id = 7
        BarButtonItem4.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        BarButtonItem4.Name = "BarButtonItem4"
        ' 
        ' RibbonPageCategory1
        ' 
        RibbonPageCategory1.Name = "RibbonPageCategory1"
        RibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {RibbonPage3, RibbonPage2})
        RibbonPageCategory1.Text = "Branches and Success"
        RibbonPageCategory1.Visible = False
        ' 
        ' RibbonPage3
        ' 
        RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {RibbonPageGroup3})
        RibbonPage3.Name = "RibbonPage3"
        RibbonPage3.Text = "Branches"
        RibbonPage3.Visible = False
        ' 
        ' RibbonPageGroup3
        ' 
        RibbonPageGroup3.Name = "RibbonPageGroup3"
        RibbonPageGroup3.Text = "RibbonPageGroup3"
        ' 
        ' RibbonPage2
        ' 
        RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {RibbonPageGroup2})
        RibbonPage2.Name = "RibbonPage2"
        RibbonPage2.Text = "Diffiuclty"
        RibbonPage2.Visible = False
        ' 
        ' RibbonPageGroup2
        ' 
        RibbonPageGroup2.Name = "RibbonPageGroup2"
        RibbonPageGroup2.Text = "RibbonPageGroup2"
        ' 
        ' ribbonPage1
        ' 
        ribbonPage1.Appearance.Font = New Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ribbonPage1.Appearance.Options.UseFont = True
        ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {ribbonPageGroup1, RibbonPageGroup4})
        ribbonPage1.Name = "ribbonPage1"
        ribbonPage1.Text = "Cards and Decks"
        ' 
        ' ribbonPageGroup1
        ' 
        ribbonPageGroup1.ItemLinks.Add(BarButtonItem1)
        ribbonPageGroup1.ItemLinks.Add(BarButtonItem2)
        ribbonPageGroup1.Name = "ribbonPageGroup1"
        ribbonPageGroup1.Text = "Cards"
        ' 
        ' RibbonPageGroup4
        ' 
        RibbonPageGroup4.ItemLinks.Add(BarButtonItem3)
        RibbonPageGroup4.ItemLinks.Add(BarButtonItem4)
        RibbonPageGroup4.Name = "RibbonPageGroup4"
        RibbonPageGroup4.Text = "Decks"
        ' 
        ' XtraOpenFileDialog1
        ' 
        XtraOpenFileDialog1.Title = "Open TXT Story"
        ' 
        ' StackPanel1
        ' 
        StackPanel1.Controls.Add(BackstageViewControl1)
        StackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown
        StackPanel1.Location = New Point(26, 169)
        StackPanel1.Name = "StackPanel1"
        StackPanel1.Size = New Size(1117, 354)
        StackPanel1.TabIndex = 3
        StackPanel1.UseSkinIndents = True
        ' 
        ' BarManager1
        ' 
        BarManager1.DockControls.Add(barDockControlTop)
        BarManager1.DockControls.Add(barDockControlBottom)
        BarManager1.DockControls.Add(barDockControlLeft)
        BarManager1.DockControls.Add(barDockControlRight)
        BarManager1.Form = Me
        BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {BarListItem1, BarButtonItem5})
        BarManager1.MaxItemId = 2
        ' 
        ' barDockControlTop
        ' 
        barDockControlTop.CausesValidation = False
        barDockControlTop.Dock = DockStyle.Top
        barDockControlTop.Location = New Point(0, 0)
        barDockControlTop.Manager = BarManager1
        barDockControlTop.Size = New Size(1167, 0)
        ' 
        ' barDockControlBottom
        ' 
        barDockControlBottom.CausesValidation = False
        barDockControlBottom.Dock = DockStyle.Bottom
        barDockControlBottom.Location = New Point(0, 560)
        barDockControlBottom.Manager = BarManager1
        barDockControlBottom.Size = New Size(1167, 0)
        ' 
        ' barDockControlLeft
        ' 
        barDockControlLeft.CausesValidation = False
        barDockControlLeft.Dock = DockStyle.Left
        barDockControlLeft.Location = New Point(0, 0)
        barDockControlLeft.Manager = BarManager1
        barDockControlLeft.Size = New Size(0, 560)
        ' 
        ' barDockControlRight
        ' 
        barDockControlRight.CausesValidation = False
        barDockControlRight.Dock = DockStyle.Right
        barDockControlRight.Location = New Point(1167, 0)
        barDockControlRight.Manager = BarManager1
        barDockControlRight.Size = New Size(0, 560)
        ' 
        ' BarListItem1
        ' 
        BarListItem1.Caption = "BarListItem1"
        BarListItem1.Id = 0
        BarListItem1.Name = "BarListItem1"
        ' 
        ' BarButtonItem5
        ' 
        BarButtonItem5.Caption = "BarButtonItem1"
        BarButtonItem5.Id = 1
        BarButtonItem5.Name = "BarButtonItem5"
        ' 
        ' WorldNexusEditor
        ' 
        Appearance.Options.UseFont = True
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1167, 560)
        Controls.Add(StackPanel1)
        Controls.Add(ribbonControl1)
        Controls.Add(barDockControlLeft)
        Controls.Add(barDockControlRight)
        Controls.Add(barDockControlBottom)
        Controls.Add(barDockControlTop)
        Font = New Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "WorldNexusEditor"
        Ribbon = ribbonControl1
        Text = "WorldNexus Editor"
        CType(ribbonControl1, ComponentModel.ISupportInitialize).EndInit()
        CType(BackstageViewControl1, ComponentModel.ISupportInitialize).EndInit()
        CType(StackPanel1, ComponentModel.ISupportInitialize).EndInit()
        StackPanel1.ResumeLayout(False)
        CType(BarManager1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BackstageViewControl1 As DevExpress.XtraBars.Ribbon.BackstageViewControl
    Friend WithEvents SkinDropDownButtonItem1 As DevExpress.XtraBars.SkinDropDownButtonItem
    Friend WithEvents RibbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents BackstageViewButtonItem1 As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
    Friend WithEvents BackstageViewButtonItem2 As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
    Friend WithEvents StackPanel1 As DevExpress.Utils.Layout.StackPanel
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarListItem1 As DevExpress.XtraBars.BarListItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem

End Class

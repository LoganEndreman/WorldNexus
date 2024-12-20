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
        RibbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(components)
        StackPanel1 = New DevExpress.Utils.Layout.StackPanel()
        PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(ribbonControl1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BackstageViewControl1, ComponentModel.ISupportInitialize).BeginInit()
        CType(StackPanel1, ComponentModel.ISupportInitialize).BeginInit()
        StackPanel1.SuspendLayout()
        CType(PanelControl1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ribbonControl1
        ' 
        ribbonControl1.ApplicationButtonDropDownControl = BackstageViewControl1
        ribbonControl1.CaptionBarItemLinks.Add(SkinDropDownButtonItem1)
        ribbonControl1.ExpandCollapseItem.Id = 0
        ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {SkinDropDownButtonItem1, ribbonControl1.ExpandCollapseItem, BarButtonItem1})
        ribbonControl1.Location = New Point(0, 0)
        ribbonControl1.MaxItemId = 3
        ribbonControl1.Name = "ribbonControl1"
        ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {RibbonPageCategory1})
        ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {ribbonPage1})
        ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        ribbonControl1.Size = New Size(1125, 145)
        ' 
        ' BackstageViewControl1
        ' 
        BackstageViewControl1.Items.Add(BackstageViewButtonItem2)
        BackstageViewControl1.Items.Add(BackstageViewButtonItem1)
        BackstageViewControl1.Location = New Point(859, 309)
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
        BarButtonItem1.ItemAppearance.Normal.Font = New Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        BarButtonItem1.Name = "BarButtonItem1"
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
        ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {ribbonPageGroup1})
        ribbonPage1.Name = "ribbonPage1"
        ribbonPage1.Text = "Cards and Decks"
        ' 
        ' ribbonPageGroup1
        ' 
        ribbonPageGroup1.ItemLinks.Add(BarButtonItem1)
        ribbonPageGroup1.Name = "ribbonPageGroup1"
        ribbonPageGroup1.Text = "Cards"
        ' 
        ' XtraOpenFileDialog1
        ' 
        XtraOpenFileDialog1.Title = "Open TXT Story"
        ' 
        ' StackPanel1
        ' 
        StackPanel1.Controls.Add(PanelControl1)
        StackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown
        StackPanel1.Location = New Point(22, 207)
        StackPanel1.Name = "StackPanel1"
        StackPanel1.Size = New Size(1117, 354)
        StackPanel1.TabIndex = 3
        StackPanel1.UseSkinIndents = True
        ' 
        ' PanelControl1
        ' 
        PanelControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        PanelControl1.Location = New Point(13, 12)
        PanelControl1.Name = "PanelControl1"
        PanelControl1.Size = New Size(1090, 199)
        PanelControl1.TabIndex = 0
        PanelControl1.Visible = False
        ' 
        ' WorldNexusEditor
        ' 
        Appearance.Options.UseFont = True
        AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1125, 516)
        Controls.Add(StackPanel1)
        Controls.Add(BackstageViewControl1)
        Controls.Add(ribbonControl1)
        Font = New Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "WorldNexusEditor"
        Ribbon = ribbonControl1
        Text = "WorldNexus Editor"
        CType(ribbonControl1, ComponentModel.ISupportInitialize).EndInit()
        CType(BackstageViewControl1, ComponentModel.ISupportInitialize).EndInit()
        CType(StackPanel1, ComponentModel.ISupportInitialize).EndInit()
        StackPanel1.ResumeLayout(False)
        CType(PanelControl1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl

End Class

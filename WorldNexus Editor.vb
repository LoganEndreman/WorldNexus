Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

Partial Public Class WorldNexusEditor
    Private Test As Card
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub ribbonControl1_Click(sender As Object, e As EventArgs) Handles ribbonControl1.Click

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Test = New Card()
        ' Add the Card control to a container, e.g., a Panel
        StackPanel1.Controls.Add(Test)
        Test.Location = New Point(10, 10)
        Test.Size = New Size(200, 100)
    End Sub

    Private Sub BackstageViewControl1_Click(sender As Object, e As EventArgs) Handles BackstageViewControl1.Click

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub BackstageViewButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs) Handles BackstageViewButtonItem1.ItemClick

    End Sub

    Private Sub BackstageViewButtonItem2_ItemClick(sender As Object, e As BackstageViewItemEventArgs) Handles BackstageViewButtonItem2.ItemClick
        XtraOpenFileDialog1.ShowDialog()
    End Sub

    Private Sub StackPanel1_Paint(sender As Object, e As PaintEventArgs) Handles StackPanel1.Paint

    End Sub

    Private Sub XtraOpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs)

    End Sub

End Class

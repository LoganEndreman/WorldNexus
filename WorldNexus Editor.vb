Imports System.ComponentModel
Imports System.Text
Imports System.Text.Json
Imports System.IO
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
        Dim dialog As New DevExpress.XtraEditors.XtraSaveFileDialog()
        dialog.Filter = "Story World (*.storyworld)|*.storyworld"
        If dialog.ShowDialog() = DialogResult.OK Then
            SaveCards(dialog.FileName)
        End If
    End Sub

    Private Sub BackstageViewButtonItem2_ItemClick(sender As Object, e As BackstageViewItemEventArgs) Handles BackstageViewButtonItem2.ItemClick
        XtraOpenFileDialog1.ShowDialog()
    End Sub

    Private Sub StackPanel1_Paint(sender As Object, e As PaintEventArgs) Handles StackPanel1.Paint

    End Sub

    Private Sub XtraOpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
        LoadCards(XtraOpenFileDialog1.FileName)
    End Sub

    Private Sub SaveCards(path As String)
        Dim list As New List(Of CardData)()
        For Each ctrl As Control In StackPanel1.Controls
            If TypeOf ctrl Is Card Then
                Dim c As Card = CType(ctrl, Card)
                list.Add(c.ToCardData())
            End If
        Next
        Dim json As String = JsonSerializer.Serialize(list, New JsonSerializerOptions With {.WriteIndented = True})
        File.WriteAllText(path, json)
    End Sub

    Private Sub LoadCards(path As String)
        If Not File.Exists(path) Then Return
        Dim json As String = File.ReadAllText(path)
        Dim list As List(Of CardData) = JsonSerializer.Deserialize(Of List(Of CardData))(json)
        If list Is Nothing Then Return
        Dim toRemove = New List(Of Control)()
        For Each ctrl As Control In StackPanel1.Controls
            If TypeOf ctrl Is Card Then
                toRemove.Add(ctrl)
            End If
        Next
        For Each ctrl As Control In toRemove
            StackPanel1.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next
        For Each data As CardData In list
            Dim c As New Card()
            c.FromCardData(data)
            StackPanel1.Controls.Add(c)
            c.Location = New Point(10, 10)
            c.Size = New Size(200, 100)
        Next
    End Sub

End Class

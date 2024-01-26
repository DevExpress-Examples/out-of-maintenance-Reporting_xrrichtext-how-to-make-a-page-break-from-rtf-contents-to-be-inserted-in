Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraReports.UI

Namespace WindowsFormsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim server As RichEditDocumentServer = New RichEditDocumentServer()
            server.LoadDocument("fish.rtf")
            Dim ranges As DocumentRange() = server.Document.FindAll(DevExpress.Office.Characters.PageBreak.ToString(), SearchOptions.None)
            Dim dp As DocumentPosition = server.Document.Paragraphs(0).Range.Start
            Dim collection As List(Of MyRtfObject) = New List(Of MyRtfObject)()
            For Each dr As DocumentRange In ranges
                Dim tmpRange As DocumentRange = server.Document.CreateRange(dp, dr.Start.ToInt() - dp.ToInt())
                collection.Add(New MyRtfObject() With {.RtfSplitContent = server.Document.GetRtfText(tmpRange)})
                dp = dr.End
            Next

            Dim tmpRange2 As DocumentRange = server.Document.CreateRange(dp, server.Document.Paragraphs(server.Document.Paragraphs.Count - 1).Range.End.ToInt() - dp.ToInt())
            collection.Add(New MyRtfObject() With {.RtfSplitContent = server.Document.GetRtfText(tmpRange2)})
            Dim report As XtraReport1 = New XtraReport1()
            report.DataSource = collection
            report.ShowPreviewDialog()
        End Sub
    End Class

    Public Class MyRtfObject

        Public Property RtfSplitContent As String
    End Class
End Namespace

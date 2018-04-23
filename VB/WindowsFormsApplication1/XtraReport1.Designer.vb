Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
	Partial Public Class XtraReport1
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
			Me.xrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrRichText1, Me.xrPageBreak1})
			Me.Detail.HeightF = 24.99999F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPageBreak1
			' 
			Me.xrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 22.99999F)
			Me.xrPageBreak1.Name = "xrPageBreak1"
			' 
			' xrRichText1
			' 
			Me.xrRichText1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Rtf", Nothing, "RtfSplitContent")})
			Me.xrRichText1.Font = New System.Drawing.Font("Times New Roman", 9.75F)
			Me.xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrRichText1.Name = "xrRichText1"
			Me.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString")
			Me.xrRichText1.SizeF = New System.Drawing.SizeF(650F, 23F)
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataSource = GetType(WindowsFormsApplication1.MyRtfObject)
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
			Me.DataSource = Me.bindingSource1
			Me.Version = "13.1"
			CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrRichText1 As DevExpress.XtraReports.UI.XRRichText
		Private xrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
		Private bindingSource1 As System.Windows.Forms.BindingSource
	End Class
End Namespace

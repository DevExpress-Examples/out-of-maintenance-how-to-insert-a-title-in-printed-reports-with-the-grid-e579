Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace PrintGridTitle
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem
		Private WithEvents printableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
			Me.printableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.printableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(408, 258)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' printingSystem1
			' 
			Me.printingSystem1.Links.AddRange(New Object() { Me.printableComponentLink1})
			' 
			' printableComponentLink1
			' 
			Me.printableComponentLink1.Component = Me.gridControl1
			' 
			' 
			' 
			Me.printableComponentLink1.ImageCollection.ImageStream = (CType(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.printableComponentLink1.PrintingSystem = Me.printingSystem1
			Me.printableComponentLink1.PrintingSystemBase = Me.printingSystem1
'			Me.printableComponentLink1.CreateReportHeaderArea += New DevExpress.XtraPrinting.CreateAreaEventHandler(Me.printableComponentLink1_CreateReportHeaderArea);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(272, 8)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(120, 20)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Print Preview"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(408, 258)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "How to insert a title in printed reports with the grid"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.printableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim TempXViewsPrinting As DevExpress.XtraGrid.Design.XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			printableComponentLink1.CreateDocument()
			printableComponentLink1.ShowPreview()
		End Sub

		Private Sub printableComponentLink1_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles printableComponentLink1.CreateReportHeaderArea
			Dim brick As DevExpress.XtraPrinting.TextBrick
			brick = e.Graph.DrawString("My Report", Color.Navy, New RectangleF(0, 0, 500, 40), DevExpress.XtraPrinting.BorderSide.None)
			brick.Font = New Font("Tahoma", 16)
			brick.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
		End Sub
	End Class
End Namespace

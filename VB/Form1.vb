Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace PrintGridTitle

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits Form

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem

        Private printableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

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
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
            components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            gridControl1 = New DevExpress.XtraGrid.GridControl()
            gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(components)
            printableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(components)
            simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            CType(gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(printingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(printableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            gridControl1.Dock = DockStyle.Fill
            gridControl1.Location = New System.Drawing.Point(0, 0)
            gridControl1.MainView = gridView1
            gridControl1.Name = "gridControl1"
            gridControl1.Size = New System.Drawing.Size(408, 258)
            gridControl1.TabIndex = 0
            gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {gridView1})
            ' 
            ' gridView1
            ' 
            gridView1.GridControl = gridControl1
            gridView1.Name = "gridView1"
            ' 
            ' printingSystem1
            ' 
            printingSystem1.Links.AddRange(New Object() {printableComponentLink1})
            ' 
            ' printableComponentLink1
            ' 
            printableComponentLink1.Component = gridControl1
            ' 
            ' 
            ' 
            printableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            printableComponentLink1.PrintingSystem = printingSystem1
            printableComponentLink1.PrintingSystemBase = printingSystem1
            AddHandler printableComponentLink1.CreateReportHeaderArea, New DevExpress.XtraPrinting.CreateAreaEventHandler(AddressOf printableComponentLink1_CreateReportHeaderArea)
            ' 
            ' simpleButton1
            ' 
            simpleButton1.Location = New System.Drawing.Point(272, 8)
            simpleButton1.Name = "simpleButton1"
            simpleButton1.Size = New System.Drawing.Size(120, 20)
            simpleButton1.TabIndex = 1
            simpleButton1.Text = "Print Preview"
            AddHandler simpleButton1.Click, New EventHandler(AddressOf simpleButton1_Click)
            ' 
            ' Form1
            ' 
            AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            ClientSize = New System.Drawing.Size(408, 258)
            Me.Controls.Add(simpleButton1)
            Me.Controls.Add(gridControl1)
            Name = "Form1"
            Text = "How to insert a title in printed reports with the grid"
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            CType(gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(printingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(printableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            Call Application.Run(New Form1())
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim tmp_XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            printableComponentLink1.CreateDocument()
            printableComponentLink1.ShowPreview()
        End Sub

        Private Sub printableComponentLink1_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs)
            Dim brick As DevExpress.XtraPrinting.TextBrick
            brick = e.Graph.DrawString("My Report", Color.Navy, New RectangleF(0, 0, 500, 40), DevExpress.XtraPrinting.BorderSide.None)
            brick.Font = New Font("Tahoma", 16)
            brick.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
        End Sub
    End Class
End Namespace

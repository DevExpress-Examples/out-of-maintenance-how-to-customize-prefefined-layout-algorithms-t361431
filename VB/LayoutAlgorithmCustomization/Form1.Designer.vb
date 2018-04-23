Namespace LayoutAlgorithmCustomization
    Partial Public Class Form1
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
            Dim treeMapPaletteColorizer1 As New DevExpress.XtraTreeMap.TreeMapPaletteColorizer()
            Dim treeMapItemStorage1 As New DevExpress.XtraTreeMap.TreeMapItemStorage()
            Dim treeMapItem1 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem2 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem3 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem4 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem5 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem6 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem7 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem8 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem9 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem10 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem11 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem12 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem13 As New DevExpress.XtraTreeMap.TreeMapItem()
            Me.treeMap = New DevExpress.XtraTreeMap.TreeMapControl()
            Me.layout = New DevExpress.XtraLayout.LayoutControl()
            Me.lbLayoutDirection = New DevExpress.XtraEditors.ListBoxControl()
            Me.lbLayoutAlgorithm = New DevExpress.XtraEditors.ListBoxControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciLayoutAlgorithm = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciLayoutDirection = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.treeMap, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layout.SuspendLayout()
            DirectCast(Me.lbLayoutDirection, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lbLayoutAlgorithm, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciLayoutAlgorithm, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciLayoutDirection, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeMap
            ' 
            Me.treeMap.BorderOptions.Color = System.Drawing.Color.FromArgb((CInt((CByte(50)))), (CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
            treeMapPaletteColorizer1.Palette = DevExpress.XtraTreeMap.Palette.Office2016Palette
            Me.treeMap.Colorizer = treeMapPaletteColorizer1
            treeMapItem2.Label = "United States"
            treeMapItem2.Value = 17.968R
            treeMapItem3.Label = "Brazil"
            treeMapItem3.Value = 1.8R
            treeMapItem4.Label = "Canada"
            treeMapItem4.Value = 1.573R
            treeMapItem1.Children.AddRange(New DevExpress.XtraTreeMap.TreeMapItem() { treeMapItem2, treeMapItem3, treeMapItem4})
            treeMapItem1.Label = "Americas"
            treeMapItem6.Label = "Germany"
            treeMapItem6.Value = 3.371R
            treeMapItem7.Label = "United Kingdom"
            treeMapItem7.Value = 2.865R
            treeMapItem8.Label = "France"
            treeMapItem8.Value = 2.423R
            treeMapItem9.Label = "Italy"
            treeMapItem9.Value = 1.819R
            treeMapItem5.Children.AddRange(New DevExpress.XtraTreeMap.TreeMapItem() { treeMapItem6, treeMapItem7, treeMapItem8, treeMapItem9})
            treeMapItem5.Label = "Europe"
            treeMapItem11.Label = "China"
            treeMapItem11.Value = 11.385R
            treeMapItem12.Label = "Japan"
            treeMapItem12.Value = 4.116R
            treeMapItem13.Label = "India"
            treeMapItem13.Value = 2.183R
            treeMapItem10.Children.AddRange(New DevExpress.XtraTreeMap.TreeMapItem() { treeMapItem11, treeMapItem12, treeMapItem13})
            treeMapItem10.Label = "Asia"
            treeMapItemStorage1.Items.AddRange(New DevExpress.XtraTreeMap.TreeMapItem() { treeMapItem1, treeMapItem5, treeMapItem10})
            Me.treeMap.DataAdapter = treeMapItemStorage1
            Me.treeMap.Location = New System.Drawing.Point(2, 2)
            Me.treeMap.Name = "treeMap"
            Me.treeMap.Size = New System.Drawing.Size(1025, 677)
            Me.treeMap.TabIndex = 0
            ' 
            ' layout
            ' 
            Me.layout.Controls.Add(Me.lbLayoutDirection)
            Me.layout.Controls.Add(Me.lbLayoutAlgorithm)
            Me.layout.Controls.Add(Me.treeMap)
            Me.layout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layout.Location = New System.Drawing.Point(0, 0)
            Me.layout.Margin = New System.Windows.Forms.Padding(0)
            Me.layout.Name = "layout"
            Me.layout.Padding = New System.Windows.Forms.Padding(4)
            Me.layout.Root = Me.layoutControlGroup1
            Me.layout.Size = New System.Drawing.Size(1264, 681)
            Me.layout.TabIndex = 1
            Me.layout.Text = "layoutControl1"
            ' 
            ' lbLayoutDirection
            ' 
            Me.lbLayoutDirection.Location = New System.Drawing.Point(1031, 358)
            Me.lbLayoutDirection.Name = "lbLayoutDirection"
            Me.lbLayoutDirection.Size = New System.Drawing.Size(231, 321)
            Me.lbLayoutDirection.StyleController = Me.layout
            Me.lbLayoutDirection.TabIndex = 5
            ' 
            ' lbLayoutAlgorithm
            ' 
            Me.lbLayoutAlgorithm.Location = New System.Drawing.Point(1031, 18)
            Me.lbLayoutAlgorithm.Name = "lbLayoutAlgorithm"
            Me.lbLayoutAlgorithm.Size = New System.Drawing.Size(231, 320)
            Me.lbLayoutAlgorithm.StyleController = Me.layout
            Me.lbLayoutAlgorithm.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.lciLayoutAlgorithm, Me.lciLayoutDirection})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1264, 681)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.treeMap
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(1029, 681)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' lciLayoutAlgorithm
            ' 
            Me.lciLayoutAlgorithm.Control = Me.lbLayoutAlgorithm
            Me.lciLayoutAlgorithm.Location = New System.Drawing.Point(1029, 0)
            Me.lciLayoutAlgorithm.Name = "lciLayoutAlgorithm"
            Me.lciLayoutAlgorithm.Size = New System.Drawing.Size(235, 340)
            Me.lciLayoutAlgorithm.Text = "Layout Algorithm:"
            Me.lciLayoutAlgorithm.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciLayoutAlgorithm.TextSize = New System.Drawing.Size(85, 13)
            ' 
            ' lciLayoutDirection
            ' 
            Me.lciLayoutDirection.Control = Me.lbLayoutDirection
            Me.lciLayoutDirection.Location = New System.Drawing.Point(1029, 340)
            Me.lciLayoutDirection.Name = "lciLayoutDirection"
            Me.lciLayoutDirection.Size = New System.Drawing.Size(235, 341)
            Me.lciLayoutDirection.Text = "Layout Direction:"
            Me.lciLayoutDirection.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciLayoutDirection.TextSize = New System.Drawing.Size(85, 13)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 681)
            Me.Controls.Add(Me.layout)
            Me.MinimumSize = New System.Drawing.Size(640, 360)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.treeMap, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layout.ResumeLayout(False)
            DirectCast(Me.lbLayoutDirection, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lbLayoutAlgorithm, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciLayoutAlgorithm, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciLayoutDirection, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private treeMap As DevExpress.XtraTreeMap.TreeMapControl
        Private layout As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents lbLayoutAlgorithm As DevExpress.XtraEditors.ListBoxControl
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private lciLayoutAlgorithm As DevExpress.XtraLayout.LayoutControlItem
        Private lciLayoutDirection As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents lbLayoutDirection As DevExpress.XtraEditors.ListBoxControl
    End Class
End Namespace


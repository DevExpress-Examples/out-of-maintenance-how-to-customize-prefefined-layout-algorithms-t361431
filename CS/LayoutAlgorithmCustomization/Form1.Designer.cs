namespace LayoutAlgorithmCustomization {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraTreeMap.TreeMapPaletteColorizer treeMapPaletteColorizer1 = new DevExpress.XtraTreeMap.TreeMapPaletteColorizer();
            DevExpress.XtraTreeMap.TreeMapItemStorage treeMapItemStorage1 = new DevExpress.XtraTreeMap.TreeMapItemStorage();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem1 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem2 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem3 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem4 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem5 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem6 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem7 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem8 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem9 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem10 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem11 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem12 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem13 = new DevExpress.XtraTreeMap.TreeMapItem();
            this.treeMap = new DevExpress.XtraTreeMap.TreeMapControl();
            this.layout = new DevExpress.XtraLayout.LayoutControl();
            this.lbLayoutDirection = new DevExpress.XtraEditors.ListBoxControl();
            this.lbLayoutAlgorithm = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLayoutAlgorithm = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLayoutDirection = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.treeMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbLayoutDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbLayoutAlgorithm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLayoutAlgorithm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLayoutDirection)).BeginInit();
            this.SuspendLayout();
            // 
            // treeMap
            // 
            this.treeMap.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeMapPaletteColorizer1.Palette = DevExpress.XtraTreeMap.Palette.Office2016Palette;
            this.treeMap.Colorizer = treeMapPaletteColorizer1;
            treeMapItem2.Label = "United States";
            treeMapItem2.Value = 17.968D;
            treeMapItem3.Label = "Brazil";
            treeMapItem3.Value = 1.8D;
            treeMapItem4.Label = "Canada";
            treeMapItem4.Value = 1.573D;
            treeMapItem1.Children.AddRange(new DevExpress.XtraTreeMap.TreeMapItem[] {
            treeMapItem2,
            treeMapItem3,
            treeMapItem4});
            treeMapItem1.Label = "Americas";
            treeMapItem6.Label = "Germany";
            treeMapItem6.Value = 3.371D;
            treeMapItem7.Label = "United Kingdom";
            treeMapItem7.Value = 2.865D;
            treeMapItem8.Label = "France";
            treeMapItem8.Value = 2.423D;
            treeMapItem9.Label = "Italy";
            treeMapItem9.Value = 1.819D;
            treeMapItem5.Children.AddRange(new DevExpress.XtraTreeMap.TreeMapItem[] {
            treeMapItem6,
            treeMapItem7,
            treeMapItem8,
            treeMapItem9});
            treeMapItem5.Label = "Europe";
            treeMapItem11.Label = "China";
            treeMapItem11.Value = 11.385D;
            treeMapItem12.Label = "Japan";
            treeMapItem12.Value = 4.116D;
            treeMapItem13.Label = "India";
            treeMapItem13.Value = 2.183D;
            treeMapItem10.Children.AddRange(new DevExpress.XtraTreeMap.TreeMapItem[] {
            treeMapItem11,
            treeMapItem12,
            treeMapItem13});
            treeMapItem10.Label = "Asia";
            treeMapItemStorage1.Items.AddRange(new DevExpress.XtraTreeMap.TreeMapItem[] {
            treeMapItem1,
            treeMapItem5,
            treeMapItem10});
            this.treeMap.DataAdapter = treeMapItemStorage1;
            this.treeMap.Location = new System.Drawing.Point(2, 2);
            this.treeMap.Name = "treeMap";
            this.treeMap.Size = new System.Drawing.Size(1025, 677);
            this.treeMap.TabIndex = 0;
            // 
            // layout
            // 
            this.layout.Controls.Add(this.lbLayoutDirection);
            this.layout.Controls.Add(this.lbLayoutAlgorithm);
            this.layout.Controls.Add(this.treeMap);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Margin = new System.Windows.Forms.Padding(0);
            this.layout.Name = "layout";
            this.layout.Padding = new System.Windows.Forms.Padding(4);
            this.layout.Root = this.layoutControlGroup1;
            this.layout.Size = new System.Drawing.Size(1264, 681);
            this.layout.TabIndex = 1;
            this.layout.Text = "layoutControl1";
            // 
            // lbLayoutDirection
            // 
            this.lbLayoutDirection.Location = new System.Drawing.Point(1031, 358);
            this.lbLayoutDirection.Name = "lbLayoutDirection";
            this.lbLayoutDirection.Size = new System.Drawing.Size(231, 321);
            this.lbLayoutDirection.StyleController = this.layout;
            this.lbLayoutDirection.TabIndex = 5;
            this.lbLayoutDirection.SelectedIndexChanged += new System.EventHandler(this.lbLayoutDirection_SelectedIndexChanged);
            // 
            // lbLayoutAlgorithm
            // 
            this.lbLayoutAlgorithm.Location = new System.Drawing.Point(1031, 18);
            this.lbLayoutAlgorithm.Name = "lbLayoutAlgorithm";
            this.lbLayoutAlgorithm.Size = new System.Drawing.Size(231, 320);
            this.lbLayoutAlgorithm.StyleController = this.layout;
            this.lbLayoutAlgorithm.TabIndex = 4;
            this.lbLayoutAlgorithm.SelectedIndexChanged += new System.EventHandler(this.lbLayoutAlgorithm_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lciLayoutAlgorithm,
            this.lciLayoutDirection});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1264, 681);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.treeMap;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1029, 681);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lciLayoutAlgorithm
            // 
            this.lciLayoutAlgorithm.Control = this.lbLayoutAlgorithm;
            this.lciLayoutAlgorithm.Location = new System.Drawing.Point(1029, 0);
            this.lciLayoutAlgorithm.Name = "lciLayoutAlgorithm";
            this.lciLayoutAlgorithm.Size = new System.Drawing.Size(235, 340);
            this.lciLayoutAlgorithm.Text = "Layout Algorithm:";
            this.lciLayoutAlgorithm.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciLayoutAlgorithm.TextSize = new System.Drawing.Size(85, 13);
            // 
            // lciLayoutDirection
            // 
            this.lciLayoutDirection.Control = this.lbLayoutDirection;
            this.lciLayoutDirection.Location = new System.Drawing.Point(1029, 340);
            this.lciLayoutDirection.Name = "lciLayoutDirection";
            this.lciLayoutDirection.Size = new System.Drawing.Size(235, 341);
            this.lciLayoutDirection.Text = "Layout Direction:";
            this.lciLayoutDirection.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciLayoutDirection.TextSize = new System.Drawing.Size(85, 13);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.layout);
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
            this.layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbLayoutDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbLayoutAlgorithm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLayoutAlgorithm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLayoutDirection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeMap.TreeMapControl treeMap;
        private DevExpress.XtraLayout.LayoutControl layout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.ListBoxControl lbLayoutAlgorithm;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciLayoutAlgorithm;
        private DevExpress.XtraLayout.LayoutControlItem lciLayoutDirection;
        private DevExpress.XtraEditors.ListBoxControl lbLayoutDirection;
    }
}


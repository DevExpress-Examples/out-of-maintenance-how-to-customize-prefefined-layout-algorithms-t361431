using DevExpress.XtraTreeMap;
using System;
using System.Windows.Forms;

namespace LayoutAlgorithmCustomization {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitializeLayoutAlgorithmListBox();
            InitializeLayoutDirectionListBox();
        }

        private void InitializeLayoutAlgorithmListBox() {
            lbLayoutAlgorithm.DataSource = new ITreeMapLayoutAlgorithm[] {
                new TreeMapSliceAndDiceLayoutAlgorithm(),
                new TreeMapSquarifiedLayoutAlgorithm(),
                new TreeMapStripedLayoutAlgorithm()
            };
        }

        private void InitializeLayoutDirectionListBox() {
            lbLayoutDirection.DataSource = Enum.GetValues(typeof(TreeMapLayoutDirection));
        }

        private void SetLayoutAlgorithm() {
            if(lbLayoutAlgorithm.SelectedValue == null) return;
            treeMap.LayoutAlgorithm = lbLayoutAlgorithm.SelectedValue as ITreeMapLayoutAlgorithm;
        }

        private void SetLayoutDirection() {
            if(lbLayoutDirection.SelectedValue == null) return;
            TreeMapLayoutAlgorithmBase layoutAlgorithm = treeMap.LayoutAlgorithm as TreeMapLayoutAlgorithmBase;
            layoutAlgorithm.Direction = (TreeMapLayoutDirection)lbLayoutDirection.SelectedValue;
        }

        private void lbLayoutAlgorithm_SelectedIndexChanged(object sender, EventArgs e) {
            SetLayoutAlgorithm();
            SetLayoutDirection();
        }

        private void lbLayoutDirection_SelectedIndexChanged(object sender, EventArgs e) {
            SetLayoutDirection();
        }
    }
}

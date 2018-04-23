Imports DevExpress.XtraTreeMap
Imports System
Imports System.Windows.Forms

Namespace LayoutAlgorithmCustomization
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitializeLayoutAlgorithmListBox()
            InitializeLayoutDirectionListBox()
        End Sub

        Private Sub InitializeLayoutAlgorithmListBox()
            lbLayoutAlgorithm.DataSource = New ITreeMapLayoutAlgorithm() { _
                New TreeMapSliceAndDiceLayoutAlgorithm(), _
                New TreeMapSquarifiedLayoutAlgorithm(), _
                New TreeMapStripedLayoutAlgorithm() _
            }
        End Sub

        Private Sub InitializeLayoutDirectionListBox()
            lbLayoutDirection.DataSource = System.Enum.GetValues(GetType(TreeMapLayoutDirection))
        End Sub

        Private Sub SetLayoutAlgorithm()
            If lbLayoutAlgorithm.SelectedValue Is Nothing Then
                Return
            End If
            treeMap.LayoutAlgorithm = TryCast(lbLayoutAlgorithm.SelectedValue, ITreeMapLayoutAlgorithm)
        End Sub

        Private Sub SetLayoutDirection()
            If lbLayoutDirection.SelectedValue Is Nothing Then
                Return
            End If
            Dim layoutAlgorithm As TreeMapLayoutAlgorithmBase = TryCast(treeMap.LayoutAlgorithm, TreeMapLayoutAlgorithmBase)
            layoutAlgorithm.Direction = CType(lbLayoutDirection.SelectedValue, TreeMapLayoutDirection)
        End Sub

        Private Sub lbLayoutAlgorithm_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbLayoutAlgorithm.SelectedIndexChanged
            SetLayoutAlgorithm()
            SetLayoutDirection()
        End Sub

        Private Sub lbLayoutDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbLayoutDirection.SelectedIndexChanged
            SetLayoutDirection()
        End Sub
    End Class
End Namespace

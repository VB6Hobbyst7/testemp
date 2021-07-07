Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace EvoHtmlToPdfDemo
	Partial Public Class MasterPage
		Inherits System.Web.UI.MasterPage
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Public Sub CollapseAll()
			demoTreeView.Nodes(0).Collapse()
			demoTreeView.Nodes(1).Collapse()
			demoTreeView.Nodes(2).Collapse()
			demoTreeView.Nodes(3).Collapse()
		End Sub

		Public Sub ExpandAll()
			demoTreeView.Nodes(0).Expand()
			demoTreeView.Nodes(1).Expand()
			demoTreeView.Nodes(2).Expand()
			demoTreeView.Nodes(3).Expand()
		End Sub

		Public Sub ExpandNode(ByVal nodeValue As String)
			ExpandNodeRecursive(demoTreeView.Nodes, nodeValue)
		End Sub

		Private Function ExpandNodeRecursive(ByVal nodesCollection As TreeNodeCollection, ByVal nodeValue As String) As Boolean
			If nodesCollection Is Nothing Then
				Return False
			End If

			If nodesCollection.Count = 0 Then
				Return False
			End If

			For Each treeNode As TreeNode In nodesCollection
				If treeNode.Value = nodeValue Then
					treeNode.Expand()
					Return True
				ElseIf ExpandNodeRecursive(treeNode.ChildNodes, nodeValue) Then
					Return True
				End If
			Next treeNode

			Return False
		End Function

		Public Sub CollapseNode(ByVal nodeValue As String)
			CollapseNodeRecursive(demoTreeView.Nodes, nodeValue)
		End Sub

		Private Function CollapseNodeRecursive(ByVal nodesCollection As TreeNodeCollection, ByVal nodeValue As String) As Boolean
			If nodesCollection Is Nothing Then
				Return False
			End If

			If nodesCollection.Count = 0 Then
				Return False
			End If

			For Each treeNode As TreeNode In nodesCollection
				If treeNode.Value = nodeValue Then
					treeNode.Collapse()
					Return True
				ElseIf CollapseNodeRecursive(treeNode.ChildNodes, nodeValue) Then
					Return True
				End If
			Next treeNode

			Return False
		End Function

		Public Sub SelectNode(ByVal nodeValue As String)
			SelectNodeRecursive(demoTreeView.Nodes, nodeValue)
		End Sub

		Private Function SelectNodeRecursive(ByVal nodesCollection As TreeNodeCollection, ByVal nodeValue As String) As Boolean
			If nodesCollection Is Nothing Then
				Return False
			End If

			If nodesCollection.Count = 0 Then
				Return False
			End If

			For Each treeNode As TreeNode In nodesCollection
				If treeNode.Value = nodeValue Then
					treeNode.Selected = True
					Return True
				ElseIf SelectNodeRecursive(treeNode.ChildNodes, nodeValue) Then
					Return True
				End If
			Next treeNode

			Return False
		End Function

		Protected Sub collapseAllLinkButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			CollapseAll()
		End Sub

		Protected Sub expandAllLinkButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			ExpandAll()
		End Sub

		Protected Sub collapseAllImageButton_Click(ByVal sender As Object, ByVal e As ImageClickEventArgs)
			CollapseAll()
		End Sub

		Protected Sub expandAllImageButton_Click(ByVal sender As Object, ByVal e As ImageClickEventArgs)
			ExpandAll()
		End Sub
	End Class
End Namespace
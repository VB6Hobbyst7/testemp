Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Display_Session_Variables
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				firstNameLabel.Text = If(Session("firstName") IsNot Nothing, CType(Session("firstName"), String), String.Empty)
				lastNameLabel.Text = If(Session("lastName") IsNot Nothing, CType(Session("lastName"), String), String.Empty)
				genderLabel.Text = If(Session("gender") IsNot Nothing, CType(Session("gender"), String), String.Empty)

				Dim iHaveCar As Boolean = If(Session("haveCar") IsNot Nothing, CBool(Session("haveCar")), False)
				haveCarLabel.Text = If(iHaveCar, "Yes", "No")
				carTypePanel.Visible = iHaveCar
				carTypeLabel.Text = If(iHaveCar AndAlso Session("carType") IsNot Nothing, CType(Session("carType"), String), String.Empty)

				commentsLabel.Text = If(Session("comments") IsNot Nothing, CType(Session("comments"), String), String.Empty)
			End If
		End Sub
	End Class
End Namespace
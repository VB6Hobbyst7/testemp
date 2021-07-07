Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class Graphic_Elements
		Inherits System.Web.UI.Page
		Protected Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			Try
				' The result of adding elements to PDF document
				Dim addElementResult As AddElementResult = Nothing

				' The titles font used to mark various sections of the PDF document
				Dim titleFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Point))

				' The position on X anf Y axes where to add the next element
				Dim yLocation As Single = 5
				Dim xLocation As Single = 5

				' Create a PDF page in PDF document
				Dim pdfPage As PdfPage = pdfDocument.AddPage()

				' Line Elements

				' Add section title
				Dim titleTextElement As New TextElement(xLocation, yLocation, "Line Elements", titleFont)
				titleTextElement.ForeColor = Color.Black
				addElementResult = pdfPage.AddElement(titleTextElement)
				yLocation = addElementResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addElementResult.EndPdfPage

				' Add a line with default properties
				Dim lineElement As New LineElement(xLocation, yLocation, xLocation + 50, yLocation)
				addElementResult = pdfPage.AddElement(lineElement)

				' Add a bold line
				Dim boldLineElement As New LineElement(xLocation + 60, yLocation, xLocation + 110, yLocation)
				boldLineElement.LineStyle.LineWidth = 3
				addElementResult = pdfPage.AddElement(boldLineElement)

				' Add dotted line
				Dim dottedLineElement As New LineElement(xLocation + 120, yLocation, xLocation + 170, yLocation)
				dottedLineElement.LineStyle.LineDashStyle = LineDashStyle.Dot
				dottedLineElement.ForeColor = Color.Green
				addElementResult = pdfPage.AddElement(dottedLineElement)

				' Add a dashed line
				Dim dashedLineElement As New LineElement(xLocation + 180, yLocation, xLocation + 230, yLocation)
				dashedLineElement.LineStyle.LineDashStyle = LineDashStyle.Dash
				dashedLineElement.ForeColor = Color.Green
				addElementResult = pdfPage.AddElement(dashedLineElement)

				' Add a dash-dot-dot line
				Dim dashDotDotLineElement As New LineElement(xLocation + 240, yLocation, xLocation + 290, yLocation)
				dashDotDotLineElement.LineStyle.LineDashStyle = LineDashStyle.DashDotDot
				dashDotDotLineElement.ForeColor = Color.Green
				addElementResult = pdfPage.AddElement(dashDotDotLineElement)

				' Add a bold line with rounded cap style
				Dim roundCapBoldLine As New LineElement(xLocation + 300, yLocation, xLocation + 350, yLocation)
				roundCapBoldLine.LineStyle.LineWidth = 5
				roundCapBoldLine.LineStyle.LineCapStyle = LineCapStyle.RoundCap
				roundCapBoldLine.ForeColor = Color.Blue
				addElementResult = pdfPage.AddElement(roundCapBoldLine)

				' Add a bold line with projecting square cap style
				Dim projectingSquareCapBoldLine As New LineElement(xLocation + 360, yLocation, xLocation + 410, yLocation)
				projectingSquareCapBoldLine.LineStyle.LineWidth = 5
				projectingSquareCapBoldLine.LineStyle.LineCapStyle = LineCapStyle.ProjectingSquareCap
				projectingSquareCapBoldLine.ForeColor = Color.Blue
				addElementResult = pdfPage.AddElement(projectingSquareCapBoldLine)

				' Add a bold line with projecting butt cap style
				Dim buttCapBoldLine As New LineElement(xLocation + 420, yLocation, xLocation + 470, yLocation)
				buttCapBoldLine.LineStyle.LineWidth = 5
				buttCapBoldLine.LineStyle.LineCapStyle = LineCapStyle.ButtCap
				buttCapBoldLine.ForeColor = Color.Blue
				addElementResult = pdfPage.AddElement(buttCapBoldLine)

				yLocation = addElementResult.EndPageBounds.Bottom + 3
				pdfPage = addElementResult.EndPdfPage

				' Line Join Styles

				' Add section title
				xLocation -= 5
				yLocation += 10
				titleTextElement = New TextElement(xLocation, yLocation, "Line Join and Cap Styles", titleFont)
				titleTextElement.ForeColor = Color.Black
				addElementResult = pdfPage.AddElement(titleTextElement)
				yLocation = addElementResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addElementResult.EndPdfPage

				' Add graphic path with miter join line style
				Dim miterJoinPath As New PathElement(New PointF(xLocation, yLocation + 50))
				' Add path lines
				miterJoinPath.AddLineSegment(New PointF(xLocation + 25, yLocation))
				miterJoinPath.AddLineSegment(New PointF(xLocation + 50, yLocation + 50))
				' Set path style
				miterJoinPath.LineStyle.LineWidth = 5
				miterJoinPath.LineStyle.LineCapStyle = LineCapStyle.ProjectingSquareCap
				miterJoinPath.LineStyle.LineJoinStyle = LineJoinStyle.MiterJoin
				miterJoinPath.ForeColor = Color.Coral
				addElementResult = pdfPage.AddElement(miterJoinPath)

				' Add graphic path with round join line style
				Dim roundJoinPath As New PathElement(New PointF(xLocation + 70, yLocation + 50))
				' Add path lines
				roundJoinPath.AddLineSegment(New PointF(xLocation + 95, yLocation))
				roundJoinPath.AddLineSegment(New PointF(xLocation + 120, yLocation + 50))
				' Set path style
				roundJoinPath.LineStyle.LineWidth = 5
				roundJoinPath.LineStyle.LineCapStyle = LineCapStyle.RoundCap
				roundJoinPath.LineStyle.LineJoinStyle = LineJoinStyle.RoundJoin
				roundJoinPath.ForeColor = Color.Coral
				addElementResult = pdfPage.AddElement(roundJoinPath)

				' Add graphic path with bevel join line style
				Dim bevelJoinPath As New PathElement(New PointF(xLocation + 140, yLocation + 50))
				' Add lines to path
				bevelJoinPath.AddLineSegment(New PointF(xLocation + 165, yLocation))
				bevelJoinPath.AddLineSegment(New PointF(xLocation + 190, yLocation + 50))
				' Set path style
				bevelJoinPath.LineStyle.LineWidth = 5
				bevelJoinPath.LineStyle.LineCapStyle = LineCapStyle.ButtCap
				bevelJoinPath.LineStyle.LineJoinStyle = LineJoinStyle.BevelJoin
				bevelJoinPath.ForeColor = Color.Coral
				' Add element to document
				addElementResult = pdfPage.AddElement(bevelJoinPath)

				' Add a polygon with miter join line style
				Dim polygonPoints() As PointF = { New PointF(xLocation + 210, yLocation + 50), New PointF(xLocation + 235, yLocation), New PointF(xLocation + 260, yLocation + 50)}
				Dim miterJoinPolygon As New PolygonElement(polygonPoints)
				' Set polygon style
				miterJoinPolygon.LineStyle.LineWidth = 5
				miterJoinPolygon.LineStyle.LineJoinStyle = LineJoinStyle.MiterJoin
				miterJoinPolygon.ForeColor = Color.Green
				miterJoinPolygon.BackColor = Color.AliceBlue
				addElementResult = pdfPage.AddElement(miterJoinPolygon)

				' Add a polygon with round join line style
				polygonPoints = New PointF(){ New PointF(xLocation + 280, yLocation + 50), New PointF(xLocation + 305, yLocation), New PointF(xLocation + 330, yLocation + 50)}
				Dim roundJoinPolygon As New PolygonElement(polygonPoints)
				' Set polygon style
				roundJoinPolygon.LineStyle.LineWidth = 5
				roundJoinPolygon.LineStyle.LineJoinStyle = LineJoinStyle.RoundJoin
				roundJoinPolygon.ForeColor = Color.Green
				roundJoinPolygon.BackColor = Color.Blue
				addElementResult = pdfPage.AddElement(roundJoinPolygon)

				' Add a polygon with bevel join line style
				polygonPoints = New PointF(){ New PointF(xLocation + 350, yLocation + 50), New PointF(xLocation + 375, yLocation), New PointF(xLocation + 400, yLocation + 50)}
				Dim bevelJoinPolygon As New PolygonElement(polygonPoints)
				' Set polygon style
				bevelJoinPolygon.LineStyle.LineWidth = 5
				bevelJoinPolygon.LineStyle.LineJoinStyle = LineJoinStyle.BevelJoin
				bevelJoinPolygon.ForeColor = Color.Green
				bevelJoinPolygon.BackColor = Color.Blue
				addElementResult = pdfPage.AddElement(bevelJoinPolygon)

				yLocation = addElementResult.EndPageBounds.Bottom + 3
				pdfPage = addElementResult.EndPdfPage

				' Add a Graphics Path Element

				' Add section title
				xLocation -= 5
				yLocation += 10
				titleTextElement = New TextElement(xLocation, yLocation, "Path Elements", titleFont)
				titleTextElement.ForeColor = Color.Black
				addElementResult = pdfPage.AddElement(titleTextElement)
				yLocation = addElementResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addElementResult.EndPdfPage

				' Create the path 
				Dim graphicsPath As New PathElement(New PointF(xLocation, yLocation))
				' Add line and Bezier curve segments
				graphicsPath.AddLineSegment(New PointF(xLocation + 50, yLocation + 50))
				graphicsPath.AddBezierCurveSegment(New PointF(xLocation + 100, yLocation), New PointF(xLocation + 200, yLocation + 100), New PointF(xLocation + 250, yLocation + 50))
				graphicsPath.AddLineSegment(New PointF(xLocation + 300, yLocation))
				' Close path
				graphicsPath.ClosePath = True
				' Set path style
				graphicsPath.LineStyle.LineWidth = 3
				graphicsPath.LineStyle.LineJoinStyle = LineJoinStyle.MiterJoin
				graphicsPath.LineStyle.LineCapStyle = LineCapStyle.RoundCap
				graphicsPath.ForeColor = Color.Green
				'graphicsPath.BackColor = Color.Green;
				graphicsPath.Gradient = New GradientColor(GradientDirection.Vertical, Color.LightGreen, Color.Blue)
				' Add element to document
				addElementResult = pdfPage.AddElement(graphicsPath)

				yLocation = addElementResult.EndPageBounds.Bottom + 3
				pdfPage = addElementResult.EndPdfPage

				' Add Circle Elements

				' Add section title
				xLocation -= 5
				yLocation -= 10
				titleTextElement = New TextElement(xLocation, yLocation, "Circle Elements", titleFont)
				titleTextElement.ForeColor = Color.Black
				addElementResult = pdfPage.AddElement(titleTextElement)
				yLocation = addElementResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addElementResult.EndPdfPage

				' Add a Circle Element with default settings
				Dim circleElement As New CircleElement(xLocation + 30, yLocation + 30, 30)
				addElementResult = pdfPage.AddElement(circleElement)

				' Add dotted circle element
				Dim dottedCircleElement As New CircleElement(xLocation + 100, yLocation + 30, 30)
				dottedCircleElement.ForeColor = Color.Green
				dottedCircleElement.LineStyle.LineDashStyle = LineDashStyle.Dot
				addElementResult = pdfPage.AddElement(dottedCircleElement)

				' Add a disc
				Dim discElement As New CircleElement(xLocation + 170, yLocation + 30, 30)
				discElement.ForeColor = Color.Green
				discElement.BackColor = Color.LightGray
				addElementResult = pdfPage.AddElement(discElement)

				' Add disc with bold border
				Dim discWithBoldBorder As New CircleElement(xLocation + 240, yLocation + 30, 30)
				discWithBoldBorder.LineStyle.LineWidth = 5
				discWithBoldBorder.BackColor = Color.Coral
				discWithBoldBorder.ForeColor = Color.Blue
				addElementResult = pdfPage.AddElement(discWithBoldBorder)

				' Add colored disc with bold border
				For i As Integer = 30 To 0 Step -3
					Dim coloredDisc As New CircleElement(xLocation + 310, yLocation + 30,If(i = 0, 1, i))
					coloredDisc.LineStyle.LineWidth = 3
					Select Case (i \ 3) Mod 7
						Case 0
							coloredDisc.BackColor = Color.Red
						Case 1
							coloredDisc.BackColor = Color.Orange
						Case 2
							coloredDisc.BackColor = Color.Yellow
						Case 3
							coloredDisc.BackColor = Color.Green
						Case 4
							coloredDisc.BackColor = Color.Blue
						Case 5
							coloredDisc.BackColor = Color.Indigo
						Case 6
							coloredDisc.BackColor = Color.Violet
						Case Else
					End Select
					addElementResult = pdfPage.AddElement(coloredDisc)
				Next i

				' Add a doughnut
				Dim exteriorNoBorderDisc As New CircleElement(xLocation + 380, yLocation + 30, 30)
				exteriorNoBorderDisc.BackColor = Color.Coral
				addElementResult = pdfPage.AddElement(exteriorNoBorderDisc)

				Dim interiorNoBorderDisc As New CircleElement(xLocation + 380, yLocation + 30, 15)
				interiorNoBorderDisc.BackColor = Color.White
				pdfPage.AddElement(interiorNoBorderDisc)

				' Add a simple disc
				Dim simpleDisc As New CircleElement(xLocation + 450, yLocation + 30, 30)
				simpleDisc.BackColor = Color.Green
				addElementResult = pdfPage.AddElement(simpleDisc)

				yLocation = addElementResult.EndPageBounds.Bottom + 3
				pdfPage = addElementResult.EndPdfPage

				' Add Ellipse Elements

				' Add section title
				xLocation -= 5
				yLocation += 10
				titleTextElement = New TextElement(xLocation, yLocation, "Ellipse Elements", titleFont)
				titleTextElement.ForeColor = Color.Black
				addElementResult = pdfPage.AddElement(titleTextElement)
				yLocation = addElementResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addElementResult.EndPdfPage

				' Add an Ellipse Element with default settings
				Dim ellipseElement As New EllipseElement(xLocation + 50, yLocation + 30, 50, 30)
				addElementResult = pdfPage.AddElement(ellipseElement)

				' Add an Ellipse Element with background color and line color
				Dim ellipseWithBackgroundAndBorder As New EllipseElement(xLocation + 160, yLocation + 30, 50, 30)
				ellipseWithBackgroundAndBorder.BackColor = Color.LightGray
				ellipseWithBackgroundAndBorder.ForeColor = Color.Green
				addElementResult = pdfPage.AddElement(ellipseWithBackgroundAndBorder)

				' Create an ellipse from multiple Ellipse Arc Elements
				Dim ellipseArcElement1 As New EllipseArcElement(xLocation + 220, yLocation, 100, 60, 0, 100)
				ellipseArcElement1.ForeColor = Color.Coral
				ellipseArcElement1.LineStyle.LineWidth = 3
				addElementResult = pdfPage.AddElement(ellipseArcElement1)

				Dim ellipseArcElement2 As New EllipseArcElement(xLocation + 220, yLocation, 100, 60, 100, 100)
				ellipseArcElement2.ForeColor = Color.Blue
				ellipseArcElement2.LineStyle.LineWidth = 3
				addElementResult = pdfPage.AddElement(ellipseArcElement2)

				Dim ellipseArcElement3 As New EllipseArcElement(xLocation + 220, yLocation, 100, 60, 180, 100)
				ellipseArcElement3.ForeColor = Color.Green
				ellipseArcElement3.LineStyle.LineWidth = 3
				addElementResult = pdfPage.AddElement(ellipseArcElement3)

				Dim ellipseArcElement4 As New EllipseArcElement(xLocation + 220, yLocation, 100, 60, 270, 100)
				ellipseArcElement4.ForeColor = Color.Violet
				ellipseArcElement4.LineStyle.LineWidth = 3
				addElementResult = pdfPage.AddElement(ellipseArcElement4)

				' Create an ellipse from multiple Ellipse Slice Elements
				Dim ellipseSliceElement1 As New EllipseSliceElement(xLocation + 330, yLocation, 100, 60, 0, 90)
				ellipseSliceElement1.BackColor = Color.Coral
				addElementResult = pdfPage.AddElement(ellipseSliceElement1)

				Dim ellipseSliceElement2 As New EllipseSliceElement(xLocation + 330, yLocation, 100, 60, 90, 90)
				ellipseSliceElement2.BackColor = Color.Blue
				addElementResult = pdfPage.AddElement(ellipseSliceElement2)

				Dim ellipseSliceElement3 As New EllipseSliceElement(xLocation + 330, yLocation, 100, 60, 180, 90)
				ellipseSliceElement3.BackColor = Color.Green
				addElementResult = pdfPage.AddElement(ellipseSliceElement3)

				Dim ellipseSliceElement4 As New EllipseSliceElement(xLocation + 330, yLocation, 100, 60, 270, 90)
				ellipseSliceElement4.BackColor = Color.Violet
				addElementResult = pdfPage.AddElement(ellipseSliceElement4)

				' Add an Ellipse Element with background
				Dim ellipseWithBackground As New EllipseElement(xLocation + 490, yLocation + 30, 50, 30)
				ellipseWithBackground.BackColor = Color.Green
				addElementResult = pdfPage.AddElement(ellipseWithBackground)

				yLocation = addElementResult.EndPageBounds.Bottom + 3
				pdfPage = addElementResult.EndPdfPage

				' Add Rectangle Elements

				' Add section title
				xLocation -= 5
				yLocation += 10
				titleTextElement = New TextElement(xLocation, yLocation, "Rectangle Elements", titleFont)
				titleTextElement.ForeColor = Color.Black
				addElementResult = pdfPage.AddElement(titleTextElement)
				yLocation = addElementResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addElementResult.EndPdfPage

				' Add a Rectangle Element with default settings
				Dim rectangleElement As New RectangleElement(xLocation, yLocation, 100, 60)
				addElementResult = pdfPage.AddElement(rectangleElement)

				' Add a Rectangle Element with background color and dotted line
				Dim rectangleElementWithDottedLine As New RectangleElement(xLocation + 110, yLocation, 100, 60)
				rectangleElementWithDottedLine.BackColor = Color.LightGray
				rectangleElementWithDottedLine.ForeColor = Color.Green
				rectangleElementWithDottedLine.LineStyle.LineDashStyle = LineDashStyle.Dot
				addElementResult = pdfPage.AddElement(rectangleElementWithDottedLine)

				' Add a Rectangle Element with background color without border
				Dim rectangleElementWithoutBorder As New RectangleElement(xLocation + 220, yLocation, 100, 60)
				rectangleElementWithoutBorder.BackColor = Color.Green
				addElementResult = pdfPage.AddElement(rectangleElementWithoutBorder)

				' Add a Rectangle Element with background color, bold border line and rounded corners
				Dim rectangleElementWithRoundedCorners As New RectangleElement(xLocation + 330, yLocation, 100, 60)
				rectangleElementWithRoundedCorners.BackColor = Color.Coral
				rectangleElementWithRoundedCorners.ForeColor = Color.Blue
				rectangleElementWithRoundedCorners.LineStyle.LineWidth = 5
				rectangleElementWithRoundedCorners.LineStyle.LineJoinStyle = LineJoinStyle.RoundJoin
				addElementResult = pdfPage.AddElement(rectangleElementWithRoundedCorners)

				yLocation = addElementResult.EndPageBounds.Bottom + 3
				pdfPage = addElementResult.EndPdfPage

				' Add Polygon Elements

				' Add section title
				xLocation -= 5
				yLocation += 10
				titleTextElement = New TextElement(xLocation, yLocation, "Polygon Elements", titleFont)
				titleTextElement.ForeColor = Color.Black
				addElementResult = pdfPage.AddElement(titleTextElement)
				yLocation = addElementResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addElementResult.EndPdfPage

				Dim polygonElementPoints() As PointF = { New PointF(xLocation, yLocation + 50), New PointF(xLocation + 50, yLocation), New PointF(xLocation + 100, yLocation + 50), New PointF(xLocation + 50, yLocation + 100) }

				' Add a Polygon Element with default settings
				Dim polygonElement As New PolygonElement(polygonElementPoints)
				addElementResult = pdfPage.AddElement(polygonElement)

				polygonElementPoints = New PointF(){ New PointF(xLocation + 110, yLocation + 50), New PointF(xLocation + 160, yLocation), New PointF(xLocation + 210, yLocation + 50), New PointF(xLocation + 160, yLocation + 100) }

				' Add a Polygon Element with background color and border
				polygonElement = New PolygonElement(polygonElementPoints)
				polygonElement.BackColor = Color.LightGray
				polygonElement.ForeColor = Color.Green
				polygonElement.LineStyle.LineDashStyle = LineDashStyle.Dot
				addElementResult = pdfPage.AddElement(polygonElement)

				polygonElementPoints = New PointF(){ New PointF(xLocation + 220, yLocation + 50), New PointF(xLocation + 270, yLocation), New PointF(xLocation + 320, yLocation + 50), New PointF(xLocation + 270, yLocation + 100) }

				' Add a Polygon Element with background color
				polygonElement = New PolygonElement(polygonElementPoints)
				polygonElement.BackColor = Color.Green
				addElementResult = pdfPage.AddElement(polygonElement)

				Dim polyFillPoints() As PointF = { New PointF(xLocation + 330, yLocation + 50), New PointF(xLocation + 380, yLocation), New PointF(xLocation + 430, yLocation + 50), New PointF(xLocation + 380, yLocation + 100) }

				' Add a Polygon Element with background color and rounded line joins
				Dim polygonElementWithBackgruondColorAndBorder As New PolygonElement(polyFillPoints)
				polygonElementWithBackgruondColorAndBorder.ForeColor = Color.Blue
				polygonElementWithBackgruondColorAndBorder.BackColor = Color.Coral
				polygonElementWithBackgruondColorAndBorder.LineStyle.LineWidth = 5
				polygonElementWithBackgruondColorAndBorder.LineStyle.LineCapStyle = LineCapStyle.RoundCap
				polygonElementWithBackgruondColorAndBorder.LineStyle.LineJoinStyle = LineJoinStyle.RoundJoin
				addElementResult = pdfPage.AddElement(polygonElementWithBackgruondColorAndBorder)

				yLocation = addElementResult.EndPageBounds.Bottom + 3
				pdfPage = addElementResult.EndPdfPage

				' Add Bezier Curve Elements

				' Add section title
				xLocation -= 5
				yLocation += 10
				titleTextElement = New TextElement(xLocation, yLocation, "Bezier Curve Elements", titleFont)
				titleTextElement.ForeColor = Color.Black
				addElementResult = pdfPage.AddElement(titleTextElement)
				yLocation = addElementResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addElementResult.EndPdfPage

				' Add a Bezier Curve Element with normal style

				Dim bezierCurveElement As New BezierCurveElement(xLocation, yLocation + 50, xLocation + 50, yLocation, xLocation + 100, yLocation + 100, xLocation + 150, yLocation + 50)
				bezierCurveElement.ForeColor = Color.Blue
				bezierCurveElement.LineStyle.LineWidth = 3
				addElementResult = pdfPage.AddElement(bezierCurveElement)

				' Mark the points controlling the Bezier curve
				Dim controlPoint1 As New CircleElement(xLocation + 200, yLocation + 50, 2)
				controlPoint1.BackColor = Color.Violet
				pdfPage.AddElement(controlPoint1)

				Dim controlPoint2 As New CircleElement(xLocation + 250, yLocation, 2)
				controlPoint2.BackColor = Color.Violet
				pdfPage.AddElement(controlPoint2)

				Dim controlPoint3 As New CircleElement(xLocation + 300, yLocation + 100, 2)
				controlPoint3.BackColor = Color.Violet
				pdfPage.AddElement(controlPoint3)

				Dim controlPoint4 As New CircleElement(xLocation + 350, yLocation + 50, 2)
				controlPoint4.BackColor = Color.Violet
				pdfPage.AddElement(controlPoint4)

				' Add a Bezier Curve Element with dotted line using the controlling points above

				bezierCurveElement = New BezierCurveElement(controlPoint1.X, controlPoint1.Y, controlPoint2.X, controlPoint2.Y, controlPoint3.X, controlPoint3.Y, controlPoint4.X, controlPoint4.Y)
				bezierCurveElement.ForeColor = Color.Green
				bezierCurveElement.LineStyle.LineDashStyle = LineDashStyle.Dot
				bezierCurveElement.LineStyle.LineWidth = 1
				addElementResult = pdfPage.AddElement(bezierCurveElement)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Graphic_Elements.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close the PDF document
				pdfDocument.Close()
			End Try
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/Graphic_Elements.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/Graphic_Elements.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.SelectNode("Graphic_Elements")
			End If
		End Sub

		Protected Sub demoMenu_MenuItemClick(ByVal sender As Object, ByVal e As MenuEventArgs)
			Select Case e.Item.Value
				Case "Live_Demo"
					demoMultiView.SetActiveView(liveDemoView)
				Case "Description"
					demoMultiView.SetActiveView(descriptionView)
				Case "Sample_Code"
					demoMultiView.SetActiveView(sampleCodeView)
				Case Else
			End Select
		End Sub
	End Class
End Namespace
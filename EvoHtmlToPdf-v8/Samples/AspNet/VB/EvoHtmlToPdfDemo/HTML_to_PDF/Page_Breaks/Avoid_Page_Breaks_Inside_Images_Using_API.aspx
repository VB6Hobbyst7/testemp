﻿<%@ Page Title="Avoid Page Breaks Inside Images Using API" Language="vb" MasterPageFile="~/MasterPage.Master"
	AutoEventWireup="true" CodeBehind="Avoid_Page_Breaks_Inside_Images_Using_API.aspx.vb"
	Inherits="EvoHtmlToPdfDemo.HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_Images_Using_API" %>

<%@ MasterType VirtualPath="~/MasterPage.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table style="width: 100%; height: 100%">
		<tr>
			<td style="height: 20px; padding-bottom: 1px">
				<asp:Menu ID="demoMenu" runat="server" Orientation="Horizontal" Font-Bold="True"
					OnMenuItemClick="demoMenu_MenuItemClick">
					<Items>
						<asp:MenuItem Text="Live Demo" ToolTip="Live Demo" Value="Live_Demo" Selected="True">
						</asp:MenuItem>
						<asp:MenuItem Text="Description" ToolTip="Description" Value="Description"></asp:MenuItem>
						<asp:MenuItem Text="Sample Code" ToolTip="Sample Code" Value="Sample_Code"></asp:MenuItem>
					</Items>
					<StaticHoverStyle BackColor="White" Font-Underline="True" />
					<StaticMenuItemStyle Font-Size="14px" ForeColor="Black" BackColor="WhiteSmoke" BorderStyle="Solid"
						BorderWidth="1px" HorizontalPadding="20px" ItemSpacing="1px" VerticalPadding="5px"
						Font-Bold="False" Font-Underline="False" />
					<StaticSelectedStyle BackColor="White" Font-Underline="False" ForeColor="Navy" />
				</asp:Menu>
			</td>
		</tr>
		<tr>
			<td style="border: solid 1px Black; padding-top: 10px; padding-left: 10px; padding-right: 10px;
				padding-bottom: 0px">
				<table style="width: 100%; height: 100%">
					<tr>
						<td style="font-size: 14px; font-weight: bold; height: 20px; padding-bottom: 15px;
							padding-top: 5px">
							Avoid Page Breaks Inside Images Using API
						</td>
					</tr>
					<tr>
						<td style="width: 100%;">
							<asp:MultiView ID="demoMultiView" runat="server" ActiveViewIndex="0">
								<asp:View ID="liveDemoView" runat="server">
									<table style="width: 535px; height: 855px">
										<tr>
											<td style="vertical-align: top">
												<table>
													<tr>
														<td>
															EVO HTML to PDF Converter can be configured to avoid the page breaks inside images
															in the generated PDF document setting the 'AvoidImageBreak' API property. The Full
															Description and a Code Sample can be accessed from the top tabs.
														</td>
													</tr>
													<tr>
														<td style="height: 20px">
														</td>
													</tr>
													<tr>
														<td>
															<table>
																<tr>
																	<td style="padding-bottom: 5px; font-weight: bold">
																		HTML Page URL or Local File to Convert
																	</td>
																</tr>
																<tr>
																	<td>
																		<asp:TextBox ID="urlTextBox" runat="server" Text="http://www.cnn.com" Width="500px"></asp:TextBox>
																	</td>
																</tr>
															</table>
														</td>
													</tr>
													<tr>
														<td style="height: 20px">
														</td>
													</tr>
													<tr>
														<td>
															<asp:CheckBox ID="avoidImagesBreakCheckBox" runat="server" Text="Avoid Page Breaks Inside Images"
																Checked="true" Font-Bold="False" />
														</td>
													</tr>
													<tr>
														<td style="height: 20px">
														</td>
													</tr>
													<tr>
														<td>
															<asp:Button ID="convertToPdfButton" runat="server" Text="Convert HTML to PDF" OnClick="convertToPdfButton_Click" />
														</td>
													</tr>
												</table>
											</td>
										</tr>
									</table>
								</asp:View>
								<asp:View ID="descriptionView" runat="server">
									<div style="width: 535px; height: 855px; overflow: scroll; font-size: 11px">
										<asp:Literal ID="descriptionLiteral" runat="server"></asp:Literal>
									</div>
								</asp:View>
								<asp:View ID="sampleCodeView" runat="server">
									<div style="width: 535px; height: 855px; overflow: scroll; font-size: 11px">
										<asp:Literal ID="sampleCodeLiteral" runat="server"></asp:Literal>
									</div>
								</asp:View>
							</asp:MultiView>
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</asp:Content>
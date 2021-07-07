﻿<%@ Page Title="PDF Creator - Automatically Resize the Header and Footer" Language="C#"
    MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Header_Footer_Auto_Resize.aspx.cs"
    Inherits="EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_Auto_Resize" %>

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
                            Automatically Resize the Header and Footer
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
                                                            EVO HTML to PDF Converter offers a great control of headers and footers. This demo
                                                            shows how to automatically resize the header to adapt to HTML content being rendered.
                                                            The Full Description and a Code Sample can be accessed from the top tabs.
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
                                                                        <asp:TextBox ID="urlTextBox" runat="server" Text="http://www.evopdf.com/DemoAppFiles/HTML_Files/Structured_HTML.html" Width="500px"></asp:TextBox>
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
                                                            <table>
                                                                <tr style="height: 30px">
                                                                    <td>
                                                                        <asp:RadioButton ID="autoResizeHeaderRadioButton" GroupName="AutoResize" runat="server"
                                                                            Text="Auto Resize Header" Checked="True" Font-Bold="False" AutoPostBack="True"
                                                                            OnCheckedChanged="autoResizeHeaderRadioButton_CheckedChanged" />
                                                                    </td>
                                                                    <td style="width: 30px">
                                                                    </td>
                                                                    <td>
                                                                        <asp:RadioButton ID="fitHeaderHeightRadioButton" GroupName="AutoResize" runat="server"
                                                                            Text="Fit a Fixed Header Height" Font-Bold="False" AutoPostBack="True" OnCheckedChanged="fitHeaderHeightRadioButton_CheckedChanged" />
                                                                    </td>
                                                                    <td style="width: 20px">
                                                                    </td>
                                                                    <td>
                                                                        <asp:Panel ID="fixedHeightOptionsPanel" runat="server" Visible="false">
                                                                            <table>
                                                                                <tr>
                                                                                    <td>
                                                                                        Header Height:
                                                                                    </td>
                                                                                    <td style="width: 5px">
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="headerHeightTextBox" runat="server" Width="35px">40</asp:TextBox>
                                                                                    </td>
                                                                                    <td style="width: 5px">
                                                                                    </td>
                                                                                    <td>
                                                                                        pt
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </asp:Panel>
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
                                                            <asp:Button ID="createPdfButton" runat="server" Text="Create PDF Document" OnClick="createPdfButton_Click" />
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
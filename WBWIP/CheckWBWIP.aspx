<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CheckWBWIP.aspx.vb" Inherits="WBWIP.CheckWBWIP" %>

<%@ Register src="ControlPosition.ascx" tagname="controlposition" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

    label {
      display: block;
      margin: 30px 0 0 0;
    }
        .auto-style7 {
            height: 50px;
        }
        .auto-style8 {
            width: 30%;
            height: 50px;
        }
        
        .hide{
  display:none;  
}
       
        </style>
    <style type="text/css">
        .ddl
        {
            border:2px solid #7d6754;
            border-radius:5px;
            padding:3px;
            -webkit-appearance: none; 
            background-image:url('Images/Arrowhead-Down-01.png');
            background-position:88px;
            background-repeat:no-repeat;
            text-indent: 0.01px;/*In Firefox*/
            text-overflow: '';/*In Firefox*/
        }
</style>
        <link href="scripts/jquery-ui.css" rel="stylesheet" />
    <link rel="stylesheet" href="/resources/demos/style.css" />
    
     <script src="scripts/jquery-1.12.4.js"></script>
     <script src="scripts/jquery-ui.js"></script>
    <script>
   
     $(function () {
       
         //initial TAB
         var tabs = $( "#tabs" ).tabs();
         tabs.find( ".ui-tabs-nav" ).sortable({
            axis: "x",
            stop: function() {
                tabs.tabs( "refresh" );
            }
         });
  });
  
  </script>
</head>
<body>

        <%--   <%
               For i As Integer = 1 To 10
                   Response.Write("<input type=""text"" value=" & i.ToString() & " />")
               Next
          %>--%>

    <form id="form2" runat="server" >

    
   
    <div id="Main" style="background-color: #f6fad1;">
    
                          <table style="width: 100%;" border="1" >
                    <tr>
                        <td class="auto-style7"><%--Head--%>
                            <asp:Label ID="WebName" runat="server" Text=" WB PROCESS REQUEST WIP" Font-Bold="True" Font-Size="25px" Font-Underline="True" ForeColor="#0033CC"></asp:Label>
                                
                            <asp:SqlDataSource ID="SqlDBx" runat="server" ConnectionString="<%$ ConnectionStrings:DBxConnectionString %>" ></asp:SqlDataSource>
                  
                            
                           
                            <asp:SqlDataSource ID="SqlAPCSDB" runat="server" ConnectionString="Data Source=172.16.0.102;Initial Catalog=APCSDB;User ID=APCSDBUSER" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>
                  
                            
                           
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                           
                  
                            
                           
             <%-- <asp:ScriptManager ID="ScriptManager2" runat="server">
            </asp:ScriptManager>--%>
                                    
                        </td>
                        <td style="text-align:right;vertical-align:bottom; font-size: 20px;" class="auto-style8" >
                            <asp:Label ID="lbGotoProcess" runat="server" Font-Size="30px" ForeColor="Red" Visible="False"></asp:Label>
                            <asp:Button ID="Button3" runat="server" Text="Query" Visible="False" />
                            <asp:UpdatePanel ID="UpdatePanelRackList" runat="server"  Width="100%" UpdateMode="Conditional">

                                <ContentTemplate>
                              <asp:Panel ID="PanelRackSelect" runat="server" align="Right" Font-Size="10pt" ForeColor="#CC0000" Width="430px">
                                         <%--   Rack No. :--%> <asp:DropDownList ID="DropDownListPKG" runat="server" AutoPostBack="True" Font-Size="30px" Width="430px" BackColor="#F6F1DB" ForeColor="#7d6754" Font-Names="Andalus" CssClass="ddl">
                                                        </asp:DropDownList>   <%-- &nbsp; --%>
                                        </asp:Panel>
                                     </ContentTemplate>
                          </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td style="vertical-align:top;text-align:right;" colspan="2">
                           
                            <div >
                             
                               <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                    <ContentTemplate>
                                         <asp:Timer ID="Timer1" runat="server" Interval="1000">
                            </asp:Timer>
                                       
                                     </ContentTemplate>
                               </asp:UpdatePanel>
                                          <asp:UpdatePanel ID="UpdatePanelControl" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                
                                        <asp:Panel ID="Panel1" runat="server" align="center">
                                           
                                            <table border="1" style="width:100%;height:750px;background-color: #ffffff;">
                                                <tr>
                                                    <td style="width:33%">
                                                        <uc1:ControlPosition ID="ControlPosition01" runat="server"/>
                                                    </td>
                                                     <td >
                                                        <uc1:ControlPosition ID="ControlPosition02" runat="server" />
                                                    </td>
                                                   <td style="width:33%">
                                                        <uc1:ControlPosition ID="ControlPosition03" runat="server" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <uc1:ControlPosition ID="ControlPosition04" runat="server" />
                                                    </td>
                                                    <td>
                                                        <uc1:ControlPosition ID="ControlPosition05" runat="server" />
                                                    </td>
                                                    <td>
                                                        <uc1:ControlPosition ID="ControlPosition06" runat="server" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <uc1:ControlPosition ID="ControlPosition07" runat="server" />
                                                    </td>
                                                    <td>
                                                        <uc1:ControlPosition ID="ControlPosition08" runat="server" />
                                                    </td>
                                                    <td>
                                                        <uc1:ControlPosition ID="ControlPosition09" runat="server" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                  </ContentTemplate>
            </asp:UpdatePanel>
                                  <%--  </ContentTemplate>
                                   
                                </asp:UpdatePanel>--%>
                            </div>
                            </td>
            </tr>
            <tr>
             <td style="height:400px;vertical-align:top;" colspan="2" >  
           
                 <div id="tabs" >
          
  <ul >
  
      <li id="Tab2"  runat="server" ><a href="#tabs-2">List Package Blank</a></li>
  </ul>

  <div id="tabs-2">
                        <asp:UpdatePanel ID="UpdatePanelBlank" runat="server"  Width="100%" UpdateMode="Conditional">
                                <ContentTemplate>
                                        <asp:Panel ID="PanelListBlank" runat="server" Width="100%" HorizontalAlign="Right">               
                                        <asp:Button ID="SubmitButton0" CssClass="hide" runat="server" Font-Bold="True" Font-Size="15pt" Height="33px" Text="List Package Blank" UseSubmitBehavior="False" Width="100%" />
                                        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="100%" Height="272px" Font-Size="14pt"></asp:TextBox>
                                        </asp:Panel>
                           
                              </ContentTemplate>
                        </asp:UpdatePanel> 

  </div>
 </div>
               
                     
                
                </td>
            </tr>
        </table>

          
    </div>
    </form>
  
</body>
</html>

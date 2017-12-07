<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlPosition4x2.ascx.vb" Inherits="WBWIP.ControlPosition4x2" %>
 <script type="text/javascript">
        function OnClickButton () {
            //alert("You clicked on the button!");

        }

    </script>
<style type="text/css">
       .body {
    /*background: url(~/Image/14emoticon-sad-emotion.png) repeat-x;
    background-repeat: no-repeat;
    background-position: center top;*/
    /*background-size: cover;*/
    background-repeat: no-repeat;
     background-size:100px;
      background-position:center;
}
    .auto-style1 {
        height: 38px;
    }
      .auto-Img {
            width: 421px;
           height: 374px;
           background-size: cover;
        }
    </style>
<%--<asp:Timer id="Timer1" runat="server" Interval="5000" OnTick="Timer1_Tick" ></asp:Timer>--%><%--<asp:Label ID="Label1" runat="server"  Visible="false" Text="0"></asp:Label>--%><%--onMouseOver="this.style.cursor='pointer'" Onclick="OnClickButton()"--%>
<asp:Panel ID="Panel1" runat="server" BorderStyle="Solid"  Font-Size="20pt" BackColor="White" CssClass = "body" > 
     
    <table style="width: 100%;height:338px" border="0">
        <tr>
            <td style="text-align:left" class="auto-style1">
                <asp:Label ID="lbLotNo" runat="server" Font-Size="16pt"></asp:Label>
            </td>
            <td style="text-align:center" colspan="2" class="auto-style1">
                

            </td>
            <td style="text-align:right;vertical-align:top" class="auto-style1">
               <asp:Label ID="lbStatus" runat="server" Font-Bold="True" ForeColor="#FF3300" Font-Size="19pt" ></asp:Label>

            </td>
        </tr>
        <tr>
            <td colspan="4" style="text-align:left">
                <asp:Label ID="lbPKG" runat="server" Font-Size="16pt"></asp:Label>
            </td>
        </tr>
        <tr>
            <td  colspan="4" style="text-align:left">
                <asp:Label ID="lbDevice" runat="server" Font-Size="17pt"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="4" style="text-align:left">
                <asp:Label ID="lbWireType" runat="server" Font-Size="17pt"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align:left">
                <asp:Label ID="lbFrameType" runat="server" Font-Size="17pt"></asp:Label>
            </td>
            <td colspan="2" style="text-align:right"><asp:Label ID="lbTime" runat="server" Font-Size="19pt"></asp:Label></td>
        </tr>
        <tr>
            <td style="text-align:left">
                 <asp:Label ID="lbMCNoRequest" runat="server" Font-Size="17pt"></asp:Label>
            </td>
            <td style="text-align:right;vertical-align:bottom" colspan="3">
            
                    <asp:Label ID="lbPosition" runat="server" BackColor="White" BorderWidth="2px" Font-Size="19pt"></asp:Label>
       
            </td>
        </tr>
       
    </table>

</asp:Panel>

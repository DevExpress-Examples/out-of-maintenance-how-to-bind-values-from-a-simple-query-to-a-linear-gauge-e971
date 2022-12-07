<%@ Page Language="C#" AutoEventWireup="true" Inherits="_Default" Codebehind="Default.aspx.cs" %>

<%@ Register Assembly="DevExpress.Web.ASPxGauges.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGauges.Gauges" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGauges.Gauges.Linear" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGauges.Gauges.Circular" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGauges.Gauges.State" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGauges.Gauges.Digital" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGauges" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v15.1" Namespace="DevExpress.Web.ASPxGauges" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v15.1" Namespace="DevExpress.Web.ASPxGauges.Gauges" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v15.1" Namespace="DevExpress.Web.ASPxGauges.Gauges.Linear" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v15.1" Namespace="DevExpress.Web.ASPxGauges.Gauges.Circular" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v15.1" Namespace="DevExpress.Web.ASPxGauges.Gauges.State" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v15.1" Namespace="DevExpress.Web.ASPxGauges.Gauges.Digital" TagPrefix="dxg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;
            <dxg:ASPxGaugeControl ID="ASPxGaugeControl1" runat="server" BackColor="White" Height="262px"
                Width="258px">
                <Gauges>
<dxg:LinearGauge ID="lGauge1" Bounds="0, 0, 258, 262"><BackgroundLayers>
<dxg:LinearScaleBackgroundLayerComponent ShapeType="Linear_Style1" ScaleEndPos="0.5, 0.08" ScaleStartPos="0.5, 0.92" ScaleID="scale1" Name="bg1" ZOrder="1000"></dxg:LinearScaleBackgroundLayerComponent>
</BackgroundLayers>
<Levels>
<dxg:LinearScaleLevelComponent ShapeType="Style1" ZOrder="-50" ScaleID="scale1" Name="level1"></dxg:LinearScaleLevelComponent>
</Levels>
<Scales>
<dxg:LinearScaleComponent Name="scale1" MaxValue="500" Value="250" MinorTickmark-ShapeType="Linear_Style1_2" MinorTickmark-ShapeOffset="6" MajorTickCount="6" MinorTickCount="4" MajorTickmark-TextOffset="35" MajorTickmark-FormatString="{0:F0}" MajorTickmark-ShapeType="Linear_Style1_1" MajorTickmark-ShapeOffset="6" StartPoint="62.5, 230" EndPoint="62.5, 20" AppearanceTickmarkText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;"></dxg:LinearScaleComponent>
</Scales>
</dxg:LinearGauge>
</Gauges>
            </dxg:ASPxGaugeControl>
        </div>
    </form>
</body>
</html>
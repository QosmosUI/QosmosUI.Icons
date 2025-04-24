// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCrystalWand : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 512 512";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M377.154 21.04l4.06 50.167 54.32 2.856 2.677 54.306 50.173 3.898-7.994-102.88-103.236-8.35zM359.31 32.267L245.954 145.623l44.086 3.566 72.837-72.842-3.566-44.08zm16.696 57.38l-72.98 72.983 2.19 41.692 41.526 2.05 73.004-73.01L417.7 91.84l-41.694-2.192zm56.836 57.05l-72.457 72.46 3.433 44.213 113.24-113.237-44.216-3.436zm-196.213 16.92l7.483 92.525-43.234-43.235c-.846 7.773-2.35 14.887-4.5 21.356l78.48 78.482c6.443-2.176 13.52-3.72 21.244-4.613l-42.5-42.5 92.203 7.164-3.723-47.943-54.648-2.696-2.868-54.662-47.94-3.877zm-48.855 88.472c-4.9 7.32-11.07 13.37-18.474 18.187l69.585 69.584c4.836-7.382 10.892-13.547 18.2-18.458l-69.31-69.312zm-36.392 26.7c-6.41 2.14-13.407 3.69-20.983 4.66l29.25 29.25.34-.34 13.215 13.216-.34.34 52.697 52.697c1.007-7.542 2.585-14.51 4.75-20.894l-78.93-78.93zM135.53 315.01L17.09 433.094v22.17l129.348-129.348-10.905-10.904zm24.12 24.12L17.088 481.69V495h53.73l122.35-122.35-33.518-33.517z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

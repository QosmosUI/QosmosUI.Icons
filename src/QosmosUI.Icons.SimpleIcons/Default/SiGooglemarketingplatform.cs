// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiGooglemarketingplatform : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M12 0C8.926 0 5.852 1.17 3.511 3.511c-4.37 4.371-4.66 11.299-.869 16.01a3.138 3.138 0 0 1 .719-3.314 3.138 3.138 0 0 1 3.672-.56 6.163 6.163 0 0 1 9.324-8.004 2.921 2.921 0 1 0 4.132-4.132A11.968 11.968 0 0 0 12 0zm9.36 4.481a3.138 3.138 0 0 1-.72 3.313 3.138 3.138 0 0 1-3.672.56 6.165 6.165 0 0 1-.61 8.003 2.921 2.921 0 1 0 4.131 4.132c4.37-4.37 4.66-11.298.87-16.008zM5.576 15.501a2.92 2.92 0 0 0-2.922 2.922 2.92 2.92 0 0 0 2.922 2.922 2.92 2.92 0 0 0 2.922-2.922A2.92 2.92 0 0 0 5.577 15.5zm10.07 1.467a6.168 6.168 0 0 1-7.293 0 3.14 3.14 0 0 1-.56 3.672 3.136 3.136 0 0 1-3.314.718c4.376 3.523 10.665 3.523 15.04 0a3.136 3.136 0 0 1-3.313-.718 3.138 3.138 0 0 1-.56-3.672z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

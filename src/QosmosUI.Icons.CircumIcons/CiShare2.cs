// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiShare2 : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Share_2");
		builder.AddAttribute(15, "data-name", "Share 2");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M18.44,15.94a2.5,2.5,0,0,0-1.96.95L7.97,12.64a2.356,2.356,0,0,0,0-1.29l8.5-4.25a2.5,2.5,0,1,0-.53-1.54,2.269,2.269,0,0,0,.09.65l-8.5,4.25a2.5,2.5,0,1,0,0,3.08l8.5,4.25a2.269,2.269,0,0,0-.09.65,2.5,2.5,0,1,0,2.5-2.5Zm0-11.88a1.5,1.5,0,1,1-1.5,1.5A1.5,1.5,0,0,1,18.44,4.06ZM5.56,13.5A1.5,1.5,0,1,1,7.06,12,1.5,1.5,0,0,1,5.56,13.5Zm12.88,6.44a1.5,1.5,0,1,1,1.5-1.5A1.5,1.5,0,0,1,18.44,19.94Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}

// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiFacebook : ComponentBase
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
		builder.AddAttribute(14, "id", "Facebook");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M19.02,4.975A9.93,9.93,0,0,0,2.07,12,9.935,9.935,0,0,0,12,21.935a9.98,9.98,0,0,0,3.8-.75,10.189,10.189,0,0,0,3.22-2.16,9.934,9.934,0,0,0,0-14.05Zm-.7,13.34A8.921,8.921,0,0,1,13,20.885v-6.56h1.88a1,1,0,0,0,0-2H13V9.585a1,1,0,0,1,1-1h1.2a1,1,0,0,0,0-2H13.5a2.5,2.5,0,0,0-2.5,2.5v3.24H9.13a1,1,0,1,0,0,2H11v6.56a8.919,8.919,0,1,1,9.26-5.47A9.061,9.061,0,0,1,18.32,18.315Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}

// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrSwim : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-linecap", "round");
		builder.AddAttribute(16, "stroke-linejoin", "round");
		builder.AddAttribute(17, "stroke-width", "2");
		builder.AddAttribute(18, "d", "M11,13 C11.5,13.5 13.1299859,12.8876287 14.2620192,12.5 C15.7222222,12 17.5,12.5 17,12 C15.3609614,10.3609614 15,10 15,10 C15,10 10.5,12.5 11,13 Z M2,20 C4,20 5,19 7,19 C9,19 10,20 12,20 C14,20 15,19 17,19 C19,19 20,20 22,20 M2,16 C4,16 5,15 7,15 C9,15 10,16 12,16 C14,16 15,15 17,15 C19,15 20,16 22,16 M17.5,4 L12.2222222,7 L15.5,10.5 L12,12 M19.2222222,10 C19.774507,10 20.2222222,9.55228475 20.2222222,9 C20.2222222,8.44771525 19.774507,8 19.2222222,8 C18.6699375,8 18.2222222,8.44771525 18.2222222,9 C18.2222222,9.55228475 18.6699375,10 19.2222222,10 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

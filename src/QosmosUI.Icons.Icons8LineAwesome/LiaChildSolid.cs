// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaChildSolid : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 16 3 C 13.25 3 11 5.25 11 8 C 11 9.570313 11.765625 10.957031 12.90625 11.875 C 11.175781 12.929688 10 14.832031 10 17 L 10 20.40625 L 10.28125 20.71875 L 12 22.4375 L 12 29 L 14 29 L 14 24 L 18 24 L 18 29 L 20 29 L 20 22.4375 L 21.71875 20.71875 L 22 20.40625 L 22 17 C 22 14.832031 20.824219 12.929688 19.09375 11.875 C 20.234375 10.957031 21 9.570313 21 8 C 21 5.25 18.75 3 16 3 Z M 16 5 C 17.667969 5 19 6.332031 19 8 C 19 9.667969 17.667969 11 16 11 C 14.332031 11 13 9.667969 13 8 C 13 6.332031 14.332031 5 16 5 Z M 16 13 C 18.21875 13 20 14.78125 20 17 L 20 19.5625 L 19.5625 20 L 12.4375 20 L 12 19.5625 L 12 17 C 12 14.78125 13.78125 13 16 13 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

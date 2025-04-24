// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaPoundSignSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 17.6875 5 C 17.417969 5 17.140625 5.027344 16.875 5.0625 C 13.699219 5.476563 11 8.203125 11 11.65625 C 11 12.785156 11.28125 13.898438 11.65625 15 L 9 15 L 9 17 L 12.40625 17 C 12.605469 17.554688 12.765625 18.101563 12.90625 18.65625 C 13.46875 20.863281 13.527344 22.839844 11.53125 25 L 8 25 L 8 27 L 24 27 L 24 22 L 22 22 L 22 25 L 14.0625 25 C 15.453125 22.695313 15.378906 20.253906 14.84375 18.15625 C 14.742188 17.757813 14.617188 17.382813 14.5 17 L 20 17 L 20 15 L 13.84375 15 C 13.390625 13.691406 13 12.53125 13 11.65625 C 13 8.425781 16.300781 6.113281 19.375 7.34375 L 20.125 5.5 C 19.308594 5.175781 18.496094 5 17.6875 5 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

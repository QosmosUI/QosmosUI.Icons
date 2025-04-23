// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaMicroscopeSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 17 4 L 17 6 L 21 6 L 21 4 Z M 16 7 L 16 9 L 14 9 C 11.253906 9 9 11.253906 9 14 L 9 18.1875 C 7.84375 18.605469 7 19.707031 7 21 C 7 22.292969 7.84375 23.394531 9 23.8125 L 9 26 L 7 26 L 7 28 L 24 28 L 24 26 L 11 26 L 11 23.8125 C 11.84375 23.507813 12.507813 22.84375 12.8125 22 L 24 22 L 24 20 L 12.8125 20 C 12.507813 19.160156 11.839844 18.492188 11 18.1875 L 11 14 C 11 12.34375 12.34375 11 14 11 L 16 11 L 16 17 L 22 17 L 22 7 Z M 18 9 L 20 9 L 20 15 L 18 15 Z M 10 20 C 10.5625 20 11 20.4375 11 21 C 11 21.5625 10.5625 22 10 22 C 9.4375 22 9 21.5625 9 21 C 9 20.4375 9.4375 20 10 20 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaPercentSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 9.5 6 C 7.578125 6 6 7.578125 6 9.5 L 6 12.5 C 6 14.421875 7.578125 16 9.5 16 C 11.421875 16 13 14.421875 13 12.5 L 13 9.5 C 13 7.578125 11.421875 6 9.5 6 Z M 20.75 6 L 8.75 26 L 11.25 26 L 23.25 6 Z M 9.5 8 C 10.339844 8 11 8.660156 11 9.5 L 11 12.5 C 11 13.339844 10.339844 14 9.5 14 C 8.660156 14 8 13.339844 8 12.5 L 8 9.5 C 8 8.660156 8.660156 8 9.5 8 Z M 22.5 16 C 20.578125 16 19 17.578125 19 19.5 L 19 22.5 C 19 24.421875 20.578125 26 22.5 26 C 24.421875 26 26 24.421875 26 22.5 L 26 19.5 C 26 17.578125 24.421875 16 22.5 16 Z M 22.5 18 C 23.339844 18 24 18.660156 24 19.5 L 24 22.5 C 24 23.339844 23.339844 24 22.5 24 C 21.660156 24 21 23.339844 21 22.5 L 21 19.5 C 21 18.660156 21.660156 18 22.5 18 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

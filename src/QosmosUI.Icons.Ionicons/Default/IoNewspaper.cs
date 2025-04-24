// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoNewspaper : ComponentBase
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
		builder.AddAttribute(14, "d", "M439.91,112H416.09a.09.09,0,0,0-.09.09V416a32,32,0,0,0,32,32h0a32,32,0,0,0,32-32V152.09A40.09,40.09,0,0,0,439.91,112Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M384,416V72a40,40,0,0,0-40-40H72A40,40,0,0,0,32,72V424a56,56,0,0,0,56,56H430.85a1.14,1.14,0,0,0,1.15-1.15h0a1.14,1.14,0,0,0-.85-1.1A64.11,64.11,0,0,1,384,416ZM96,128a16,16,0,0,1,16-16h64a16,16,0,0,1,16,16v64a16,16,0,0,1-16,16H112a16,16,0,0,1-16-16ZM304,400H112.45c-8.61,0-16-6.62-16.43-15.23A16,16,0,0,1,112,368H303.55c8.61,0,16,6.62,16.43,15.23A16,16,0,0,1,304,400Zm0-64H112.45c-8.61,0-16-6.62-16.43-15.23A16,16,0,0,1,112,304H303.55c8.61,0,16,6.62,16.43,15.23A16,16,0,0,1,304,336Zm0-64H112.45c-8.61,0-16-6.62-16.43-15.23A16,16,0,0,1,112,240H303.55c8.61,0,16,6.62,16.43,15.23A16,16,0,0,1,304,272Zm0-64H240.45c-8.61,0-16-6.62-16.43-15.23A16,16,0,0,1,240,176h63.55c8.61,0,16,6.62,16.43,15.23A16,16,0,0,1,304,208Zm0-64H240.45c-8.61,0-16-6.62-16.43-15.23A16,16,0,0,1,240,112h63.55c8.61,0,16,6.62,16.43,15.23A16,16,0,0,1,304,144Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

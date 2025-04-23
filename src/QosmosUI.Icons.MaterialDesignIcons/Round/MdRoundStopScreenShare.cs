// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundStopScreenShare : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M23 18h-1.2l1.79 1.79c.24-.18.41-.46.41-.79 0-.55-.45-1-1-1zM3.23 2.28c-.39-.39-1.03-.39-1.42 0-.39.39-.39 1.02 0 1.41l.84.86s-.66.57-.66 1.47C2 6.92 2 16 2 16l.01.01c0 1.09.88 1.98 1.97 1.99H1c-.55 0-1 .45-1 1s.45 1 1 1h17.13l2 2c.39.39 1.02.39 1.41 0s.39-1.02 0-1.41L3.23 2.28zM7 15c.31-1.48.94-2.93 2.08-4.05l1.59 1.59C9.13 12.92 7.96 13.71 7 15zm6-5.87v-.98c0-.44.52-.66.84-.37L15 8.87l1.61 1.5c.21.2.21.53 0 .73l-.89.83 5.58 5.58c.43-.37.7-.9.7-1.51V6c0-1.09-.89-1.98-1.98-1.98H7.8l5.14 5.13c.02-.01.04-.02.06-.02z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

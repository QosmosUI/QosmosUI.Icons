// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImInfinite : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M12.25 11.75c-1.002 0-1.943-0.39-2.652-1.098l-1.598-1.598-1.598 1.598c-0.708 0.708-1.65 1.098-2.652 1.098s-1.944-0.39-2.652-1.098c-0.708-0.708-1.098-1.65-1.098-2.652s0.39-1.943 1.098-2.652c0.708-0.708 1.65-1.098 2.652-1.098s1.943 0.39 2.652 1.098l1.598 1.598 1.598-1.598c0.708-0.708 1.65-1.098 2.652-1.098s1.944 0.39 2.652 1.098c0.708 0.708 1.098 1.65 1.098 2.652s-0.39 1.943-1.098 2.652c-0.708 0.708-1.65 1.098-2.652 1.098zM10.652 9.598c0.427 0.427 0.994 0.662 1.598 0.662s1.171-0.235 1.598-0.662c0.427-0.427 0.662-0.994 0.662-1.598s-0.235-1.171-0.662-1.598c-0.427-0.427-0.994-0.662-1.598-0.662s-1.171 0.235-1.598 0.662l-1.598 1.598 1.598 1.598zM3.75 5.74c-0.604 0-1.171 0.235-1.598 0.662s-0.662 0.994-0.662 1.598c0 0.604 0.235 1.171 0.662 1.598s0.994 0.662 1.598 0.662c0.604 0 1.171-0.235 1.598-0.662l1.598-1.598-1.598-1.598c-0.427-0.427-0.994-0.662-1.598-0.662v0z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundRotate90DegreesCcw : ComponentBase
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
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M5.93 7.83l-3.65 3.66c-.78.78-.78 2.05 0 2.83l3.66 3.66c.78.78 2.05.78 2.83 0l3.66-3.65c.78-.78.78-2.05 0-2.83L8.76 7.82c-.79-.78-2.05-.78-2.83.01zM4.4 12.19l2.25-2.25c.39-.39 1.02-.39 1.42 0l2.24 2.24c.39.39.39 1.02 0 1.41l-2.25 2.25c-.39.39-1.02.39-1.42 0L4.4 13.61c-.39-.39-.39-1.03 0-1.42zm14.96-5.55C17.61 4.88 15.3 4 13 4v-.83c0-.89-1.08-1.34-1.71-.71L9.47 4.29c-.39.39-.39 1.02 0 1.41l1.83 1.83c.62.63 1.7.19 1.7-.7V6c2.02 0 4.03.86 5.45 2.61 2.05 2.52 2.05 6.27 0 8.79C17.03 19.14 15.02 20 13 20c-.78 0-1.55-.13-2.29-.39-.36-.12-.75-.01-1.02.26-.5.5-.34 1.39.34 1.62.96.34 1.96.51 2.97.51 2.3 0 4.61-.88 6.36-2.64 3.52-3.51 3.52-9.21 0-12.72z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

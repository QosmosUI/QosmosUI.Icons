// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneFace : ComponentBase
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
		builder.AddAttribute(17, "d", "M17.5 8c.46 0 .91-.05 1.34-.12C17.44 5.56 14.9 4 12 4c-.46 0-.91.05-1.34.12C12.06 6.44 14.6 8 17.5 8zM8.08 5.03C6.37 6 5.05 7.58 4.42 9.47c1.71-.97 3.03-2.55 3.66-4.44z");
		builder.AddAttribute(18, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M12 2C6.48 2 2 6.48 2 12s4.48 10 10 10 10-4.48 10-10S17.52 2 12 2zm0 2c2.9 0 5.44 1.56 6.84 3.88-.43.07-.88.12-1.34.12-2.9 0-5.44-1.56-6.84-3.88.43-.07.88-.12 1.34-.12zM8.08 5.03C7.45 6.92 6.13 8.5 4.42 9.47 5.05 7.58 6.37 6 8.08 5.03zM12 20c-4.41 0-8-3.59-8-8 0-.05.01-.1.01-.15 2.6-.98 4.68-2.99 5.74-5.55 1.83 2.26 4.62 3.7 7.75 3.7.75 0 1.47-.09 2.17-.24.21.71.33 1.46.33 2.24 0 4.41-3.59 8-8 8z");
		builder.CloseElement();
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "cx", "9");
		builder.AddAttribute(23, "cy", "13");
		builder.AddAttribute(24, "r", "1.25");
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "cx", "15");
		builder.AddAttribute(27, "cy", "13");
		builder.AddAttribute(28, "r", "1.25");
		builder.CloseElement();
		builder.CloseElement();
    }
}

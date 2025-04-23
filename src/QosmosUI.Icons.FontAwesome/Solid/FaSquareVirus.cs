// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaSquareVirus : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 448 512";

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
		builder.AddAttribute(14, "d", "M64 32C28.7 32 0 60.7 0 96L0 416c0 35.3 28.7 64 64 64l320 0c35.3 0 64-28.7 64-64l0-320c0-35.3-28.7-64-64-64L64 32zM223.8 93.7c13.3 0 24 10.7 24 24c0 29.3 35.4 43.9 56.1 23.2c9.4-9.4 24.6-9.4 33.9 0s9.4 24.6 0 33.9c-20.7 20.7-6 56.1 23.2 56.1c13.3 0 24 10.7 24 24s-10.7 24-24 24c-29.3 0-43.9 35.4-23.2 56.1c9.4 9.4 9.4 24.6 0 33.9s-24.6 9.4-33.9 0c-20.7-20.7-56.1-6-56.1 23.2c0 13.3-10.7 24-24 24s-24-10.7-24-24c0-29.3-35.4-43.9-56.1-23.2c-9.4 9.4-24.6 9.4-33.9 0s-9.4-24.6 0-33.9c20.7-20.7 6-56.1-23.2-56.1c-13.3 0-24-10.7-24-24s10.7-24 24-24c29.3 0 43.9-35.4 23.2-56.1c-9.4-9.4-9.4-24.6 0-33.9s24.6-9.4 33.9 0c20.7 20.7 56.1 6 56.1-23.2c0-13.3 10.7-24 24-24zM192 256a32 32 0 1 0 0-64 32 32 0 1 0 0 64zm88 32a24 24 0 1 0 -48 0 24 24 0 1 0 48 0z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

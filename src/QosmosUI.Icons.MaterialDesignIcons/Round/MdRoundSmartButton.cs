// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSmartButton : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M22,9v6c0,1.1-0.9,2-2,2h-1l0-2h1V9H4v6h6v2H4c-1.1,0-2-0.9-2-2V9c0-1.1,0.9-2,2-2h16C21.1,7,22,7.9,22,9z M14.04,17.99 c0.18,0.39,0.73,0.39,0.91,0l0.63-1.4l1.4-0.63c0.39-0.18,0.39-0.73,0-0.91l-1.4-0.63l-0.63-1.4c-0.18-0.39-0.73-0.39-0.91,0 l-0.63,1.4l-1.4,0.63c-0.39,0.18-0.39,0.73,0,0.91l1.4,0.63L14.04,17.99z M16.74,13.43c0.1,0.22,0.42,0.22,0.52,0l0.36-0.8 l0.8-0.36c0.22-0.1,0.22-0.42,0-0.52l-0.8-0.36l-0.36-0.8c-0.1-0.22-0.42-0.22-0.52,0l-0.36,0.8l-0.8,0.36 c-0.22,0.1-0.22,0.42,0,0.52l0.8,0.36L16.74,13.43z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}

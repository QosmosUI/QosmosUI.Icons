// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSaveAs : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M20.41,6.41l-2.83-2.83C17.21,3.21,16.7,3,16.17,3H5C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h7.4l8.6-8.6V7.83 C21,7.3,20.79,6.79,20.41,6.41z M12,18c-1.66,0-3-1.34-3-3s1.34-3,3-3s3,1.34,3,3S13.66,18,12,18z M15,9c0,0.55-0.45,1-1,1H7 c-0.55,0-1-0.45-1-1V7c0-0.55,0.45-1,1-1h7c0.55,0,1,0.45,1,1V9z M19.99,16.25l1.77,1.77l-4.84,4.84C16.82,22.95,16.69,23,16.56,23 H15.5c-0.28,0-0.5-0.22-0.5-0.5v-1.06c0-0.13,0.05-0.26,0.15-0.35L19.99,16.25z M23.25,16.51l-0.85,0.85l-1.77-1.77l0.85-0.85 c0.2-0.2,0.51-0.2,0.71,0l1.06,1.06C23.45,16,23.45,16.32,23.25,16.51z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}

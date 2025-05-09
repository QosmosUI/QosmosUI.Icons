// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundTranscribe : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M22.54,10.28c-0.34-0.82-0.34-1.72,0-2.54c0.19-0.45,0.1-0.96-0.24-1.3l-0.1-0.1c-0.56-0.56-1.51-0.44-1.88,0.26 c-0.8,1.48-0.79,3.24,0.03,4.79c0.37,0.69,1.31,0.83,1.86,0.27l0.1-0.1C22.65,11.23,22.73,10.72,22.54,10.28z M18.82,15.11 L18.82,15.11c0.4-0.4,0.46-1.02,0.13-1.48c-1.97-2.73-1.96-6.39,0.01-9.23c0.32-0.47,0.26-1.1-0.14-1.5l0,0 c-0.5-0.5-1.34-0.46-1.78,0.1c-2.73,3.54-2.73,8.36,0.02,12C17.49,15.56,18.33,15.61,18.82,15.11z M9,13c2.21,0,4-1.79,4-4 c0-2.21-1.79-4-4-4S5,6.79,5,9C5,11.21,6.79,13,9,13z M15.39,15.56C13.71,14.7,11.53,14,9,14c-2.53,0-4.71,0.7-6.39,1.56 C1.61,16.07,1,17.1,1,18.22L1,20c0,0.55,0.45,1,1,1h14c0.55,0,1-0.45,1-1l0-1.78C17,17.1,16.39,16.07,15.39,15.56z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}

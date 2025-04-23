// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree;

public class ImFlattr : ComponentBase
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
		builder.AddAttribute(14, "d", "M5.743 0c-3.802 0-5.743 2.19-5.743 6.279v0 8.579l3.725-3.729v-4.358c0-1.694 0.449-2.772 1.955-3.014v0c0.526-0.103 1.621-0.067 2.317-0.067v0 2.587c0 0.024 0.003 0.066 0.009 0.087v0c0.029 0.105 0.124 0.181 0.236 0.182v0c0.063 0 0.123-0.033 0.184-0.093v0l6.455-6.453-9.139-0.001zM12.275 4.871v4.358c0 1.694-0.449 2.772-1.955 3.014v0c-0.526 0.103-1.621 0.067-2.317 0.067v0-2.587c0-0.023-0.003-0.066-0.009-0.087v0c-0.029-0.105-0.124-0.182-0.236-0.182v0c-0.064-0-0.123 0.033-0.184 0.093v0l-6.455 6.453 9.139 0.001c3.802 0 5.743-2.19 5.743-6.279v0-8.579l-3.725 3.729z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

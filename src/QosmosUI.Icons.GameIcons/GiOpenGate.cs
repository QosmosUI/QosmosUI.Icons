// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiOpenGate : ComponentBase
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
		builder.AddAttribute(14, "d", "M192 64c-15.4 3.77-35.7 16.04-53 33.17-19.2 19.13-34.9 43.63-39.58 64.63l-.58 135.3.37 157.4 93.99-40.3L192 64zm128 0l-1.2 350.2 94 40.3.4-156.8-.6-135.9c-4.7-21-20.3-45.5-39.6-64.63-17.3-17.13-37.6-29.4-53-33.17zM57.24 94.67c-8.39 0-15 6.63-15 15.03 0 8.4 6.61 15 15 15s15-6.6 15-15-6.61-15.03-15-15.03zm397.56 0c-8.4 0-15 6.63-15 15.03 0 8.4 6.6 15 15 15s15-6.6 15-15-6.6-15.03-15-15.03zM35.5 142.7l-1.42 334h46l1.42-334h-46zm395 0l1.5 334h46l-1.5-334h-46zM159.2 231h18v48h-18v-48zm175.6 0h18v48h-18v-48z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

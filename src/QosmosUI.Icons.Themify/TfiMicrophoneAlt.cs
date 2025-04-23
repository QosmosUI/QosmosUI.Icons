// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiMicrophoneAlt : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M11.614 7.021c0.688-0.754 1.12-1.747 1.12-2.847 0-2.335-1.899-4.234-4.234-4.234s-4.234 1.899-4.234 4.234c0 1.1 0.432 2.093 1.12 2.847l1.137 7.979h1.477v1.984h1v-1.984h1.477l1.137-7.979zM6 2.147v1.853h1v-2.674c0.309-0.164 0.643-0.28 1-0.336v4.010h1v-4.010c0.357 0.056 0.691 0.172 1 0.336v2.674h1v-1.853c0.452 0.557 0.734 1.256 0.734 2.026 0 1.784-1.451 3.235-3.234 3.235s-3.234-1.45-3.234-3.234c0-0.771 0.282-1.47 0.734-2.027zM7.391 14l-0.87-6.104c0.593 0.316 1.26 0.513 1.979 0.513s1.386-0.197 1.979-0.514l-0.87 6.105h-2.218z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

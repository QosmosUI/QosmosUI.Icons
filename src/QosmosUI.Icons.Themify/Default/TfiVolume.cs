// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiVolume : ComponentBase
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
		builder.AddAttribute(15, "d", "M3.587 5.933c-0.956 0-1.55 0.5-1.55 1.306v2.161c0 0.415 0.161 0.804 0.453 1.098 0.292 0.293 0.682 0.455 1.097 0.455h1.743l5.686 5.688v-16.429l-5.63 5.721h-1.799zM10.016 2.654v11.572l-4.272-4.273h-2.158c-0.303 0-0.549-0.248-0.549-0.553v-2.161c0-0.091 0-0.306 0.55-0.306h2.217l4.212-4.279zM12.005 10.987v-1c0.556 0 1.008-0.452 1.008-1.008s-0.452-1.008-1.008-1.008v-1c1.107 0 2.008 0.901 2.008 2.008s-0.901 2.008-2.008 2.008zM16.029 8.987c0 2.206-1.794 4-4 4v-1c1.654 0 3-1.346 3-3s-1.346-3-3-3v-1c2.205 0 4 1.795 4 4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaColonSign : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 384 512";

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
		builder.AddAttribute(14, "d", "M255 39.8c4.3-17.1-6.1-34.5-23.3-38.8S197.2 7.1 193 24.2L181.9 68.6C96.1 87.8 32 164.4 32 256c0 58.1 25.8 110.2 66.7 145.4L81 472.2c-4.3 17.1 6.1 34.5 23.3 38.8s34.5-6.1 38.8-23.3l13-52.1c9 3.4 18.4 6.2 28 8.2L177 472.2c-4.3 17.1 6.1 34.5 23.3 38.8s34.5-6.1 38.8-23.3l10.4-41.4c33.4-4.4 64.1-17.4 89.8-36.7c14.1-10.6 17-30.7 6.4-44.8s-30.7-17-44.8-6.4c-10.2 7.7-21.7 13.9-34 18.3L321 160c9.4-.3 18.5-4.7 24.6-12.8c10.6-14.1 7.8-34.2-6.4-44.8c-1.1-.8-2.2-1.6-3.3-2.4L351 39.8c4.3-17.1-6.1-34.5-23.3-38.8S293.2 7.1 289 24.2L277.2 71.5c-9.3-2.7-18.8-4.6-28.6-5.9L255 39.8zM163.2 143.3L117.3 326.8C103.9 306.5 96 282.2 96 256c0-48.7 27.2-91 67.2-112.7zm8.6 229.5l61.1-244.6c9.9 .7 19.5 2.5 28.7 5.3l-62 248.1c-9.7-1.9-19-4.8-27.8-8.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

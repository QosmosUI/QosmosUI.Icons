// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFloorPolisher : ComponentBase
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
		builder.AddAttribute(14, "d", "M37.08 29c-8.55 0-15.284 6.734-15.284 15.284S28.53 59.57 37.08 59.57s15.285-6.735 15.285-15.285S45.63 29 37.08 29zm31.745 26.3C64.226 68.41 51.69 77.91 37.08 77.91c-5.008 0-9.77-1.123-14.056-3.119l37.413 49.886 19.324-8.453zm16.708 78.418l-16.435 7.19 111.193 283.177 16.108-8.056zm213.04 198.173v14.265h79.479v-14.265zm0 32.607v46.872h79.479v-46.872zm-149.69 32.606l-4.56 11.398a58.622 58.622 0 0 1 15.041 12.014l-8.78-23.412zm60.01 0l5.35 14.266h65.99v-14.266zm-92.713 22.417a39.601 39.601 0 0 0-39.74 39.74A39.601 39.601 0 0 0 116.18 499a39.601 39.601 0 0 0 39.74-39.74 39.601 39.601 0 0 0-39.74-39.739zm100.877 10.19v30.569h242.512v-30.57zm-18.342 5.668l-25.537 12.77a57.869 57.869 0 0 1 1.083 11.112c0 .341-.02.678-.026 1.019h24.48v-24.901zm14.84 43.242l-7.134 14.265h263.783l-7.133-14.265z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

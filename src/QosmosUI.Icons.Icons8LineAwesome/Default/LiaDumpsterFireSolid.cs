// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaDumpsterFireSolid : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 5 6 L 3 14 L 4.3339844 14 L 4.6660156 16 L 3 16 L 3 18 L 5 18 L 6 24 L 6 26 L 8 26 L 8 24 L 19.638672 24 C 19.935672 23.269 20.309078 22.604 20.705078 22 L 7.6933594 22 L 6.3613281 14 L 8.1894531 14 L 10.25 14 L 15 14 L 17 14 L 21.75 14 L 23.810547 14 L 25.638672 14 L 25.095703 17.255859 L 26.554688 16.150391 C 26.554688 16.150391 28.651437 17.881 28.773438 18 L 29 18 L 29 16 L 27.332031 16 L 27.666016 14 L 29 14 L 27 6 L 17 6 L 15 6 L 5 6 z M 6.5625 8 L 9.3378906 8 L 8.5722656 12 L 5.5625 12 L 6.5625 8 z M 11.390625 8 L 15 8 L 15 12 L 10.630859 12 L 11.390625 8 z M 17 8 L 20.609375 8 L 21.369141 12 L 17 12 L 17 8 z M 22.662109 8 L 25.4375 8 L 26.4375 12 L 23.427734 12 L 22.662109 8 z M 26.529297 18.660156 L 25.880859 19.220703 C 25.880859 19.220703 24.660703 20.200859 23.470703 21.630859 C 22.280703 23.060859 21 24.961562 21 27.101562 C 21 28.611563 21.630156 29.92125 22.660156 30.78125 C 23.680156 31.65125 25.05 32.101562 26.5 32.101562 C 27.95 32.101562 29.319844 31.65125 30.339844 30.78125 C 31.369844 29.92125 32 28.611562 32 27.101562 C 32 25.111563 30.709297 23.290313 29.529297 21.820312 C 28.349297 20.340312 27.189453 19.251953 27.189453 19.251953 L 26.529297 18.660156 z M 26.470703 21.441406 C 26.860703 21.821406 27.220703 22.140313 27.970703 23.070312 C 29.040703 24.410312 30 26.131562 30 27.101562 C 30 28.081563 29.629297 28.78125 29.029297 29.28125 C 28.849297 29.44125 28.640156 29.581406 28.410156 29.691406 C 28.460156 29.501406 28.5 29.301562 28.5 29.101562 C 28.5 26.151563 26.939453 24.410156 26.939453 24.410156 C 26.939453 24.410156 26.989453 27.041016 26.189453 27.041016 C 25.639453 27.041016 25.089844 26.191406 25.089844 26.191406 C 25.089844 26.191406 24.5 27.451563 24.5 29.101562 C 24.5 29.301562 24.539844 29.501406 24.589844 29.691406 C 24.359844 29.581406 24.150703 29.44125 23.970703 29.28125 C 23.370703 28.78125 23 28.081563 23 27.101562 C 23 25.841562 23.969297 24.180156 25.029297 22.910156 C 25.759297 22.040156 26.090703 21.781406 26.470703 21.441406 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

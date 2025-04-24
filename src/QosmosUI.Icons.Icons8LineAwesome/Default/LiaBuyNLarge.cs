// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaBuyNLarge : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 4.2109375 C 7.72 4.2109375 1 9.49 1 16 C 1 22.51 7.72 27.789062 16 27.789062 C 24.28 27.789062 31 22.51 31 16 C 31 9.49 24.28 4.2109375 16 4.2109375 z M 8.8398438 8 L 15.349609 8 C 18.499609 8 19.590234 9.4797656 19.240234 11.759766 C 19.230234 11.839766 19.180625 12.019688 19.140625 12.179688 C 18.790625 12.069688 18.419297 12 18.029297 12 C 15.819297 12 14.029297 13.79 14.029297 16 C 14.029297 18.03 15.549766 19.689219 17.509766 19.949219 C 17.499766 19.949219 17.5 19.960703 17.5 19.970703 C 16.56 21.760703 14.7 22.97 11.75 23 C 11.75 23 5.01 23.01 5 23 L 8.8398438 8 z M 21.349609 8 L 26 8 L 23.210938 19 L 28 19 L 27 23 L 17.609375 23 L 18.359375 19.970703 C 20.419375 19.800703 22.029297 18.1 22.029297 16 C 22.029297 14.59 21.299453 13.350625 20.189453 12.640625 L 21.349609 8 z M 11.990234 11 L 11.339844 13.759766 L 12.529297 13.759766 C 13.539297 13.759766 14.510937 12.970313 14.710938 12.070312 C 14.930938 11.080312 14.239688 11 13.179688 11 L 11.990234 11 z M 16.429688 13.419922 L 18.070312 13.419922 L 18.849609 15.410156 L 19.349609 13.419922 L 21.029297 13.419922 L 19.869141 18.320312 L 18.009766 18.320312 L 17.429688 16.380859 L 17.019531 18.320312 L 15.029297 18.320312 L 16.429688 13.419922 z M 10.609375 16.740234 L 9.8398438 20 L 11.220703 20 C 12.120703 20 13.009844 19.820937 13.339844 18.460938 C 13.649844 17.170938 12.890234 16.740234 11.990234 16.740234 L 10.609375 16.740234 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

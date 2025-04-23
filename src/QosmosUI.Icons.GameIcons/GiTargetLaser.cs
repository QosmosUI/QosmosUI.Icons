// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiTargetLaser : ComponentBase
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
		builder.AddAttribute(14, "d", "M61 16L16 61l195 180 195 165-165-195L61 16zm314.97 240c-21.068.066-42.135 5.635-60.876 16.656l45.406 45.406c10.03-2.64 20.587-2.446 30.594.157l45.75-45.75v-.064c-18.757-11.03-39.81-16.472-60.875-16.406zm-103.314 59.156c-22.027 37.48-22.31 84.238-.25 121.75l45.75-45.75c-2.56-10.002-2.73-20.594-.094-30.625l-45.406-45.374zm206.938 0l-45.75 45.75c2.556 10.007 2.73 20.565.094 30.594l45.406 45.406c22.03-37.48 22.312-84.24.25-121.75zM360.906 433.844l-45.75 45.75c37.514 22.06 84.27 21.788 121.75-.25L391.5 433.938V434c-10.03 2.64-20.592 2.45-30.594-.156z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

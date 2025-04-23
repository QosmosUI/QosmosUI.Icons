// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiFireBreath : ComponentBase
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
		builder.AddAttribute(14, "d", "M19.563 17.5l1.718 345.656c15.677 8.52 35.932 6.66 49.75-1.625 7.5-4.494 12.795-10.567 14.97-17.03 2.175-6.463 1.855-13.602-3.625-22.688-58.988-97.785-45.843-189.42 5.688-240.843 51.53-51.424 140.25-61.073 224.687-1.626 13.64 9.602 20.366 9.61 24.594 7.656 4.227-1.954 8.902-8.547 12.594-18.72 3.69-10.17 6.408-22.988 9.312-34.81 1.32-5.38 2.57-10.488 4.156-15.282L19.562 17.5zm172.625 39.28c-4.418.057-8.753.3-13.032.75l98.97 66.69 16.53-34.595c-35.624-23.28-70.743-33.247-102.47-32.844zm-65.72 17.94c-9.217 5.424-17.68 11.976-25.218 19.5-12.852 12.824-23.157 28.612-30 46.78 71.867 74.02 173.938 182.317 76.313 160.344 30.6 28.633 137.543 49.855 149.593 98.094 10.005 40.048-25.533 71.875-55.78 71.875-40.617 0-82.835-32.52-44.876-70.157-24.106 4.008-35.584 21.004-36.22 40.25-.633 19.247 9.704 40.793 29.345 54.063h303.03V170c-7.068-59.46-121.172-84.22-119.03 3.47 23.285-55.158 65.423 9.63 52.906 56.343-9.737 36.35-42.167 58.896-88.31 29.218-106.057-68.21-78.403-101.62-132.126-157.342 17.683 74.736-32.005 32.17-79.625-26.97zM61.845 195c.08 32.478 9.46 69.05 31.093 107.844l22.126-13.125L61.843 195z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

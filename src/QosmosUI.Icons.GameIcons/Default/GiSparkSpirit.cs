// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSparkSpirit : ComponentBase
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
		builder.AddAttribute(14, "d", "M420.402 19.873c37.886 49.484 19.76 88.205-39.797 90.787 15.374-23.54 18.565-50.758-1.503-72.215 15.56 37.318-14.397 62.848-50.137 67.096-4.39-.934-8.887-1.99-13.508-3.19-60.132-15.624-114.527 22.936-137.37 78.923-.43-34.33 9.72-68.377 29.83-102.152-50.37 35.038-75.926 89.323-72.616 166.003l-59.41-65.365L89.55 374.43 254.15 494.025 392.703 389.54l52.584-196.853-93.224 72.415c-23.56-25.652-13.02-55.2 33.736-50.293-38.077-22.19-64.97-2.473-75.952 24.356-5.608-27.825 18.206-63.122 50.218-58.686 76.728 10.638 151.882-107.834 60.336-160.607zM119.838 272.05l94.777 73.214-103.095-21.22 29.263-3.05-20.945-48.943zm255.48 12.237l-10.623 25.262 27.8-.28-12.095 23.437-96.25 14.438 91.168-62.858zM204.305 360.13l42.256 62.552 11.247-44.094 17.84 32.598 56.574-48.54-7.23 24.368 51.71-21.274-54.485 61.82 9.654-29.966-76.21 71.62-47.574-55.136 3.176 27.483-74.627-77.593 61.166 29.998 6.505-33.834z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

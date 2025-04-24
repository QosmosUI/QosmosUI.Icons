// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiNuclear : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 31c-26.498 0-79.5 26.92-79.5 53.844S203.003 165.62 256 219.47c52.997-53.85 79.5-107.702 79.5-134.626C335.5 57.92 282.498 31 256 31zm1.53 215.406A52.997 53.847 0 0 0 203 300.25a52.997 53.847 0 0 0 106 0 52.997 53.847 0 0 0-51.47-53.844zm-166.155 80.47c-26.704.12-47.245 4.393-58.72 11.124-22.947 13.462-19.373 73.558-6.124 96.875 13.25 23.317 62.678 56.493 85.626 43.03 22.95-13.46 55.602-63.722 75-137.28-36.197-9.855-69.077-13.87-95.78-13.75zm329.25 0c-26.704-.122-59.584 3.894-95.78 13.75 19.397 73.557 52.05 123.818 75 137.28 22.947 13.462 72.375-19.714 85.624-43.03 13.248-23.318 16.822-83.414-6.126-96.876-11.474-6.73-32.015-11.004-58.72-11.125z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

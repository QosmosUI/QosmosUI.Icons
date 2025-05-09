// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoHeartDislikeOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M417.84,448a15.94,15.94,0,0,1-11.35-4.72L40.65,75.26A16,16,0,0,1,63.35,52.7l365.83,368A16,16,0,0,1,417.84,448Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M364.92,80c-48.09,0-80,29.55-96.92,51-16.88-21.48-48.83-51-96.92-51a107.37,107.37,0,0,0-31,4.55L168,112c22.26,0,45.81,9,63.94,26.67a123,123,0,0,1,21.75,28.47,16,16,0,0,0,28.6,0,123,123,0,0,1,21.77-28.51C322.19,121,342.66,112,364.92,112c43.15,0,78.62,36.33,79.07,81,.54,53.69-22.75,99.55-57.38,139.52l22.63,22.77c3-3.44,5.7-6.64,8.14-9.6,40-48.75,59.15-98.8,58.61-153C475.37,130.52,425.54,80,364.92,80Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M268,432C180.38,372.51,91,297.6,92,193a83.69,83.69,0,0,1,2.24-18.39L69,149.14a115.1,115.1,0,0,0-9,43.49c-.54,54.22,18.63,104.27,58.61,153,18.77,22.87,52.8,59.45,131.39,112.8a31.84,31.84,0,0,0,36,0c20.35-13.81,37.7-26.5,52.58-38.11l-22.66-22.81C300.25,409.6,284.09,421.05,268,432Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

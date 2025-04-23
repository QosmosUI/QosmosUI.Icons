// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBarbedNails : ComponentBase
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
		builder.AddAttribute(14, "d", "M14.922 14.21V197.01c105.426 65.67 171.442 156.49 109.213 299.017 71.456-76.97 99.707-180.437 72.418-273.904l-43.217 28.034c-8.593-32.65-25.23-63.915-44.04-88.097-18.808-24.182-35.91-41.747-54.142-58.317l12.57-13.83c26.36 23.958 50.918 50.426 71.26 81.727 122.584 56.688 209.387 144.066 155.1 301.027 65.208-82.512 85.325-187.03 50.81-277.992l-41.466 30.37c-9.225-26.42-23.88-51.128-43.455-74.562-31.626-34.863-68.584-59.443-108.29-79.904l8.56-16.61c46.226 23.82 90.127 53.793 126.312 98.87C399.033 189.56 479.498 260.64 456.44 409.59c49.442-93.163 50.723-200.15.585-283.248l-35.04 38.547C379.276 89.6 288.66 35.463 159.76 14.21H14.924z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

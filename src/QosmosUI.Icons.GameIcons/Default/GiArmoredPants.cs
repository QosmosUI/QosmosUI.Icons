// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiArmoredPants : ComponentBase
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
		builder.AddAttribute(14, "d", "M89.452 32v44.667l166.75 28.9 166.75-28.9V32l-166.75 28.902L89.452 32zm-.405 69.444v186.712c49.478 16.004 90.187 8.72 139.67 0 1.14-34.244 12.925-60.635 27.09-60.672 14.165.04 25.95 26.428 27.09 60.672 49.472 16.003 90.173 8.72 139.65 0V101.444l-166.74 28.813-166.76-28.813zm0 212.25V382.88c45.914 7.332 85.747 13.896 131.648 0V313.694c-45.915 7.33-85.747 13.895-131.648 0zm201.853 0V382.88c45.914 7.332 85.747 13.896 131.648 0V313.694c-45.915 7.33-85.747 13.895-131.648 0zm-198.44 94.55v64.2c43.532 6.802 81.302 12.893 124.823 0v-64.2c-43.534 6.8-81.303 12.893-124.824 0zm201.854 0v64.2c43.533 6.802 81.3 12.893 124.822 0v-64.2c-43.534 6.8-81.3 12.893-124.822 0z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCalculator : ComponentBase
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
		builder.AddAttribute(14, "d", "M95 25v462h322V25H95zm193 18h80v18h-80V43zM114 83h284v84H114V83zm22 46v18h88v-18h-88zm-22 54h58v58h-58v-58zm76 0h58v58h-58v-58zm74 0h58v58h-58v-58zm76 0h58v58h-58v-58zm-208 18v22h22v-22h-22zm76 0v22h22v-22h-22zm74 0v22h22v-22h-22zm76 0v22h22v-22h-22zm-244 56h58v58h-58v-58zm76 0h58v58h-58v-58zm74 0h58v58h-58v-58zm76 0h58v58h-58v-58zm-208 18v22h22v-22h-22zm76 0v22h22v-22h-22zm74 0v22h22v-22h-22zm76 0v22h22v-22h-22zm-244 56h58v58h-58v-58zm76 0h58v58h-58v-58zm74 0h58v58h-58v-58zm76 0h58v132h-58V331zm-208 18v22h22v-22h-22zm76 0v22h22v-22h-22zm74 0v22h22v-22h-22zm76 0v96h22v-96h-22zm-244 56h58v58h-58v-58zm76 0h58v58h-58v-58zm74 0h58v58h-58v-58zm-132 18v22h22v-22h-22zm76 0v22h22v-22h-22zm74 0v22h22v-22h-22z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

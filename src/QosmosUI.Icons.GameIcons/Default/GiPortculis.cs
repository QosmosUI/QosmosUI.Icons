// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiPortculis : ComponentBase
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
		builder.AddAttribute(14, "d", "M98.156 22.656V438.53H79.72l30.53 58.064 30.53-58.063h-17.218v-63.467H152.5v-36.344h-28.938V269.06H152.5V232.75h-28.938v-69.625H152.5V126.78h-28.938V58.845H152.5V22.656H98.156zm73.03 0V438.53h-15.624l30.532 58.064 30.53-58.063h-17.718v-63.467h26.625v-36.344h-26.624V269.06h26.625V232.75h-26.624v-69.625h26.625V126.78h-26.624V58.845h26.625V22.656h-54.343zm73.033 0V438.53H230l30.53 58.064 30.533-58.063H272.5v-63.467h29.594v-36.344H272.5V269.06h29.594V232.75H272.5v-69.625h29.594V126.78H272.5V58.845h29.594V22.656H244.22zm76.56 0V438.53h-15.56l30.53 58.064 30.563-58.063h-17.907v-63.467h27.25v-36.344h-27.25V269.06h27.25V232.75h-27.25v-69.625h27.25V126.78h-27.25V58.845h27.25V22.656H320.78zm73.564 0V438.53h-14.688l30.563 58.064 30.53-58.063H422V22.657h-27.655z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiMineralHeart : ComponentBase
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
		builder.AddAttribute(14, "d", "M182.344 19.906L28.78 173.47 255.626 487.5 481.938 174 328.375 20.47l-72.75 72.75-73.28-73.314zm-.938 27.75L188 54.28l67.625 67.626L323.25 54.28l6.625-6.624 6.594 6.625L452.56 170.376l5.625 5.625-4.656 6.438-190.31 263.78-7.595 10.5-7.563-10.5L57.72 182.44 53.062 176l5.624-5.625L174.78 54.28l6.626-6.624zm0 26.438L77.53 177.97l178.095 246.81L433.72 177.97 329.874 74.093l-61 60.97 66 66 6.594 6.592-6.595 6.625-78.25 78.25-6.625 6.626-6.594-6.625-78.25-78.25 13.188-13.218L250 272.72l65.063-65.033-59.407-59.406-.03.032-6.595-6.593-67.624-67.626zm1.406 24.78l109.032 109.032-13.22 13.22-109.03-109.032 13.22-13.22zm147.97 0l81.437 81.407L399 193.5l-81.406-81.406 13.187-13.22z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

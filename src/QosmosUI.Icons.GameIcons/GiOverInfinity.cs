// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiOverInfinity : ComponentBase
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
		builder.AddAttribute(14, "d", "M256.938 21.938c-8.8 0-17.504 5.467-24.625 16.406-7.122 10.938-11.938 26.954-11.938 44.78 0 17.828 4.816 33.813 11.938 44.75 7.12 10.94 15.825 16.407 24.625 16.407s17.503-5.467 24.625-16.405c7.12-10.938 11.937-26.923 11.937-44.75s-4.816-33.843-11.938-44.78c-7.12-10.94-15.825-16.407-24.625-16.407zm-92.907 53L24.845 263.313 164.03 451.719l93.282-126.283.063.063 89.063-120.563 7.53-10.187 7.5 10.188 46.407 62.78-15.03 11.126-38.876-52.625-85 115.03 81.624 110.47L489.78 263.31 350.595 74.938l-93.28 126.25-.127-.156-90.812 122.94-7.5 10.186-7.53-10.187-46.407-62.783 15.03-11.125 38.876 52.625 86.75-117.375L164.03 74.938z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

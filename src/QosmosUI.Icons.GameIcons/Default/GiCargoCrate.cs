// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCargoCrate : ComponentBase
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
		builder.AddAttribute(14, "d", "M247 16v89h9c14.9 0 23 11.7 23.8 23.6.4 6-1.2 11.5-4.7 15.4-3.5 4-9.1 7-19.1 7-5 0-11.1-2.8-15.6-7.4-4.6-4.5-7.4-10.6-7.4-15.6h-18c0 11 5.2 20.9 12.6 28.4 7.5 7.4 17.4 12.6 28.4 12.6 14 0 25.4-5 32.5-13 7.2-8.1 10-18.6 9.3-28.6-1.2-17.5-13.4-35.18-32.8-39.42V16h-18zm-47.9 140.5L61.34 247h32.7l114.86-75.5-9.8-15zm113.8 0l-9.8 15L418 247h32.6l-137.7-90.5zM41 265v222h430V265H41zm38 23h18v176H79V288zm48 0h18v176h-18V288zm48 0h18v176h-18V288zm48 0h18v176h-18V288zm48 0h18v176h-18V288zm48 0h18v176h-18V288zm48 0h18v176h-18V288zm48 0h18v176h-18V288z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

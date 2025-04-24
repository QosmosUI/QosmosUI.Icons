// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCoalWagon : ComponentBase
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
		builder.AddAttribute(14, "d", "M304 64c-23.723 1.039-64 32-96 48-32-10.667-79.124-37.34-96-32-22.196 7.024-47.374 44.154-71.533 71h435.719C467.4 130.604 444.747 80.887 432 80c-15.998-1.113-80 48-80 48-16-21.333-36.57-64.5-48-64zM27.133 169l44.144 206H119V169H27.133zM137 169v14h46v-14h-46zm64 0v206h239.725l44.142-206H201zm-64 32v14h46v-14h-46zm0 32v14h46v-14h-46zm0 32v14h46v-14h-46zm0 32v14h46v-14h-46zm0 32v14h46v-14h-46zm0 32v14h46v-14h-46zM25 393v30h462v-30H25zm11.822 48C34.387 445.436 33 450.543 33 456c0 17.227 13.773 31 31 31s31-13.773 31-31c0-5.457-1.387-10.564-3.822-15H36.822zm80 0c-2.435 4.436-3.822 9.543-3.822 15 0 17.227 13.773 31 31 31s31-13.773 31-31c0-5.457-1.387-10.564-3.822-15h-54.356zm81.74 0l15 30h84.875l15-30H198.563zm142.26 0c-2.435 4.436-3.822 9.543-3.822 15 0 17.227 13.773 31 31 31s31-13.773 31-31c0-5.457-1.387-10.564-3.822-15h-54.356zm80 0c-2.435 4.436-3.822 9.543-3.822 15 0 17.227 13.773 31 31 31s31-13.773 31-31c0-5.457-1.387-10.564-3.822-15h-54.356z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

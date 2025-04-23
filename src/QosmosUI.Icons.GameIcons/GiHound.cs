// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiHound : ComponentBase
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
		builder.AddAttribute(14, "d", "M137.75 17.28l-15.313 78.782 20.313 56.876h45.97L137.75 17.28zM74.5 19L20 378.156v116.156h208L210.125 386.5H113.28l-2.218-6.156-25.78-71.594 17.562-6.344 23.562 65.406h90.344l230.688-2.968 9.812-33.406H278.5V312.75h184.22l7.374-25.156L415.53 209.5H291.47l-20.345-37.594h-75.28l-.095-.28h-46.313L159.563 200l-17.593 6.28-26.532-74.25-.126.72L74.5 19zm133.375 178.22h56.094l21.405 38.874-26.094-.438-51.405-38.437zm230.47 12.28l38.53 55.094L493.03 209.5h-54.686zm-82.814 15.938c6.613 0 11.97 5.356 11.97 11.968 0 6.613-5.357 11.97-11.97 11.97-6.61 0-11.967-5.357-11.967-11.97 0-6.612 5.356-11.97 11.968-11.97zm44.595 0c6.612 0 12 5.356 12 11.968 0 6.613-5.388 11.97-12 11.97s-11.97-5.357-11.97-11.97c0-6.612 5.358-11.97 11.97-11.97zm-66.188 29.187c6.612 0 11.97 5.356 11.97 11.97 0 6.61-5.358 11.967-11.97 11.967-6.61 0-11.968-5.356-11.968-11.968 0-6.613 5.356-11.97 11.967-11.97zm43.125 0c6.612 0 12 5.356 12 11.97 0 6.61-5.388 11.967-12 11.967-6.61 0-11.968-5.356-11.968-11.968 0-6.613 5.357-11.97 11.97-11.97zm42.063 0c6.612 0 11.97 5.356 11.97 11.97 0 6.61-5.358 11.967-11.97 11.967-6.612 0-11.97-5.356-11.97-11.968 0-6.613 5.358-11.97 11.97-11.97z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

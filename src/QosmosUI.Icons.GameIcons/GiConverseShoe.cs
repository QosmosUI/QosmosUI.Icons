// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiConverseShoe : ComponentBase
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
		builder.AddAttribute(14, "d", "M42.63 89c8.3 49.2 17.42 100.1 14.35 151.5-2.9 48.8-28.19 92.8-31.58 134.5h319.7c5.3-16.4 16.2-30.9 28.3-42.1 4.2-3.9 8.5-7.5 12.8-10.6-34.9-9.7-61.7-24-82.5-41.3H244v-18h41c-8.5-9.5-15.7-19.6-21.7-30H208v-18h46c-4.6-9.9-8.4-19.9-11.7-30H192v-18h44.8c-2.8-10.1-5.3-20.2-7.6-30H176v-18h49c-2.4-10.5-4.9-20.54-7.7-30H42.63zM128 215c31.4 0 57 25.6 57 57s-25.6 57-57 57c-31.37 0-57-25.6-57-57s25.63-57 57-57zm0 18c-21.6 0-39 17.4-39 39s17.4 39 39 39 39-17.4 39-39-17.4-39-39-39zm287.6 96c-5 .3-18.6 6.5-30 17.1-8.7 8-16.5 18.3-21.2 28.9H448c11.5 0 25.6-5.7 38.6-12.3-.4-4.2-1-7.7-2.2-10-1.6-3.3-3.9-5.7-8.7-8.3-9.6-5.2-28.9-9.5-60.1-15.4zm71.4 52.9c-2 .9-3.4 1.6-5.7 2.5C471 388.5 459 393 448 393H25v30h407c22.2 0 45.3-8.7 55-12.8v-28.3z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

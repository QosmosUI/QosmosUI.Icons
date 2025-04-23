// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiArtificialHive : ComponentBase
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
		builder.AddAttribute(14, "d", "M251.313 23.844L49.438 140.25l-.376 233.5 202.625 116.406L453.563 373.75l.375-233.5L251.313 23.844zm-1.407 57.062l52.406 30.25v60.5l-52.406 30.25-52.406-30.25v-60.5l52.406-30.25zm-105.344 60.47l52.407 30.25v60.5l-52.407 30.25 52.406 30.25v60.53l-52.407 30.25-52.407-30.25v-60.53l52.406-30.25-52.406-30.25v-60.5l52.406-30.25zm210.313 0l52.406 30.25v60.5l-52.405 30.25 52.406 30.25v60.53l-52.405 30.25-52.406-30.25v-60.53l52.405-30.25-52.406-30.25v-60.5l52.405-30.25zM249.905 202l52.407 30.25v60.5l-52.28 30.188 52.28 30.156v60.53l-52.406 30.25-52.406-30.25v-60.53l52.28-30.156-52.28-30.188v-60.5L249.906 202z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

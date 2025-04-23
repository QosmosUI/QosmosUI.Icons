// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPlayerTime : ComponentBase
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
		builder.AddAttribute(14, "d", "M119.7 22.8c-23.36 3.1-44.58 30.5-44.58 66 0 19.5 6.78 36.8 16.69 48.8l11.79 14.2-18.2 3.4c-12.86 2.5-22.31 9.3-30.39 20.4-8.09 11.1-14.27 26.5-18.6 44.4-7.84 32.2-9.58 71.6-9.84 106.4h42.86L81.2 484.2c29.9 6.8 61.8 6.5 90.6 0l10.4-157.8H223c0-35.2-.5-75.1-7.6-107.7-3.9-17.9-9.8-33.3-18-44.3s-18.1-17.7-32.6-20l-18.6-2.9 11.8-14.7c9.5-11.9 15.9-29 15.9-48 0-37.9-23.7-65.9-49.4-65.9zm141.7 30.62v18h224v-18zm16 39c0 47.98 48 159.98 96 159.98s96-112 96-159.98zm96 179.98c-48 0-96 112-96 160h192c0-48-48-160-96-160zm-112 181v18h224v-18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

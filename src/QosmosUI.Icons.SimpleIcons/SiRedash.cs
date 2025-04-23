// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiRedash : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M12 0C6.775 0 2.546 4.238 2.546 9.455c0 4.971 3.842 9.05 8.727 9.423V24c3.405-3.49 5.837-6.072 7.307-7.756a9.5 9.5 0 0 0 1.532-1.93l.005-.006q.003-.007.007-.014a9.4 9.4 0 0 0 1.33-4.84C21.455 4.238 17.226 0 12 0m3.821 5.818h1.385c.337.001.611.25.612.558v6.157c-.001.308-.275.557-.612.558H15.82c-.337-.001-.611-.25-.612-.558V6.376c0-.307.275-.557.612-.558M9.297 7.921h1.386c.338 0 .611.25.613.558v4.054c-.002.308-.275.557-.613.558H9.297c-.337-.001-.61-.25-.61-.558V8.479c0-.308.273-.558.61-.558m3.222 1.534h1.396c.337 0 .61.25.61.558v2.52c0 .308-.273.557-.61.558h-1.396c-.338-.001-.612-.25-.613-.558v-2.52c.001-.308.275-.558.613-.558M6.067 10.71h1.396c.337.001.61.25.61.559v1.264c0 .308-.273.557-.61.558H6.067c-.338-.001-.611-.25-.612-.558v-1.264c0-.308.274-.558.612-.559");
		builder.CloseElement();
		builder.CloseElement();
    }
}

// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiFlathub : ComponentBase
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
		builder.AddAttribute(15, "d", "M6.068 0a6 6 0 0 0-6 6 6 6 0 0 0 6 6 6 6 0 0 0 5.998-6 6 6 0 0 0-5.998-6Zm9.15.08a1.656 1.656 0 0 0-1.654 1.656v8.15a1.656 1.656 0 0 0 2.483 1.434l7.058-4.074a1.656 1.656 0 0 0 0-2.869l-1.044-.604-6.014-3.47a1.656 1.656 0 0 0-.828-.223Zm3.575 13.135a.815.815 0 0 0-.816.818v2.453h-2.454a.817.817 0 1 0 0 1.635h2.454v2.453a.817.817 0 1 0 1.635 0v-2.453h2.452a.817.817 0 1 0 0-1.635h-2.453v-2.453a.817.817 0 0 0-.818-.818zM2.865 13.5a2.794 2.794 0 0 0-2.799 2.8v4.9c0 1.55 1.248 2.8 2.8 2.8h4.9c1.55 0 2.8-1.25 2.8-2.8v-4.9c0-1.55-1.25-2.8-2.8-2.8Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

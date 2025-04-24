// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiKlook : ComponentBase
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
		builder.AddAttribute(15, "d", "M4.8 0A4.79 4.79 0 0 0 0 4.8v14.4C0 21.86 2.14 24 4.8 24h14.4c2.66 0 4.8-2.14 4.8-4.8V4.8C24 2.14 21.86 0 19.2 0H4.8zM12 3.449v.001c4.242 0 7.833 1.904 7.833 6.17 0 2.932-3.86 7.815-6.164 10.164-.99 1.008-2.32 1.036-3.338 0-2.303-2.349-6.164-7.232-6.164-10.164 0-4.162 3.476-6.171 7.833-6.171zm3.54 2.155l-5.05 4.96 5.05 4.956a1.84 1.84 0 0 0 0-2.634v-.001l-2.366-2.323 2.366-2.323a1.84 1.84 0 0 0 0-2.635zm-7.349.144v9.772a1.86 1.86 0 0 0 1.868-1.852V7.602a1.86 1.86 0 0 0-1.866-1.854h-.002z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

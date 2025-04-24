// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImGrin : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M8 16c4.418 0 8-3.582 8-8s-3.582-8-8-8-8 3.582-8 8 3.582 8 8 8zM8 1.5c3.59 0 6.5 2.91 6.5 6.5s-2.91 6.5-6.5 6.5-6.5-2.91-6.5-6.5 2.91-6.5 6.5-6.5zM3 8v1c0 2.2 1.8 4 4 4h2c2.2 0 4-1.8 4-4v-1h-10zM6 11.828c-0.415-0.148-0.796-0.388-1.118-0.71-0.569-0.569-0.882-1.321-0.882-2.118h2v2.828zM9 12h-2v-3h2v3zM11.118 11.118c-0.322 0.322-0.703 0.562-1.118 0.71v-2.828h2c0 0.797-0.313 1.549-0.882 2.118zM3.521 6c0 0 0 0 0 0 0.153 0 0.283-0.11 0.308-0.261 0.096-0.573 0.589-0.989 1.171-0.989s1.074 0.416 1.171 0.989c0.025 0.151 0.156 0.261 0.308 0.261s0.283-0.11 0.308-0.261c0.017-0.101 0.025-0.202 0.025-0.302 0-0.999-0.813-1.813-1.813-1.813s-1.813 0.813-1.813 1.813c0 0.1 0.009 0.201 0.025 0.302 0.025 0.151 0.156 0.261 0.308 0.261zM9.521 6c0 0 0 0 0 0 0.153 0 0.283-0.11 0.308-0.261 0.096-0.573 0.589-0.989 1.171-0.989s1.074 0.416 1.171 0.989c0.025 0.151 0.156 0.261 0.308 0.261s0.283-0.11 0.308-0.261c0.017-0.101 0.025-0.202 0.025-0.302 0-0.999-0.813-1.813-1.813-1.813s-1.813 0.813-1.813 1.813c0 0.1 0.008 0.201 0.025 0.302 0.025 0.151 0.156 0.261 0.308 0.261z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

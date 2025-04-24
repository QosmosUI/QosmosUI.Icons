// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiScrapy : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0C5.373 0 0 5.373 0 12c0 6.628 5.373 12 12 12 6.628 0 12-5.372 12-12 0-6.627-5.372-12-12-12Zm0 1.113c6.003 0 10.887 4.884 10.887 10.887S18.003 22.887 12 22.887 1.113 18.003 1.113 12 5.997 1.113 12 1.113Zm7.03 5.201c-.536-.002-1.28.304-2.255 1.098-1.052.858-3.814 3.045-3.814 3.045l1.025 1.3c4.694-2.558 6.19-3.167 6.116-4.294-.042-.634-.384-1.146-1.073-1.149Zm-.507.752c.147 0 .266.106.266.239 0 .132-.119.238-.266.238-.146 0-.265-.106-.265-.238 0-.171.162-.239.265-.239zm-1.58 1.489c0 .131-.118.238-.265.238-.147 0-.264-.107-.264-.238 0-.128.11-.234.24-.24.13-.006.29.077.29.24zm-2.109 1.01c.147 0 .266.106.266.238s-.12.238-.266.238c-.146 0-.266-.106-.266-.238 0-.148.139-.239.266-.239zm-2.445.972c-1.502.225-5.807.992-8.01 2.672l3.574 5.387s4.706-2.932 5.863-6.244z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

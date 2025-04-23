// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiTeespring : ComponentBase
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
		builder.AddAttribute(15, "d", "M15.78 8.348c-.77 0-1.396.615-1.396 1.37 0 1.075.406 2.058 1.075 2.813.277.312.598.584.956.807a5 5 0 0 0 .736-3.874c-.005-.029-.013-.058-.02-.087a1.392 1.392 0 0 0-1.35-1.029zm-8.612 3.958c.138.366.317.712.533 1.032.356-.223.678-.495.955-.807a4.221 4.221 0 0 0 1.076-2.813c0-.755-.626-1.37-1.397-1.37-.65 0-1.195.438-1.35 1.029-.006.029-.015.057-.02.086a5.002 5.002 0 0 0 .205 2.843zm15.501-.67L24 12.29a5.873 5.873 0 0 1-5.243 3.18 5.958 5.958 0 0 1-1.926-.32 6.745 6.745 0 0 1-4.774 1.963 6.742 6.742 0 0 1-4.774-1.964 5.943 5.943 0 0 1-1.926.32A5.87 5.87 0 0 1 0 12.054l1.362-.595a4.38 4.38 0 0 0 3.995 2.549c.324 0 .641-.036.946-.102a6.45 6.45 0 0 1-.945-3.367 6.512 6.512 0 0 1 .19-1.554c.328-1.208 1.45-2.098 2.786-2.098l.079.002c.08.002.162.008.242.016 1.444.157 2.565 1.357 2.565 2.814 0 1.958-.999 3.687-2.522 4.724a5.244 5.244 0 0 0 3.36 1.21 5.247 5.247 0 0 0 3.358-1.21c-1.523-1.037-2.522-2.767-2.522-4.724 0-1.458 1.122-2.658 2.564-2.814.08-.008.16-.014.242-.016l.08-.002a2.877 2.877 0 0 1 2.832 2.286 6.478 6.478 0 0 1-.8 4.733c.305.066.62.102.945.102 1.71 0 3.191-.967 3.91-2.372z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

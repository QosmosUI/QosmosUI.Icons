// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaUmbraco : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 510 512";

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
		builder.AddAttribute(14, "d", "M255.35 8C118.36 7.83 7.14 118.72 7 255.68c-.07 137 111 248.2 248 248.27 136.85 0 247.82-110.7 248-247.67S392.34 8.17 255.35 8zm145 266q-1.14 40.68-14 65t-43.51 35q-30.61 10.7-85.45 10.47h-4.6q-54.78.22-85.44-10.47t-43.52-35q-12.85-24.36-14-65a224.81 224.81 0 0 1 0-30.71 418.37 418.37 0 0 1 3.6-43.88c1.88-13.39 3.57-22.58 5.4-32 1-4.88 1.28-6.42 1.82-8.45a5.09 5.09 0 0 1 4.9-3.89h.69l32 5a5.07 5.07 0 0 1 4.16 5 5 5 0 0 1 0 .77l-1.7 8.78q-2.41 13.25-4.84 33.68a380.62 380.62 0 0 0-2.64 42.15q-.28 40.43 8.13 59.83a43.87 43.87 0 0 0 31.31 25.18A243 243 0 0 0 250 340.6h10.25a242.64 242.64 0 0 0 57.27-5.16 43.86 43.86 0 0 0 31.15-25.23q8.53-19.42 8.13-59.78a388 388 0 0 0-2.6-42.15q-2.48-20.38-4.89-33.68l-1.69-8.78a5 5 0 0 1 0-.77 5 5 0 0 1 4.2-5l32-5h.82a5 5 0 0 1 4.9 3.89c.55 2.05.81 3.57 1.83 8.45 1.82 9.62 3.52 18.78 5.39 32a415.71 415.71 0 0 1 3.61 43.88 228.06 228.06 0 0 1-.04 30.73z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

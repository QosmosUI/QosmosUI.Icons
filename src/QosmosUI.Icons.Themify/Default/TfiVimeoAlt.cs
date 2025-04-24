// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiVimeoAlt : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.OpenElement(13, "g");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M16.132 2.301c-0.58-0.736-1.796-0.764-2.645-0.637-0.68 0.113-2.998 1.131-3.777 3.579 1.387-0.113 2.12 0.101 1.98 1.627-0.058 0.65-0.383 1.344-0.736 2.024-0.426 0.776-1.201 2.305-2.235 1.201-0.919-0.99-0.863-2.885-1.060-4.144-0.129-0.708-0.255-1.585-0.482-2.32-0.199-0.623-0.666-1.371-1.216-1.542-0.608-0.171-1.359 0.099-1.797 0.353-1.389 0.822-2.306 1.982-3.664 2.943v0.1c0.452 0.227 0.312 0.594 0.665 0.651 0.835 0.112 1.625-0.78 2.179 0.154 0.339 0.565 0.438 1.188 0.649 1.798 0.296 0.819 0.511 1.711 0.75 2.645 0.396 1.6 0.878 3.975 2.263 4.557 0.695 0.297 1.756-0.1 2.279-0.426 1.441-0.85 2.59-2.080 3.536-3.352 2.221-2.973 3.424-6.367 3.608-7.343 0.127-0.666 0.113-1.345-0.297-1.868z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

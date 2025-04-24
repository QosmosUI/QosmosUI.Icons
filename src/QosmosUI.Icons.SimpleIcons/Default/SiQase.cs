// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiQase : ComponentBase
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
		builder.AddAttribute(15, "d", "M23.85 18.994s-.802.46-1.795.28c-.19-.03-.37-.1-.551-.19a11.768 11.768 0 0 0 2.367-7.088C23.87 5.428 18.525.1 11.935.1S0 5.428 0 11.996c0 6.568 5.346 11.897 11.935 11.897 2.087 0 4.042-.54 5.747-1.47.562.59 1.344 1.21 2.297 1.4 1.796.34 3.1-.48 3.631-1.58.451-.96.482-2.1.24-3.249m-11.925-.13c-3.79 0-6.88-3.079-6.88-6.858 0-3.779 3.09-6.858 6.88-6.858 3.792 0 6.89 3.07 6.89 6.848 0 1.16-.29 2.26-.812 3.22-.15-.19-.28-.37-.37-.49-.352-.48-.713-.97-1.064-1.47-.461-.65-1.524-1.95-2.989-2.23-1.795-.34-3.099.48-3.63 1.58-.452.96-.482 2.1-.251 3.239 0 0 .802-.46 1.795-.28.722.13 1.404.68 2.277 1.76.07.09.371.49.772 1.01-.802.34-1.685.53-2.618.53");
		builder.CloseElement();
		builder.CloseElement();
    }
}

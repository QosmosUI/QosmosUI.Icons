// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiPrimeng : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0 .784 3.984l1.711 14.772L12 24l9.506-5.244 1.71-14.772ZM8.354 4.212h1.674L9.19 6.124l-2.51-.24Zm2.032 0h1.315v6.812h-.717L5.843 9.112l-.717-2.988 4.308.35Zm1.794 0h1.314l.953 2.261 4.427-.349-.717 2.988-5.14 1.912h-.837Zm1.673 0h1.674L17.2 5.885l-2.51.239zM5.963 9.59l1.315.478 1.315 1.315 1.076-.24-.837 1.196v3.704l-2.87-2.39zm11.955 0v4.063l-2.87 2.39v-3.704l-.837-1.195 1.077.239 1.314-1.315zm-7.786 1.536.596.36h2.384l.597-.36.953 1.437v5.388l-.715 1.078-.835.838h-2.384l-.834-.838-.715-1.078v-5.388zm-2.854 4.08 1.554 1.315v1.793L7.278 16.76Zm9.324 0v1.554l-1.553 1.554V16.52z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

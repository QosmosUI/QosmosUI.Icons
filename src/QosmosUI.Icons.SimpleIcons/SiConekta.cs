// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiConekta : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.2914 17.8831a11.7327 11.7327 0 0 1-6.1742 3.0338 2.4598 2.4598 0 0 1-2.1647-.7461c-4.2466-4.6258-4.2466-11.7322 0-16.358a2.4599 2.4599 0 0 1 2.1729-.7461 11.668 11.668 0 0 1 6.289 3.1404 27.1655 27.1655 0 0 0-.6969 6.1004 27.7762 27.7762 0 0 0 .5739 5.5756zm9.8962-3.9376a1.394 1.394 0 0 0-1.5244.5266 24.6804 24.6804 0 0 1-11.9139 8.9375 35.4417 35.4417 0 0 0 6.4284.5903 36.2857 36.2857 0 0 0 4.4605-.2788 3.5997 3.5997 0 0 0 3.0338-2.6977c.4692-1.884.6453-3.8838.5166-5.8134a1.394 1.394 0 0 0-1.001-1.2645zm-1.5245-4.3356a1.394 1.394 0 0 0 2.5255-.7462c.1354-1.9699-.0438-3.9689-.5166-5.8872A3.5997 3.5997 0 0 0 19.6382.2789 36.2678 36.2678 0 0 0 15.1776 0a35.4337 35.4337 0 0 0-6.4284.5904 24.6396 24.6396 0 0 1 11.9139 9.0195z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiInputCheckedOutline : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M19.885 6.177c-.221-.771-.728-1.409-1.427-1.798-.445-.248-.949-.379-1.457-.379-.862 0-1.661.381-2.219 1h-6.782c-1.654 0-3 1.346-3 3v8c0 1.654 1.346 3 3 3h8c1.654 0 3-1.346 3-3v-6.454l.622-1.088c.39-.7.482-1.51.263-2.281zm-3.758.338c.104-.189.27-.328.459-.416.301-.113.623-.127.9.027.232.13.402.343.476.6.033.117.039.236.03.353-.012.115-.043.227-.092.332l-.021.065-4.006 7.011c-.151.273-.427.461-.742.506l-.132.009c-.267 0-.518-.104-.707-.293l-3-3c-.39-.39-.39-1.024 0-1.414.189-.189.44-.293.707-.293s.518.104.707.293l1.125 1.125.92.92.652-1.125 2.724-4.7zm-.127 10.485h-8c-.552 0-1-.449-1-1v-8c0-.551.448-1 1-1h6.689l-2.15 3.712-1.125-1.125c-.391-.391-.902-.586-1.414-.586s-1.023.195-1.414.586c-.781.781-.781 2.047 0 2.828l3 3c.378.378.888.586 1.414.586l.277-.02c.621-.087 1.166-.461 1.471-1.01l2.252-3.94v4.969c0 .551-.448 1-1 1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

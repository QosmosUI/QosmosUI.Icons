// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.AntDesignIcons.Outline;

public class AiOutlineJavaScript : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 1024 1024";

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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M353 16H192.545v425.615c0 105.313-36.166 134.718-99.104 134.718-29.494 0-56.055-5.05-76.718-12.144L0 688.784C29.484 698.924 74.73 705 110.126 705 254.631 705 353 637.16 353 442.658zM702.49 0C547.26 0 449 88.126 449 204.609c0 100.313 75.67 163.12 185.696 203.629 79.577 28.358 111.03 53.695 111.03 95.218 0 45.579-36.358 74.96-105.13 74.96-63.868 0-121.849-21.311-161.146-42.573v-.042L449 662.427C486.361 683.735 556.12 705 631.741 705 813.52 705 898 607.753 898 493.293c0-97.243-54.036-160.035-170.937-204.627-86.47-34.432-122.813-53.669-122.813-97.227 0-34.45 31.446-65.834 96.3-65.834 63.834 0 107.728 21.445 133.307 34.632L872.193 32.05C832.103 14.461 778.109 0 702.49 0");
		builder.AddAttribute(16, "transform", "translate(63 160)");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}

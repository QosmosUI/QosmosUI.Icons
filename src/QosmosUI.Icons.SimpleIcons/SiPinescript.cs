// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiPinescript : ComponentBase
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
		builder.AddAttribute(15, "d", "M3.785 16.14.124 21.287c-.311.437 0 1.044.536 1.044h22.681c.535 0 .846-.608.536-1.045l-4.2-5.927-1.979 1.161c-.037 1.063-.907 1.913-1.976 1.913-1.092 0-1.977-.887-1.977-1.982 0-.055.003-.11.007-.165l-3.173-2.328c-.341.278-.775.445-1.249.445-.56 0-1.065-.234-1.425-.609l-4.12 2.346Zm7.693-14.194L3.813 12.732c-.222.314-.132.751.197.95l.691.417 2.66-1.515a1.747 1.747 0 0 1-.007-.163c0-1.095.885-1.982 1.977-1.982 1.091 0 1.976.887 1.976 1.982 0 .138-.014.273-.041.403l3.047 2.237c.359-.366.858-.592 1.409-.592.634 0 1.198.299 1.56.764l2.831-1.66c.219-.222.258-.581.068-.849L12.553 1.948c-.262-.371-.812-.373-1.075-.002Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

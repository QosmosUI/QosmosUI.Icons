// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaPerbyte : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 448 512";

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
		builder.AddAttribute(14, "d", "M305.314,284.578H246.6V383.3h58.711q24.423,0,38.193-13.77t13.77-36.11q0-21.826-14.032-35.335T305.314,284.578ZM149.435,128.7H90.724v98.723h58.711q24.42,0,38.19-13.773t13.77-36.107q0-21.826-14.029-35.338T149.435,128.7ZM366.647,32H81.353A81.445,81.445,0,0,0,0,113.352V398.647A81.445,81.445,0,0,0,81.353,480H366.647A81.445,81.445,0,0,0,448,398.647V113.352A81.445,81.445,0,0,0,366.647,32Zm63.635,366.647a63.706,63.706,0,0,1-63.635,63.635H81.353a63.706,63.706,0,0,1-63.635-63.635V113.352A63.706,63.706,0,0,1,81.353,49.718H366.647a63.706,63.706,0,0,1,63.635,63.634ZM305.314,128.7H246.6v98.723h58.711q24.423,0,38.193-13.773t13.77-36.107q0-21.826-14.032-35.338T305.314,128.7Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

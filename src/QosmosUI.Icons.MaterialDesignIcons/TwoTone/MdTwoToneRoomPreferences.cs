// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneRoomPreferences : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M13,12.11V5H7v14h4.29C11.1,18.37,11,17.7,11,17C11,15.09,11.76,13.37,13,12.11 z M10,11h2v2h-2V11z");
		builder.AddAttribute(20, "enable-background", "new");
		builder.AddAttribute(21, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M12,13h-2v-2h2V13z M7,19V5h6v7.11c0.57-0.59,1.25-1.07,2-1.42V6h2v4h1h1V4h-4V3H5v16H3v2h9.26c-0.42-0.6-0.75-1.28-0.97-2 H7z M21.69,17.63l1.14,1l-1,1.73l-1.45-0.49c-0.32,0.27-0.68,0.48-1.08,0.63L19,22h-2l-0.3-1.49c-0.4-0.15-0.76-0.36-1.08-0.63 l-1.45,0.49l-1-1.73l1.14-1c-0.08-0.5-0.08-0.76,0-1.26l-1.14-1l1-1.73l1.45,0.49c0.32-0.27,0.68-0.48,1.08-0.63L17,12h2l0.3,1.49 c0.4,0.15,0.76,0.36,1.08,0.63l1.45-0.49l1,1.73l-1.14,1C21.77,16.87,21.77,17.13,21.69,17.63z M20,17c0-1.1-0.9-2-2-2s-2,0.9-2,2 s0.9,2,2,2S20,18.1,20,17z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}

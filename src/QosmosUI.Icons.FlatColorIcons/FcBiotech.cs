// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcBiotech : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "fill", "#AD1457");
		builder.AddAttribute(15, "d", "M36,4c0,9.3-6,13.2-12.8,17.8C16.1,26.5,8,31.8,8,44h4c0-10.1,6.5-14.4,13.4-18.9C32.2,20.6,40,15.4,40,4 H36z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#AD1457");
		builder.AddAttribute(18, "d", "M38,41H11c-0.6,0-1-0.4-1-1s0.4-1,1-1h27c0.6,0,1,0.4,1,1S38.6,41,38,41z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#AD1457");
		builder.AddAttribute(21, "d", "M36,37H12c-0.6,0-1-0.4-1-1s0.4-1,1-1h24c0.6,0,1,0.4,1,1S36.6,37,36,37z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#AD1457");
		builder.AddAttribute(24, "d", "M34,33H14c-0.6,0-1-0.4-1-1s0.4-1,1-1h20c0.6,0,1,0.4,1,1S34.6,33,34,33z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#AD1457");
		builder.AddAttribute(27, "d", "M29,29H19c-0.6,0-1-0.4-1-1s0.4-1,1-1h10c0.6,0,1,0.4,1,1S29.6,29,29,29z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "fill", "#E91E63");
		builder.AddAttribute(30, "d", "M37,9H10C9.4,9,9,8.6,9,8s0.4-1,1-1h27c0.6,0,1,0.4,1,1S37.6,9,37,9z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "fill", "#E91E63");
		builder.AddAttribute(33, "d", "M36,13H12c-0.6,0-1-0.4-1-1s0.4-1,1-1h24c0.6,0,1,0.4,1,1S36.6,13,36,13z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "fill", "#E91E63");
		builder.AddAttribute(36, "d", "M34,17H14c-0.6,0-1-0.4-1-1s0.4-1,1-1h20c0.6,0,1,0.4,1,1S34.6,17,34,17z");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "fill", "#E91E63");
		builder.AddAttribute(39, "d", "M29,21H19c-0.6,0-1-0.4-1-1s0.4-1,1-1h10c0.6,0,1,0.4,1,1S29.6,21,29,21z");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "fill", "#E91E63");
		builder.AddAttribute(42, "d", "M40,44h-4c0-10.1-6.5-14.4-13.4-18.9C15.8,20.6,8,15.4,8,4h4c0,9.3,6,13.2,12.8,17.8 C31.9,26.5,40,31.8,40,44z");
		builder.CloseElement();
		builder.CloseElement();
    }
}

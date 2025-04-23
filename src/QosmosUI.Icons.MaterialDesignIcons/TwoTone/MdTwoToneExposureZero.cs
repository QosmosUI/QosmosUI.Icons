// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneExposureZero : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M15.01 6.22c-.36-.43-.8-.74-1.31-.93S12.63 5 12 5c-.62 0-1.19.1-1.69.29-.51.19-.95.5-1.31.93s-.64.99-.84 1.69c-.2.7-.3 1.55-.3 2.55v2.04c0 1 .1 1.85.3 2.55.2.69.49 1.26.85 1.7s.8.75 1.31.95c.51.2 1.07.3 1.69.3.63 0 1.19-.1 1.7-.3.51-.2.94-.51 1.3-.95.35-.43.63-1 .83-1.7.2-.7.3-1.55.3-2.55h.01v-2.04c0-1.01-.1-1.85-.3-2.55-.2-.7-.48-1.26-.84-1.69zm-.97 6.58c0 .63-.04 1.17-.13 1.62-.09.45-.22.81-.39 1.09s-.38.48-.63.61-.54.19-.87.19c-.33 0-.62-.06-.87-.19s-.47-.33-.64-.61c-.17-.28-.31-.64-.4-1.09-.09-.44-.14-.98-.14-1.62v-2.67c0-.64.04-1.18.13-1.62.09-.44.23-.79.4-1.06s.39-.46.64-.58.54-.18.86-.18.61.06.86.19c.25.12.47.31.64.58.18.27.31.62.4 1.06.08.44.13.98.13 1.62h.01v2.66z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
